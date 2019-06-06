/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber and WhatsApp messages, blacklist phone numbers to make sure you're not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.0.1
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
    /// A delivery report
    /// </summary>
    [DataContract]
    public partial class DeliveryResult :  IEquatable<DeliveryResult>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public Status? Status { get; set; }
        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public Channel? Channel { get; set; }
        /// <summary>
        /// Gets or Sets Err
        /// </summary>
        [DataMember(Name="err", EmitDefaultValue=false)]
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
        public DeliveryResult(Status? status = default(Status?), Channel? channel = default(Channel?), string messageId = default(string), string error = default(string), ErrorCodeOmnichannelMachine? err = default(ErrorCodeOmnichannelMachine?), DateTime? timestamp = default(DateTime?))
        {
            this.Status = status;
            this.Channel = channel;
            this.MessageId = messageId;
            this.Error = error;
            this.Err = err;
            this.Timestamp = timestamp;
        }
        


        /// <summary>
        /// Unique identifier for the message
        /// </summary>
        /// <value>Unique identifier for the message</value>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Human-readable description of what went wrong, *null* in case of success or if the message has not been processed yet
        /// </summary>
        /// <value>Human-readable description of what went wrong, *null* in case of success or if the message has not been processed yet</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }


        /// <summary>
        /// When this status was received by Omnichannel API
        /// </summary>
        /// <value>When this status was received by Omnichannel API</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryResult {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Err: ").Append(Err).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as DeliveryResult);
        }

        /// <summary>
        /// Returns true if DeliveryResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Err == input.Err ||
                    (this.Err != null &&
                    this.Err.Equals(input.Err))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Err != null)
                    hashCode = hashCode * 59 + this.Err.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }

}