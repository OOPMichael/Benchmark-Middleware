using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace BenchmarkMiddleWare.Tests
{
    public class RollingAverageTests
    {
        [Theory]
        [InlineData(3,2, 3, 4)]
        [InlineData(.33, 0,0,1)]
        public  void Add_N_Values_Returns_Average(double expectedaverage, params int[] sampleset)
        {
            var average = new RollingAverage(10);

            foreach (int value in sampleset)
                average.Add(value);

            var result = average.CurrentAverage;

            Assert.Equal(expectedaverage, result);
        }

        [Fact]
        public void Add_One_Value_Over_maxCapacity_Average_RollsOver()
        {
            var average = new RollingAverage(3);
        }
    }
}
