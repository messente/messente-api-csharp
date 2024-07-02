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
    /// A container for a response received after successfully created omnimessage
    /// </summary>
    [DataContract(Name = "OmniMessageCreateSuccessResponse")]
    public partial class OmniMessageCreateSuccessResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OmniMessageCreateSuccessResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OmniMessageCreateSuccessResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OmniMessageCreateSuccessResponse" /> class.
        /// </summary>
        /// <param name="messages">List of messages that compose the omnimessage (required).</param>
        /// <param name="to">Phone number in e.164 format (required).</param>
        /// <param name="omnimessageId">Unique identifier for the omnimessage (required).</param>
        public OmniMessageCreateSuccessResponse(List<MessageResult> messages = default(List<MessageResult>), string to = default(string), Guid omnimessageId = default(Guid))
        {
            // to ensure "messages" is required (not null)
            if (messages == null)
            {
                throw new ArgumentNullException("messages is a required property for OmniMessageCreateSuccessResponse and cannot be null");
            }
            this.Messages = messages;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for OmniMessageCreateSuccessResponse and cannot be null");
            }
            this.To = to;
            this.OmnimessageId = omnimessageId;
        }

        /// <summary>
        /// List of messages that compose the omnimessage
        /// </summary>
        /// <value>List of messages that compose the omnimessage</value>
        [DataMember(Name = "messages", IsRequired = true, EmitDefaultValue = true)]
        public List<MessageResult> Messages { get; set; }

        /// <summary>
        /// Phone number in e.164 format
        /// </summary>
        /// <value>Phone number in e.164 format</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Unique identifier for the omnimessage
        /// </summary>
        /// <value>Unique identifier for the omnimessage</value>
        [DataMember(Name = "omnimessage_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid OmnimessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OmniMessageCreateSuccessResponse {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  OmnimessageId: ").Append(OmnimessageId).Append("\n");
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
