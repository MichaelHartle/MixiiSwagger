using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPhoneVerificationApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <returns>SimpleResult</returns>
        SimpleResult PhoneverificationOptions ();
        /// <summary>
        ///  
        /// </summary>
        /// <param name="verificationCode"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>SimpleResult</returns>
        SimpleResult PhoneverificationPost (string verificationCode, string phoneNumber, string authorization, string countryCode);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="authorization"></param>
        /// <param name="countryCode"></param>
        /// <returns>PhoneVerificationCreationResponse</returns>
        PhoneVerificationCreationResponse PhoneverificationPut (string phoneNumber, string authorization, string countryCode);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PhoneVerificationApi : IPhoneVerificationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneVerificationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PhoneVerificationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneVerificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PhoneVerificationApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>SimpleResult</returns>            
        public SimpleResult PhoneverificationOptions ()
        {
            
    
            var path = "/phoneverification";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneverificationOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneverificationOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SimpleResult) ApiClient.Deserialize(response.Content, typeof(SimpleResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="verificationCode"></param> 
        /// <param name="phoneNumber"></param> 
        /// <param name="authorization"></param> 
        /// <param name="countryCode"></param> 
        /// <returns>SimpleResult</returns>            
        public SimpleResult PhoneverificationPost (string verificationCode, string phoneNumber, string authorization, string countryCode)
        {
            
            // verify the required parameter 'verificationCode' is set
            if (verificationCode == null) throw new ApiException(400, "Missing required parameter 'verificationCode' when calling PhoneverificationPost");
            
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null) throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling PhoneverificationPost");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PhoneverificationPost");
            
            // verify the required parameter 'countryCode' is set
            if (countryCode == null) throw new ApiException(400, "Missing required parameter 'countryCode' when calling PhoneverificationPost");
            
    
            var path = "/phoneverification";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (verificationCode != null) queryParams.Add("verification_code", ApiClient.ParameterToString(verificationCode)); // query parameter
 if (phoneNumber != null) queryParams.Add("phone_number", ApiClient.ParameterToString(phoneNumber)); // query parameter
 if (countryCode != null) queryParams.Add("country_code", ApiClient.ParameterToString(countryCode)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneverificationPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneverificationPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SimpleResult) ApiClient.Deserialize(response.Content, typeof(SimpleResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="phoneNumber"></param> 
        /// <param name="authorization"></param> 
        /// <param name="countryCode"></param> 
        /// <returns>PhoneVerificationCreationResponse</returns>            
        public PhoneVerificationCreationResponse PhoneverificationPut (string phoneNumber, string authorization, string countryCode)
        {
            
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null) throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling PhoneverificationPut");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PhoneverificationPut");
            
            // verify the required parameter 'countryCode' is set
            if (countryCode == null) throw new ApiException(400, "Missing required parameter 'countryCode' when calling PhoneverificationPut");
            
    
            var path = "/phoneverification";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (phoneNumber != null) queryParams.Add("phone_number", ApiClient.ParameterToString(phoneNumber)); // query parameter
 if (countryCode != null) queryParams.Add("country_code", ApiClient.ParameterToString(countryCode)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneverificationPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneverificationPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PhoneVerificationCreationResponse) ApiClient.Deserialize(response.Content, typeof(PhoneVerificationCreationResponse), response.Headers);
        }
    
    }
}
