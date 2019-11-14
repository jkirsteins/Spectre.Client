/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    /// <summary>
    /// https://docs.saltedge.com/account_information/v5/#fetch-accounts-for-connections.
    /// </summary>
    public class GetAccountsResponse : TimestampedResponse
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets the account identifier.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the connection identifier.
        /// </summary>
        public string connection_id { get; set; }

        /// <summary>
        /// Gets or sets the account name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the account nature.
        /// </summary>
        public AccountNature nature { get; set; }

        /// <summary>
        /// Gets or sets the account balance.
        /// </summary>
        public decimal balance { get; set; }

        /// <summary>
        /// Gets or sets the account currency code.
        /// </summary>
        public string currency_code { get; set; }

        /// <summary>
        /// Gets or sets extra information about the account.
        /// </summary>
        public AccountExtra extra { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}