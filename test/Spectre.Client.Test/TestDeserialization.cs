/* Copyright (c) 2019 Jānis Kiršteins. */

namespace Spectre.Client.Test
{
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
                response.Content = new StringContent(@"{""data"":[{""id"":""1"", ""secret"":""secret"",""provider_id"":""67"",""provider_code"":""fakebank_interactive_xf"",""provider_name"":""Fake Bank with SMS"",""customer_id"":""123"",""next_refresh_possible_at"":""2019-11-14T08:27:15Z"",""created_at"":""2019-11-14T08:21:54Z"",""updated_at"":""2019-11-14T08:22:15Z"",""status"":""inactive"",""categorization"":""personal"",""daily_refresh"":false,""store_credentials"":true,""country_code"":""XF"",""last_success_at"":""2019-11-14T08:22:15Z"",""show_consent_confirmation"":true,""last_consent_id"":""6937741"",""last_attempt"":{""id"":""411800282"",""finished"":true,""api_mode"":""service"",""api_version"":""5"",""locale"":""en"",""user_present"":true,""customer_last_logged_at"":null,""remote_ip"":""86.242.122.176"",""finished_recent"":true,""partial"":false,""automatic_fetch"":false,""daily_refresh"":false,""categorize"":true,""custom_fields"":{},""device_type"":""desktop"",""user_agent"":""Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.2 Safari/605.1.15"",""exclude_accounts"":[],""fetch_scopes"":[""accounts"",""transactions""],""from_date"":""2019-01-01"",""to_date"":""2019-11-14"",""interactive"":true,""store_credentials"":true,""include_natures"":null,""show_consent_confirmation"":true,""consent_id"":""6937741"",""fail_at"":null,""fail_message"":null,""fail_error_class"":null,""created_at"":""2019-11-14T08:21:54Z"",""updated_at"":""2019-11-14T08:22:15Z"",""success_at"":""2019-11-14T08:22:15Z"",""last_stage"":{""id"":""50372378"",""name"":""finish"",""interactive_html"":null,""interactive_fields_names"":null,""interactive_fields_options"":null,""created_at"":""2019-11-14T08:22:15Z"",""updated_at"":""2019-11-14T08:22:15Z""}}}],""meta"":{""next_id"":null,""next_page"":null}}", Encoding.UTF8, "application/json");

                return Task.FromResult(response);
            });

            var res = await gitHubApi.GetConnectionsCall("{my_customer_id}").ConfigureAwait(false);

            Assert.Equal(ConnectionStatus.inactive, res.data.First().status);
            Assert.Equal(Categorization.personal, res.data.First().categorization);
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
                response.Content = new StringContent(@"{""data"":[{""id"":""10017529"",""connection_id"":""7502064"",""name"":""Simple account 1 MasterCard"",""nature"":""card"",""balance"":2006.11,""currency_code"":""EUR"",""extra"":{""iban"":""DE11100110012612442222"",""swift"":""ABCDEFGH"",""status"":""active"",""card_type"":""master_card"",""sort_code"":""65-43-21"",""client_name"":""John Smith"",""account_name"":""123456"",""current_date"":""2019-11-13"",""current_time"":""22:41:00"",""account_number"":""123456"",""transactions_count"":{""posted"":17,""pending"":0},""last_posted_transaction_id"":""1991514607""},""created_at"":""2019-11-13T22:41:23Z"",""updated_at"":""2019-11-13T22:41:23Z""},{""id"":""10017533"",""connection_id"":""7502064"",""name"":""Simple account 2"",""nature"":""account"",""balance"":2008.13,""currency_code"":""USD"",""extra"":{""iban"":""DE84100110012612443333"",""cards"":[""1234....5678"",""*8765""],""swift"":""ABCDEFGJ"",""status"":""active"",""sort_code"":""65-43-22"",""client_name"":""John Smith"",""account_name"":""123457"",""current_date"":""2019-11-13"",""current_time"":""22:41:00"",""account_number"":""123457"",""transactions_count"":{""posted"":18,""pending"":0},""last_posted_transaction_id"":""1991514679""},""created_at"":""2019-11-13T22:41:23Z"",""updated_at"":""2019-11-13T22:41:23Z""},{""id"":""10017537"",""connection_id"":""7502064"",""name"":""Simple account 3"",""nature"":""credit"",""balance"":-2008.13,""currency_code"":""USD"",""extra"":{""iban"":""DE60100110012612444444"",""cards"":[""1234....8765"",""*5678""],""swift"":""ABCDEFGK"",""status"":""active"",""sort_code"":""65-43-23"",""client_name"":""John Smith"",""account_name"":""123458"",""credit_limit"":5000.0,""current_date"":""2019-11-13"",""current_time"":""22:41:00"",""account_number"":""123458"",""available_amount"":2991.87,""transactions_count"":{""posted"":15,""pending"":0},""last_posted_transaction_id"":""1991514739""},""created_at"":""2019-11-13T22:41:23Z"",""updated_at"":""2019-11-13T22:41:23Z""},{""id"":""10017541"",""connection_id"":""7502064"",""name"":""Account 4 merchant testing"",""nature"":""account"",""balance"":1997.41,""currency_code"":""GBP"",""extra"":{""iban"":""GB33BUKB20201555555555"",""swift"":""ABCDEFGH"",""status"":""active"",""sort_code"":""65-43-21"",""client_name"":""John Smith"",""account_name"":""Local Merchant"",""account_number"":""300-200-100"",""transactions_count"":{""posted"":6,""pending"":0},""last_posted_transaction_id"":""1991514763""},""created_at"":""2019-11-13T22:41:23Z"",""updated_at"":""2019-11-13T22:41:24Z""},{""id"":""10017545"",""connection_id"":""7502064"",""name"":""5325 **** **** 1285"",""nature"":""credit_card"",""balance"":-2008.13,""currency_code"":""USD"",""extra"":{""status"":""active"",""card_type"":""master_card"",""client_name"":""John Smith"",""expiry_date"":""2021-11-01"",""account_name"":""**** 1285 MasterCard"",""credit_limit"":10000.0,""blocked_amount"":13.0,""closing_balance"":-1004.07,""available_amount"":7978.87,""next_payment_date"":""2019-12-03"",""transactions_count"":{""posted"":0,""pending"":0},""next_payment_amount"":133.88},""created_at"":""2019-11-13T22:41:24Z"",""updated_at"":""2019-11-13T22:41:24Z""}],""meta"":{""next_id"":null,""next_page"":null}}", Encoding.UTF8, "application/json");

                return Task.FromResult(response);
            });

            var res = await gitHubApi.GetAccountsCall("{my_id}").ConfigureAwait(false);

            Assert.Equal(5, res.data.Count());
            Assert.Equal(2006.11m, res.data.First().balance);
            Assert.Equal(17, res.data.First().extra.transactions_count.posted);
            Assert.Equal(0, res.data.First().extra.transactions_count.pending);
        }
    }
}
