# com.Messente.Api.Api.DeliveryReportApi

All URIs are relative to *https://api.messente.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RetrieveDeliveryReport**](DeliveryReportApi.md#retrievedeliveryreport) | **GET** /omnimessage/{omnimessageId}/status | Retrieves the delivery report for the Omnimessage


<a name="retrievedeliveryreport"></a>
# **RetrieveDeliveryReport**
> DeliveryReportResponse RetrieveDeliveryReport (string omnimessageId)

Retrieves the delivery report for the Omnimessage

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class RetrieveDeliveryReportExample
    {
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeliveryReportApi();
            var omnimessageId = omnimessageId_example;  // string | UUID of the omnimessage to for which the delivery report is to be retrieved

            try
            {
                // Retrieves the delivery report for the Omnimessage
                DeliveryReportResponse result = apiInstance.RetrieveDeliveryReport(omnimessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryReportApi.RetrieveDeliveryReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **omnimessageId** | **string**| UUID of the omnimessage to for which the delivery report is to be retrieved | 

### Return type

[**DeliveryReportResponse**](DeliveryReportResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

