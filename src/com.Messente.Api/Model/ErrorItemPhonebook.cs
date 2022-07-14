/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 2.0.0
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
    /// A container for Phonebook API error
    /// </summary>
    [DataContract]
    public partial class ErrorItemPhonebook :  IEquatable<ErrorItemPhonebook>
    {
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public ErrorTitlePhonebook Title { get; set; }
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public ErrorCodePhonebook Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorItemPhonebook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorItemPhonebook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorItemPhonebook" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="detail">Free form more detailed description of the error (required).</param>
        /// <param name="code">code (required).</param>
        public ErrorItemPhonebook(ErrorTitlePhonebook title = default(ErrorTitlePhonebook), string detail = default(string), ErrorCodePhonebook code = default(ErrorCodePhonebook))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for ErrorItemPhonebook and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "detail" is required (not null)
            if (detail == null)
            {
                throw new InvalidDataException("detail is a required property for ErrorItemPhonebook and cannot be null");
            }
            else
            {
                this.Detail = detail;
            }
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for ErrorItemPhonebook and cannot be null");
            }
            else
            {
                this.Code = code;
            }
        }
        

        /// <summary>
        /// Free form more detailed description of the error
        /// </summary>
        /// <value>Free form more detailed description of the error</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorItemPhonebook {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as ErrorItemPhonebook);
        }

        /// <summary>
        /// Returns true if ErrorItemPhonebook instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorItemPhonebook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorItemPhonebook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                return hashCode;
            }
        }
    }

}
