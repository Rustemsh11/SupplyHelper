using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SupplyHelper
{
    static class HttpRequester
    {
        public static async Task<HttpStatusCode> CheckConnection(string url)
        {
            using (var connection = new HttpClient())
            {
                var responce = await connection.GetAsync(url);

                return responce.StatusCode;
            }
        }

        public static async Task<string> GetData(string url)
        {
            using (var connection = new HttpClient())
            {
                var res = await connection.GetAsync(url).ConfigureAwait(false);
                return await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }
        
        public static async Task<string> SendRequest(HttpRequestMessage httpRequestMessage)
        {
            using (var connection = new HttpClient())
            {
                var res = await connection.SendAsync(httpRequestMessage).ConfigureAwait(false);
                return await res.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }
    }
}
