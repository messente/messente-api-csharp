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
    /// A message part of an omnimessage
    /// </summary>
    [DataContract(Name = "MessageResult")]
    public partial class MessageResult : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = true)]
        public Channel Channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResult" /> class.
        /// </summary>
        /// <param name="messageId">Unique identifier for the message (required).</param>
        /// <param name="channel">channel (required).</param>
        /// <param name="sender">Sender that was used for the message (required).</param>
        public MessageResult(Guid messageId = default(Guid), Channel channel = default(Channel), string sender = default(string))
        {
            this.MessageId = messageId;
            this.Channel = channel;
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for MessageResult and cannot be null");
            }
            this.Sender = sender;
        }

        /// <summary>
        /// Unique identifier for the message
        /// </summary>
        /// <value>Unique identifier for the message</value>
        [DataMember(Name = "message_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid MessageId { get; set; }

        /// <summary>
        /// Sender that was used for the message
        /// </summary>
        /// <value>Sender that was used for the message</value>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = true)]
        public string Sender { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageResult {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
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
