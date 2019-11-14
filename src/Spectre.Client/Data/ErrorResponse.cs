/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    /// <summary>
    /// Salt Edge API error response params.
    /// </summary>
    public class ErrorResponse
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets error.
        /// </summary>
        public ErrorField error { get; set; }

        /// <summary>
        /// Gets or sets request data.
        /// </summary>
        public object request { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}
