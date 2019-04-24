using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BenchmarkMiddleWare.Interfaces
{
    public interface IBenchMarkMiddleWare
    {
        Task InvokeAsync(HttpContext context);
    }
}