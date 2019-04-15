using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkMiddleWare
{
    public class RollingAverage
    {
        private const int DefaultMaxCapacity = 10;

        private readonly Queue<int> counts;

        private readonly int maxSize;

        private long currentTotal;

        public RollingAverage() : this(DefaultMaxCapacity)
        {
        }

        public RollingAverage(int maxCapacity)
        {
            if (maxCapacity < 1)
            {
                throw new ArgumentOutOfRangeException(
                    "maxCapacity",
                    "maxCapacity must be greater than 0.");
            }

            this.counts = new Queue<int>(maxCapacity);
            this.maxSize = maxCapacity;
            this.currentTotal = 0L;
        }

        public double CurrentAverage
        {
            get
            {
                lock (this.counts)
                {
                    var lenCounts = this.counts.Count;

                    if (lenCounts == 0)
                    {
                        throw new InvalidOperationException("No counts to average.");
                    }

                    return Math.Round(this.currentTotal / (double)lenCounts,2);
                }
            }
        }

        public void Add(int value)
        {
            lock (this.counts)
            {
                if (this.counts.Count == this.maxSize)
                {
                    this.currentTotal -= this.counts.Dequeue();
                }

                this.counts.Enqueue(value);
                this.currentTotal += value;
            }
        }

        public void Clear()
        {
            lock (this.counts)
            {
                this.counts.Clear();
                this.currentTotal = 0L;
            }
        }
    }
}