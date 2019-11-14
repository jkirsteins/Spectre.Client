/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client.Test
{
    using System;
    using Refit;

    /// <summary>
    /// Class for creating a dummy instance of the API client.
    /// </summary>
    public static class ClientFactory
    {
        /// <summary>
        /// Creates an instance of ISaltEdgeClient that does
        /// not send HTTP requests.
        /// </summary>
        /// <param name="func">Function that can inspect the outgoing request, and provide a dummy response.</param>
        /// <returns>Instance of <see cref="ISaltEdgeClient"/>.</returns>
        public static ISaltEdgeClient Create(Func<System.Net.Http.HttpRequestMessage, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>> func)
        {
#pragma warning disable CA2000
            return RestService.For<ISaltEdgeClient>(new System.Net.Http.HttpClient(new TestHttpClientHandler(func))
            {
                BaseAddress = new Uri("https://example.com"),
            });
#pragma warning restore CA2000

        }
    }
}
