/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber and WhatsApp messages, blacklist phone numbers to make sure you're not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.0.1
 * Contact: messente@messente.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace com.Messente.Api.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeliveryReportApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves the delivery report for the Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the omnimessage to for which the delivery report is to be retrieved</param>
        /// <returns>DeliveryReportResponse</returns>
        DeliveryReportResponse RetrieveDeliveryReport (string omnimessageId);

        /// <summary>
        /// Retrieves the delivery report for the Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the omnimessage to for which the delivery report is to be retrieved</param>
        /// <returns>ApiResponse of DeliveryReportResponse</returns>
        ApiResponse<DeliveryReportResponse> RetrieveDeliveryReportWithHttpInfo (string omnimessageId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves the delivery report for the Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the omnimessage to for which the delivery report is to be retrieved</param>
        /// <returns>Task of DeliveryReportResponse</returns>
        System.Threading.Tasks.Task<DeliveryReportResponse> RetrieveDeliveryReportAsync (string omnimessageId);

        /// <summary>
        /// Retrieves the delivery report for the Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the omnimessage to for which the delivery report is to be retrieved</param>
        /// <returns>Task of ApiResponse (DeliveryReportResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeliveryReportResponse>> RetrieveDeliveryReportAsyncWithHttpInfo (string omnimessageId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeliveryReportApi : IDeliveryReportApi
    {
        private com.Messente.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryReportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeliveryReportApi(String basePath)
        {
            this.Configuration = new com.Messente.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = com.Messente.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryReportApi"/> class
        /// </summary>
        /// <returns></returns>
        public DeliveryReportApi()
        {
            this.Configuration = com.Messente.Api.Client.Configuration.Default;

            ExceptionFactory = com.Messente.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryReportApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeliveryReportApi(com.Messente.Api.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = com.Messente.Api.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.Messente.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public com.Messente.Api.Client.Configuration Configuration {get; set;}

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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieves the delivery report for the Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the omnimessage to for which the delivery report is to be retrieved</param>
        /// <returns>DeliveryReportResponse</returns>
        public DeliveryReportResponse RetrieveDeliveryReport (string omnimessageId)
        {
             ApiResponse<DeliveryReportResponse> localVarResponse = RetrieveDeliveryReportWithHttpInfo(omnimessageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the delivery report for the Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the omnimessage to for which the delivery report is to be retrieved</param>
        /// <returns>ApiResponse of DeliveryReportResponse</returns>
        public ApiResponse< DeliveryReportResponse > RetrieveDeliveryReportWithHttpInfo (string omnimessageId)
        {
            // verify the required parameter 'omnimessageId' is set
            if (omnimessageId == null)
                throw new ApiException(400, "Missing required parameter 'omnimessageId' when calling DeliveryReportApi->RetrieveDeliveryReport");

            var localVarPath = "./omnimessage/{omnimessageId}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (omnimessageId != null) localVarPathParams.Add("omnimessageId", this.Configuration.ApiClient.ParameterToString(omnimessageId)); // path parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetrieveDeliveryReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeliveryReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DeliveryReportResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeliveryReportResponse)));
        }

        /// <summary>
        /// Retrieves the delivery report for the Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the omnimessage to for which the delivery report is to be retrieved</param>
        /// <returns>Task of DeliveryReportResponse</returns>
        public async System.Threading.Tasks.Task<DeliveryReportResponse> RetrieveDeliveryReportAsync (string omnimessageId)
        {
             ApiResponse<DeliveryReportResponse> localVarResponse = await RetrieveDeliveryReportAsyncWithHttpInfo(omnimessageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves the delivery report for the Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the omnimessage to for which the delivery report is to be retrieved</param>
        /// <returns>Task of ApiResponse (DeliveryReportResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeliveryReportResponse>> RetrieveDeliveryReportAsyncWithHttpInfo (string omnimessageId)
        {
            // verify the required parameter 'omnimessageId' is set
            if (omnimessageId == null)
                throw new ApiException(400, "Missing required parameter 'omnimessageId' when calling DeliveryReportApi->RetrieveDeliveryReport");

            var localVarPath = "./omnimessage/{omnimessageId}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (omnimessageId != null) localVarPathParams.Add("omnimessageId", this.Configuration.ApiClient.ParameterToString(omnimessageId)); // path parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetrieveDeliveryReport", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeliveryReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DeliveryReportResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeliveryReportResponse)));
        }

    }
}
