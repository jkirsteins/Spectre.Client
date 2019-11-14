/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;

    /// <summary>
    /// Attempt params.
    /// </summary>
    public class Attempt
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets return_to.
        /// </summary>
        public Uri return_to { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}