/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// https://docs.saltedge.com/account_information/v5/#attempts-attributes.
    /// </summary>
    public class ConnectionAttempt
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the attempt is finished.
        /// </summary>
        public bool finished { get; set; }

        /// <summary>
        /// Gets or sets the API mode.
        /// </summary>
        public ApiMode api_mode { get; set; }

        /// <summary>
        /// Gets or sets the API version.
        /// </summary>
        public string api_version { get; set; }

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        public string locale { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is present.
        /// </summary>
        public bool user_present { get; set; }

        /// <summary>
        /// Gets or sets when the customer last logged in.
        /// </summary>
        public DateTime? customer_last_logged_at { get; set; }

        /// <summary>
        /// Gets or sets the remote IP string representation.
        /// </summary>
        public string remote_ip { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this was recently finished.
        /// </summary>
        public bool finished_recent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a partial attempt.
        /// </summary>
        public bool partial { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether automatic fetch is enabled.
        /// </summary>
        public bool automatic_fetch { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether daily refresh is enabled.
        /// </summary>
        public bool daily_refresh { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether categorized.
        /// </summary>
        public bool categorize { get; set; }

        /// <summary>
        /// Gets the custom fields.
        /// </summary>
        public IDictionary<string, string> custom_fields { get; }

        /// <summary>
        /// Gets or sets the device type.
        /// </summary>
        public DeviceType device_type { get; set; }

        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        public string user_agent { get; set; }

        /// <summary>
        /// Gets or sets the excluded accounts.
        /// </summary>
        public IEnumerable<string> exclude_accounts { get; set; }

        /// <summary>
        /// Gets or sets the fetch scopes.
        /// </summary>
        public IEnumerable<string> fetch_scopes { get; set; }

        /// <summary>
        /// Gets or sets the start date of access that the user consents to.
        /// </summary>
        /// <value>
        /// The allowed values for this parameter must be within exactly 365 days ago.
        /// </value>
        public DateTime? from_date { get; set; }

        /// <summary>
        /// Gets or sets the end date of the consent.
        /// </summary>
        public DateTime? to_date { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is an interactive attempt.
        /// </summary>
        public bool interactive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether credentials should be stored.
        /// </summary>
        public bool store_credentials { get; set; }

        /// <summary>
        /// Gets or sets the included account natures.
        /// </summary>
        public IEnumerable<AccountNature> include_natures { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Consent Confirmation is handled on the client’s side or not.
        ///
        /// If Consent Confirmation is handled on the client’s side,
        /// this parameter should be sent as false so, upon submitting the form,
        /// the user will not be asked to give his consent to Salt Edge Inc.
        ///
        /// Default value: true.
        /// </summary>
        public bool show_consent_confirmation { get; set; }

        /// <summary>
        /// Gets or sets the consent id.
        /// </summary>
        public string consent_id { get; set; }

        /// <summary>
        /// Gets or sets when this attempt failed.
        /// </summary>
        public DateTime? fail_at { get; set; }

        /// <summary>
        /// Gets or sets the failure message.
        /// </summary>
        public string fail_message { get; set; }

        /// <summary>
        /// Gets or sets the error class associated with the failure.
        /// </summary>
        public ErrorClass? fail_error_class { get; set; }

        /// <summary>
        /// Gets or sets the creation datetime.
        /// </summary>
        public DateTime created_at { get; set; }

        /// <summary>
        /// Gets or sets the update datetime.
        /// </summary>
        public DateTime updated_at { get; set; }

        /// <summary>
        /// Gets or sets the success datetime.
        /// </summary>
        public DateTime success_at { get; set; }

        /// <summary>
        /// Gets or sets the last stage of the connection attempt.
        /// </summary>
        public AttemptStage last_stage { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}