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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// MixiiPhoneUserRequest
    /// </summary>
    [DataContract]
    public partial class MixiiPhoneUserRequest :  IEquatable<MixiiPhoneUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixiiPhoneUserRequest" /> class.
        /// </summary>
        /// <param name="VerificationUuid">VerificationUuid.</param>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="PasswordHash">PasswordHash.</param>
        public MixiiPhoneUserRequest(string VerificationUuid = default(string), string EmailAddress = default(string), string FirstName = default(string), string LastName = default(string), string PasswordHash = default(string))
        {
            this.VerificationUuid = VerificationUuid;
            this.EmailAddress = EmailAddress;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PasswordHash = PasswordHash;
        }
        
        /// <summary>
        /// Gets or Sets VerificationUuid
        /// </summary>
        [DataMember(Name="verification_uuid", EmitDefaultValue=false)]
        public string VerificationUuid { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="email_address", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets PasswordHash
        /// </summary>
        [DataMember(Name="password_hash", EmitDefaultValue=false)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MixiiPhoneUserRequest {\n");
            sb.Append("  VerificationUuid: ").Append(VerificationUuid).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MixiiPhoneUserRequest);
        }

        /// <summary>
        /// Returns true if MixiiPhoneUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MixiiPhoneUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MixiiPhoneUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerificationUuid == input.VerificationUuid ||
                    (this.VerificationUuid != null &&
                    this.VerificationUuid.Equals(input.VerificationUuid))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.PasswordHash == input.PasswordHash ||
                    (this.PasswordHash != null &&
                    this.PasswordHash.Equals(input.PasswordHash))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.VerificationUuid != null)
                    hashCode = hashCode * 59 + this.VerificationUuid.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.PasswordHash != null)
                    hashCode = hashCode * 59 + this.PasswordHash.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
