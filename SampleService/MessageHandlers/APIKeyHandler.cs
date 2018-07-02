using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace SampleService.MessageHandlers
{
    public class APIKeyHandler : DelegatingHandler
    {
        private const string _APIKey = "12345-ABCDE";
        private const string _APIKeyName = "APIKEY";

        protected override async Task<HttpResponseMessage> SendAsync (HttpRequestMessage reqMessage, CancellationToken token)
        {
            bool isValid = false;
            IEnumerable<string> headers;
            
            var keyExists = reqMessage.Headers.TryGetValues(_APIKeyName, out headers);
            if (keyExists)
            {
                if (headers.FirstOrDefault().Equals(_APIKey))
                {
                    isValid = true;
                }
            }

            if (!isValid)
            {
                return reqMessage.CreateResponse(HttpStatusCode.Forbidden, "Sorry, Invalid API Key");
            }

            var response = await base.SendAsync(reqMessage, token);
            return response;
        }

    }
}