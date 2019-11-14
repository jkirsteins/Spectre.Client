/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;

    /// <summary>
    /// Base response with created_at and updated_at fields.
    /// </summary>
    public abstract class TimestampedResponse
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609
        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        public DateTime created_at { get; set; }

        /// <summary>
        /// Gets or sets the update date.
        /// </summary>
        public DateTime updated_at { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}