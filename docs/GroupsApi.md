# com.Messente.Api.Api.GroupsApi

All URIs are relative to *https://api.messente.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroup**](GroupsApi.md#creategroup) | **POST** /groups | Creates a new group with the provided name
[**DeleteGroup**](GroupsApi.md#deletegroup) | **DELETE** /groups/{groupId} | Deletes a group
[**FetchGroup**](GroupsApi.md#fetchgroup) | **GET** /groups/{groupId} | Lists a group
[**FetchGroups**](GroupsApi.md#fetchgroups) | **GET** /groups | Returns all groups
[**UpdateGroup**](GroupsApi.md#updategroup) | **PUT** /groups/{groupId} | Updates a group with the provided name


<a name="creategroup"></a>
# **CreateGroup**
> GroupEnvelope CreateGroup (GroupName groupName)

Creates a new group with the provided name

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var groupName = new GroupName(); // GroupName | 

            try
            {
                // Creates a new group with the provided name
                GroupEnvelope result = apiInstance.CreateGroup(groupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | [**GroupName**](GroupName.md)|  | 

### Return type

[**GroupEnvelope**](GroupEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (string groupId)

Deletes a group

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | String in uuid format.

            try
            {
                // Deletes a group
                apiInstance.DeleteGroup(groupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| String in uuid format. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fetchgroup"></a>
# **FetchGroup**
> GroupEnvelope FetchGroup (string groupId)

Lists a group

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchGroupExample
    {
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | String in uuid format.

            try
            {
                // Lists a group
                GroupEnvelope result = apiInstance.FetchGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.FetchGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| String in uuid format. | 

### Return type

[**GroupEnvelope**](GroupEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fetchgroups"></a>
# **FetchGroups**
> GroupListEnvelope FetchGroups ()

Returns all groups

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class FetchGroupsExample
    {
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();

            try
            {
                // Returns all groups
                GroupListEnvelope result = apiInstance.FetchGroups();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.FetchGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GroupListEnvelope**](GroupListEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> GroupEnvelope UpdateGroup (string groupId, GroupName groupName)

Updates a group with the provided name

### Example
```csharp
using System;
using System.Diagnostics;
using com.Messente.Api.Api;
using com.Messente.Api.Client;
using com.Messente.Api.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public static void Main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new GroupsApi();
            var groupId = groupId_example;  // string | String in uuid format.
            var groupName = new GroupName(); // GroupName | 

            try
            {
                // Updates a group with the provided name
                GroupEnvelope result = apiInstance.UpdateGroup(groupId, groupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| String in uuid format. | 
 **groupName** | [**GroupName**](GroupName.md)|  | 

### Return type

[**GroupEnvelope**](GroupEnvelope.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

