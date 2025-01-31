/*
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: messente@messente.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.Messente.Api.Client.OpenAPIDateConverter;

namespace com.Messente.Api.Model
{
    /// <summary>
    /// A container for errors
    /// </summary>
    [DataContract(Name = "ErrorNumberLookup")]
    public partial class ErrorNumberLookup : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorNumberLookup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorNumberLookup()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorNumberLookup" /> class.
        /// </summary>
        /// <param name="errors">An array of errors (required).</param>
        public ErrorNumberLookup(List<ErrorItemNumberLookup> errors = default(List<ErrorItemNumberLookup>))
        {
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new ArgumentNullException("errors is a required property for ErrorNumberLookup and cannot be null");
            }
            this.Errors = errors;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// An array of errors
        /// </summary>
        /// <value>An array of errors</value>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = true)]
        public List<ErrorItemNumberLookup> Errors { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorNumberLookup {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
