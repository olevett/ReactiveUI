using System.Threading.Tasks;
using Microsoft.Reactive.Testing;
using ReactiveUI.Testing;
using Xunit;

namespace ReactiveUI.Tests
{
    public class TestUtilsTest
    {
        [Fact(Skip ="Skipped to diagnose xunit/threading/scheduling issue")]
        public async Task WithAsyncScheduler()
        {
            await new TestScheduler().WithAsync(_ => Task.Run(() => { }));
        }
    }
}
