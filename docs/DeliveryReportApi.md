# com.Messente.Api.Api.DeliveryReportApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RetrieveDeliveryReport**](DeliveryReportApi.md#retrievedeliveryreport) | **GET** /omnimessage/{omnimessageId}/status | Retrieves the delivery report for the Omnimessage |

<a id="retrievedeliveryreport"></a>
# **RetrieveDeliveryReport**
> DeliveryReportResponse RetrieveDeliveryReport (Guid omnimessageId)

Retrieves the delivery report for the Omnimessage

### Example
```csharp
using System.Collections.Generic;
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
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DeliveryReportApi(config);
            var omnimessageId = "omnimessageId_example";  // Guid | UUID of the omnimessage to for which the delivery report is to be retrieved

            try
            {
                // Retrieves the delivery report for the Omnimessage
                DeliveryReportResponse result = apiInstance.RetrieveDeliveryReport(omnimessageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryReportApi.RetrieveDeliveryReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveDeliveryReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the delivery report for the Omnimessage
    ApiResponse<DeliveryReportResponse> response = apiInstance.RetrieveDeliveryReportWithHttpInfo(omnimessageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryReportApi.RetrieveDeliveryReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **omnimessageId** | **Guid** | UUID of the omnimessage to for which the delivery report is to be retrieved |  |

### Return type

[**DeliveryReportResponse**](DeliveryReportResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delivery report success |  -  |
| **401** | Unauthorized |  -  |
| **404** | If no such message exists or you do not have access to the particular message |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

