/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.2.0
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
    public interface IOmnimessageApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancels a scheduled Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <returns>EmptyObject</returns>
        EmptyObject CancelScheduledMessage (string omnimessageId);

        /// <summary>
        /// Cancels a scheduled Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <returns>ApiResponse of EmptyObject</returns>
        ApiResponse<EmptyObject> CancelScheduledMessageWithHttpInfo (string omnimessageId);
        /// <summary>
        /// Sends an Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <returns>OmniMessageCreateSuccessResponse</returns>
        OmniMessageCreateSuccessResponse SendOmnimessage (Omnimessage omnimessage);

        /// <summary>
        /// Sends an Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <returns>ApiResponse of OmniMessageCreateSuccessResponse</returns>
        ApiResponse<OmniMessageCreateSuccessResponse> SendOmnimessageWithHttpInfo (Omnimessage omnimessage);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Cancels a scheduled Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <returns>Task of EmptyObject</returns>
        System.Threading.Tasks.Task<EmptyObject> CancelScheduledMessageAsync (string omnimessageId);

        /// <summary>
        /// Cancels a scheduled Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <returns>Task of ApiResponse (EmptyObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmptyObject>> CancelScheduledMessageAsyncWithHttpInfo (string omnimessageId);
        /// <summary>
        /// Sends an Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <returns>Task of OmniMessageCreateSuccessResponse</returns>
        System.Threading.Tasks.Task<OmniMessageCreateSuccessResponse> SendOmnimessageAsync (Omnimessage omnimessage);

        /// <summary>
        /// Sends an Omnimessage
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <returns>Task of ApiResponse (OmniMessageCreateSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OmniMessageCreateSuccessResponse>> SendOmnimessageAsyncWithHttpInfo (Omnimessage omnimessage);
        #endregion Asynchronous Operations
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
        public OmnimessageApi(String basePath)
        {
            this.Configuration = new com.Messente.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = com.Messente.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmnimessageApi"/> class
        /// </summary>
        /// <returns></returns>
        public OmnimessageApi()
        {
            this.Configuration = com.Messente.Api.Client.Configuration.Default;

            ExceptionFactory = com.Messente.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmnimessageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OmnimessageApi(com.Messente.Api.Client.Configuration configuration = null)
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
        /// Cancels a scheduled Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <returns>EmptyObject</returns>
        public EmptyObject CancelScheduledMessage (string omnimessageId)
        {
             ApiResponse<EmptyObject> localVarResponse = CancelScheduledMessageWithHttpInfo(omnimessageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancels a scheduled Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <returns>ApiResponse of EmptyObject</returns>
        public ApiResponse< EmptyObject > CancelScheduledMessageWithHttpInfo (string omnimessageId)
        {
            // verify the required parameter 'omnimessageId' is set
            if (omnimessageId == null)
                throw new ApiException(400, "Missing required parameter 'omnimessageId' when calling OmnimessageApi->CancelScheduledMessage");

            var localVarPath = "./omnimessage/{omnimessageId}";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelScheduledMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmptyObject>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (EmptyObject) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmptyObject)));
        }

        /// <summary>
        /// Cancels a scheduled Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <returns>Task of EmptyObject</returns>
        public async System.Threading.Tasks.Task<EmptyObject> CancelScheduledMessageAsync (string omnimessageId)
        {
             ApiResponse<EmptyObject> localVarResponse = await CancelScheduledMessageAsyncWithHttpInfo(omnimessageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancels a scheduled Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessageId">UUID of the scheduled omnimessage to be cancelled</param>
        /// <returns>Task of ApiResponse (EmptyObject)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmptyObject>> CancelScheduledMessageAsyncWithHttpInfo (string omnimessageId)
        {
            // verify the required parameter 'omnimessageId' is set
            if (omnimessageId == null)
                throw new ApiException(400, "Missing required parameter 'omnimessageId' when calling OmnimessageApi->CancelScheduledMessage");

            var localVarPath = "./omnimessage/{omnimessageId}";
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
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancelScheduledMessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmptyObject>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (EmptyObject) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmptyObject)));
        }

        /// <summary>
        /// Sends an Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <returns>OmniMessageCreateSuccessResponse</returns>
        public OmniMessageCreateSuccessResponse SendOmnimessage (Omnimessage omnimessage)
        {
             ApiResponse<OmniMessageCreateSuccessResponse> localVarResponse = SendOmnimessageWithHttpInfo(omnimessage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sends an Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <returns>ApiResponse of OmniMessageCreateSuccessResponse</returns>
        public ApiResponse< OmniMessageCreateSuccessResponse > SendOmnimessageWithHttpInfo (Omnimessage omnimessage)
        {
            // verify the required parameter 'omnimessage' is set
            if (omnimessage == null)
                throw new ApiException(400, "Missing required parameter 'omnimessage' when calling OmnimessageApi->SendOmnimessage");

            var localVarPath = "./omnimessage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (omnimessage != null && omnimessage.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(omnimessage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = omnimessage; // byte array
            }

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendOmnimessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OmniMessageCreateSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (OmniMessageCreateSuccessResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OmniMessageCreateSuccessResponse)));
        }

        /// <summary>
        /// Sends an Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <returns>Task of OmniMessageCreateSuccessResponse</returns>
        public async System.Threading.Tasks.Task<OmniMessageCreateSuccessResponse> SendOmnimessageAsync (Omnimessage omnimessage)
        {
             ApiResponse<OmniMessageCreateSuccessResponse> localVarResponse = await SendOmnimessageAsyncWithHttpInfo(omnimessage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sends an Omnimessage 
        /// </summary>
        /// <exception cref="com.Messente.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="omnimessage">Omnimessage to be sent</param>
        /// <returns>Task of ApiResponse (OmniMessageCreateSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OmniMessageCreateSuccessResponse>> SendOmnimessageAsyncWithHttpInfo (Omnimessage omnimessage)
        {
            // verify the required parameter 'omnimessage' is set
            if (omnimessage == null)
                throw new ApiException(400, "Missing required parameter 'omnimessage' when calling OmnimessageApi->SendOmnimessage");

            var localVarPath = "./omnimessage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (omnimessage != null && omnimessage.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(omnimessage); // http body (model) parameter
            }
            else
            {
                localVarPostBody = omnimessage; // byte array
            }

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SendOmnimessage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OmniMessageCreateSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (OmniMessageCreateSuccessResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OmniMessageCreateSuccessResponse)));
        }

    }
}
