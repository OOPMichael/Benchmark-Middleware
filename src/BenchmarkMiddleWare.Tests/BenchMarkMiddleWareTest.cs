using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Xunit;

namespace BenchmarkMiddleWare.Tests
{
    public class BenchMarkMiddleWareTest
    {
        [Fact]
        public void BenchMarkMiddleWare_MeasuresSucesfully()
        {
            var sizeofs = new SizeOf();
            //SH how i new action
            var context = new DefaultHttpContext();
            context.Response.Body = new MemoryStream();
            var action = new Action(() => new Task(null));
            var middleware = new BenchMarkMiddleWare(sizeofs, (innerHttpContext) => Task.FromResult(0));

        }
    }
}