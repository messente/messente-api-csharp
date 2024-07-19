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
    /// A container for fields of a group
    /// </summary>
    [DataContract(Name = "GroupResponseFields")]
    public partial class GroupResponseFields : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponseFields" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupResponseFields()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupResponseFields" /> class.
        /// </summary>
        /// <param name="id">Id string in UUID format (required).</param>
        /// <param name="name">The name of the group (required).</param>
        /// <param name="createdOn">When the group was created.</param>
        /// <param name="contactsCount">The count of contacts in the group (required).</param>
        public GroupResponseFields(string id = default(string), string name = default(string), string createdOn = default(string), int contactsCount = default(int))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GroupResponseFields and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GroupResponseFields and cannot be null");
            }
            this.Name = name;
            this.ContactsCount = contactsCount;
            this.CreatedOn = createdOn;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Id string in UUID format
        /// </summary>
        /// <value>Id string in UUID format</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the group
        /// </summary>
        /// <value>The name of the group</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// When the group was created
        /// </summary>
        /// <value>When the group was created</value>
        [DataMember(Name = "createdOn", EmitDefaultValue = true)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// The count of contacts in the group
        /// </summary>
        /// <value>The count of contacts in the group</value>
        [DataMember(Name = "contactsCount", IsRequired = true, EmitDefaultValue = true)]
        public int ContactsCount { get; set; }

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
            sb.Append("class GroupResponseFields {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ContactsCount: ").Append(ContactsCount).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
