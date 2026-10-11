"""A stand-in for one Azure blob container, for the local test only: GET and PUT of whole blobs,
refused (403) without a 'sig' query parameter, as a SAS URL would be."""
import http.server, os, sys, urllib.parse

root, port_file = sys.argv[1], sys.argv[2]

class Handler(http.server.BaseHTTPRequestHandler):
    def _path(self):
        url = urllib.parse.urlsplit(self.path)
        if "sig" not in urllib.parse.parse_qs(url.query):
            self.send_response(403); self.end_headers(); return None
        return os.path.join(root, url.path.lstrip("/").replace("/", "_"))

    def do_PUT(self):
        path = self._path()
        if path is None: return
        if self.headers.get("x-ms-blob-type") != "BlockBlob":
            self.send_response(400); self.end_headers(); return
        data = self.rfile.read(int(self.headers["Content-Length"]))
        with open(path, "wb") as f: f.write(data)
        self.send_response(201); self.end_headers()

    def do_GET(self):
        path = self._path()
        if path is None: return
        if not os.path.exists(path):
            self.send_response(404); self.end_headers(); return
        data = open(path, "rb").read()
        self.send_response(200); self.send_header("Content-Length", str(len(data))); self.end_headers()
        self.wfile.write(data)

    def log_message(self, *args): pass

server = http.server.ThreadingHTTPServer(("127.0.0.1", 0), Handler)
with open(port_file, "w") as f:
    f.write(str(server.server_address[1]))
server.serve_forever()
