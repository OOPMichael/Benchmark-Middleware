using System;
using Xunit;

namespace BenchmarkMiddleWare.Tests
{
    public class CalcTests
    {
        [Theory]
        [InlineData("a",2)]
        [InlineData("42",4)]
        [InlineData(null,0)]
        [InlineData("",0)]
        public void SizeofPayloadCalculations(string inputstring, int bytelength)
        {
            var calc = new SizeOf();

            var result = calc.SizeofPayload(inputstring);

            Assert.Equal(bytelength, result);
        }
    }
}