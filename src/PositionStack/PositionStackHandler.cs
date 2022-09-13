using Microsoft.Extensions.Options;
using PositionStack.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PositionStack
{
    public class PositionStackHandler: DelegatingHandler
    {
        private readonly IOptions<PositionStackOptions> _options;

        public PositionStackHandler(IOptions<PositionStackOptions> options)
        {
            _options = options;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var uriBuilder = new UriBuilder(request.RequestUri!);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["access_key"] = _options.Value.AccessKey;
            uriBuilder.Query = query.ToString();        
            request.RequestUri = uriBuilder.Uri;
            return base.SendAsync(request, cancellationToken);
        }
    }
}
