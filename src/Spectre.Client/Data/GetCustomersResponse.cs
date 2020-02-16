/* Copyright (c) 2020 Jānis Kiršteins. */

namespace Spectre.Client
{
    /// <summary>
    /// https://docs.saltedge.com/account_information/v5/#customers.
    /// </summary>
    public class GetCustomersResponse
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the application (non-SaltEdge) identifier.
        /// </summary>
        public string identifier { get; set; }

        /// <summary>
        /// Gets or sets the customer secret.
        /// </summary>
        public string secret { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}