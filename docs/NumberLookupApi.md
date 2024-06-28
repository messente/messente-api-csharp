# com.Messente.Api.Api.NumberLookupApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FetchInfo**](NumberLookupApi.md#fetchinfo) | **POST** /hlr/sync | Requests info about phone numbers |

<a id="fetchinfo"></a>
# **FetchInfo**
> SyncNumberLookupSuccess FetchInfo (NumbersToInvestigate numbersToInvestigate)

Requests info about phone numbers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new NumberLookupApi(config);
            var numbersToInvestigate = new NumbersToInvestigate(); // NumbersToInvestigate | Numbers for lookup

            try
            {
                // Requests info about phone numbers
                SyncNumberLookupSuccess result = apiInstance.FetchInfo(numbersToInvestigate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NumberLookupApi.FetchInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests info about phone numbers
    ApiResponse<SyncNumberLookupSuccess> response = apiInstance.FetchInfoWithHttpInfo(numbersToInvestigate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NumberLookupApi.FetchInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **numbersToInvestigate** | [**NumbersToInvestigate**](NumbersToInvestigate.md) | Numbers for lookup |  |

### Return type

[**SyncNumberLookupSuccess**](SyncNumberLookupSuccess.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Info about phone numbers returned |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthorized |  -  |
| **402** | Failed crediting |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

