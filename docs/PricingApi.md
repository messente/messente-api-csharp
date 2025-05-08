# com.Messente.Api.Api.PricingApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPricelist**](PricingApi.md#getpricelist) | **GET** /pricelist | Get pricelist for account |
| [**GetPrices**](PricingApi.md#getprices) | **GET** /prices | Get pricing for a specific country |

<a id="getpricelist"></a>
# **GetPricelist**
> string GetPricelist (string username, string password)

Get pricelist for account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class GetPricelistExample
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

            var apiInstance = new PricingApi(config);
            var username = "username_example";  // string | The API username
            var password = "password_example";  // string | The API password

            try
            {
                // Get pricelist for account
                string result = apiInstance.GetPricelist(username, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PricingApi.GetPricelist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPricelistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get pricelist for account
    ApiResponse<string> response = apiInstance.GetPricelistWithHttpInfo(username, password);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PricingApi.GetPricelistWithHttpInfo: " + e.Message);
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
| **200** | Both errors and success responses are returned as plain text with HTTP status 200. Unsuccessful responses contain the error code, while successful ones contain the pricelist in CSV format.  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprices"></a>
# **GetPrices**
> Price GetPrices (string username, string password, string country, string? format = null)

Get pricing for a specific country

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class GetPricesExample
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

            var apiInstance = new PricingApi(config);
            var username = "username_example";  // string | The API username
            var password = "password_example";  // string | The API password
            var country = "country_example";  // string | The country code, for which to get the prices
            var format = "format_example";  // string? | The format of the response. Can be either 'json' or 'xml'. If not specified, defaults to 'json'. (optional) 

            try
            {
                // Get pricing for a specific country
                Price result = apiInstance.GetPrices(username, password, country, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PricingApi.GetPrices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPricesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get pricing for a specific country
    ApiResponse<Price> response = apiInstance.GetPricesWithHttpInfo(username, password, country, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PricingApi.GetPricesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | The API username |  |
| **password** | **string** | The API password |  |
| **country** | **string** | The country code, for which to get the prices |  |
| **format** | **string?** | The format of the response. Can be either &#39;json&#39; or &#39;xml&#39;. If not specified, defaults to &#39;json&#39;. | [optional]  |

### Return type

[**Price**](Price.md)

### Authorization

[apiPassword](../README.md#apiPassword), [apiUsername](../README.md#apiUsername)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/plain; charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unsuccessful responses are returned as plain text with an error code, while successful ones contain either JSON or XML depending on the user&#39;s choice. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

