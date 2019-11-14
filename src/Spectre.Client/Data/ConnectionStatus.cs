/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    /// <summary>
    /// Connection status.
    /// </summary>
    public enum ConnectionStatus
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Active.
        /// </summary>
        active,

        /// <summary>
        /// Inactive.
        /// </summary>
        inactive,

        /// <summary>
        /// Disabled.
        /// </summary>
        disabled,
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}