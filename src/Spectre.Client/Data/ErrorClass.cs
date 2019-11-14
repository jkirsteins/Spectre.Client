/* Copyright (c) 2019 Jānis Kiršteins. All rights reserved. */

namespace Spectre.Client
{
    /// <summary>
    /// https://docs.saltedge.com/account_information/v5/#errors-list.
    /// </summary>
    public enum ErrorClass
    {
        /// <summary>
        /// An account with the sent account_id could not be found
        /// </summary>
        AccountNotFound,

        /// <summary>
        /// The client has no access to the required route.
        /// </summary>
        ActionNotAllowed,

        /// <summary>
        /// You have excluded all the accounts from the connection fetching process.
        /// </summary>
        AllAccountsExcluded,

        /// <summary>
        /// The API key with the provided App-id and Secret does not exist or is inactive.
        /// </summary>
        ApiKeyNotFound,

        /// <summary>
        /// The App-id was not provided in request headers.
        /// </summary>
        AppIdNotProvided,

        /// <summary>
        /// An attempt with such id does not exist.
        /// </summary>
        AttemptNotFound,

        /// <summary>
        /// Background fetch limit (4 times in a 24 hour period) was exceeded.This restriction applies only to PSD2 providers.
        /// </summary>
        BackgroundFetchLimitExceeded,

        /// <summary>
        /// More than 100 objects were sent in the request (100 is the limit).
        /// </summary>
        BatchSizeLimitExceeded,

        /// <summary>
        /// One client can categorize at most 1000 transactions per day.
        /// </summary>
        CategorizationLimitReached,

        /// <summary>
        /// The client has been disabled.You can find out more about the disabled status on Disabled guides page.
        /// </summary>
        ClientDisabled,

        /// <summary>
        /// The API key used in the request does not belong to a client.
        /// </summary>
        ClientNotFound,

        /// <summary>
        /// The client is pending approval.You can find out more about the pending status on Pending guides page.
        /// </summary>
        ClientPending,

        /// <summary>
        /// The client is in the Restricted state.You can find out more about the restricted status on Restricted guides page.
        /// </summary>
        ClientRestricted,

        /// <summary>
        /// Some network errors appear while fetching data.
        /// </summary>
        ConnectionFailed,

        /// <summary>
        /// Internet connection was lost in the process.
        /// </summary>
        ConnectionLost,

        /// <summary>
        /// Sending a country_code that is not present in our system.
        /// </summary>
        CountryNotFound,

        /// <summary>
        /// A customer with such customer_id could not be found.
        /// </summary>
        CustomerNotFound,

        /// <summary>
        /// Customer is locked.
        /// </summary>
        CustomerLocked,

        /// <summary>
        /// New connection credentials do not match old ones on reconnect.
        /// </summary>
        CredentialsNotMatch,

        /// <summary>
        /// The custom_fields object has more than 1 KB.
        /// </summary>
        CustomFieldsSizeTooBig,

        /// <summary>
        /// The custom_fields field is not of type object.
        /// </summary>
        CustomFieldsFormatInvalid,

        /// <summary>
        /// We have received an invalid Date format.
        /// </summary>
        DateFormatInvalid,

        /// <summary>
        /// Sending a date value that does not fit in admissible range.
        /// </summary>
        DateOutOfRange,

        /// <summary>
        /// We have received an invalid DateTime format.
        /// </summary>
        DateTimeFormatInvalid,

        /// <summary>
        /// Sending a datetime value that does not fit in admissible range.
        /// </summary>
        DateTimeOutOfRange,

        /// <summary>
        /// The customer you are trying to create already exists.
        /// </summary>
        DuplicatedCustomer,

        /// <summary>
        /// The email is invalid.
        /// </summary>
        EmailInvalid,

        /// <summary>
        /// The whole fetching process took too long to execute.
        /// </summary>
        ExecutionTimeout,

        /// <summary>
        /// The Expires-at header is invalid, or is set to more than 1 hour from now in UTC.
        /// </summary>
        ExpiresAtInvalid,

        /// <summary>
        /// One of the steps of the fetching process took too long to execute.
        /// </summary>
        FetchingTimeout,

        /// <summary>
        /// The value of fetch_scopes parameter is not allowed by client, provider and/or consent.
        /// </summary>
        FetchScopesNotAllowed,

        /// <summary>
        /// The value of fetch_scopes parameter is invalid.
        /// </summary>
        FetchScopesInvalid,

        /// <summary>
        /// There were errors while uploading and processing files.
        /// </summary>
        FileError,

        /// <summary>
        /// Provider with the file mode was chosen, but no file was uploaded before creating or reconnecting a connection.
        /// </summary>
        FileNotProvided,

        /// <summary>
        /// File was not saved because of an error.
        /// </summary>
        FileNotSaved,

        /// <summary>
        /// Fetching holder info for this provider is not supported.
        /// </summary>
        HolderInfoNotSupported,

        /// <summary>
        /// Invalid identifier sent for identifying the customer.
        /// </summary>
        IdentifierInvalid,

        /// <summary>
        /// The interactive step of the fetching process took too long to execute.
        /// </summary>
        InteractiveAdapterTimeout,

        /// <summary>
        /// It took too long to respond to the interactive question.
        /// </summary>
        InteractiveTimeout,

        /// <summary>
        /// An internal error has occurred
        /// </summary>
        InternalServerError,

        /// <summary>
        /// The customer tried to connect/reconnect a connection with invalid credentials.
        /// </summary>
        InvalidCredentials,

        /// <summary>
        /// Invalid JSON encoded values.
        /// </summary>
        InvalidEncoding,

