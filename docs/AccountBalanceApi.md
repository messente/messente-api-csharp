# com.Messente.Api.Api.AccountBalanceApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountBalance**](AccountBalanceApi.md#getaccountbalance) | **GET** /get_balance | Get account balance |
| [**GetAccountBalanceUsingPost**](AccountBalanceApi.md#getaccountbalanceusingpost) | **POST** /get_balance | Get account balance |

<a id="getaccountbalance"></a>
# **GetAccountBalance**
> string GetAccountBalance (string username, string password)

Get account balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class GetAccountBalanceExample
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

            var apiInstance = new AccountBalanceApi(config);
            var username = "username_example";  // string | The API username
            var password = "password_example";  // string | The API password

            try
            {
                // Get account balance
                string result = apiInstance.GetAccountBalance(username, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountBalanceApi.GetAccountBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account balance
    ApiResponse<string> response = apiInstance.GetAccountBalanceWithHttpInfo(username, password);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountBalanceApi.GetAccountBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | The API username |  |
| **password** | **string** | The API password |  |

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

<a id="getaccountbalanceusingpost"></a>
# **GetAccountBalanceUsingPost**
> string GetAccountBalanceUsingPost (string username, string password)

Get account balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class GetAccountBalanceUsingPostExample
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

            var apiInstance = new AccountBalanceApi(config);
            var username = "username_example";  // string | The API username
            var password = "password_example";  // string | The API password

            try
            {
                // Get account balance
                string result = apiInstance.GetAccountBalanceUsingPost(username, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountBalanceApi.GetAccountBalanceUsingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountBalanceUsingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account balance
    ApiResponse<string> response = apiInstance.GetAccountBalanceUsingPostWithHttpInfo(username, password);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountBalanceApi.GetAccountBalanceUsingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | The API username |  |
| **password** | **string** | The API password |  |

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

