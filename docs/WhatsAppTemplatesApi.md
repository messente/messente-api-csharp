# com.Messente.Api.Api.WhatsAppTemplatesApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWhatsappTemplate**](WhatsAppTemplatesApi.md#createwhatsapptemplate) | **POST** /whatsapp/wabas/{wabaId}/templates | Creates a WhatsApp template |
| [**DeleteWhatsappTemplate**](WhatsAppTemplatesApi.md#deletewhatsapptemplate) | **DELETE** /whatsapp/wabas/{wabaId}/templates | Deletes a WhatsApp template |
| [**GetWhatsappTemplateById**](WhatsAppTemplatesApi.md#getwhatsapptemplatebyid) | **GET** /whatsapp/wabas/{wabaId}/templates/{templateId} | Requests a WhatsApp template with the given ID |
| [**ListWhatsappTemplates**](WhatsAppTemplatesApi.md#listwhatsapptemplates) | **GET** /whatsapp/wabas/{wabaId}/templates | Requests a list of WhatsApp templates |
| [**UpdateWhatsappTemplate**](WhatsAppTemplatesApi.md#updatewhatsapptemplate) | **PUT** /whatsapp/wabas/{wabaId}/templates/{templateId} | Updates a WhatsApp template |

<a id="createwhatsapptemplate"></a>
# **CreateWhatsappTemplate**
> WhatsappCreateTemplateResponse CreateWhatsappTemplate (string wabaId, WhatsappCreateTemplateRequest whatsappCreateTemplateRequest)

Creates a WhatsApp template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class CreateWhatsappTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WhatsAppTemplatesApi(config);
            var wabaId = "wabaId_example";  // string | The ID of the WABA
            var whatsappCreateTemplateRequest = new WhatsappCreateTemplateRequest(); // WhatsappCreateTemplateRequest | The WhatsApp template to create

            try
            {
                // Creates a WhatsApp template
                WhatsappCreateTemplateResponse result = apiInstance.CreateWhatsappTemplate(wabaId, whatsappCreateTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhatsAppTemplatesApi.CreateWhatsappTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWhatsappTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a WhatsApp template
    ApiResponse<WhatsappCreateTemplateResponse> response = apiInstance.CreateWhatsappTemplateWithHttpInfo(wabaId, whatsappCreateTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhatsAppTemplatesApi.CreateWhatsappTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wabaId** | **string** | The ID of the WABA |  |
| **whatsappCreateTemplateRequest** | [**WhatsappCreateTemplateRequest**](WhatsappCreateTemplateRequest.md) | The WhatsApp template to create |  |

### Return type

[**WhatsappCreateTemplateResponse**](WhatsappCreateTemplateResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template creation successful |  -  |
| **400** | Invalid input |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewhatsapptemplate"></a>
# **DeleteWhatsappTemplate**
> Object DeleteWhatsappTemplate (string wabaId, string name, string? hsmId = null)

Deletes a WhatsApp template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class DeleteWhatsappTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WhatsAppTemplatesApi(config);
            var wabaId = "wabaId_example";  // string | The ID of the WABA
            var name = template_name;  // string | The name of the template to delete
            var hsmId = 1;  // string? | The ID of the template to delete (optional) 

            try
            {
                // Deletes a WhatsApp template
                Object result = apiInstance.DeleteWhatsappTemplate(wabaId, name, hsmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhatsAppTemplatesApi.DeleteWhatsappTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWhatsappTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a WhatsApp template
    ApiResponse<Object> response = apiInstance.DeleteWhatsappTemplateWithHttpInfo(wabaId, name, hsmId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhatsAppTemplatesApi.DeleteWhatsappTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wabaId** | **string** | The ID of the WABA |  |
| **name** | **string** | The name of the template to delete |  |
| **hsmId** | **string?** | The ID of the template to delete | [optional]  |

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template deletion successful |  -  |
| **400** | Invalid input |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwhatsapptemplatebyid"></a>
# **GetWhatsappTemplateById**
> WhatsappTemplateResponse GetWhatsappTemplateById (string wabaId, string templateId)

Requests a WhatsApp template with the given ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class GetWhatsappTemplateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WhatsAppTemplatesApi(config);
            var wabaId = "wabaId_example";  // string | The ID of the WABA
            var templateId = "templateId_example";  // string | The ID of the template to retrieve

            try
            {
                // Requests a WhatsApp template with the given ID
                WhatsappTemplateResponse result = apiInstance.GetWhatsappTemplateById(wabaId, templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhatsAppTemplatesApi.GetWhatsappTemplateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWhatsappTemplateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests a WhatsApp template with the given ID
    ApiResponse<WhatsappTemplateResponse> response = apiInstance.GetWhatsappTemplateByIdWithHttpInfo(wabaId, templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhatsAppTemplatesApi.GetWhatsappTemplateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wabaId** | **string** | The ID of the WABA |  |
| **templateId** | **string** | The ID of the template to retrieve |  |

### Return type

[**WhatsappTemplateResponse**](WhatsappTemplateResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template fetched successfully |  -  |
| **400** | Invalid input |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listwhatsapptemplates"></a>
# **ListWhatsappTemplates**
> WhatsappListTemplatesResponse ListWhatsappTemplates (string wabaId, int? limit = null, string? before = null, string? after = null, WhatsappTemplateCategory? category = null, string? content = null, string? language = null, string? name = null, WhatsappTemplateStatus? status = null)

Requests a list of WhatsApp templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class ListWhatsappTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WhatsAppTemplatesApi(config);
            var wabaId = "wabaId_example";  // string | The ID of the WABA
            var limit = 10;  // int? | The number of templates to return in the list. Although the max size is 500, for large datasets it is recommended to use a lower limit and instead use pagination to avoid potential timeouts. Defaults to 25. (optional)  (default to 25)
            var before = MAZDZD;  // string? | A cursor point used for a paginated request to indicate the template to paginate backwards from. (optional) 
            var after = MjQZD;  // string? | A cursor point used for a paginated request to indicate the template to paginate forwards from. (optional) 
            var category = new WhatsappTemplateCategory?(); // WhatsappTemplateCategory? | A filter for returning only templates matching a specific category. (optional) 
            var content = special offer;  // string? | A search filter representing the content of a template. Only matching templates will be returned in the list. (optional) 
            var language = en;  // string? | A filter  for returning only templates matching a specific language code. A list of supported languages is available in the [WhatsApp documentation](https://developers.facebook.com/docs/whatsapp/api/messages/message-templates/)  (optional) 
            var name = Sample Template;  // string? | A search filter representing the name, either full or partial, of a template. Only matching templates will be returned in the list. (optional) 
            var status = new WhatsappTemplateStatus?(); // WhatsappTemplateStatus? | A filter for returning only templates matching a specific status. (optional) 

            try
            {
                // Requests a list of WhatsApp templates
                WhatsappListTemplatesResponse result = apiInstance.ListWhatsappTemplates(wabaId, limit, before, after, category, content, language, name, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhatsAppTemplatesApi.ListWhatsappTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWhatsappTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests a list of WhatsApp templates
    ApiResponse<WhatsappListTemplatesResponse> response = apiInstance.ListWhatsappTemplatesWithHttpInfo(wabaId, limit, before, after, category, content, language, name, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhatsAppTemplatesApi.ListWhatsappTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wabaId** | **string** | The ID of the WABA |  |
| **limit** | **int?** | The number of templates to return in the list. Although the max size is 500, for large datasets it is recommended to use a lower limit and instead use pagination to avoid potential timeouts. Defaults to 25. | [optional] [default to 25] |
| **before** | **string?** | A cursor point used for a paginated request to indicate the template to paginate backwards from. | [optional]  |
| **after** | **string?** | A cursor point used for a paginated request to indicate the template to paginate forwards from. | [optional]  |
| **category** | [**WhatsappTemplateCategory?**](WhatsappTemplateCategory?.md) | A filter for returning only templates matching a specific category. | [optional]  |
| **content** | **string?** | A search filter representing the content of a template. Only matching templates will be returned in the list. | [optional]  |
| **language** | **string?** | A filter  for returning only templates matching a specific language code. A list of supported languages is available in the [WhatsApp documentation](https://developers.facebook.com/docs/whatsapp/api/messages/message-templates/)  | [optional]  |
| **name** | **string?** | A search filter representing the name, either full or partial, of a template. Only matching templates will be returned in the list. | [optional]  |
| **status** | [**WhatsappTemplateStatus?**](WhatsappTemplateStatus?.md) | A filter for returning only templates matching a specific status. | [optional]  |

### Return type

[**WhatsappListTemplatesResponse**](WhatsappListTemplatesResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template list fetched successfully |  -  |
| **400** | Invalid input |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewhatsapptemplate"></a>
# **UpdateWhatsappTemplate**
> Object UpdateWhatsappTemplate (string wabaId, string templateId, WhatsappUpdateTemplateRequest whatsappUpdateTemplateRequest)

Updates a WhatsApp template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class UpdateWhatsappTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WhatsAppTemplatesApi(config);
            var wabaId = "wabaId_example";  // string | The ID of the WABA
            var templateId = "templateId_example";  // string | The ID of the template to update
            var whatsappUpdateTemplateRequest = new WhatsappUpdateTemplateRequest(); // WhatsappUpdateTemplateRequest | The template data to be updated

            try
            {
                // Updates a WhatsApp template
                Object result = apiInstance.UpdateWhatsappTemplate(wabaId, templateId, whatsappUpdateTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhatsAppTemplatesApi.UpdateWhatsappTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWhatsappTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a WhatsApp template
    ApiResponse<Object> response = apiInstance.UpdateWhatsappTemplateWithHttpInfo(wabaId, templateId, whatsappUpdateTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhatsAppTemplatesApi.UpdateWhatsappTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wabaId** | **string** | The ID of the WABA |  |
| **templateId** | **string** | The ID of the template to update |  |
| **whatsappUpdateTemplateRequest** | [**WhatsappUpdateTemplateRequest**](WhatsappUpdateTemplateRequest.md) | The template data to be updated |  |

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | template update successful |  -  |
| **400** | Invalid input |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

