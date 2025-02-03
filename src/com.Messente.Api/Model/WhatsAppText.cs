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
    /// A text
    /// </summary>
    [DataContract(Name = "WhatsAppText")]
    public partial class WhatsAppText : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppText" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppText()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppText" /> class.
        /// </summary>
        /// <param name="previewUrl">Whether to display link preview if the message contains a hyperlink (default to true).</param>
        /// <param name="body">Plaintext content for WhatsApp, can contain URLs, emojis and formatting (required).</param>
        public WhatsAppText(bool previewUrl = true, string body = default(string))
        {
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new ArgumentNullException("body is a required property for WhatsAppText and cannot be null");
            }
            this.Body = body;
            this.PreviewUrl = previewUrl;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Whether to display link preview if the message contains a hyperlink
        /// </summary>
        /// <value>Whether to display link preview if the message contains a hyperlink</value>
        [DataMember(Name = "preview_url", EmitDefaultValue = true)]
        public bool PreviewUrl { get; set; }

        /// <summary>
        /// Plaintext content for WhatsApp, can contain URLs, emojis and formatting
        /// </summary>
        /// <value>Plaintext content for WhatsApp, can contain URLs, emojis and formatting</value>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = true)]
        public string Body { get; set; }

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
            sb.Append("class WhatsAppText {\n");
            sb.Append("  PreviewUrl: ").Append(PreviewUrl).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
