/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Connect session creation request params.
    /// </summary>
    public class CreateConnectSessionRequest
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets customer_id.
        /// </summary>
        public string customer_id { get; set; }

        /// <summary>
        /// Gets or sets consent.
        /// </summary>
        public Consent consent { get; set; }

        /// <summary>
        /// Gets or sets attempt.
        /// </summary>
        public Attempt attempt { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}
