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
    public interface IStatisticsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Requests statistics reports for each country
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statisticsReportSettings">Settings for statistics report</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>StatisticsReportSuccess</returns>
        StatisticsReportSuccess CreateStatisticsReport(StatisticsReportSettings statisticsReportSettings, int operationIndex = 0);

        /// <summary>
        /// Requests statistics reports for each country
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statisticsReportSettings">Settings for statistics report</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of StatisticsReportSuccess</returns>
        ApiResponse<StatisticsReportSuccess> CreateStatisticsReportWithHttpInfo(StatisticsReportSettings statisticsReportSettings, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatisticsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Requests statistics reports for each country
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statisticsReportSettings">Settings for statistics report</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StatisticsReportSuccess</returns>
        System.Threading.Tasks.Task<StatisticsReportSuccess> CreateStatisticsReportAsync(StatisticsReportSettings statisticsReportSettings, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Requests statistics reports for each country
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statisticsReportSettings">Settings for statistics report</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StatisticsReportSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatisticsReportSuccess>> CreateStatisticsReportWithHttpInfoAsync(StatisticsReportSettings statisticsReportSettings, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatisticsApi : IStatisticsApiSync, IStatisticsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StatisticsApi : IStatisticsApi
    {
        private com.Messente.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatisticsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatisticsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="StatisticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatisticsApi(com.Messente.Api.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="StatisticsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StatisticsApi(com.Messente.Api.Client.ISynchronousClient client, com.Messente.Api.Client.IAsynchronousClient asyncClient, com.Messente.Api.Client.IReadableConfiguration configuration)
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
        /// Requests statistics reports for each country 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statisticsReportSettings">Settings for statistics report</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>StatisticsReportSuccess</returns>
        public StatisticsReportSuccess CreateStatisticsReport(StatisticsReportSettings statisticsReportSettings, int operationIndex = 0)
        {
            com.Messente.Api.Client.ApiResponse<StatisticsReportSuccess> localVarResponse = CreateStatisticsReportWithHttpInfo(statisticsReportSettings);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Requests statistics reports for each country 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statisticsReportSettings">Settings for statistics report</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of StatisticsReportSuccess</returns>
        public com.Messente.Api.Client.ApiResponse<StatisticsReportSuccess> CreateStatisticsReportWithHttpInfo(StatisticsReportSettings statisticsReportSettings, int operationIndex = 0)
        {
            // verify the required parameter 'statisticsReportSettings' is set
            if (statisticsReportSettings == null)
            {
                throw new com.Messente.Api.Client.ApiException(400, "Missing required parameter 'statisticsReportSettings' when calling StatisticsApi->CreateStatisticsReport");
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

            localVarRequestOptions.Data = statisticsReportSettings;

            localVarRequestOptions.Operation = "StatisticsApi.CreateStatisticsReport";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<StatisticsReportSuccess>("/statistics/reports", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateStatisticsReport", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Requests statistics reports for each country 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statisticsReportSettings">Settings for statistics report</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StatisticsReportSuccess</returns>
        public async System.Threading.Tasks.Task<StatisticsReportSuccess> CreateStatisticsReportAsync(StatisticsReportSettings statisticsReportSettings, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            com.Messente.Api.Client.ApiResponse<StatisticsReportSuccess> localVarResponse = await CreateStatisticsReportWithHttpInfoAsync(statisticsReportSettings, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Requests statistics reports for each country 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statisticsReportSettings">Settings for statistics report</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StatisticsReportSuccess)</returns>
        public async System.Threading.Tasks.Task<com.Messente.Api.Client.ApiResponse<StatisticsReportSuccess>> CreateStatisticsReportWithHttpInfoAsync(StatisticsReportSettings statisticsReportSettings, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'statisticsReportSettings' is set
            if (statisticsReportSettings == null)
            {
                throw new com.Messente.Api.Client.ApiException(400, "Missing required parameter 'statisticsReportSettings' when calling StatisticsApi->CreateStatisticsReport");
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

            localVarRequestOptions.Data = statisticsReportSettings;

            localVarRequestOptions.Operation = "StatisticsApi.CreateStatisticsReport";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<StatisticsReportSuccess>("/statistics/reports", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateStatisticsReport", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
