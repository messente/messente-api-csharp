/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.1.1
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
    /// A container for a soon-to-be blacklisted number
    /// </summary>
    [DataContract]
    public partial class NumberToBlacklist :  IEquatable<NumberToBlacklist>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberToBlacklist" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NumberToBlacklist() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberToBlacklist" /> class.
        /// </summary>
        /// <param name="phoneNumber">Phone number in e.164 format (required).</param>
        public NumberToBlacklist(string phoneNumber = default(string))
        {
            // to ensure "phoneNumber" is required (not null)
            if (phoneNumber == null)
            {
                throw new InvalidDataException("phoneNumber is a required property for NumberToBlacklist and cannot be null");
            }
            else
            {
                this.PhoneNumber = phoneNumber;
            }
        }
        
        /// <summary>
        /// Phone number in e.164 format
        /// </summary>
        /// <value>Phone number in e.164 format</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberToBlacklist {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as NumberToBlacklist);
        }

        /// <summary>
        /// Returns true if NumberToBlacklist instances are equal
        /// </summary>
        /// <param name="input">Instance of NumberToBlacklist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberToBlacklist input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                return hashCode;
            }
        }
    }

}
