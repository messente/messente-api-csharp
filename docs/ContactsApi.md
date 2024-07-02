# com.Messente.Api.Api.ContactsApi

All URIs are relative to *https://api.messente.com/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddContactToGroup**](ContactsApi.md#addcontacttogroup) | **POST** /phonebook/groups/{groupId}/contacts/{phone} | Adds a contact to a group |
| [**CreateContact**](ContactsApi.md#createcontact) | **POST** /phonebook/contacts | Creates a new contact |
| [**DeleteContact**](ContactsApi.md#deletecontact) | **DELETE** /phonebook/contacts/{phone} | Deletes a contact |
| [**FetchContact**](ContactsApi.md#fetchcontact) | **GET** /phonebook/contacts/{phone} | Lists a contact |
| [**FetchContactGroups**](ContactsApi.md#fetchcontactgroups) | **GET** /phonebook/contacts/{phone}/groups | Lists groups of a contact |
| [**FetchContacts**](ContactsApi.md#fetchcontacts) | **GET** /phonebook/contacts | Returns all contacts |
| [**RemoveContactFromGroup**](ContactsApi.md#removecontactfromgroup) | **DELETE** /phonebook/groups/{groupId}/contacts/{phone} | Removes a contact from a group |
| [**UpdateContact**](ContactsApi.md#updatecontact) | **PATCH** /phonebook/contacts/{phone} | Updates a contact |

<a id="addcontacttogroup"></a>
# **AddContactToGroup**
> Object AddContactToGroup (string groupId, string phone)

Adds a contact to a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class AddContactToGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi(config);
            var groupId = 5792a02a-e5c2-422b-a0a0-0ae65d814663;  // string | String in UUID format
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Adds a contact to a group
                Object result = apiInstance.AddContactToGroup(groupId, phone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.AddContactToGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddContactToGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds a contact to a group
    ApiResponse<Object> response = apiInstance.AddContactToGroupWithHttpInfo(groupId, phone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.AddContactToGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | String in UUID format |  |
| **phone** | **string** | A phone number |  |

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
| **201** | An empty object |  -  |
| **400** | Invalid phone number provided |  -  |
| **401** | Unauthorized |  -  |
| **404** | Contact or group is missing |  -  |
| **409** | Contact already added to group |  -  |
| **0** | General error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontact"></a>
# **CreateContact**
> ContactEnvelope CreateContact (ContactFields contactFields)

Creates a new contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class CreateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi(config);
            var contactFields = new ContactFields(); // ContactFields | 

            try
            {
                // Creates a new contact
                ContactEnvelope result = apiInstance.CreateContact(contactFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new contact
    ApiResponse<ContactEnvelope> response = apiInstance.CreateContactWithHttpInfo(contactFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.CreateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactFields** | [**ContactFields**](ContactFields.md) |  |  |

### Return type

[**ContactEnvelope**](ContactEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | An object containing a contact object |  -  |
| **400** | Invalid phone number provided |  -  |
| **401** | Unauthorized |  -  |
| **409** | Contact with phone already created |  -  |
| **0** | General error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontact"></a>
# **DeleteContact**
> void DeleteContact (string phone)

Deletes a contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class DeleteContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi(config);
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Deletes a contact
                apiInstance.DeleteContact(phone);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a contact
    apiInstance.DeleteContactWithHttpInfo(phone);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.DeleteContactWithHttpInfo: " + e.Message);
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
| **204** | Contact deleted |  -  |
| **400** | Invalid phone number provided |  -  |
| **401** | Unauthorized |  -  |
| **404** | Contact missing |  -  |
| **0** | General error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchcontact"></a>
# **FetchContact**
> ContactEnvelope FetchContact (string phone)

Lists a contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi(config);
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Lists a contact
                ContactEnvelope result = apiInstance.FetchContact(phone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.FetchContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists a contact
    ApiResponse<ContactEnvelope> response = apiInstance.FetchContactWithHttpInfo(phone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.FetchContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phone** | **string** | A phone number |  |

### Return type

[**ContactEnvelope**](ContactEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object containing a contact object |  -  |
| **400** | Invalid phone number provided |  -  |
| **401** | Unauthorized |  -  |
| **404** | Contact missing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchcontactgroups"></a>
# **FetchContactGroups**
> GroupListEnvelope FetchContactGroups (string phone)

Lists groups of a contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchContactGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi(config);
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Lists groups of a contact
                GroupListEnvelope result = apiInstance.FetchContactGroups(phone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.FetchContactGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchContactGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists groups of a contact
    ApiResponse<GroupListEnvelope> response = apiInstance.FetchContactGroupsWithHttpInfo(phone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.FetchContactGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phone** | **string** | A phone number |  |

### Return type

[**GroupListEnvelope**](GroupListEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object containing a list of group objects |  -  |
| **400** | Invalid phone number provided |  -  |
| **401** | Unauthorized |  -  |
| **404** | Contact missing |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchcontacts"></a>
# **FetchContacts**
> ContactListEnvelope FetchContacts (List<string>? groupIds = null)

Returns all contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi(config);
            var groupIds = new List<string>?(); // List<string>? | Optional one or many group id strings in UUID format. For example: \"/contacts?groupIds=group_id_one&groupIds=group_id_two\"  (optional) 

            try
            {
                // Returns all contacts
                ContactListEnvelope result = apiInstance.FetchContacts(groupIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.FetchContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all contacts
    ApiResponse<ContactListEnvelope> response = apiInstance.FetchContactsWithHttpInfo(groupIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.FetchContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupIds** | [**List&lt;string&gt;?**](string.md) | Optional one or many group id strings in UUID format. For example: \&quot;/contacts?groupIds&#x3D;group_id_one&amp;groupIds&#x3D;group_id_two\&quot;  | [optional]  |

### Return type

[**ContactListEnvelope**](ContactListEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object containing a list of contact objects |  -  |
| **400** | Invalid \&quot;groupIds\&quot; parameters provided |  -  |
| **401** | Unauthorized |  -  |
| **0** | General error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removecontactfromgroup"></a>
# **RemoveContactFromGroup**
> void RemoveContactFromGroup (string groupId, string phone)

Removes a contact from a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class RemoveContactFromGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi(config);
            var groupId = 5792a02a-e5c2-422b-a0a0-0ae65d814663;  // string | String in UUID format
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Removes a contact from a group
                apiInstance.RemoveContactFromGroup(groupId, phone);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.RemoveContactFromGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveContactFromGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a contact from a group
    apiInstance.RemoveContactFromGroupWithHttpInfo(groupId, phone);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.RemoveContactFromGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **string** | String in UUID format |  |
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
| **204** | Contact removed from group |  -  |
| **400** | Invalid phone number provided |  -  |
| **401** | Unauthorized |  -  |
| **404** | Contact or group is missing or contact is missing from group |  -  |
| **0** | General error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecontact"></a>
# **UpdateContact**
> ContactEnvelope UpdateContact (string phone, ContactUpdateFields contactUpdateFields)

Updates a contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.messente.com/v1";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi(config);
            var phone = +37251000000;  // string | A phone number
            var contactUpdateFields = new ContactUpdateFields(); // ContactUpdateFields | 

            try
            {
                // Updates a contact
                ContactEnvelope result = apiInstance.UpdateContact(phone, contactUpdateFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a contact
    ApiResponse<ContactEnvelope> response = apiInstance.UpdateContactWithHttpInfo(phone, contactUpdateFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.UpdateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phone** | **string** | A phone number |  |
| **contactUpdateFields** | [**ContactUpdateFields**](ContactUpdateFields.md) |  |  |

### Return type

[**ContactEnvelope**](ContactEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An object containing a contact object |  -  |
| **400** | Invalid phone number or empty patch body or unknown fields provided |  -  |
| **401** | Unauthorized |  -  |
| **404** | Contact missing |  -  |
| **0** | General error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

