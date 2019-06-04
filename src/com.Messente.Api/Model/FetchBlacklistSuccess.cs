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
    /// FetchBlacklistSuccess
    /// </summary>
    [DataContract]
    public partial class FetchBlacklistSuccess :  IEquatable<FetchBlacklistSuccess>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchBlacklistSuccess" /> class.
        /// </summary>
        /// <param name="phoneNumbers">Array of unique phone numbers.</param>
        public FetchBlacklistSuccess(List<string> phoneNumbers = default(List<string>))
        {
            this.PhoneNumbers = phoneNumbers;
        }
        
        /// <summary>
        /// Array of unique phone numbers
        /// </summary>
        /// <value>Array of unique phone numbers</value>
        [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
        public List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FetchBlacklistSuccess {\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
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
            return this.Equals(input as FetchBlacklistSuccess);
        }

        /// <summary>
        /// Returns true if FetchBlacklistSuccess instances are equal
        /// </summary>
        /// <param name="input">Instance of FetchBlacklistSuccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FetchBlacklistSuccess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
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
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                return hashCode;
            }
        }
    }

}
