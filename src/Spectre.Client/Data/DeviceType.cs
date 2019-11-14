/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    /// <summary>
    /// Device type.
    /// </summary>
    public enum DeviceType
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Desktop.
        /// </summary>
        desktop,

        /// <summary>
        /// Tablet.
        /// </summary>
        tablet,

        /// <summary>
        /// Mobile.
        /// </summary>
        mobile,
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}
