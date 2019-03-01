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
    /// WhatsAppImage
    /// </summary>
    [DataContract]
    public partial class WhatsAppImage :  IEquatable<WhatsAppImage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppImage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppImage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppImage" /> class.
        /// </summary>
        /// <param name="caption">Description for the image.</param>
        /// <param name="content">Base64-encoded image (required).</param>
        public WhatsAppImage(string caption = default(string), string content = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for WhatsAppImage and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            this.Caption = caption;
        }
        
        /// <summary>
        /// Description for the image
        /// </summary>
        /// <value>Description for the image</value>
        [DataMember(Name="caption", EmitDefaultValue=false)]
        public string Caption { get; set; }

        /// <summary>
        /// Base64-encoded image
        /// </summary>
        /// <value>Base64-encoded image</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsAppImage {\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
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
            return this.Equals(input as WhatsAppImage);
        }

        /// <summary>
        /// Returns true if WhatsAppImage instances are equal
        /// </summary>
        /// <param name="input">Instance of WhatsAppImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppImage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Caption == input.Caption ||
                    (this.Caption != null &&
                    this.Caption.Equals(input.Caption))
                ) && 
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
                if (this.Caption != null)
                    hashCode = hashCode * 59 + this.Caption.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }

}
