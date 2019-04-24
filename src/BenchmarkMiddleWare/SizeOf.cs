using BenchmarkMiddleWare.Interfaces;

namespace BenchmarkMiddleWare
{
    //TODO rename this to anything besides sizeof
    public class SizeOf : ISizeOf
    {
        //TODO: does this handle multiple encodings?
        public int SizeofPayload(string responseBody)
        {
            if (responseBody == null)
                return 0;
            return responseBody.Length * sizeof(char);
        }
    }
}