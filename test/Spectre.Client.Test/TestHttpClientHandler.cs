/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client.Test
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Client handler that does not perform HTTP calls.
    /// </summary>
    public class TestHttpClientHandler : HttpClientHandler
    {
        private readonly Func<HttpRequestMessage, Task<HttpResponseMessage>> produceResponse;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestHttpClientHandler"/> class.
        /// </summary>
        /// <param name="produceResponse">Function that produces the response.</param>
        public TestHttpClientHandler(Func<HttpRequestMessage, Task<HttpResponseMessage>> produceResponse)
        {
            this.produceResponse = produceResponse;
        }

        /// <inheritdoc/>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await this.produceResponse(request).ConfigureAwait(false);
        }
    }
}
