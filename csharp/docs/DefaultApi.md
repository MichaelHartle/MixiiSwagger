# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://api.mixiimobile.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PhoneregistrationOptions**](DefaultApi.md#phoneregistrationoptions) | **OPTIONS** /phoneregistration | 
[**PhoneregistrationPut**](DefaultApi.md#phoneregistrationput) | **PUT** /phoneregistration | 


<a name="phoneregistrationoptions"></a>
# **PhoneregistrationOptions**
> SimpleResult PhoneregistrationOptions ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PhoneregistrationOptionsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                SimpleResult result = apiInstance.PhoneregistrationOptions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PhoneregistrationOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SimpleResult**](SimpleResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="phoneregistrationput"></a>
# **PhoneregistrationPut**
> MixiiPhoneUserRequest PhoneregistrationPut (string emailAddress, string passwordHash, string authorization, string firstName, string lastName, string phoneNumber, string countryCode, string verificationUuid)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PhoneregistrationPutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var emailAddress = emailAddress_example;  // string | 
            var passwordHash = passwordHash_example;  // string | 
            var authorization = authorization_example;  // string | 
            var firstName = firstName_example;  // string | 
            var lastName = lastName_example;  // string | 
            var phoneNumber = phoneNumber_example;  // string | 
            var countryCode = countryCode_example;  // string | 
            var verificationUuid = verificationUuid_example;  // string | 

            try
            {
                MixiiPhoneUserRequest result = apiInstance.PhoneregistrationPut(emailAddress, passwordHash, authorization, firstName, lastName, phoneNumber, countryCode, verificationUuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PhoneregistrationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddress** | **string**|  | 
 **passwordHash** | **string**|  | 
 **authorization** | **string**|  | 
 **firstName** | **string**|  | 
 **lastName** | **string**|  | 
 **phoneNumber** | **string**|  | 
 **countryCode** | **string**|  | 
 **verificationUuid** | **string**|  | 

### Return type

[**MixiiPhoneUserRequest**](MixiiPhoneUserRequest.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

