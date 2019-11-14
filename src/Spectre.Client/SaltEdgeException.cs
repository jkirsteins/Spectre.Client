/* Copyright (c) 2019 Jānis Kiršteins. */

#pragma warning disable CA1032 // Exception constructors

namespace Spectre.Client
{
    using System;

    /// <summary>
    /// Exception raised by the Salt Edge API.
    /// </summary>
    public class SaltEdgeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaltEdgeException"/> class.
        /// </summary>
        /// <param name="r">Error data from the API.</param>
        internal SaltEdgeException(ErrorResponse r)
        {
            this.Response = r;
        }

        /// <summary>
        /// Gets error response from the API.
        /// </summary>
        /// <value>ErrorResponse, which should always be set.</value>
        public ErrorResponse Response { get; }
    }
}

#pragma warning restore CA1032 // Exception constructors