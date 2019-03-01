# com.Messente.Api.Api.ContactsApi

All URIs are relative to *https://api.messente.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddContactToGroup**](ContactsApi.md#addcontacttogroup) | **POST** /groups/{groupId}/contacts/{phone} | Adds a contact to a group.
[**CreateContact**](ContactsApi.md#createcontact) | **POST** /contacts | Creates a new contact.
[**DeleteContact**](ContactsApi.md#deletecontact) | **DELETE** /contacts/{phone} | Deletes a contact.
[**FetchContact**](ContactsApi.md#fetchcontact) | **GET** /contacts/{phone} | Lists a contact.
[**FetchContactGroups**](ContactsApi.md#fetchcontactgroups) | **GET** /contacts/{phone}/groups | Lists groups of a contact.
[**FetchContacts**](ContactsApi.md#fetchcontacts) | **GET** /contacts | Returns all contacts.
[**RemoveContactFromGroup**](ContactsApi.md#removecontactfromgroup) | **DELETE** /groups/{groupId}/contacts/{phone} | Remove a contact from a group.
[**UpdateContact**](ContactsApi.md#updatecontact) | **PATCH** /contacts/{phone} | Updates a contact.


<a name="addcontacttogroup"></a>
# **AddContactToGroup**
> Object AddContactToGroup (string groupId, string phone)

Adds a contact to a group.

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class AddContactToGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var groupId = groupId_example;  // string | String in uuid format.
            var phone = phone_example;  // string | A phone number

            try
            {
                // Adds a contact to a group.
                Object result = apiInstance.AddContactToGroup(groupId, phone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.AddContactToGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| String in uuid format. | 
 **phone** | **string**| A phone number | 

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcontact"></a>
# **CreateContact**
> ContactEnvelope CreateContact (ContactFields contactFields)

Creates a new contact.

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class CreateContactExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var contactFields = new ContactFields(); // ContactFields | 

            try
            {
                // Creates a new contact.
                ContactEnvelope result = apiInstance.CreateContact(contactFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactFields** | [**ContactFields**](ContactFields.md)|  | 

### Return type

[**ContactEnvelope**](ContactEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontact"></a>
# **DeleteContact**
> void DeleteContact (string phone)

Deletes a contact.

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class DeleteContactExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var phone = phone_example;  // string | A phone number

            try
            {
                // Deletes a contact.
                apiInstance.DeleteContact(phone);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteContact: " + e.Message );
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

<a name="fetchcontact"></a>
# **FetchContact**
> ContactEnvelope FetchContact (string phone)

Lists a contact.

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchContactExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var phone = phone_example;  // string | A phone number

            try
            {
                // Lists a contact.
                ContactEnvelope result = apiInstance.FetchContact(phone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.FetchContact: " + e.Message );
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

[**ContactEnvelope**](ContactEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fetchcontactgroups"></a>
# **FetchContactGroups**
> GroupListEnvelope FetchContactGroups (string phone)

Lists groups of a contact.

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchContactGroupsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var phone = phone_example;  // string | A phone number

            try
            {
                // Lists groups of a contact.
                GroupListEnvelope result = apiInstance.FetchContactGroups(phone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.FetchContactGroups: " + e.Message );
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

[**GroupListEnvelope**](GroupListEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fetchcontacts"></a>
# **FetchContacts**
> ContactListEnvelope FetchContacts (List<string> groupIds = null)

Returns all contacts.

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchContactsExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var groupIds = new List<string>(); // List<string> | Group id string in uuid format. (optional) 

            try
            {
                // Returns all contacts.
                ContactListEnvelope result = apiInstance.FetchContacts(groupIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.FetchContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupIds** | [**List&lt;string&gt;**](string.md)| Group id string in uuid format. | [optional] 

### Return type

[**ContactListEnvelope**](ContactListEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removecontactfromgroup"></a>
# **RemoveContactFromGroup**
> void RemoveContactFromGroup (string groupId, string phone)

Remove a contact from a group.

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class RemoveContactFromGroupExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var groupId = groupId_example;  // string | String in uuid format.
            var phone = phone_example;  // string | A phone number

            try
            {
                // Remove a contact from a group.
                apiInstance.RemoveContactFromGroup(groupId, phone);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.RemoveContactFromGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| String in uuid format. | 
 **phone** | **string**| A phone number | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontact"></a>
# **UpdateContact**
> ContactEnvelope UpdateContact (string phone, ContactUpdateFields contactUpdateFields)

Updates a contact.

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var phone = phone_example;  // string | A phone number
            var contactUpdateFields = new ContactUpdateFields(); // ContactUpdateFields | 

            try
            {
                // Updates a contact.
                ContactEnvelope result = apiInstance.UpdateContact(phone, contactUpdateFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phone** | **string**| A phone number | 
 **contactUpdateFields** | [**ContactUpdateFields**](ContactUpdateFields.md)|  | 

### Return type

[**ContactEnvelope**](ContactEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

