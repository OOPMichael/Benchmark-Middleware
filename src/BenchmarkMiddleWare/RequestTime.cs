using System;
using System.Diagnostics;

namespace BenchmarkMiddleWare
{
    public class RequestTime : IDisposable
    {
        private readonly Stopwatch sw;
        private readonly Action<TimeSpan> f;

        public RequestTime(Action<TimeSpan> f)
        {
            this.f = f;
            sw = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            sw.Stop();
            f(sw.Elapsed);
        }
    }
}