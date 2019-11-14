/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Refit;

    /// <summary>
    /// Salt Edge API client interface.
    /// </summary>
    public interface ISaltEdgeClient
    {
#pragma warning disable IDE1006, SA1300, CA1707, SA1609
        /// <summary>
        /// https://docs.saltedge.com/account_information/v5/#create-customer.
        /// </summary>
        /// <param name="par">Params.</param>
        /// <returns>Wrapped CreateCustomerResponse.</returns>
        [Post("/customers")]
        Task<ParamWrapper<CreateCustomerResponse>> CreateCustomerCall(ParamWrapper<CreateCustomerRequest> par);

        /// <summary>
        /// https://docs.saltedge.com/account_information/v5/#create-connect-session.
        /// </summary>
        /// <param name="par">Params.</param>
        /// <returns>Wrapped CreateConnectSessionResponse.</returns>
        [Post("/connect_sessions/create")]
        Task<ParamWrapper<CreateConnectSessionResponse>> CreateConnectSessionCall(ParamWrapper<CreateConnectSessionRequest> par);

        /// <summary>
        /// https://docs.saltedge.com/account_information/v5/#fetch-connections.
        /// </summary>
        /// <param name="customer_id">Customer id.</param>
        /// <returns>Wrapped enumerable of <see cref="GetConnectionsResponse"/>.</returns>
        [Get("/connections")]
        Task<ParamWrapper<IEnumerable<GetConnectionsResponse>>> GetConnectionsCall(string customer_id);

        /// <summary>
        /// https://docs.saltedge.com/account_information/v5/#fetch-accounts-for-connections.
        /// </summary>
        /// <param name="connection_id">Connection id.</param>
        /// <returns>Wrapped enumerable of <see cref="GetAccountsResponse"/>.</returns>
        [Get("/accounts")]
        Task<ParamWrapper<IEnumerable<GetAccountsResponse>>> GetAccountsCall(string connection_id);
#pragma warning restore IDE1006, SA1300, CA1707, SA1609
    }
}
