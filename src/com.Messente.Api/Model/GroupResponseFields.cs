/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber, WhatsApp and Telegram messages, blacklist phone numbers to make sure you're not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.1.0
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
    /// A container for fields of a group
    /// </summary>
    [DataContract]
    public partial class GroupResponseFields :  IEquatable<GroupResponseFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponseFields" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupResponseFields() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponseFields" /> class.
        /// </summary>
        /// <param name="id">Id string in UUID format (required).</param>
        /// <param name="name">The name of the group (required).</param>
        /// <param name="createdOn">When the group was created.</param>
        /// <param name="contactsCount">The count of contacts in the group (required).</param>
        public GroupResponseFields(string id = default(string), string name = default(string), string createdOn = default(string), int? contactsCount = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GroupResponseFields and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GroupResponseFields and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "contactsCount" is required (not null)
            if (contactsCount == null)
            {
                throw new InvalidDataException("contactsCount is a required property for GroupResponseFields and cannot be null");
            }
            else
            {
                this.ContactsCount = contactsCount;
            }
            this.CreatedOn = createdOn;
        }
        
        /// <summary>
        /// Id string in UUID format
        /// </summary>
        /// <value>Id string in UUID format</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the group
        /// </summary>
        /// <value>The name of the group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// When the group was created
        /// </summary>
        /// <value>When the group was created</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// The count of contacts in the group
        /// </summary>
        /// <value>The count of contacts in the group</value>
        [DataMember(Name="contactsCount", EmitDefaultValue=false)]
        public int? ContactsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupResponseFields {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ContactsCount: ").Append(ContactsCount).Append("\n");
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
            return this.Equals(input as GroupResponseFields);
        }

        /// <summary>
        /// Returns true if GroupResponseFields instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupResponseFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupResponseFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.ContactsCount == input.ContactsCount ||
                    (this.ContactsCount != null &&
                    this.ContactsCount.Equals(input.ContactsCount))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.ContactsCount != null)
                    hashCode = hashCode * 59 + this.ContactsCount.GetHashCode();
                return hashCode;
            }
        }
    }

}
