/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    using System;

    /// <summary>
    /// Error field params.
    /// </summary>
    public class ErrorField
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets error class. See https://docs.saltedge.com/account_information/v4/#errors-list.
        /// </summary>
        public ErrorClass @class { get; set; }

        /// <summary>
        /// Gets or sets error message.
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// Gets or sets documentation URL where the error is described, or solution indicated.
        /// </summary>
        public Uri documentation_url { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}