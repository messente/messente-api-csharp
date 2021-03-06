# com.Messente.Api.Api.ContactsApi

All URIs are relative to *https://api.messente.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddContactToGroup**](ContactsApi.md#addcontacttogroup) | **POST** /phonebook/groups/{groupId}/contacts/{phone} | Adds a contact to a group
[**CreateContact**](ContactsApi.md#createcontact) | **POST** /phonebook/contacts | Creates a new contact
[**DeleteContact**](ContactsApi.md#deletecontact) | **DELETE** /phonebook/contacts/{phone} | Deletes a contact
[**FetchContact**](ContactsApi.md#fetchcontact) | **GET** /phonebook/contacts/{phone} | Lists a contact
[**FetchContactGroups**](ContactsApi.md#fetchcontactgroups) | **GET** /phonebook/contacts/{phone}/groups | Lists groups of a contact
[**FetchContacts**](ContactsApi.md#fetchcontacts) | **GET** /phonebook/contacts | Returns all contacts
[**RemoveContactFromGroup**](ContactsApi.md#removecontactfromgroup) | **DELETE** /phonebook/groups/{groupId}/contacts/{phone} | Removes a contact from a group
[**UpdateContact**](ContactsApi.md#updatecontact) | **PATCH** /phonebook/contacts/{phone} | Updates a contact


<a name="addcontacttogroup"></a>
# **AddContactToGroup**
> EmptyObject AddContactToGroup (string groupId, string phone)

Adds a contact to a group

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
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var groupId = 5792a02a-e5c2-422b-a0a0-0ae65d814663;  // string | String in UUID format
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Adds a contact to a group
                EmptyObject result = apiInstance.AddContactToGroup(groupId, phone);
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
 **groupId** | **string**| String in UUID format | 
 **phone** | **string**| A phone number | 

### Return type

[**EmptyObject**](EmptyObject.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcontact"></a>
# **CreateContact**
> ContactEnvelope CreateContact (ContactFields contactFields)

Creates a new contact

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
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var contactFields = new ContactFields(); // ContactFields | 

            try
            {
                // Creates a new contact
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

Deletes a contact

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
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Deletes a contact
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

Lists a contact

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
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Lists a contact
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

Lists groups of a contact

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
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Lists groups of a contact
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

Returns all contacts

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
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var groupIds = new List<string>(); // List<string> | Optional one or many group id strings in UUID format. For example: \"/contacts?groupIds=group_id_one&groupIds=group_id_two\"  (optional) 

            try
            {
                // Returns all contacts
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
 **groupIds** | [**List&lt;string&gt;**](string.md)| Optional one or many group id strings in UUID format. For example: \&quot;/contacts?groupIds&#x3D;group_id_one&amp;groupIds&#x3D;group_id_two\&quot;  | [optional] 

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

Removes a contact from a group

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
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var groupId = 5792a02a-e5c2-422b-a0a0-0ae65d814663;  // string | String in UUID format
            var phone = +37251000000;  // string | A phone number

            try
            {
                // Removes a contact from a group
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
 **groupId** | **string**| String in UUID format | 
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

Updates a contact

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
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ContactsApi();
            var phone = +37251000000;  // string | A phone number
            var contactUpdateFields = new ContactUpdateFields(); // ContactUpdateFields | 

            try
            {
                // Updates a contact
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

