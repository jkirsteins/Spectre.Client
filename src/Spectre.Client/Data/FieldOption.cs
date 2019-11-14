/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    /// <summary>
    /// Field option.
    ///
    /// See: <see cref="AttemptStage.interactive_fields_options"/>.
    /// </summary>
    public class FieldOption
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the english name.
        /// </summary>
        public string english_name { get; set; }

        /// <summary>
        /// Gets or sets the localized name.
        /// </summary>
        public string localized_name { get; set; }

        /// <summary>
        /// Gets or sets the option value.
        /// </summary>
        public string option_value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the option is selected.
        /// </summary>
        public bool selected { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}