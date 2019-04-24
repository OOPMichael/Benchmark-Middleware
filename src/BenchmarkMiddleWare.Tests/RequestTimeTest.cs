using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
namespace BenchmarkMiddleWare.Tests
{
    public class RequestTimeTest
    {
        [Fact]
        public void RequestTImerWrapper_InjectsOneSecondTask_ReportsTime()
        {
            
            using (new RequestTime(x => Console.WriteLine("{0} elapsed", x)))
            {
                var v = new Task(() => Thread.Sleep(1000));
            }
        }

    }
}