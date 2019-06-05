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
    /// Viber message content
    /// </summary>
    [DataContract]
    public partial class Viber :  IEquatable<Viber>
    {
        /// <summary>
        /// The channel used to deliver the message
        /// </summary>
        /// <value>The channel used to deliver the message</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum Viber for value: viber
            /// </summary>
            [EnumMember(Value = "viber")]
            Viber = 1

        }

        /// <summary>
        /// The channel used to deliver the message
        /// </summary>
        /// <value>The channel used to deliver the message</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public ChannelEnum? Channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Viber" /> class.
        /// </summary>
        /// <param name="sender">Phone number or alphanumeric sender name.</param>
        /// <param name="validity">After how many minutes this channel is considered as failed and the next channel is attempted.</param>
        /// <param name="text">Plaintext content for Viber.</param>
        /// <param name="imageUrl">URL for the embedded image.    Valid combinations:    1) image_url,    2) text, image_url, button_url, button_text.</param>
        /// <param name="buttonUrl">URL of the button, must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_text&#39;&#39; and &#39;&#39;image_url&#39;&#39; (optional).</param>
        /// <param name="buttonText">Must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_url&#39;&#39;, &#39;&#39;button_text&#39;&#39;, &#39;&#39;image_url&#39;&#39; (optional).</param>
        /// <param name="channel">The channel used to deliver the message (default to ChannelEnum.Viber).</param>
        public Viber(string sender = default(string), int? validity = default(int?), string text = default(string), string imageUrl = default(string), string buttonUrl = default(string), string buttonText = default(string), ChannelEnum? channel = ChannelEnum.Viber)
        {
            this.Sender = sender;
            this.Validity = validity;
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.ButtonUrl = buttonUrl;
            this.ButtonText = buttonText;
            // use default value if no "channel" provided
            if (channel == null)
            {
                this.Channel = ChannelEnum.Viber;
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
        /// Plaintext content for Viber
        /// </summary>
        /// <value>Plaintext content for Viber</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// URL for the embedded image.    Valid combinations:    1) image_url,    2) text, image_url, button_url, button_text
        /// </summary>
        /// <value>URL for the embedded image.    Valid combinations:    1) image_url,    2) text, image_url, button_url, button_text</value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// URL of the button, must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_text&#39;&#39; and &#39;&#39;image_url&#39;&#39; (optional)
        /// </summary>
        /// <value>URL of the button, must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_text&#39;&#39; and &#39;&#39;image_url&#39;&#39; (optional)</value>
        [DataMember(Name="button_url", EmitDefaultValue=false)]
        public string ButtonUrl { get; set; }

        /// <summary>
        /// Must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_url&#39;&#39;, &#39;&#39;button_text&#39;&#39;, &#39;&#39;image_url&#39;&#39; (optional)
        /// </summary>
        /// <value>Must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_url&#39;&#39;, &#39;&#39;button_text&#39;&#39;, &#39;&#39;image_url&#39;&#39; (optional)</value>
        [DataMember(Name="button_text", EmitDefaultValue=false)]
        public string ButtonText { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Viber {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ButtonUrl: ").Append(ButtonUrl).Append("\n");
            sb.Append("  ButtonText: ").Append(ButtonText).Append("\n");
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
            return this.Equals(input as Viber);
        }

        /// <summary>
        /// Returns true if Viber instances are equal
        /// </summary>
        /// <param name="input">Instance of Viber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Viber input)
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
                    this.ButtonUrl == input.ButtonUrl ||
                    (this.ButtonUrl != null &&
                    this.ButtonUrl.Equals(input.ButtonUrl))
                ) && 
                (
                    this.ButtonText == input.ButtonText ||
                    (this.ButtonText != null &&
                    this.ButtonText.Equals(input.ButtonText))
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
                if (this.ButtonUrl != null)
                    hashCode = hashCode * 59 + this.ButtonUrl.GetHashCode();
                if (this.ButtonText != null)
                    hashCode = hashCode * 59 + this.ButtonText.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                return hashCode;
            }
        }
    }

}
