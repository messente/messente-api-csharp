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
    /// Whatsapp template component
    /// </summary>
    [DataContract(Name = "WhatsAppComponent")]
    public partial class WhatsAppComponent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppComponent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppComponent()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppComponent" /> class.
        /// </summary>
        /// <param name="type">Type of the component (required).</param>
        /// <param name="subType">Sub-type of the component.</param>
        /// <param name="index">index used to position buttons.</param>
        /// <param name="parameters">List of parameters for the component.</param>
        public WhatsAppComponent(string type = default(string), string subType = default(string), int index = default(int), List<WhatsAppParameter> parameters = default(List<WhatsAppParameter>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for WhatsAppComponent and cannot be null");
            }
            this.Type = type;
            this.SubType = subType;
            this.Index = index;
            this.Parameters = parameters;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Type of the component
        /// </summary>
        /// <value>Type of the component</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Sub-type of the component
        /// </summary>
        /// <value>Sub-type of the component</value>
        [DataMember(Name = "sub_type", EmitDefaultValue = false)]
        public string SubType { get; set; }

        /// <summary>
        /// index used to position buttons
        /// </summary>
        /// <value>index used to position buttons</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// List of parameters for the component
        /// </summary>
        /// <value>List of parameters for the component</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<WhatsAppParameter> Parameters { get; set; }

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
            sb.Append("class WhatsAppComponent {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
