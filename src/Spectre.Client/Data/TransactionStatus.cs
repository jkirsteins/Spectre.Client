/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    /// <summary>
    /// Transaction status.
    /// </summary>
    public enum TransactionStatus
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Posted transaction.
        /// </summary>
        posted,

        /// <summary>
        /// Pending transaction.
        /// </summary>
        pending,
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}