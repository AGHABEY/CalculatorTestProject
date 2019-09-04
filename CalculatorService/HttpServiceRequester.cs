using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    class HttpServiceRequester : IHttpServiceRequester
    {
        HttpClient httpClient = null;

        public HttpServiceRequester()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> SendHttpGetAsync(string url)
        {
            HttpResponseMessage httpResponse = await httpClient.GetAsync(url);
            string numResult = await httpResponse.Content.ReadAsStringAsync();
            return numResult;
        }


      
    }
}
