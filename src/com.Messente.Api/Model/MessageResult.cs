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
    /// A message part of an omnimessage
    /// </summary>
    [DataContract]
    public partial class MessageResult :  IEquatable<MessageResult>
    {
        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
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
        public MessageResult(string messageId = default(string), Channel channel = default(Channel), string sender = default(string))
        {
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for MessageResult and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }
            // to ensure "channel" is required (not null)
            if (channel == null)
            {
                throw new InvalidDataException("channel is a required property for MessageResult and cannot be null");
            }
            else
            {
                this.Channel = channel;
            }
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new InvalidDataException("sender is a required property for MessageResult and cannot be null");
            }
            else
            {
                this.Sender = sender;
            }
        }
        
        /// <summary>
        /// Unique identifier for the message
        /// </summary>
        /// <value>Unique identifier for the message</value>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public string MessageId { get; set; }


        /// <summary>
        /// Sender that was used for the message
        /// </summary>
        /// <value>Sender that was used for the message</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageResult);
        }

        /// <summary>
        /// Returns true if MessageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
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
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                return hashCode;
            }
        }
    }

}
