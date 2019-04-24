using BenchmarkMiddleWare.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace BenchmarkMiddleWare
{
    public class BenchMarkMiddleWare : IBenchMarkMiddleWare
    {
        private readonly ISizeOf _sizeof;
        private readonly RequestDelegate _next;
        public BenchMarkMiddleWare(ISizeOf sizeoff, RequestDelegate next)
        {
            _sizeof = sizeoff;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var elapsedTime = new TimeSpan();
            using (new RequestTime(x => elapsedTime = x))
            {

                await _next(context);
                
            }
            var requestsize = _sizeof.SizeofPayload(context.Response.HttpContext.Response.ToString());
        }
    }
}