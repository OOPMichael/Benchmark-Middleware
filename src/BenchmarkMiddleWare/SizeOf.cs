using System;

namespace BenchmarkMiddleWare
{
    public class SizeOf
    {
        public int SizeofPayload(string responseBody)
        {
            if (responseBody == null)
                return 0;
            return responseBody.Length * sizeof(char);
        }
    }
}