/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Consent params.
    /// </summary>
    public class Consent
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets scopes.
        /// </summary>
        /// <value>Possible values: ['account_details'], ['holder_information'], ['account_details', 'holder_information'], ['account_details', 'transactions_details'], ['account_details', 'holder_information', 'transactions_details']
        /// Note: The allowed values for this parameter must fall within the client’s allowed_fetch_scopes and/or provider’s supported_fetch_scopes restrictions.
        /// </value>
        public IEnumerable<string> scopes { get; set; }

        /// <summary>
        /// Gets or sets from_date. Must be serialized to yyyy-MM-dd.
        /// </summary>
        public DateTime from_date { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}