/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    /// <summary>
    /// The type of the account. See: https://docs.saltedge.com/account_information/v5/#accounts-attributes.
    ///
    /// Note that for credit_card nature, the balance represents the sum of all negative transactions,
    /// the positive ones do not count.
    /// </summary>
    public enum AccountNature
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Account.
        /// </summary>
        account,

        /// <summary>
        /// Bonus.
        /// </summary>
        bonus,

        /// <summary>
        /// Card.
        /// </summary>
        card,

        /// <summary>
        /// Checking.
        /// </summary>
        checking,

        /// <summary>
        /// Credit.
        /// </summary>
        credit,

        /// <summary>
        /// Credit card.
        /// </summary>
        credit_card,

        /// <summary>
        /// Debit card.
        /// </summary>
        debit_card,

        /// <summary>
        /// E-wallet.
        /// </summary>
        ewallet,

        /// <summary>
        /// Insurance.
        /// </summary>
        insurance,

        /// <summary>
        /// Investment.
        /// </summary>
        investment,

        /// <summary>
        /// Loan.
        /// </summary>
        loan,

        /// <summary>
        /// Mortgage.
        /// </summary>
        mortgage,

        /// <summary>
        /// Savings.
        /// </summary>
        savings,
#pragma warning restore IDE1006, SA1300, CA1707, SA1609 // Naming Styles
    }
}
