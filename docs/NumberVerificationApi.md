# com.Messente.Api.Api.NumberVerificationApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VerifyNumber**](NumberVerificationApi.md#verifynumber) | **POST** /verify/start | verify number |
| [**VerifyPin**](NumberVerificationApi.md#verifypin) | **POST** /verify/pin | verified the PIN code entered by the user. |

<a id="verifynumber"></a>
# **VerifyNumber**
> string VerifyNumber (string username, string password, string to, string? template = null, string? pinLength = null, string? from = null, string? maxTries = null, string? retryDelay = null, string? validity = null, string? ip = null, string? browser = null, string? cookie = null)

verify number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class VerifyNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure API key authorization: apiPassword
            config.AddApiKey("password", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("password", "Bearer");
            // Configure API key authorization: apiUsername
            config.AddApiKey("username", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("username", "Bearer");

            var apiInstance = new NumberVerificationApi(config);
            var username = "username_example";  // string | The API username
            var password = "password_example";  // string | The API password
            var to = "to_example";  // string | Receiver's phone number with the country code
            var template = "template_example";  // string? | Template of the message, including PIN code. Placeholder for PIN code is <PIN>. When not set, default template is used: \"Your Verification PIN code is <PIN>\".  (optional) 
            var pinLength = "pinLength_example";  // string? | Length of the PIN code. Minumum 4 digits, maximum 16. Defaults to 4. (optional) 
            var from = "from_example";  // string? | Sender name. When not set, the default Sender name \"Verigator\" is used. This sender ID also needs to be added to your account beforehand. (optional) 
            var maxTries = "maxTries_example";  // string? | Maximum number of times the PIN code is sent in total. Defaults to \"2\" - initial PIN code and one retry. It is discouraged to set this value to \"1\" as only the initial PIN code is sent and retry is disabled.   (optional) 
            var retryDelay = "retryDelay_example";  // string? | For how long (in seconds) to wait for next retry, if the correct PIN code has not been entered yet? Defaults to 30 seconds. (optional) 
            var validity = "validity_example";  // string? | For how long (in seconds) is the PIN code valid. Defaults to 5 minutes (300 seconds). Maximum 30 minutes (1800 seconds). (optional) 
            var ip = "ip_example";  // string? | IP address of the client making verification request. (optional) 
            var browser = "browser_example";  // string? | User Agent of the browser. For example \"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.130 Safari/537.36\". (optional) 
            var cookie = "cookie_example";  // string? | Unique cookie assigned to this session. If a user tries logging in with the same cookie present, user is automatically logged in and no PIN code verification is needed. (optional) 

            try
            {
                // verify number
                string result = apiInstance.VerifyNumber(username, password, to, template, pinLength, from, maxTries, retryDelay, validity, ip, browser, cookie);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NumberVerificationApi.VerifyNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // verify number
    ApiResponse<string> response = apiInstance.VerifyNumberWithHttpInfo(username, password, to, template, pinLength, from, maxTries, retryDelay, validity, ip, browser, cookie);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NumberVerificationApi.VerifyNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | The API username |  |
| **password** | **string** | The API password |  |
| **to** | **string** | Receiver&#39;s phone number with the country code |  |
| **template** | **string?** | Template of the message, including PIN code. Placeholder for PIN code is &lt;PIN&gt;. When not set, default template is used: \&quot;Your Verification PIN code is &lt;PIN&gt;\&quot;.  | [optional]  |
| **pinLength** | **string?** | Length of the PIN code. Minumum 4 digits, maximum 16. Defaults to 4. | [optional]  |
| **from** | **string?** | Sender name. When not set, the default Sender name \&quot;Verigator\&quot; is used. This sender ID also needs to be added to your account beforehand. | [optional]  |
| **maxTries** | **string?** | Maximum number of times the PIN code is sent in total. Defaults to \&quot;2\&quot; - initial PIN code and one retry. It is discouraged to set this value to \&quot;1\&quot; as only the initial PIN code is sent and retry is disabled.   | [optional]  |
| **retryDelay** | **string?** | For how long (in seconds) to wait for next retry, if the correct PIN code has not been entered yet? Defaults to 30 seconds. | [optional]  |
| **validity** | **string?** | For how long (in seconds) is the PIN code valid. Defaults to 5 minutes (300 seconds). Maximum 30 minutes (1800 seconds). | [optional]  |
| **ip** | **string?** | IP address of the client making verification request. | [optional]  |
| **browser** | **string?** | User Agent of the browser. For example \&quot;Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.130 Safari/537.36\&quot;. | [optional]  |
| **cookie** | **string?** | Unique cookie assigned to this session. If a user tries logging in with the same cookie present, user is automatically logged in and no PIN code verification is needed. | [optional]  |

### Return type

**string**

### Authorization

[apiPassword](../README.md#apiPassword), [apiUsername](../README.md#apiUsername)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Both errors and success responses are returned as plain text with HTTP status 200. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="verifypin"></a>
# **VerifyPin**
> string VerifyPin (string username, string password, string verificationId, string pin, string? ip = null, string? browser = null, string? cookie = null)

verified the PIN code entered by the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class VerifyPinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure API key authorization: apiPassword
            config.AddApiKey("password", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("password", "Bearer");
            // Configure API key authorization: apiUsername
            config.AddApiKey("username", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("username", "Bearer");

            var apiInstance = new NumberVerificationApi(config);
            var username = "username_example";  // string | The API username
            var password = "password_example";  // string | The API password
            var verificationId = "verificationId_example";  // string | Verification ID returned by the successful verification request.
            var pin = "pin_example";  // string | PIN code entered by the user.
            var ip = "ip_example";  // string? | IP address of the client making verification request. If the IP address is from another country, PIN is required even if the cookies match. (optional) 
            var browser = "browser_example";  // string? | User Agent of the browser. For example \"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.130 Safari/537.36\". (optional) 
            var cookie = "cookie_example";  // string? | Unique cookie assigned to this session. If a user tries logging in with the same cookie present, user is automatically logged in and no PIN code verification is needed. (optional) 

            try
            {
                // verified the PIN code entered by the user.
                string result = apiInstance.VerifyPin(username, password, verificationId, pin, ip, browser, cookie);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NumberVerificationApi.VerifyPin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyPinWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // verified the PIN code entered by the user.
    ApiResponse<string> response = apiInstance.VerifyPinWithHttpInfo(username, password, verificationId, pin, ip, browser, cookie);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NumberVerificationApi.VerifyPinWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | The API username |  |
| **password** | **string** | The API password |  |
| **verificationId** | **string** | Verification ID returned by the successful verification request. |  |
| **pin** | **string** | PIN code entered by the user. |  |
| **ip** | **string?** | IP address of the client making verification request. If the IP address is from another country, PIN is required even if the cookies match. | [optional]  |
| **browser** | **string?** | User Agent of the browser. For example \&quot;Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.130 Safari/537.36\&quot;. | [optional]  |
| **cookie** | **string?** | Unique cookie assigned to this session. If a user tries logging in with the same cookie present, user is automatically logged in and no PIN code verification is needed. | [optional]  |

### Return type

**string**

### Authorization

[apiPassword](../README.md#apiPassword), [apiUsername](../README.md#apiUsername)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Both errors and success responses are returned as plain text with HTTP status 200. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

