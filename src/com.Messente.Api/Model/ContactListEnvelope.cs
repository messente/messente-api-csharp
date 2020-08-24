/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.3.0
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
    /// A container for contacts
    /// </summary>
    [DataContract]
    public partial class ContactListEnvelope :  IEquatable<ContactListEnvelope>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactListEnvelope" /> class.
        /// </summary>
        /// <param name="contacts">An array of contacts.</param>
        public ContactListEnvelope(List<ContactFields> contacts = default(List<ContactFields>))
        {
            this.Contacts = contacts;
        }
        
        /// <summary>
        /// An array of contacts
        /// </summary>
        /// <value>An array of contacts</value>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<ContactFields> Contacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactListEnvelope {\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
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
            return this.Equals(input as ContactListEnvelope);
        }

        /// <summary>
        /// Returns true if ContactListEnvelope instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactListEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactListEnvelope input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
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
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                return hashCode;
            }
        }
    }

}
