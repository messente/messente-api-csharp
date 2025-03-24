# com.Messente.Api.Api.BlacklistApi

All URIs are relative to *https://api.messente.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddToBlacklist**](BlacklistApi.md#addtoblacklist) | **POST** /phonebook/blacklist | Adds a phone number to the blacklist
[**DeleteFromBlacklist**](BlacklistApi.md#deletefromblacklist) | **DELETE** /phonebook/blacklist/{phone} | Deletes a phone number from the blacklist
[**FetchBlacklist**](BlacklistApi.md#fetchblacklist) | **GET** /phonebook/blacklist | Returns all blacklisted phone numbers
[**IsBlacklisted**](BlacklistApi.md#isblacklisted) | **GET** /phonebook/blacklist/{phone} | Checks if a phone number is blacklisted


<a name="addtoblacklist"></a>
# **AddToBlacklist**
> void AddToBlacklist (NumberToBlacklist numberToBlacklist)

Adds a phone number to the blacklist

### Example
```csharp
using System;
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
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BlacklistApi();
            var numberToBlacklist = new NumberToBlacklist(); // NumberToBlacklist | Phone number to be blacklisted

            try
            {
                // Adds a phone number to the blacklist
                apiInstance.AddToBlacklist(numberToBlacklist);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlacklistApi.AddToBlacklist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberToBlacklist** | [**NumberToBlacklist**](NumberToBlacklist.md)| Phone number to be blacklisted | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefromblacklist"></a>
# **DeleteFromBlacklist**
> void DeleteFromBlacklist (string phone)

Deletes a phone number from the blacklist

### Example
```csharp
using System;
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
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BlacklistApi();
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Deletes a phone number from the blacklist
                apiInstance.DeleteFromBlacklist(phone);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlacklistApi.DeleteFromBlacklist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phone** | **string**| A phone number | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fetchblacklist"></a>
# **FetchBlacklist**
> FetchBlacklistSuccess FetchBlacklist ()

Returns all blacklisted phone numbers

### Example
```csharp
using System;
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
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BlacklistApi();

            try
            {
                // Returns all blacklisted phone numbers
                FetchBlacklistSuccess result = apiInstance.FetchBlacklist();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlacklistApi.FetchBlacklist: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="isblacklisted"></a>
# **IsBlacklisted**
> void IsBlacklisted (string phone)

Checks if a phone number is blacklisted

### Example
```csharp
using System;
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
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new BlacklistApi();
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Checks if a phone number is blacklisted
                apiInstance.IsBlacklisted(phone);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlacklistApi.IsBlacklisted: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phone** | **string**| A phone number | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

