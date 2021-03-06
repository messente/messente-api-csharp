/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.4.0
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
    /// A container for Omnichannel API error
    /// </summary>
    [DataContract]
    public partial class ErrorItemOmnichannel :  IEquatable<ErrorItemOmnichannel>
    {
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public ErrorTitleOmnichannel Title { get; set; }
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public ErrorCodeOmnichannel Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorItemOmnichannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorItemOmnichannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorItemOmnichannel" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="detail">Free form more detailed description of the error (required).</param>
        /// <param name="code">code (required).</param>
        /// <param name="source">Describes which field is causing the issue in the payload, null for non 400 status code responses (required).</param>
        public ErrorItemOmnichannel(ErrorTitleOmnichannel title = default(ErrorTitleOmnichannel), string detail = default(string), ErrorCodeOmnichannel code = default(ErrorCodeOmnichannel), string source = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for ErrorItemOmnichannel and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "detail" is required (not null)
            if (detail == null)
            {
                throw new InvalidDataException("detail is a required property for ErrorItemOmnichannel and cannot be null");
            }
            else
            {
                this.Detail = detail;
            }
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for ErrorItemOmnichannel and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for ErrorItemOmnichannel and cannot be null");
            }
            else
            {
                this.Source = source;
            }
        }
        

        /// <summary>
        /// Free form more detailed description of the error
        /// </summary>
        /// <value>Free form more detailed description of the error</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }


        /// <summary>
        /// Describes which field is causing the issue in the payload, null for non 400 status code responses
        /// </summary>
        /// <value>Describes which field is causing the issue in the payload, null for non 400 status code responses</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorItemOmnichannel {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as ErrorItemOmnichannel);
        }

        /// <summary>
        /// Returns true if ErrorItemOmnichannel instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorItemOmnichannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorItemOmnichannel input)
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
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }
    }

}
