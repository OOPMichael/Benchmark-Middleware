using BenchmarkMiddleWare.Interfaces;
using System;

namespace BenchmarkMiddleWare
{
    public class MiddleWare
    {
        private readonly ISizeOf _sizeof;

        public MiddleWare(ISizeOf sizeoff)
            {
            _sizeof = sizeoff;
            }
        public void process(string request)
        {
            //testing the duration of a process will be subbed out later
            using (new RequestTime(x => Console.WriteLine("{0} elapsed", x)))
            {
                var requestsize = _sizeof.SizeofPayload(request);
            }
        }
    }
}