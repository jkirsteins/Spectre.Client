/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// https://docs.saltedge.com/account_information/v5/#accounts-extra.
    /// </summary>
    public class AccountExtra
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609 // Naming Styles
        /// <summary>
        /// Gets or sets the account IBAN number.
        /// </summary>
        public string iban { get; set; }

        /// <summary>
        /// Gets or sets the changeable name of the account.
        /// </summary>
        public string account_name { get; set; }

        /// <summary>
        /// Gets or sets the internal bank account number.
        /// </summary>
        public string account_number { get; set; }

        /// <summary>
        /// Gets the list of crypto codes and their amounts assigned to investment account.
        /// </summary>
        public IList<object> assets { get; }

        /// <summary>
        /// Gets or sets the available amount in account’s currency.
        /// </summary>
        public decimal available_amount { get; set; }

        /// <summary>
        /// Gets or sets the amount currently blocked in account’s currency.
        /// </summary>
        public decimal blocked_amount { get; set; }

        /// <summary>
        /// Gets or sets the type of the card account.
        /// </summary>
        public CardType card_type { get; set; }

        /// <summary>
        /// Gets the list of masked card numbers.
        /// </summary>
        public IList<string> cards { get; }

        /// <summary>
        /// Gets or sets the account client owner.
        /// </summary>
        public string client_name { get; set; }

        /// <summary>
        /// Gets or sets the account balance at the end of an accounting period.
        /// </summary>
        public decimal closing_balance { get; set; }

        /// <summary>
        /// Gets or sets the credit limit in account’s currency.
        /// </summary>
        public decimal credit_limit { get; set; }

        /// <summary>
        /// Gets or sets the date of provider statement generation (applicable to banks).
        /// </summary>
        public DateTime current_date { get; set; }

        /// <summary>
        /// Gets or sets the time of provider statement generation(applicable to banks).
        /// </summary>
        public DateTime current_time { get; set; }

        /// <summary>
        /// Gets or sets the card expiry date.
        /// </summary>
        public DateTime expiry_date { get; set; }

        /// <summary>
        /// Gets or sets the interest rate of the account as percentage value.
        /// </summary>
        public decimal interest_rate { get; set; }

        /// <summary>
        /// Gets or sets the next payment amount for loans or credits.
        /// </summary>
        public decimal next_payment_amount { get; set; }

        /// <summary>
        /// Gets or sets the next payment date for loans or credits.
        /// </summary>
        public DateTime next_payment_date { get; set; }

        /// <summary>
        /// Gets or sets the card open date.
        /// </summary>
        public DateTime open_date { get; set; }

        /// <summary>
        /// Gets or sets the account balance that is brought forward from the end of one accounting period to the beginning of a new accounting period.
        /// </summary>
        public decimal opening_balance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the account transactions were not imported or imported partially because of some internal error on bank’s side.
        /// </summary>
        public bool @partial { get; set; }

        /// <summary>
        /// Gets or sets the routing number(US)/BSB code(Australia)/sort code(UK).
        /// </summary>
        public string sort_code { get; set; }

        /// <summary>
        /// Gets or sets the date when current statement becomes previous one.
        /// </summary>
        public DateTime statement_cut_date { get; set; }

        /// <summary>
        /// Gets or sets if the account is active or inactive.
        /// </summary>
        public AccountStatus status { get; set; }

        /// <summary>
        /// Gets or sets the account SWIFT code.
        /// </summary>
        public string swift { get; set; }

        /// <summary>
        /// Gets or sets the total payment amount for loans or credits.
        /// </summary>
        public decimal total_payment_amount { get; set; }

        /// <summary>
        /// Gets or sets the number of transactions, separated by posted and pending.e.g. {'posted': 12, 'pending': 0}.
        /// </summary>
        public TransactionsCount transactions_count { get; set; }

        /// <summary>
        /// Gets or sets the price per unit(used with units, available for investment accounts nature only).
        /// </summary>
        public decimal unit_price { get; set; }

        /// <summary>
        /// Gets or sets the amount of units owned(used with unit_price, available for investment accounts nature only).
        /// </summary>
        public decimal units { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}