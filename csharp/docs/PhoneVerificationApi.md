# IO.Swagger.Api.PhoneVerificationApi

All URIs are relative to *https://api.mixiimobile.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PhoneverificationOptions**](PhoneVerificationApi.md#phoneverificationoptions) | **OPTIONS** /phoneverification | 
[**PhoneverificationPost**](PhoneVerificationApi.md#phoneverificationpost) | **POST** /phoneverification | 
[**PhoneverificationPut**](PhoneVerificationApi.md#phoneverificationput) | **PUT** /phoneverification | 


<a name="phoneverificationoptions"></a>
# **PhoneverificationOptions**
> SimpleResult PhoneverificationOptions ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PhoneverificationOptionsExample
    {
        public void main()
        {
            var apiInstance = new PhoneVerificationApi();

            try
            {
                SimpleResult result = apiInstance.PhoneverificationOptions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneVerificationApi.PhoneverificationOptions: " + e.Message );
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

<a name="phoneverificationpost"></a>
# **PhoneverificationPost**
> SimpleResult PhoneverificationPost (string verificationCode, string phoneNumber, string authorization, string countryCode)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PhoneverificationPostExample
    {
        public void main()
        {
            var apiInstance = new PhoneVerificationApi();
            var verificationCode = verificationCode_example;  // string | 
            var phoneNumber = phoneNumber_example;  // string | 
            var authorization = authorization_example;  // string | 
            var countryCode = countryCode_example;  // string | 

            try
            {
                SimpleResult result = apiInstance.PhoneverificationPost(verificationCode, phoneNumber, authorization, countryCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneVerificationApi.PhoneverificationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **verificationCode** | **string**|  | 
 **phoneNumber** | **string**|  | 
 **authorization** | **string**|  | 
 **countryCode** | **string**|  | 

### Return type

[**SimpleResult**](SimpleResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="phoneverificationput"></a>
# **PhoneverificationPut**
> PhoneVerificationCreationResponse PhoneverificationPut (string phoneNumber, string authorization, string countryCode)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PhoneverificationPutExample
    {
        public void main()
        {
            var apiInstance = new PhoneVerificationApi();
            var phoneNumber = phoneNumber_example;  // string | 
            var authorization = authorization_example;  // string | 
            var countryCode = countryCode_example;  // string | 

            try
            {
                PhoneVerificationCreationResponse result = apiInstance.PhoneverificationPut(phoneNumber, authorization, countryCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneVerificationApi.PhoneverificationPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneNumber** | **string**|  | 
 **authorization** | **string**|  | 
 **countryCode** | **string**|  | 

### Return type

[**PhoneVerificationCreationResponse**](PhoneVerificationCreationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

