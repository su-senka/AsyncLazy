using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>Construction and arguments</summary>
    public sealed class ConstructionTests
    {
        [Fact]
        public void Constructing_with_a_null_factory_throws()
        {
            Assert.Throws<ArgumentNullException>(() => new AsyncLazy<int>((Func<Task<int>>)null!));
            Assert.Throws<ArgumentNullException>(() => new AsyncLazy<int>((Func<CancellationToken, Task<int>>)null!, CancellationToken.None));
        }

        [Fact]
        public async Task Constructing_does_not_run_the_factory()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);

            await TestExtensions.Settle();

            Assert.Equal(0, factory.Calls);
            GC.KeepAlive(lazy);
        }

        [Fact]
        public void Constructing_with_a_value_creates_it_immediately()
        {
            var lazy = new AsyncLazy<string>("ready");

            Assert.True(lazy.IsValueCreated);
        }

        [Fact]
        public async Task Constructing_with_a_null_value_is_allowed()
        {
            var lazy = new AsyncLazy<string?>((string?)null);

            Assert.Null(await lazy.GetValueAsync(TestContext.Current.CancellationToken));
        }

        [Fact]
        public async Task A_factory_may_produce_null_as_its_value()
        {
            int calls = 0;
            var lazy = new AsyncLazy<string?>(() =>
            {
                Interlocked.Increment(ref calls);
                return Task.FromResult<string?>(null);
            });

            Assert.Null(await lazy.GetValueAsync().WithTimeout());
            Assert.Null(await lazy.GetValueAsync().WithTimeout());
            Assert.True(lazy.IsValueCreated);
            Assert.Equal(1, calls);
        }
    }
}
