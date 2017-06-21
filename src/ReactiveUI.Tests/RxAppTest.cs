using System.Diagnostics;
using System.Linq;
using System.Reactive.Concurrency;
using Splat;
using Xunit;

namespace ReactiveUI.Tests
{
    public class RxAppTest
    {
#if !MONO
        [Fact]
        public void DepPropNotifierShouldBeFound()
        {
            RxApp.EnsureInitialized();

            Assert.True(Locator.Current.GetServices<ICreatesObservableForProperty>()
                .Any(x => x is DependencyObjectObservableForProperty));
        }
#endif

        [Fact(Skip = "Requires initialize to run on seperate thread")]
        public void SchedulerShouldBeCurrentThreadInTestRunner()
        {
            Debug.WriteLine(RxApp.MainThreadScheduler.GetType().FullName);
            Assert.Equal(CurrentThreadScheduler.Instance, RxApp.MainThreadScheduler);
        }
    }
}
