/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber, WhatsApp and Telegram messages, blacklist phone numbers to make sure you're not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.0.2
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
    /// Telegram message content
    /// </summary>
    [DataContract]
    public partial class Telegram :  IEquatable<Telegram>
    {
        /// <summary>
        /// The channel used to deliver the message
        /// </summary>
        /// <value>The channel used to deliver the message</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum Telegram for value: telegram
            /// </summary>
            [EnumMember(Value = "telegram")]
            Telegram = 1

        }

        /// <summary>
        /// The channel used to deliver the message
        /// </summary>
        /// <value>The channel used to deliver the message</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public ChannelEnum? Channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Telegram" /> class.
        /// </summary>
        /// <param name="sender">Phone number or alphanumeric sender name.</param>
        /// <param name="validity">After how many minutes this channel is considered as failed and the next channel is attempted.</param>
        /// <param name="text">Plaintext content for Telegram.</param>
        /// <param name="imageUrl">URL for the embedded image. Mutually exclusive with \&quot;document_url\&quot; and \&quot;audio_url\&quot;.</param>
        /// <param name="documentUrl">URL for the embedded image. Mutually exclusive with \&quot;audio_url\&quot; and \&quot;image_url\&quot;.</param>
        /// <param name="audioUrl">URL for the embedded image. Mutually exclusive with \&quot;document_url\&quot; and \&quot;image_url\&quot;.</param>
        /// <param name="channel">The channel used to deliver the message (default to ChannelEnum.Telegram).</param>
        public Telegram(string sender = default(string), int? validity = default(int?), string text = default(string), string imageUrl = default(string), string documentUrl = default(string), string audioUrl = default(string), ChannelEnum? channel = ChannelEnum.Telegram)
        {
            this.Sender = sender;
            this.Validity = validity;
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.DocumentUrl = documentUrl;
            this.AudioUrl = audioUrl;
            // use default value if no "channel" provided
            if (channel == null)
            {
                this.Channel = ChannelEnum.Telegram;
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
        /// After how many minutes this channel is considered as failed and the next channel is attempted
        /// </summary>
        /// <value>After how many minutes this channel is considered as failed and the next channel is attempted</value>
        [DataMember(Name="validity", EmitDefaultValue=false)]
        public int? Validity { get; set; }

        /// <summary>
        /// Plaintext content for Telegram
        /// </summary>
        /// <value>Plaintext content for Telegram</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// URL for the embedded image. Mutually exclusive with \&quot;document_url\&quot; and \&quot;audio_url\&quot;
        /// </summary>
        /// <value>URL for the embedded image. Mutually exclusive with \&quot;document_url\&quot; and \&quot;audio_url\&quot;</value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// URL for the embedded image. Mutually exclusive with \&quot;audio_url\&quot; and \&quot;image_url\&quot;
        /// </summary>
        /// <value>URL for the embedded image. Mutually exclusive with \&quot;audio_url\&quot; and \&quot;image_url\&quot;</value>
        [DataMember(Name="document_url", EmitDefaultValue=false)]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// URL for the embedded image. Mutually exclusive with \&quot;document_url\&quot; and \&quot;image_url\&quot;
        /// </summary>
        /// <value>URL for the embedded image. Mutually exclusive with \&quot;document_url\&quot; and \&quot;image_url\&quot;</value>
        [DataMember(Name="audio_url", EmitDefaultValue=false)]
        public string AudioUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Telegram {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  DocumentUrl: ").Append(DocumentUrl).Append("\n");
            sb.Append("  AudioUrl: ").Append(AudioUrl).Append("\n");
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
            return this.Equals(input as Telegram);
        }

        /// <summary>
        /// Returns true if Telegram instances are equal
        /// </summary>
        /// <param name="input">Instance of Telegram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Telegram input)
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
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.DocumentUrl == input.DocumentUrl ||
                    (this.DocumentUrl != null &&
                    this.DocumentUrl.Equals(input.DocumentUrl))
                ) && 
                (
                    this.AudioUrl == input.AudioUrl ||
                    (this.AudioUrl != null &&
                    this.AudioUrl.Equals(input.AudioUrl))
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
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.DocumentUrl != null)
                    hashCode = hashCode * 59 + this.DocumentUrl.GetHashCode();
                if (this.AudioUrl != null)
                    hashCode = hashCode * 59 + this.AudioUrl.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                return hashCode;
            }
        }
    }

}
