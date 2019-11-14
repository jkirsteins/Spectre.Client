/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;
    using Refit;

    /// <summary>
    /// Generic wrapper when all the API params/response data must be included within a 'data' key.
    /// </summary>
    /// <typeparam name="T">Class of the actual request or response params.</typeparam>
    public class ParamWrapper<T>
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets data.
        /// </summary>
        public T data { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}
