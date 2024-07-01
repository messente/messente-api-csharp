# com.Messente.Api.Api.BlacklistApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddToBlacklist**](BlacklistApi.md#addtoblacklist) | **POST** /phonebook/blacklist | Adds a phone number to the blacklist |
| [**DeleteFromBlacklist**](BlacklistApi.md#deletefromblacklist) | **DELETE** /phonebook/blacklist/{phone} | Deletes a phone number from the blacklist |
| [**FetchBlacklist**](BlacklistApi.md#fetchblacklist) | **GET** /phonebook/blacklist | Returns all blacklisted phone numbers |
| [**IsBlacklisted**](BlacklistApi.md#isblacklisted) | **GET** /phonebook/blacklist/{phone} | Checks if a phone number is blacklisted |

<a id="addtoblacklist"></a>
# **AddToBlacklist**
> void AddToBlacklist (NumberToBlacklist numberToBlacklist)

Adds a phone number to the blacklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class AddToBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BlacklistApi(config);
            var numberToBlacklist = new NumberToBlacklist(); // NumberToBlacklist | Phone number to be blacklisted

            try
            {
                // Adds a phone number to the blacklist
                apiInstance.AddToBlacklist(numberToBlacklist);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlacklistApi.AddToBlacklist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddToBlacklistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a phone number to the blacklist
    apiInstance.AddToBlacklistWithHttpInfo(numberToBlacklist);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlacklistApi.AddToBlacklistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **numberToBlacklist** | [**NumberToBlacklist**](NumberToBlacklist.md) | Phone number to be blacklisted |  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Phone number added to the blacklist |  -  |
| **400** | Invalid phone number provided |  -  |
| **401** | Unauthorized |  -  |
| **409** | Phone number already blacklisted |  -  |
| **0** | General error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefromblacklist"></a>
# **DeleteFromBlacklist**
> void DeleteFromBlacklist (string phone)

Deletes a phone number from the blacklist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class DeleteFromBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BlacklistApi(config);
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Deletes a phone number from the blacklist
                apiInstance.DeleteFromBlacklist(phone);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlacklistApi.DeleteFromBlacklist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFromBlacklistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a phone number from the blacklist
    apiInstance.DeleteFromBlacklistWithHttpInfo(phone);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlacklistApi.DeleteFromBlacklistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phone** | **string** | A phone number |  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Phone number deleted from the blacklist |  -  |
| **400** | Invalid phone number provided |  -  |
| **401** | Unauthorized |  -  |
| **404** | Phone number is not in the blacklist |  -  |
| **0** | General error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchblacklist"></a>
# **FetchBlacklist**
> FetchBlacklistSuccess FetchBlacklist ()

Returns all blacklisted phone numbers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchBlacklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BlacklistApi(config);

            try
            {
                // Returns all blacklisted phone numbers
                FetchBlacklistSuccess result = apiInstance.FetchBlacklist();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlacklistApi.FetchBlacklist: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchBlacklistWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all blacklisted phone numbers
    ApiResponse<FetchBlacklistSuccess> response = apiInstance.FetchBlacklistWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlacklistApi.FetchBlacklistWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**FetchBlacklistSuccess**](FetchBlacklistSuccess.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object containing a list of blacklisted phone numbers |  -  |
| **401** | Unauthorized |  -  |
| **0** | General error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="isblacklisted"></a>
# **IsBlacklisted**
> void IsBlacklisted (string phone)

Checks if a phone number is blacklisted

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class IsBlacklistedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BlacklistApi(config);
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Checks if a phone number is blacklisted
                apiInstance.IsBlacklisted(phone);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlacklistApi.IsBlacklisted: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsBlacklistedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks if a phone number is blacklisted
    apiInstance.IsBlacklistedWithHttpInfo(phone);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlacklistApi.IsBlacklistedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phone** | **string** | A phone number |  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Phone number is in the blacklist |  -  |
| **400** | Invalid phone number provided |  -  |
| **401** | Unauthorized |  -  |
| **404** | Phone number is not in the blacklist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

