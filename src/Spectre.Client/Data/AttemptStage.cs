/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// https://docs.saltedge.com/account_information/v5/#attempts-stages.
    /// </summary>
    public class AttemptStage
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609, CA2227
        /// <summary>
        /// Attempt stage names.
        /// </summary>
        public enum StageName
        {
            /// <summary>
            /// Start.
            /// </summary>
            start,

            /// <summary>
            /// Connect.
            /// </summary>
            connect,

            /// <summary>
            /// Interactive.
            /// </summary>
            interactive,

            /// <summary>
            /// Fetch holder info.
            /// </summary>
            fetch_holder_info,

            /// <summary>
            /// Fetch accounts.
            /// </summary>
            fetch_accounts,

            /// <summary>
            /// Fetch recent.
            /// </summary>
            fetch_recent,

            /// <summary>
            /// Fetch full.
            /// </summary>
            fetch_full,

            /// <summary>
            /// Disconnect.
            /// </summary>
            disconnect,

            /// <summary>
            /// Finish.
            /// </summary>
            finish,
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public StageName name { get; set; }

        /// <summary>
        /// Gets or sets the HTML code.
        /// </summary>
        public string interactive_html { get; set; }

        /// <summary>
        /// Gets or sets the interactive field names.
        /// </summary>
        public IEnumerable<string> interactive_fields_names { get; set; }

        /// <summary>
        /// Gets or sets the interactive fields.
        /// </summary>
        public IDictionary<string, IEnumerable<FieldOption>> interactive_fields_options { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        public DateTime created_at { get; set; }

        /// <summary>
        /// Gets or sets the update date.
        /// </summary>
        public DateTime updated_at { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609, CA2227
    }
}