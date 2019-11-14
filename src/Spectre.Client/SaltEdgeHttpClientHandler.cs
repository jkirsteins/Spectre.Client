/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System.Diagnostics.Contracts;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Http client handler that logs request/response messages to debug stream,
    /// and adds the authentication headers.
    /// </summary>
    public class SaltEdgeHttpClientHandler : HttpClientHandler
    {
        /// <summary>
        /// App-id header value.
        /// </summary>
        private readonly string appId;

        /// <summary>
        /// Secret header value.
        /// </summary>
        private readonly string secret;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaltEdgeHttpClientHandler"/> class.
        /// </summary>
        /// <param name="appId">App-id header value.</param>
        /// <param name="secret">Secret header value.</param>
        public SaltEdgeHttpClientHandler(string appId, string secret)
        {
            this.appId = appId;
            this.secret = secret;
        }

        /// <inheritdoc/>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Contract.Requires(request != null);

            request.Headers.Add("App-id", this.appId);
            request.Headers.Add("Secret", this.secret);

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
