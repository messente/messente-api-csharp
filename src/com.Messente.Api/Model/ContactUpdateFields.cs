/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.2.0
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
    /// A container for fields of a contact
    /// </summary>
    [DataContract]
    public partial class ContactUpdateFields :  IEquatable<ContactUpdateFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactUpdateFields" /> class.
        /// </summary>
        /// <param name="email">The email of the contact.</param>
        /// <param name="firstName">The first name of the contact.</param>
        /// <param name="lastName">The last name of the contact.</param>
        /// <param name="company">The company of the contact.</param>
        /// <param name="title">The title of the contact.</param>
        /// <param name="custom">The first custom field.</param>
        /// <param name="custom2">The second custom field.</param>
        /// <param name="custom3">The third custom field.</param>
        /// <param name="custom4">The fourth custom field.</param>
        public ContactUpdateFields(string email = default(string), string firstName = default(string), string lastName = default(string), string company = default(string), string title = default(string), string custom = default(string), string custom2 = default(string), string custom3 = default(string), string custom4 = default(string))
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
            this.Title = title;
            this.Custom = custom;
            this.Custom2 = custom2;
            this.Custom3 = custom3;
            this.Custom4 = custom4;
        }
        
        /// <summary>
        /// The email of the contact
        /// </summary>
        /// <value>The email of the contact</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The first name of the contact
        /// </summary>
        /// <value>The first name of the contact</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the contact
        /// </summary>
        /// <value>The last name of the contact</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The company of the contact
        /// </summary>
        /// <value>The company of the contact</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// The title of the contact
        /// </summary>
        /// <value>The title of the contact</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The first custom field
        /// </summary>
        /// <value>The first custom field</value>
        [DataMember(Name="custom", EmitDefaultValue=false)]
        public string Custom { get; set; }

        /// <summary>
        /// The second custom field
        /// </summary>
        /// <value>The second custom field</value>
        [DataMember(Name="custom2", EmitDefaultValue=false)]
        public string Custom2 { get; set; }

        /// <summary>
        /// The third custom field
        /// </summary>
        /// <value>The third custom field</value>
        [DataMember(Name="custom3", EmitDefaultValue=false)]
        public string Custom3 { get; set; }

        /// <summary>
        /// The fourth custom field
        /// </summary>
        /// <value>The fourth custom field</value>
        [DataMember(Name="custom4", EmitDefaultValue=false)]
        public string Custom4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactUpdateFields {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  Custom2: ").Append(Custom2).Append("\n");
            sb.Append("  Custom3: ").Append(Custom3).Append("\n");
            sb.Append("  Custom4: ").Append(Custom4).Append("\n");
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
            return this.Equals(input as ContactUpdateFields);
        }

        /// <summary>
        /// Returns true if ContactUpdateFields instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactUpdateFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactUpdateFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Custom == input.Custom ||
                    (this.Custom != null &&
                    this.Custom.Equals(input.Custom))
                ) && 
                (
                    this.Custom2 == input.Custom2 ||
                    (this.Custom2 != null &&
                    this.Custom2.Equals(input.Custom2))
                ) && 
                (
                    this.Custom3 == input.Custom3 ||
                    (this.Custom3 != null &&
                    this.Custom3.Equals(input.Custom3))
                ) && 
                (
                    this.Custom4 == input.Custom4 ||
                    (this.Custom4 != null &&
                    this.Custom4.Equals(input.Custom4))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Custom != null)
                    hashCode = hashCode * 59 + this.Custom.GetHashCode();
                if (this.Custom2 != null)
                    hashCode = hashCode * 59 + this.Custom2.GetHashCode();
                if (this.Custom3 != null)
                    hashCode = hashCode * 59 + this.Custom3.GetHashCode();
                if (this.Custom4 != null)
                    hashCode = hashCode * 59 + this.Custom4.GetHashCode();
                return hashCode;
            }
        }
    }

}
