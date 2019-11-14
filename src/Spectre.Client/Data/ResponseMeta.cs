/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;

    /// <summary>
    /// Response metadata for pagination.
    /// </summary>
    public class ResponseMeta
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609
        /// <summary>
        /// Gets or sets the ID of the first non-returned resource.
        /// </summary>
        public string next_id { get; set; }

        /// <summary>
        /// Gets or sets the URI to fetch the next page of data.
        /// </summary>
        /// <value>E.g. /api/v5/customers?from_id=125.</value>
        public Uri next_page { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}