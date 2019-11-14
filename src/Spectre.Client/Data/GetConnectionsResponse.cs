/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    using System;

    /// <summary>
    /// https://docs.saltedge.com/account_information/v5/#fetch-connections.
    /// </summary>
    public class GetConnectionsResponse : TimestampedResponse
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the secret.
        /// </summary>
        public string secret { get; set; }

        /// <summary>
        /// Gets or sets the provider identifier.
        /// </summary>
        public string provider_id { get; set; }

        /// <summary>
        /// Gets or sets the provider code.
        /// </summary>
        public string provider_code { get; set; }

        /// <summary>
        /// Gets or sets the provider name.
        /// </summary>
        public string provider_name { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        public string customer_id { get; set; }

        /// <summary>
        /// Gets or sets when the next refresh will be available. May contain null value if connection has automatic_fetch set as false, or is already processing.
        /// </summary>
        public DateTime next_refresh_possible_at { get; set; }

        /// <summary>
        /// Gets or sets the connection status.
        /// </summary>
        public ConnectionStatus status { get; set; }

        /// <summary>
        /// Gets or sets the categorization.
        /// </summary>
        public Categorization categorization { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the daily refresh is enabled.
        /// </summary>
        public bool daily_refresh { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the credentials should be stored.
        /// </summary>
        public bool store_credentials { get; set; }

        /// <summary>
        /// Gets or sets the 2-letter country code.
        /// </summary>
        public string country_code { get; set; }

        /// <summary>
        /// Gets or sets the time when the connection was successfully fetched.
        /// </summary>
        public DateTime last_success_at { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether any consent was given for this login on Salt Edge side.
        /// </summary>
        public bool show_consent_confirmation { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the last consent.
        /// </summary>
        public string last_consent_id { get; set; }

        /// <summary>
        /// Gets or sets the last attempt of this connection.
        /// </summary>
        public ConnectionAttempt last_attempt { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}
