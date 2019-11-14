/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;

    /// <summary>
    /// Connect session creation response.
    /// </summary>
    public class CreateConnectSessionResponse
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets expires_at.
        /// </summary>
        public DateTime expires_at { get; set; }

        /// <summary>
        /// Gets or sets connect_url.
        /// </summary>
        public Uri connect_url { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}
