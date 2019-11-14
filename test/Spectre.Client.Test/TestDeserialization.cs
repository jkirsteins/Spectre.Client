/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

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
    }
}
