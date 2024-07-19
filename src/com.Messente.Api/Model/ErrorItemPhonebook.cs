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
    /// A container for Phonebook API error
    /// </summary>
    [DataContract(Name = "ErrorItemPhonebook")]
    public partial class ErrorItemPhonebook : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public ErrorTitlePhonebook Title { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public ErrorCodePhonebook Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorItemPhonebook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorItemPhonebook()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorItemPhonebook" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="detail">Free form more detailed description of the error (required).</param>
        /// <param name="code">code (required).</param>
        public ErrorItemPhonebook(ErrorTitlePhonebook title = default(ErrorTitlePhonebook), string detail = default(string), ErrorCodePhonebook code = default(ErrorCodePhonebook))
        {
            this.Title = title;
            // to ensure "detail" is required (not null)
            if (detail == null)
            {
                throw new ArgumentNullException("detail is a required property for ErrorItemPhonebook and cannot be null");
            }
            this.Detail = detail;
            this.Code = code;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Free form more detailed description of the error
        /// </summary>
        /// <value>Free form more detailed description of the error</value>
        [DataMember(Name = "detail", IsRequired = true, EmitDefaultValue = true)]
        public string Detail { get; set; }

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
            sb.Append("class ErrorItemPhonebook {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
