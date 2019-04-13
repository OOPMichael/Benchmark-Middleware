using System;
using Xunit;

namespace BenchmarkMiddleWare.Tests
{
    public class CalcTests
    {
        [Fact]
        public void Addidition_HappyPath()
        {
            var int1 = 1;
            var int2 = 2;
            var v = new Calc();

            var result = v.Addition(int1, int2);

            Assert.Equal(int1 + int2, result);
        }
    }
}
