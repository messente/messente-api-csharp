/* 
 * Messente API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.0.1
 * Contact: messente@messente.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = com.Messente.Api.Client.OpenAPIDateConverter;

namespace com.Messente.Api.Model
{
    /// <summary>
    /// ErrorOmnichannel
    /// </summary>
    [DataContract]
    public partial class ErrorOmnichannel :  IEquatable<ErrorOmnichannel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorOmnichannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorOmnichannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorOmnichannel" /> class.
        /// </summary>
        /// <param name="errors">errors (required).</param>
        public ErrorOmnichannel(List<ErrorItemOmnichannel> errors = default(List<ErrorItemOmnichannel>))
        {
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new InvalidDataException("errors is a required property for ErrorOmnichannel and cannot be null");
            }
            else
            {
                this.Errors = errors;
            }
        }
        
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ErrorItemOmnichannel> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorOmnichannel {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ErrorOmnichannel);
        }

        /// <summary>
        /// Returns true if ErrorOmnichannel instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorOmnichannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorOmnichannel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                return hashCode;
            }
        }
    }

}
