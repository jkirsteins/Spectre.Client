/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    /// <summary>
    /// API mode.
    /// </summary>
    public enum ApiMode
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Application.
        /// </summary>
        app,

        /// <summary>
        /// Service.
        /// </summary>
        service,
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}
