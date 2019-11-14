/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;

    /// <summary>
    /// Attribute documentation: https://docs.saltedge.com/account_information/v5/#transactions-attributes.
    /// Quickstart: https://docs.saltedge.com/account_information/v5/#fetch-transactions-for-an-account.
    /// </summary>
    public class GetTransactionsResponse : TimestampedResponse
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles

        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the transaction mode.
        /// </summary>
        public TransactionMode mode { get; set; }

        /// <summary>
        /// Gets or sets the transaction status.
        /// </summary>
        public TransactionStatus status { get; set; }

        /// <summary>
        /// Gets or sets the date when the transaction was made.
        /// </summary>
        public DateTime made_on { get; set; }

        /// <summary>
        /// Gets or sets the transaction’s amount.
        /// </summary>
        public decimal amount { get; set; }

        /// <summary>
        /// Gets or sets the transaction’s currency code.
        /// </summary>
        public string currency_code { get; set; }

        /// <summary>
        /// Gets or sets the transaction’s description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the transaction’s category. See https://docs.saltedge.com/account_information/v5/#categories.
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transaction is duplicated or not.
        /// </summary>
        public bool duplicate { get; set; }

        /// <summary>
        /// Gets or sets the extra data associated with the transaction.
        /// </summary>
        public TransactionExtra extra { get; set; }

        /// <summary>
        /// Gets or sets the id of the account the transaction belongs to.
        /// </summary>
        public string account_id { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}