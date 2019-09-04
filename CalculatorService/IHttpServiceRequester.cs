using System.Threading.Tasks;

namespace CalculatorService
{
    interface IHttpServiceRequester
    {
        Task<string> SendHttpGetAsync(string url);
      
    }
}