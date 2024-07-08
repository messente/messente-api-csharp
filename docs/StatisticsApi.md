# com.Messente.Api.Api.StatisticsApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateStatisticsReport**](StatisticsApi.md#createstatisticsreport) | **POST** /statistics/reports | Requests statistics reports for each country |

<a id="createstatisticsreport"></a>
# **CreateStatisticsReport**
> StatisticsReportSuccess CreateStatisticsReport (StatisticsReportSettings statisticsReportSettings)

Requests statistics reports for each country

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class CreateStatisticsReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new StatisticsApi(config);
            var statisticsReportSettings = new StatisticsReportSettings(); // StatisticsReportSettings | Settings for statistics report

            try
            {
                // Requests statistics reports for each country
                StatisticsReportSuccess result = apiInstance.CreateStatisticsReport(statisticsReportSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.CreateStatisticsReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateStatisticsReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests statistics reports for each country
    ApiResponse<StatisticsReportSuccess> response = apiInstance.CreateStatisticsReportWithHttpInfo(statisticsReportSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.CreateStatisticsReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **statisticsReportSettings** | [**StatisticsReportSettings**](StatisticsReportSettings.md) | Settings for statistics report |  |

### Return type

[**StatisticsReportSuccess**](StatisticsReportSuccess.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created reports by countries |  -  |
| **400** | Client Error |  -  |
| **401** | Unauthorized |  -  |
| **422** | Invalid data |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

