/* 
 * Mixii Mobile API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPhoneVerificationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SimpleResult</returns>
        SimpleResult PhoneverificationOptions ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SimpleResult</returns>
        ApiResponse<SimpleResult> PhoneverificationOptionsWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verificationCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>SimpleResult</returns>
        SimpleResult PhoneverificationPost (string verificationCode, string phoneNumber, string authorization, string countryCode);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verificationCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>ApiResponse of SimpleResult</returns>
        ApiResponse<SimpleResult> PhoneverificationPostWithHttpInfo (string verificationCode, string phoneNumber, string authorization, string countryCode);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>PhoneVerificationCreationResponse</returns>
        PhoneVerificationCreationResponse PhoneverificationPut (string phoneNumber, string authorization, string countryCode);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>ApiResponse of PhoneVerificationCreationResponse</returns>
        ApiResponse<PhoneVerificationCreationResponse> PhoneverificationPutWithHttpInfo (string phoneNumber, string authorization, string countryCode);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SimpleResult</returns>
        System.Threading.Tasks.Task<SimpleResult> PhoneverificationOptionsAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SimpleResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<SimpleResult>> PhoneverificationOptionsAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verificationCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>Task of SimpleResult</returns>
        System.Threading.Tasks.Task<SimpleResult> PhoneverificationPostAsync (string verificationCode, string phoneNumber, string authorization, string countryCode);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verificationCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>Task of ApiResponse (SimpleResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<SimpleResult>> PhoneverificationPostAsyncWithHttpInfo (string verificationCode, string phoneNumber, string authorization, string countryCode);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>Task of PhoneVerificationCreationResponse</returns>
        System.Threading.Tasks.Task<PhoneVerificationCreationResponse> PhoneverificationPutAsync (string phoneNumber, string authorization, string countryCode);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>Task of ApiResponse (PhoneVerificationCreationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneVerificationCreationResponse>> PhoneverificationPutAsyncWithHttpInfo (string phoneNumber, string authorization, string countryCode);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PhoneVerificationApi : IPhoneVerificationApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneVerificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PhoneVerificationApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneVerificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PhoneVerificationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SimpleResult</returns>
        public SimpleResult PhoneverificationOptions ()
        {
             ApiResponse<SimpleResult> localVarResponse = PhoneverificationOptionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SimpleResult</returns>
        public ApiResponse< SimpleResult > PhoneverificationOptionsWithHttpInfo ()
        {

            var localVarPath = "/phoneverification";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.OPTIONS, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneverificationOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SimpleResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleResult)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of SimpleResult</returns>
        public async System.Threading.Tasks.Task<SimpleResult> PhoneverificationOptionsAsync ()
        {
             ApiResponse<SimpleResult> localVarResponse = await PhoneverificationOptionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (SimpleResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SimpleResult>> PhoneverificationOptionsAsyncWithHttpInfo ()
        {

            var localVarPath = "/phoneverification";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.OPTIONS, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneverificationOptions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SimpleResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleResult)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verificationCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>SimpleResult</returns>
        public SimpleResult PhoneverificationPost (string verificationCode, string phoneNumber, string authorization, string countryCode)
        {
             ApiResponse<SimpleResult> localVarResponse = PhoneverificationPostWithHttpInfo(verificationCode, phoneNumber, authorization, countryCode);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verificationCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>ApiResponse of SimpleResult</returns>
        public ApiResponse< SimpleResult > PhoneverificationPostWithHttpInfo (string verificationCode, string phoneNumber, string authorization, string countryCode)
        {
            // verify the required parameter 'verificationCode' is set
            if (verificationCode == null)
                throw new ApiException(400, "Missing required parameter 'verificationCode' when calling PhoneVerificationApi->PhoneverificationPost");
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null)
                throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling PhoneVerificationApi->PhoneverificationPost");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PhoneVerificationApi->PhoneverificationPost");
            // verify the required parameter 'countryCode' is set
            if (countryCode == null)
                throw new ApiException(400, "Missing required parameter 'countryCode' when calling PhoneVerificationApi->PhoneverificationPost");

            var localVarPath = "/phoneverification";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (verificationCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "verification_code", verificationCode)); // query parameter
            if (phoneNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "phone_number", phoneNumber)); // query parameter
            if (countryCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country_code", countryCode)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneverificationPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SimpleResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleResult)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verificationCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>Task of SimpleResult</returns>
        public async System.Threading.Tasks.Task<SimpleResult> PhoneverificationPostAsync (string verificationCode, string phoneNumber, string authorization, string countryCode)
        {
             ApiResponse<SimpleResult> localVarResponse = await PhoneverificationPostAsyncWithHttpInfo(verificationCode, phoneNumber, authorization, countryCode);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verificationCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>Task of ApiResponse (SimpleResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SimpleResult>> PhoneverificationPostAsyncWithHttpInfo (string verificationCode, string phoneNumber, string authorization, string countryCode)
        {
            // verify the required parameter 'verificationCode' is set
            if (verificationCode == null)
                throw new ApiException(400, "Missing required parameter 'verificationCode' when calling PhoneVerificationApi->PhoneverificationPost");
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null)
                throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling PhoneVerificationApi->PhoneverificationPost");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PhoneVerificationApi->PhoneverificationPost");
            // verify the required parameter 'countryCode' is set
            if (countryCode == null)
                throw new ApiException(400, "Missing required parameter 'countryCode' when calling PhoneVerificationApi->PhoneverificationPost");

            var localVarPath = "/phoneverification";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (verificationCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "verification_code", verificationCode)); // query parameter
            if (phoneNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "phone_number", phoneNumber)); // query parameter
            if (countryCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country_code", countryCode)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneverificationPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SimpleResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SimpleResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleResult)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>PhoneVerificationCreationResponse</returns>
        public PhoneVerificationCreationResponse PhoneverificationPut (string phoneNumber, string authorization, string countryCode)
        {
             ApiResponse<PhoneVerificationCreationResponse> localVarResponse = PhoneverificationPutWithHttpInfo(phoneNumber, authorization, countryCode);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>ApiResponse of PhoneVerificationCreationResponse</returns>
        public ApiResponse< PhoneVerificationCreationResponse > PhoneverificationPutWithHttpInfo (string phoneNumber, string authorization, string countryCode)
        {
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null)
                throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling PhoneVerificationApi->PhoneverificationPut");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PhoneVerificationApi->PhoneverificationPut");
            // verify the required parameter 'countryCode' is set
            if (countryCode == null)
                throw new ApiException(400, "Missing required parameter 'countryCode' when calling PhoneVerificationApi->PhoneverificationPut");

            var localVarPath = "/phoneverification";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (phoneNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "phone_number", phoneNumber)); // query parameter
            if (countryCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country_code", countryCode)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneverificationPut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneVerificationCreationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneVerificationCreationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneVerificationCreationResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>Task of PhoneVerificationCreationResponse</returns>
        public async System.Threading.Tasks.Task<PhoneVerificationCreationResponse> PhoneverificationPutAsync (string phoneNumber, string authorization, string countryCode)
        {
             ApiResponse<PhoneVerificationCreationResponse> localVarResponse = await PhoneverificationPutAsyncWithHttpInfo(phoneNumber, authorization, countryCode);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>Task of ApiResponse (PhoneVerificationCreationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneVerificationCreationResponse>> PhoneverificationPutAsyncWithHttpInfo (string phoneNumber, string authorization, string countryCode)
        {
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null)
                throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling PhoneVerificationApi->PhoneverificationPut");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling PhoneVerificationApi->PhoneverificationPut");
            // verify the required parameter 'countryCode' is set
            if (countryCode == null)
                throw new ApiException(400, "Missing required parameter 'countryCode' when calling PhoneVerificationApi->PhoneverificationPut");

            var localVarPath = "/phoneverification";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (phoneNumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "phone_number", phoneNumber)); // query parameter
            if (countryCode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "country_code", countryCode)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", Configuration.ApiClient.ParameterToString(authorization)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneverificationPut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneVerificationCreationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneVerificationCreationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneVerificationCreationResponse)));
        }

    }
}