        /// <summary>
        /// Invalid from_date value, whether out of range or wrong date format.
        /// </summary>
        InvalidFromDate,

        /// <summary>
        /// Interactive credentials that were sent are wrong.
        /// </summary>
        InvalidInteractiveCredentials,

        /// <summary>
        /// Invalid to_date value, whether out of range or wrong date format.
        /// </summary>
        InvalidToDate,

        /// <summary>
        /// We have received some other request format instead of JSON, or the body could not be parsed.
        /// </summary>
        JsonParseError,

        /// <summary>
        /// The connection is already being processed.
        /// </summary>
        ConnectionAlreadyProcessing,

        /// <summary>
        /// The connection was already authorized.
        /// </summary>
        ConnectionAlreadyAuthorized,

        /// <summary>
        /// Connection cannot be refreshed right now.
        /// </summary>
        ConnectionCannotBeRefreshed,

        /// <summary>
        /// The customer tried to connect, reconnect or fetch a connection, but it appears to be disabled.
        /// </summary>
        ConnectionDisabled,

        /// <summary>
        /// The client tried to create a connection that already exists.
        /// </summary>
        ConnectionDuplicated,

        /// <summary>
        /// Connection fetching had stopped because of fetching timeout or connection was deleted during fetch process.
        /// </summary>
        ConnectionFetchingStopped,

        /// <summary>
        /// The client tried to create more connections than possible for a client which is in Test or Pending status.
        /// </summary>
        ConnectionLimitReached,

        /// <summary>
        /// We could not find a connection with the requested connection_id.
        /// </summary>
        ConnectionNotFound,

        /// <summary>
        /// The Expires-at field is missing in the headers.
        /// </summary>
        MissingExpiresAt,

        /// <summary>
        /// The Signature field is missing in the headers.
        /// </summary>
        MissingSignature,

        /// <summary>
        /// The customer denied access to his data from the provider’s page.
        /// </summary>
        ProviderAccessNotGranted,

        /// <summary>
        /// The accessed provider is disabled.
        /// </summary>
        ProviderDisabled,

        /// <summary>
        /// There’s an error on the provider’s side which obstructs us from obtaining the data for the connection.
        /// </summary>
        ProviderError,

        /// <summary>
        /// The accessed provider is inactive at the moment.
        /// </summary>
        ProviderInactive,

        /// <summary>
        /// Sending a provider_code that is not present in our system.
        /// </summary>
        ProviderNotFound,

        /// <summary>
        /// The chosen provider does not have provider keys.
        /// </summary>
        ProviderKeyFound,

        /// <summary>
        /// The connection’s provider has no interactive step.
        /// </summary>
        ProviderNotInteractive,

        /// <summary>
        /// The provider is temporary unavailable.
        /// </summary>
        ProviderUnavailable,

        /// <summary>
        /// The client did not provide the public key in his account information.
        /// </summary>
        PublicKeyNotProvided,

        /// <summary>
        /// Too many connections are being processed at the same time from one application.
        /// </summary>
        RateLimitExceeded,

        /// <summary>
        /// The request has expired, took longer than mentioned in the Expires-at header.
        /// </summary>
        RequestExpired,

        /// <summary>
        /// The return_to URL is invalid.
        /// </summary>
        ReturnURLInvalid,

        /// <summary>
        /// The return_to URL exceeds 2040 characters.
        /// </summary>
        ReturnURLTooLong,

        /// <summary>
        /// The action you are trying to access does not exist
        /// </summary>
        RouteNotFound,

        /// <summary>
        /// The Secret was not provided in request headers.
        /// </summary>
        SecretNotProvided,

        /// <summary>
        /// The Signature header does not match with the correct one.
        /// </summary>
        SignatureNotMatch,

        /// <summary>
        /// Too many requests have occurred for connecting/reconnecting a connection from one IP address in a small period of time.
        /// </summary>
        TooManyRequests,

        /// <summary>
        /// A transaction with the sent transaction_id could not be found.
        /// </summary>
        TransactionNotFound,

        /// <summary>
        /// Sending a value(e.g.id) which exceeds integer limit.
        /// </summary>
        ValueOutOfRange,

        /// <summary>
        /// We have received a wrong combination of customer_id, app_id and connection_id.
        /// </summary>
        WrongClientToken,

        /// <summary>
        /// We do not support the received provider_mode.
        /// </summary>
        WrongProviderMode,

        /// <summary>
        /// The JSON request is incorrectly formed.
        /// </summary>
        WrongRequestFormat,

        /// <summary>
        /// The passed from_date - to_date interval is out of consent from_date - to_date range.
        /// </summary>
        DateOutOfAispConsentRange,

        /// <summary>
        /// The value of consent scopes parameter is invalid.
        /// </summary>
        AispConsentScopesInvalid,

        /// <summary>
        /// The value of consent scopes parameter is not allowed by client or/and by provider.
        /// </summary>
        AispConsentScopesNotAllowed,

        /// <summary>
        /// Invalid consent from_date value, whether out of range or wrong date format.
        /// </summary>
        InvalidAispConsentFromDate,

        /// <summary>
        /// Invalid consent period_days value or not allowed by provider.
        /// </summary>
        InvalidAispConsentPeriod,

        /// <summary>
        /// The consent has already been revoked.
        /// </summary>
        AispConsentAlreadyRevoked,

        /// <summary>
        /// Refresh is not possible because the consent has been revoked.
        /// </summary>
        AispConsentRevoked,

        /// <summary>
        /// Refresh is not possible because the consent has expired.
        /// </summary>
        AispConsentExpired,

        /// <summary>
        /// A consent with such id does not exist.
        /// </summary>
        AispConsentNotFound,
    }
}
