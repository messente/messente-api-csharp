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
    /// A delivery report
    /// </summary>
    [DataContract(Name = "DeliveryResult")]
    public partial class DeliveryResult : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public Status? Status { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public Channel? Channel { get; set; }

        /// <summary>
        /// Gets or Sets Err
        /// </summary>
        [DataMember(Name = "err", EmitDefaultValue = false)]
        public ErrorCodeOmnichannelMachine? Err { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryResult" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="channel">channel.</param>
        /// <param name="messageId">Unique identifier for the message.</param>
        /// <param name="error">Human-readable description of what went wrong, *null* in case of success or if the message has not been processed yet.</param>
        /// <param name="err">err.</param>
        /// <param name="timestamp">When this status was received by Omnichannel API.</param>
        /// <param name="priceInfo">priceInfo.</param>
        /// <param name="sender">the sender of the message.</param>
        public DeliveryResult(Status? status = default(Status?), Channel? channel = default(Channel?), Guid messageId = default(Guid), string error = default(string), ErrorCodeOmnichannelMachine? err = default(ErrorCodeOmnichannelMachine?), DateTime timestamp = default(DateTime), PriceInfo priceInfo = default(PriceInfo), string sender = default(string))
        {
            this.Status = status;
            this.Channel = channel;
            this.MessageId = messageId;
            this.Error = error;
            this.Err = err;
            this.Timestamp = timestamp;
            this.PriceInfo = priceInfo;
            this.Sender = sender;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Unique identifier for the message
        /// </summary>
        /// <value>Unique identifier for the message</value>
        [DataMember(Name = "message_id", EmitDefaultValue = false)]
        public Guid MessageId { get; set; }

        /// <summary>
        /// Human-readable description of what went wrong, *null* in case of success or if the message has not been processed yet
        /// </summary>
        /// <value>Human-readable description of what went wrong, *null* in case of success or if the message has not been processed yet</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// When this status was received by Omnichannel API
        /// </summary>
        /// <value>When this status was received by Omnichannel API</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets PriceInfo
        /// </summary>
        [DataMember(Name = "price_info", EmitDefaultValue = false)]
        public PriceInfo PriceInfo { get; set; }

        /// <summary>
        /// the sender of the message
        /// </summary>
        /// <value>the sender of the message</value>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public string Sender { get; set; }

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
            sb.Append("class DeliveryResult {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Err: ").Append(Err).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  PriceInfo: ").Append(PriceInfo).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
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
