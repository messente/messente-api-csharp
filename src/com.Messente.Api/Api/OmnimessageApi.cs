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
    public interface IOmnimessageApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancels a scheduled Omnimessage
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        Object CancelScheduledMessage(Guid omnimessageId, int operationIndex = 0);

        /// <summary>
        /// Cancels a scheduled Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> CancelScheduledMessageWithHttpInfo(Guid omnimessageId, int operationIndex = 0);
        /// <summary>
        /// Sends a bulk Omnimessage
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkOmnimessage">Bulk Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BulkOmniMessageCreateSuccessResponse</returns>
        BulkOmniMessageCreateSuccessResponse SendBulkOmnimessage(BulkOmnimessage bulkOmnimessage, int operationIndex = 0);

        /// <summary>
        /// Sends a bulk Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkOmnimessage">Bulk Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BulkOmniMessageCreateSuccessResponse</returns>
        ApiResponse<BulkOmniMessageCreateSuccessResponse> SendBulkOmnimessageWithHttpInfo(BulkOmnimessage bulkOmnimessage, int operationIndex = 0);
        /// <summary>
        /// Sends an Omnimessage
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OmniMessageCreateSuccessResponse</returns>
        OmniMessageCreateSuccessResponse SendOmnimessage(Omnimessage omnimessage, int operationIndex = 0);

        /// <summary>
        /// Sends an Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OmniMessageCreateSuccessResponse</returns>
        ApiResponse<OmniMessageCreateSuccessResponse> SendOmnimessageWithHttpInfo(Omnimessage omnimessage, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOmnimessageApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Cancels a scheduled Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> CancelScheduledMessageAsync(Guid omnimessageId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Cancels a scheduled Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CancelScheduledMessageWithHttpInfoAsync(Guid omnimessageId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Sends a bulk Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkOmnimessage">Bulk Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BulkOmniMessageCreateSuccessResponse</returns>
        System.Threading.Tasks.Task<BulkOmniMessageCreateSuccessResponse> SendBulkOmnimessageAsync(BulkOmnimessage bulkOmnimessage, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Sends a bulk Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkOmnimessage">Bulk Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BulkOmniMessageCreateSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BulkOmniMessageCreateSuccessResponse>> SendBulkOmnimessageWithHttpInfoAsync(BulkOmnimessage bulkOmnimessage, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Sends an Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OmniMessageCreateSuccessResponse</returns>
        System.Threading.Tasks.Task<OmniMessageCreateSuccessResponse> SendOmnimessageAsync(Omnimessage omnimessage, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Sends an Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OmniMessageCreateSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OmniMessageCreateSuccessResponse>> SendOmnimessageWithHttpInfoAsync(Omnimessage omnimessage, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOmnimessageApi : IOmnimessageApiSync, IOmnimessageApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OmnimessageApi : IOmnimessageApi
    {
        private com.Messente.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OmnimessageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OmnimessageApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmnimessageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OmnimessageApi(string basePath)
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
        /// Initializes a new instance of the <see cref="OmnimessageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OmnimessageApi(com.Messente.Api.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="OmnimessageApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public OmnimessageApi(com.Messente.Api.Client.ISynchronousClient client, com.Messente.Api.Client.IAsynchronousClient asyncClient, com.Messente.Api.Client.IReadableConfiguration configuration)
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
        /// Cancels a scheduled Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        public Object CancelScheduledMessage(Guid omnimessageId, int operationIndex = 0)
        {
            com.Messente.Api.Client.ApiResponse<Object> localVarResponse = CancelScheduledMessageWithHttpInfo(omnimessageId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancels a scheduled Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        public com.Messente.Api.Client.ApiResponse<Object> CancelScheduledMessageWithHttpInfo(Guid omnimessageId, int operationIndex = 0)
        {
            com.Messente.Api.Client.RequestOptions localVarRequestOptions = new com.Messente.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("omnimessageId", com.Messente.Api.Client.ClientUtils.ParameterToString(omnimessageId)); // path parameter

            localVarRequestOptions.Operation = "OmnimessageApi.CancelScheduledMessage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/omnimessage/{omnimessageId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelScheduledMessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cancels a scheduled Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> CancelScheduledMessageAsync(Guid omnimessageId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            com.Messente.Api.Client.ApiResponse<Object> localVarResponse = await CancelScheduledMessageWithHttpInfoAsync(omnimessageId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cancels a scheduled Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<com.Messente.Api.Client.ApiResponse<Object>> CancelScheduledMessageWithHttpInfoAsync(Guid omnimessageId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            com.Messente.Api.Client.RequestOptions localVarRequestOptions = new com.Messente.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("omnimessageId", com.Messente.Api.Client.ClientUtils.ParameterToString(omnimessageId)); // path parameter

            localVarRequestOptions.Operation = "OmnimessageApi.CancelScheduledMessage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/omnimessage/{omnimessageId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancelScheduledMessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Sends a bulk Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkOmnimessage">Bulk Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>BulkOmniMessageCreateSuccessResponse</returns>
        public BulkOmniMessageCreateSuccessResponse SendBulkOmnimessage(BulkOmnimessage bulkOmnimessage, int operationIndex = 0)
        {
            com.Messente.Api.Client.ApiResponse<BulkOmniMessageCreateSuccessResponse> localVarResponse = SendBulkOmnimessageWithHttpInfo(bulkOmnimessage);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Sends a bulk Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkOmnimessage">Bulk Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of BulkOmniMessageCreateSuccessResponse</returns>
        public com.Messente.Api.Client.ApiResponse<BulkOmniMessageCreateSuccessResponse> SendBulkOmnimessageWithHttpInfo(BulkOmnimessage bulkOmnimessage, int operationIndex = 0)
        {
            // verify the required parameter 'bulkOmnimessage' is set
            if (bulkOmnimessage == null)
            {
                throw new com.Messente.Api.Client.ApiException(400, "Missing required parameter 'bulkOmnimessage' when calling OmnimessageApi->SendBulkOmnimessage");
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

            localVarRequestOptions.Data = bulkOmnimessage;

            localVarRequestOptions.Operation = "OmnimessageApi.SendBulkOmnimessage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<BulkOmniMessageCreateSuccessResponse>("/omnimessages", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendBulkOmnimessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Sends a bulk Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkOmnimessage">Bulk Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BulkOmniMessageCreateSuccessResponse</returns>
        public async System.Threading.Tasks.Task<BulkOmniMessageCreateSuccessResponse> SendBulkOmnimessageAsync(BulkOmnimessage bulkOmnimessage, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            com.Messente.Api.Client.ApiResponse<BulkOmniMessageCreateSuccessResponse> localVarResponse = await SendBulkOmnimessageWithHttpInfoAsync(bulkOmnimessage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Sends a bulk Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkOmnimessage">Bulk Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BulkOmniMessageCreateSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<com.Messente.Api.Client.ApiResponse<BulkOmniMessageCreateSuccessResponse>> SendBulkOmnimessageWithHttpInfoAsync(BulkOmnimessage bulkOmnimessage, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'bulkOmnimessage' is set
            if (bulkOmnimessage == null)
            {
                throw new com.Messente.Api.Client.ApiException(400, "Missing required parameter 'bulkOmnimessage' when calling OmnimessageApi->SendBulkOmnimessage");
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

            localVarRequestOptions.Data = bulkOmnimessage;

            localVarRequestOptions.Operation = "OmnimessageApi.SendBulkOmnimessage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<BulkOmniMessageCreateSuccessResponse>("/omnimessages", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendBulkOmnimessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Sends an Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>OmniMessageCreateSuccessResponse</returns>
        public OmniMessageCreateSuccessResponse SendOmnimessage(Omnimessage omnimessage, int operationIndex = 0)
        {
            com.Messente.Api.Client.ApiResponse<OmniMessageCreateSuccessResponse> localVarResponse = SendOmnimessageWithHttpInfo(omnimessage);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Sends an Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of OmniMessageCreateSuccessResponse</returns>
        public com.Messente.Api.Client.ApiResponse<OmniMessageCreateSuccessResponse> SendOmnimessageWithHttpInfo(Omnimessage omnimessage, int operationIndex = 0)
        {
            // verify the required parameter 'omnimessage' is set
            if (omnimessage == null)
            {
                throw new com.Messente.Api.Client.ApiException(400, "Missing required parameter 'omnimessage' when calling OmnimessageApi->SendOmnimessage");
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

            localVarRequestOptions.Data = omnimessage;

            localVarRequestOptions.Operation = "OmnimessageApi.SendOmnimessage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<OmniMessageCreateSuccessResponse>("/omnimessage", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendOmnimessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Sends an Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OmniMessageCreateSuccessResponse</returns>
        public async System.Threading.Tasks.Task<OmniMessageCreateSuccessResponse> SendOmnimessageAsync(Omnimessage omnimessage, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            com.Messente.Api.Client.ApiResponse<OmniMessageCreateSuccessResponse> localVarResponse = await SendOmnimessageWithHttpInfoAsync(omnimessage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Sends an Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OmniMessageCreateSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<com.Messente.Api.Client.ApiResponse<OmniMessageCreateSuccessResponse>> SendOmnimessageWithHttpInfoAsync(Omnimessage omnimessage, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'omnimessage' is set
            if (omnimessage == null)
            {
                throw new com.Messente.Api.Client.ApiException(400, "Missing required parameter 'omnimessage' when calling OmnimessageApi->SendOmnimessage");
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

            localVarRequestOptions.Data = omnimessage;

            localVarRequestOptions.Operation = "OmnimessageApi.SendOmnimessage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + com.Messente.Api.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<OmniMessageCreateSuccessResponse>("/omnimessage", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendOmnimessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
