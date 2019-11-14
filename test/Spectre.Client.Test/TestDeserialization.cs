/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client.Test
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>
    /// Tests for request deserialization.
    /// </summary>
    public class TestDeserialization
    {
        /// <summary>
        /// Test the response when fetching connections.
        /// </summary>
        /// <returns>Task value.</returns>
        [Fact]
        public async Task TestGetConnectionsCall()
        {
            var gitHubApi = ClientFactory.Create(req =>
            {
                Assert.Equal("https://example.com/connections?customer_id={my_customer_id}", req.RequestUri.ToString());
                Assert.Equal("GET", req.Method.Method);

                var response = new HttpResponseMessage();
                response.Content = new StringContent(@"{""meta"": {""next_id"": null, ""next_page"": null}, ""data"": [{""status"": ""inactive"", ""show_consent_confirmation"": true, ""provider_id"": ""67"", ""categorization"": ""personal"", ""provider_code"": ""fakebank_interactive_xf"", ""store_credentials"": true, ""daily_refresh"": false, ""created_at"": ""2019-11-14T08:21:54Z"", ""updated_at"": ""2019-11-14T08:22:15Z"", ""next_refresh_possible_at"": ""2019-11-14T08:27:15Z"", ""secret"": ""secret"", ""last_attempt"": {""show_consent_confirmation"": true, ""customer_last_logged_at"": null, ""partial"": false, ""store_credentials"": true, ""daily_refresh"": false, ""success_at"": ""2019-11-14T08:22:15Z"", ""locale"": ""en"", ""consent_id"": ""6937741"", ""updated_at"": ""2019-11-14T08:22:15Z"", ""finished"": true, ""fail_message"": null, ""to_date"": ""2019-11-14"", ""device_type"": ""desktop"", ""exclude_accounts"": [], ""categorize"": true, ""fail_error_class"": null, ""id"": ""411800282"", ""custom_fields"": {""custom_key"": ""custom_value""}, ""user_present"": true, ""interactive"": true, ""include_natures"": null, ""last_stage"": {""interactive_html"": null, ""interactive_fields_options"": {""field_a"": [{""name"": ""Field Name""}]}, ""created_at"": ""2019-11-14T08:22:15Z"", ""updated_at"": ""2019-11-14T08:22:15Z"", ""name"": ""finish"", ""id"": ""50372378"", ""interactive_fields_names"": [""field_a""]}, ""from_date"": ""2019-01-01"", ""fail_at"": null, ""fetch_scopes"": [""accounts"", ""transactions""], ""user_agent"": ""Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.2 Safari/605.1.15"", ""api_mode"": ""service"", ""automatic_fetch"": false, ""finished_recent"": true, ""created_at"": ""2019-11-14T08:21:54Z"", ""api_version"": ""5"", ""remote_ip"": ""86.242.122.176""}, ""country_code"": ""XF"", ""last_success_at"": ""2019-11-14T08:22:15Z"", ""provider_name"": ""Fake Bank with SMS"", ""customer_id"": ""123"", ""id"": ""1"", ""last_consent_id"": ""6937741""}]}", Encoding.UTF8, "application/json");

                return Task.FromResult(response);
            });

            var res = await gitHubApi.GetConnectionsCall("{my_customer_id}").ConfigureAwait(false);

            Assert.Equal(ConnectionStatus.inactive, res.data.First().status);
            Assert.Equal(Categorization.personal, res.data.First().categorization);
            Assert.NotEmpty(res.data.First().last_attempt.custom_fields);
            Assert.NotEmpty(res.data.First().last_attempt.last_stage.interactive_fields_names);
            Assert.NotEmpty(res.data.First().last_attempt.last_stage.interactive_fields_options);
            Assert.NotEmpty(res.data.First().last_attempt.last_stage.interactive_fields_options["field_a"]);
        }

        /// <summary>
        /// Test the response when fetching accounts.
        /// </summary>
        /// <returns>Task value.</returns>
        [Fact]
        public async Task TestGetAccountsCall()
        {
            var gitHubApi = ClientFactory.Create(req =>
            {
                Assert.Equal("https://example.com/accounts?connection_id={my_id}", req.RequestUri.ToString());
                Assert.Equal("GET", req.Method.Method);

                var response = new HttpResponseMessage();
                response.Content = new StringContent(@"{""meta"": {""next_id"": null, ""next_page"": null}, ""data"": [{""extra"": {""status"": ""active"", ""transactions_count"": {""pending"": 0, ""posted"": 17}, ""last_posted_transaction_id"": ""1991514607"", ""iban"": ""DE11100110012612442222"", ""swift"": ""ABCDEFGH"", ""account_name"": ""123456"", ""current_time"": ""22:41:00"", ""assets"": [""asset_a"", ""asset_b""], ""client_name"": ""John Smith"", ""card_type"": ""master_card"", ""current_date"": ""2019-11-13"", ""account_number"": ""123456"", ""cards"": [""card_a"", ""card_b""], ""sort_code"": ""65-43-21""}, ""name"": ""Simple account 1 MasterCard"", ""nature"": ""card"", ""updated_at"": ""2019-11-13T22:41:23Z"", ""created_at"": ""2019-11-13T22:41:23Z"", ""balance"": 2006.11, ""id"": ""10017529"", ""currency_code"": ""EUR"", ""connection_id"": ""7502064""}]}", Encoding.UTF8, "application/json");

                return Task.FromResult(response);
            });

            var res = await gitHubApi.GetAccountsCall("{my_id}").ConfigureAwait(false);

            Assert.Single(res.data);
            Assert.Equal(2006.11m, res.data.First().balance);
            Assert.Equal(17, res.data.First().extra.transactions_count.posted);
            Assert.Equal(0, res.data.First().extra.transactions_count.pending);
            Assert.NotEmpty(res.data.First().extra.assets);
            Assert.NotEmpty(res.data.First().extra.cards);
        }

        /// <summary>
        /// Test the response when fetching transactions.
        /// </summary>
        /// <returns>Task value.</returns>
        [Fact]
        public async Task TestGetTransactionsCall()
        {
            var gitHubApi = ClientFactory.Create(req =>
            {
                Assert.Equal("https://example.com/transactions?connection_id={my_id}&account_id={my_account}", req.RequestUri.ToString());
                Assert.Equal("GET", req.Method.Method);

                var response = new HttpResponseMessage();
                response.Content = new StringContent(@"{""meta"": {""next_id"": null, ""next_page"": null}, ""data"": [{""status"": ""posted"", ""account_id"": ""10017529"", ""extra"": {""categorization_confidence"": 1, ""account_balance_snapshot"": 2006.11, ""tags"": [""tag_a"", ""tag_b""]}, ""updated_at"": ""2019-11-13T22:41:23Z"", ""made_on"": ""2019-08-17"", ""id"": ""1991514543"", ""description"": ""Income for Simple account 1 MasterCard"", ""category"": ""income"", ""created_at"": ""2019-11-13T22:41:23Z"", ""amount"": 10000, ""mode"": ""normal"", ""duplicated"": false, ""currency_code"": ""EUR""}]}", Encoding.UTF8, "application/json");
                return Task.FromResult(response);
            });

            var res = await gitHubApi.GetTransactionsCall("{my_id}", "{my_account}").ConfigureAwait(false);

            Assert.Single(res.data);
            Assert.Equal(new List<string> { "tag_a", "tag_b" }, res.data.First().extra.tags);
        }
    }
}
