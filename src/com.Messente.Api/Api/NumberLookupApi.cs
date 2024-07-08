/*
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: messente@messente.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace com.Messente.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INumberLookupApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Requests info about phone numbers
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numbersToInvestigate">Numbers for lookup</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SyncNumberLookupSuccess</returns>
        SyncNumberLookupSuccess FetchInfo(NumbersToInvestigate numbersToInvestigate, int operationIndex = 0);

        /// <summary>
        /// Requests info about phone numbers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numbersToInvestigate">Numbers for lookup</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SyncNumberLookupSuccess</returns>
        ApiResponse<SyncNumberLookupSuccess> FetchInfoWithHttpInfo(NumbersToInvestigate numbersToInvestigate, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INumberLookupApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Requests info about phone numbers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numbersToInvestigate">Numbers for lookup</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SyncNumberLookupSuccess</returns>
        System.Threading.Tasks.Task<SyncNumberLookupSuccess> FetchInfoAsync(NumbersToInvestigate numbersToInvestigate, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Requests info about phone numbers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numbersToInvestigate">Numbers for lookup</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SyncNumberLookupSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<SyncNumberLookupSuccess>> FetchInfoWithHttpInfoAsync(NumbersToInvestigate numbersToInvestigate, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INumberLookupApi : INumberLookupApiSync, INumberLookupApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NumberLookupApi : INumberLookupApi
    {
        private com.Messente.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberLookupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NumberLookupApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberLookupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NumberLookupApi(string basePath)
        {
            this.Configuration = com.Messente.Api.Client.Configuration.MergeConfigurations(
                com.Messente.Api.Client.GlobalConfiguration.Instance,
                new com.Messente.Api.Client.Configuration { BasePath = basePath }
            );
            this.Client = new com.Messente.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new com.Messente.Api.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = com.Messente.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberLookupApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NumberLookupApi(com.Messente.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = com.Messente.Api.Client.Configuration.MergeConfigurations(
                com.Messente.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new com.Messente.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new com.Messente.Api.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = com.Messente.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberLookupApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public NumberLookupApi(com.Messente.Api.Client.ISynchronousClient client, com.Messente.Api.Client.IAsynchronousClient asyncClient, com.Messente.Api.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = com.Messente.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public com.Messente.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public com.Messente.Api.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public com.Messente.Api.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.Messente.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Requests info about phone numbers 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numbersToInvestigate">Numbers for lookup</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SyncNumberLookupSuccess</returns>
        public SyncNumberLookupSuccess FetchInfo(NumbersToInvestigate numbersToInvestigate, int operationIndex = 0)
        {
            com.Messente.Api.Client.ApiResponse<SyncNumberLookupSuccess> localVarResponse = FetchInfoWithHttpInfo(numbersToInvestigate);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Requests info about phone numbers 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numbersToInvestigate">Numbers for lookup</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SyncNumberLookupSuccess</returns>
        public com.Messente.Api.Client.ApiResponse<SyncNumberLookupSuccess> FetchInfoWithHttpInfo(NumbersToInvestigate numbersToInvestigate, int operationIndex = 0)
        {
            // verify the required parameter 'numbersToInvestigate' is set
            if (numbersToInvestigate == null)
            {
                throw new com.Messente.Api.Client.ApiException(400, "Missing required parameter 'numbersToInvestigate' when calling NumberLookupApi->FetchInfo");
            }

            com.Messente.Api.Client.RequestOptions localVarRequestOptions = new com.Messente.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = com.Messente.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = com.Messente.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = numbersToInvestigate;

            localVarRequestOptions.Operation = "NumberLookupApi.FetchInfo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<SyncNumberLookupSuccess>("/hlr/sync", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchInfo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Requests info about phone numbers 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numbersToInvestigate">Numbers for lookup</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SyncNumberLookupSuccess</returns>
        public async System.Threading.Tasks.Task<SyncNumberLookupSuccess> FetchInfoAsync(NumbersToInvestigate numbersToInvestigate, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            com.Messente.Api.Client.ApiResponse<SyncNumberLookupSuccess> localVarResponse = await FetchInfoWithHttpInfoAsync(numbersToInvestigate, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Requests info about phone numbers 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numbersToInvestigate">Numbers for lookup</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SyncNumberLookupSuccess)</returns>
        public async System.Threading.Tasks.Task<com.Messente.Api.Client.ApiResponse<SyncNumberLookupSuccess>> FetchInfoWithHttpInfoAsync(NumbersToInvestigate numbersToInvestigate, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'numbersToInvestigate' is set
            if (numbersToInvestigate == null)
            {
                throw new com.Messente.Api.Client.ApiException(400, "Missing required parameter 'numbersToInvestigate' when calling NumberLookupApi->FetchInfo");
            }


            com.Messente.Api.Client.RequestOptions localVarRequestOptions = new com.Messente.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = com.Messente.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = com.Messente.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = numbersToInvestigate;

            localVarRequestOptions.Operation = "NumberLookupApi.FetchInfo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<SyncNumberLookupSuccess>("/hlr/sync", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("FetchInfo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
