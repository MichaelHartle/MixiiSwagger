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
    public interface IDefaultApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <returns>SimpleResult</returns>
        SimpleResult PhoneregistrationOptions ();
        /// <summary>
        ///  
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="passwordHash"></param>
        /// <param name="authorization"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="countryCode"></param>
        /// <param name="verificationUuid"></param>
        /// <returns>MixiiPhoneUserRequest</returns>
        MixiiPhoneUserRequest PhoneregistrationPut (string emailAddress, string passwordHash, string authorization, string firstName, string lastName, string phoneNumber, string countryCode, string verificationUuid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
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
        public SimpleResult PhoneregistrationOptions ()
        {
            
    
            var path = "/phoneregistration";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneregistrationOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneregistrationOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SimpleResult) ApiClient.Deserialize(response.Content, typeof(SimpleResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="emailAddress"></param> 
        /// <param name="passwordHash"></param> 
        /// <param name="authorization"></param> 
        /// <param name="firstName"></param> 
        /// <param name="lastName"></param> 
        /// <param name="phoneNumber"></param> 
        /// <param name="countryCode"></param> 
        /// <param name="verificationUuid"></param> 
        /// <returns>MixiiPhoneUserRequest</returns>            
        public MixiiPhoneUserRequest PhoneregistrationPut (string emailAddress, string passwordHash, string authorization, string firstName, string lastName, string phoneNumber, string countryCode, string verificationUuid)
        {
            
            // verify the required parameter 'emailAddress' is set
            if (emailAddress == null) throw new ApiException(400, "Missing required parameter 'emailAddress' when calling PhoneregistrationPut");
            
            // verify the required parameter 'passwordHash' is set
            if (passwordHash == null) throw new ApiException(400, "Missing required parameter 'passwordHash' when calling PhoneregistrationPut");
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling PhoneregistrationPut");
            
            // verify the required parameter 'firstName' is set
            if (firstName == null) throw new ApiException(400, "Missing required parameter 'firstName' when calling PhoneregistrationPut");
            
            // verify the required parameter 'lastName' is set
            if (lastName == null) throw new ApiException(400, "Missing required parameter 'lastName' when calling PhoneregistrationPut");
            
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null) throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling PhoneregistrationPut");
            
            // verify the required parameter 'countryCode' is set
            if (countryCode == null) throw new ApiException(400, "Missing required parameter 'countryCode' when calling PhoneregistrationPut");
            
            // verify the required parameter 'verificationUuid' is set
            if (verificationUuid == null) throw new ApiException(400, "Missing required parameter 'verificationUuid' when calling PhoneregistrationPut");
            
    
            var path = "/phoneregistration";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (emailAddress != null) queryParams.Add("email_address", ApiClient.ParameterToString(emailAddress)); // query parameter
 if (passwordHash != null) queryParams.Add("password_hash", ApiClient.ParameterToString(passwordHash)); // query parameter
 if (firstName != null) queryParams.Add("first_name", ApiClient.ParameterToString(firstName)); // query parameter
 if (lastName != null) queryParams.Add("last_name", ApiClient.ParameterToString(lastName)); // query parameter
 if (phoneNumber != null) queryParams.Add("phone_number", ApiClient.ParameterToString(phoneNumber)); // query parameter
 if (countryCode != null) queryParams.Add("country_code", ApiClient.ParameterToString(countryCode)); // query parameter
 if (verificationUuid != null) queryParams.Add("verification_uuid", ApiClient.ParameterToString(verificationUuid)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneregistrationPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PhoneregistrationPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MixiiPhoneUserRequest) ApiClient.Deserialize(response.Content, typeof(MixiiPhoneUserRequest), response.Headers);
        }
    
    }
}
