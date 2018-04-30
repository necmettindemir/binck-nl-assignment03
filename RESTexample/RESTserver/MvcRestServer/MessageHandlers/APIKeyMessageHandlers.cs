using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MvcRestServer.MessageHandlers
{
    public class APIKeyMessageHandlers  : DelegatingHandler
    {       
        // for simplicity of code it is given as an example here
        private const string APIKeyToCheck = "DFSDFSD7G8FGDF87GDF8F"; 
        
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
        {
            bool validKey = false;
            var response = (HttpResponseMessage)null;

            IEnumerable<string> requestHeaders;
            var ChekcApiKeyExists = httpRequestMessage.Headers.TryGetValues("APIKey", out requestHeaders );

            if (ChekcApiKeyExists)
            {
                // it could be checked using database
                if (requestHeaders.FirstOrDefault().Equals(APIKeyToCheck))
                {
                    validKey = true;
                }
            }

            if (!validKey)
            {
                response = httpRequestMessage.CreateResponse(HttpStatusCode.BadRequest, "Invalid API key");
            }
            else
            {
                response = await base.SendAsync(httpRequestMessage, cancellationToken);
            }

            //----- the request can be logged here -----           
            string requestUri = httpRequestMessage.RequestUri.ToString();
            // all the things about the logging request can be done here

            //----- /the request can be logged here -----

            return response;
        }

    }
}