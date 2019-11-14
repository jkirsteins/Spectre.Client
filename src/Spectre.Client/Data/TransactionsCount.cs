/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    /// <summary>
    /// The number of transactions, separated by posted and pending.
    /// </summary>
    public class TransactionsCount
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets the number of posted transactions.
        /// </summary>
        public int posted { get; set; }

        /// <summary>
        /// Gets or sets the number of pending transactions.
        /// </summary>
        public int pending { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}