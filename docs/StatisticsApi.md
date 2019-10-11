# com.Messente.Api.Api.StatisticsApi

All URIs are relative to *https://api.messente.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStatisticsReport**](StatisticsApi.md#createstatisticsreport) | **POST** /statistics/reports | Requests statistics reports for each country


<a name="createstatisticsreport"></a>
# **CreateStatisticsReport**
> StatisticsReportSuccess CreateStatisticsReport (StatisticsReportSettings statisticsReportSettings)

Requests statistics reports for each country

### Example
```csharp
using System;
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
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new StatisticsApi();
            var statisticsReportSettings = new StatisticsReportSettings(); // StatisticsReportSettings | Settings for statistics report

            try
            {
                // Requests statistics reports for each country
                StatisticsReportSuccess result = apiInstance.CreateStatisticsReport(statisticsReportSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatisticsApi.CreateStatisticsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **statisticsReportSettings** | [**StatisticsReportSettings**](StatisticsReportSettings.md)| Settings for statistics report | 

### Return type

[**StatisticsReportSuccess**](StatisticsReportSuccess.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

