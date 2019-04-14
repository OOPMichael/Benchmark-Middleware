using BenchmarkMiddleWare.Interfaces;

namespace BenchmarkMiddleWare
{
    public class SizeOf : ISizeOf
    {
        public int SizeofPayload(string responseBody)
        {
            if (responseBody == null)
                return 0;
            return responseBody.Length * sizeof(char);
        }
    }
}