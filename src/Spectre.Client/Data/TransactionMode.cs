/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    /// <summary>
    /// Transaction mode.
    /// </summary>
    public enum TransactionMode
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Normal transaction.
        /// </summary>
        normal,

        /// <summary>
        /// Fee transaction.
        /// </summary>
        fee,

        /// <summary>
        /// Transfer transaction.
        /// </summary>
        transfer,
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}