# com.Messente.Api.Api.NumberLookupApi

All URIs are relative to *https://api.messente.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FetchInfo**](NumberLookupApi.md#fetchinfo) | **POST** /hlr/sync | Requests info about phone numbers


<a name="fetchinfo"></a>
# **FetchInfo**
> SyncNumberLookupSuccess FetchInfo (NumbersToInvestigate numbersToInvestigate)

Requests info about phone numbers

### Example
```csharp
using System;
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
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new NumberLookupApi();
            var numbersToInvestigate = new NumbersToInvestigate(); // NumbersToInvestigate | Numbers for lookup

            try
            {
                // Requests info about phone numbers
                SyncNumberLookupSuccess result = apiInstance.FetchInfo(numbersToInvestigate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberLookupApi.FetchInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numbersToInvestigate** | [**NumbersToInvestigate**](NumbersToInvestigate.md)| Numbers for lookup | 

### Return type

[**SyncNumberLookupSuccess**](SyncNumberLookupSuccess.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

