/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber, WhatsApp and Telegram messages, blacklist phone numbers to make sure you're not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.0.2
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
    /// A text
    /// </summary>
    [DataContract]
    public partial class WhatsAppText :  IEquatable<WhatsAppText>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppText" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppText() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppText" /> class.
        /// </summary>
        /// <param name="previewUrl">Whether to display link preview if the message contains a hyperlink (default to true).</param>
        /// <param name="body">Plaintext content for WhatsApp, can contain URLs, emojis and formatting (required).</param>
        public WhatsAppText(bool? previewUrl = true, string body = default(string))
        {
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for WhatsAppText and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            // use default value if no "previewUrl" provided
            if (previewUrl == null)
            {
                this.PreviewUrl = true;
            }
            else
            {
                this.PreviewUrl = previewUrl;
            }
        }
        
        /// <summary>
        /// Whether to display link preview if the message contains a hyperlink
        /// </summary>
        /// <value>Whether to display link preview if the message contains a hyperlink</value>
        [DataMember(Name="preview_url", EmitDefaultValue=false)]
        public bool? PreviewUrl { get; set; }

        /// <summary>
        /// Plaintext content for WhatsApp, can contain URLs, emojis and formatting
        /// </summary>
        /// <value>Plaintext content for WhatsApp, can contain URLs, emojis and formatting</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsAppText {\n");
            sb.Append("  PreviewUrl: ").Append(PreviewUrl).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(input as WhatsAppText);
        }

        /// <summary>
        /// Returns true if WhatsAppText instances are equal
        /// </summary>
        /// <param name="input">Instance of WhatsAppText to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppText input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreviewUrl == input.PreviewUrl ||
                    (this.PreviewUrl != null &&
                    this.PreviewUrl.Equals(input.PreviewUrl))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.PreviewUrl != null)
                    hashCode = hashCode * 59 + this.PreviewUrl.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }

}
