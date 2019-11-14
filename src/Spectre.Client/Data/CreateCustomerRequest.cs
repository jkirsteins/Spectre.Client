/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    /// <summary>
    /// Customer creation API call params.
    /// </summary>
    public class CreateCustomerRequest
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets desired identifier.
        /// </summary>
        public string identifier { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}
