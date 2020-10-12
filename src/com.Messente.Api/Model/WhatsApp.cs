/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.4.0
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
    /// WhatsApp message content.   Only one of \&quot;text\&quot;, \&quot;image\&quot;, \&quot;document\&quot; or \&quot;audio\&quot; can be provided
    /// </summary>
    [DataContract]
    public partial class WhatsApp :  IEquatable<WhatsApp>
    {
        /// <summary>
        /// The channel used to deliver the message
        /// </summary>
        /// <value>The channel used to deliver the message</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum Whatsapp for value: whatsapp
            /// </summary>
            [EnumMember(Value = "whatsapp")]
            Whatsapp = 1

        }

        /// <summary>
        /// The channel used to deliver the message
        /// </summary>
        /// <value>The channel used to deliver the message</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public ChannelEnum? Channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsApp" /> class.
        /// </summary>
        /// <param name="sender">Phone number or alphanumeric sender name.</param>
        /// <param name="validity">After how many minutes this channel is   considered as failed and the next channel is attempted.</param>
        /// <param name="text">text.</param>
        /// <param name="image">image.</param>
        /// <param name="document">document.</param>
        /// <param name="audio">audio.</param>
        /// <param name="channel">The channel used to deliver the message (default to ChannelEnum.Whatsapp).</param>
        public WhatsApp(string sender = default(string), int? validity = default(int?), WhatsAppText text = default(WhatsAppText), WhatsAppImage image = default(WhatsAppImage), WhatsAppDocument document = default(WhatsAppDocument), WhatsAppAudio audio = default(WhatsAppAudio), ChannelEnum? channel = ChannelEnum.Whatsapp)
        {
            this.Sender = sender;
            this.Validity = validity;
            this.Text = text;
            this.Image = image;
            this.Document = document;
            this.Audio = audio;
            // use default value if no "channel" provided
            if (channel == null)
            {
                this.Channel = ChannelEnum.Whatsapp;
            }
            else
            {
                this.Channel = channel;
            }
        }
        
        /// <summary>
        /// Phone number or alphanumeric sender name
        /// </summary>
        /// <value>Phone number or alphanumeric sender name</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// After how many minutes this channel is   considered as failed and the next channel is attempted
        /// </summary>
        /// <value>After how many minutes this channel is   considered as failed and the next channel is attempted</value>
        [DataMember(Name="validity", EmitDefaultValue=false)]
        public int? Validity { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public WhatsAppText Text { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public WhatsAppImage Image { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public WhatsAppDocument Document { get; set; }

        /// <summary>
        /// Gets or Sets Audio
        /// </summary>
        [DataMember(Name="audio", EmitDefaultValue=false)]
        public WhatsAppAudio Audio { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsApp {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
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
            return this.Equals(input as WhatsApp);
        }

        /// <summary>
        /// Returns true if WhatsApp instances are equal
        /// </summary>
        /// <param name="input">Instance of WhatsApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsApp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Validity == input.Validity ||
                    (this.Validity != null &&
                    this.Validity.Equals(input.Validity))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
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
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Validity != null)
                    hashCode = hashCode * 59 + this.Validity.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                return hashCode;
            }
        }
    }

}
