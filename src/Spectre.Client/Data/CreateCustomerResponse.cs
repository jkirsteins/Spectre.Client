/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    using System;
    using Refit;

    /// <summary>
    /// Customer creation response.
    /// </summary>
    public class CreateCustomerResponse
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets identifier.
        /// </summary>
        public string identifier { get; set; }

        /// <summary>
        /// Gets or sets secret.
        /// </summary>
        public string secret { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Element should begin with upper-case letter
    }
}
