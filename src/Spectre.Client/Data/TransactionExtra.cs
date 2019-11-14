/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Extra data associated with a transaction.
    /// </summary>
    public class TransactionExtra
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609, CA2227 // Naming Styles
        /// <summary>
        /// Gets or sets the balance of the account at the moment of attempt when the transaction was imported.
        /// </summary>
        public decimal account_balance_snapshot { get; set; }

        /// <summary>
        /// Gets or sets the number of the account the transaction belongs to.
        /// </summary>
        public string account_number { get; set; }

        /// <summary>
        /// Gets or sets the additional information (recommended to use in concatenation with original description, if present).
        /// </summary>
        public string additional { get; set; }

        /// <summary>
        /// Gets or sets the original transaction amount in asset units.
        /// </summary>
        public decimal asset_amount { get; set; }

        /// <summary>
        /// Gets or sets the asset's commonly used abbreviation.
        /// </summary>
        /// <value>E.g. BTC (for Bitcoin), XAU (for Gold), etc.</value>
        public string asset_code { get; set; }

        /// <summary>
        /// Gets or sets the the probability that the current category is the correct one.
        /// </summary>
        /// <value>Between 0.0f and 1.0f.</value>
        public float categorization_confidence { get; set; }

        /// <summary>
        /// Gets or sets the payee’s transaction check number.
        /// </summary>
        public string check_number { get; set; }

        /// <summary>
        /// Gets or sets the account balance after transaction.
        /// </summary>
        public decimal closing_balance { get; set; }

        /// <summary>
        /// Gets or sets the payment reference for cashless domestic payments (transfers).
        /// </summary>
        public string constant_code { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the transaction amount was converted using exchange rates or not.
        /// </summary>
        public bool convert { get; set; }

        /// <summary>
        /// Gets or sets the category (present in categories list) that was categorized by the rules created by the customer.
        /// </summary>
        public string customer_category_code { get; set; }

        /// <summary>
        /// Gets or sets the category (not present in categories list) that was categorized by the rules created by the customer.
        /// </summary>
        public string customer_category_name { get; set; }

        /// <summary>
        /// Gets or sets the possible transaction ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the information about the transaction.
        /// </summary>
        public string information { get; set; }

        /// <summary>
        /// Gets or sets the transaction’s Merchant Category Code.
        /// </summary>
        public string mcc { get; set; }

        /// <summary>
        /// Gets or sets the merchant identifier.
        /// </summary>
        public string merchant_id { get; set; }

        /// <summary>
        /// Gets or sets the account balance before transaction.
        /// </summary>
        public decimal opening_balance { get; set; }

        /// <summary>
        /// Gets or sets the native amount of the transaction in transaction’s currency(comes with original_currency_code).
        /// </summary>
        public decimal original_amount { get; set; }

        /// <summary>
        /// Gets or sets the original category of the transaction.
        /// </summary>
        public string original_category { get; set; }

        /// <summary>
        /// Gets or sets the native currency of the transaction(comes with original_amount).
        /// </summary>
        public string original_currency_code { get; set; }

        /// <summary>
        /// Gets or sets the original subcategory of the transaction.
        /// </summary>
        public string original_subcategory { get; set; }

        /// <summary>
        /// Gets or sets the party to whom money is paid.
        /// </summary>
        public string payee { get; set; }

        /// <summary>
        /// Gets or sets additional payee information.
        /// </summary>
        public string payee_information { get; set; }

        /// <summary>
        /// Gets or sets the party who paid the money.
        /// </summary>
        public string payer { get; set; }

        /// <summary>
        /// Gets or sets additional payer information.
        /// </summary>
        public string payer_information { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a possible duplicate.
        /// </summary>
        /// <value>
        /// Set to true if current transaction duplicates amount, made_on and currency_code of any transaction parsed in previous attempt.
        /// </value>
        public bool possible_duplicate { get; set; }

        /// <summary>
        /// Gets or sets the date when the transaction appears in statement.
        /// </summary>
        public DateTime posting_date { get; set; }

        /// <summary>
        /// Gets or sets the time in HH:MM:SS format, representing time when the transaction appears in statement.
        /// </summary>
        public string posting_time { get; set; }

        /// <summary>
        /// Gets or sets the bank record number.
        /// </summary>
        public string record_number { get; set; }

        /// <summary>
        /// Gets or sets additional identification information for cashless domestic payments(transfers).
        /// </summary>
        public string specific_code { get; set; }

        /// <summary>
        /// Gets or sets the original tags of the transaction.
        /// </summary>
        public IList<string> tags { get; set; }

        /// <summary>
        /// Gets or sets the time when the transaction was made.
        /// </summary>
        /// <value>Time in HH:mm:ss format.</value>
        public string time { get; set; }

        /// <summary>
        /// Gets or sets the name of the linked account.
        /// </summary>
        public string transfer_account_name { get; set; }

        /// <summary>
        /// Gets or sets the transaction type.
        /// </summary>
        public string @type { get; set; }

        /// <summary>
        /// Gets or sets the price per unit (used with units, available for investment accounts nature only).
        /// </summary>
        public decimal unit_price { get; set; }

        /// <summary>
        /// Gets or sets the amount of units owned (used with unit_price, available for investment accounts nature only).
        /// </summary>
        public decimal units { get; set; }

        /// <summary>
        /// Gets or sets a value that identifies the tax subject to the tax office, used for domestic payments (transfers).
        /// </summary>
        public string variable_code { get; set; }
#pragma warning restore IDE1006, SA1300, CA1707, SA1609, CA2227 // Naming Styles
    }
}