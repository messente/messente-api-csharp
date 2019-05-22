/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber and WhatsApp messages, blacklist phone numbers to make sure you're not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.0.1
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
    /// WhatsAppAudio
    /// </summary>
    [DataContract]
    public partial class WhatsAppAudio :  IEquatable<WhatsAppAudio>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppAudio" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppAudio() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppAudio" /> class.
        /// </summary>
        /// <param name="content">Base64-encoded audio (required).</param>
        public WhatsAppAudio(string content = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for WhatsAppAudio and cannot be null");
            }
            else
            {
                this.Content = content;
            }
        }
        
        /// <summary>
        /// Base64-encoded audio
        /// </summary>
        /// <value>Base64-encoded audio</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsAppAudio {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as WhatsAppAudio);
        }

        /// <summary>
        /// Returns true if WhatsAppAudio instances are equal
        /// </summary>
        /// <param name="input">Instance of WhatsAppAudio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppAudio input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }

}
