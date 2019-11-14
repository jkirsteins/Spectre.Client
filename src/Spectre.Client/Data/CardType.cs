/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    /// <summary>
    /// Credit card type.
    /// </summary>
    public enum CardType
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// American Express.
        /// </summary>
        american_express,

        /// <summary>
        /// China UnionPay.
        /// </summary>
        china_unionpay,

        /// <summary>
        /// Diner's Club.
        /// </summary>
        diners_club,

        /// <summary>
        /// Jcb.
        /// </summary>
        jcb,

        /// <summary>
        /// Maestro.
        /// </summary>
        maestro,

        /// <summary>
        /// MasterCard.
        /// </summary>
        master_card,

        /// <summary>
        /// Uatp.
        /// </summary>
        uatp,

        /// <summary>
        /// Visa.
        /// </summary>
        visa,

        /// <summary>
        /// Mir.
        /// </summary>
        mir,
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles

    }
}