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
    /// Viber message content
    /// </summary>
    [DataContract(Name = "Viber")]
    public partial class Viber : IValidatableObject
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
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public ChannelEnum? Channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Viber" /> class.
        /// </summary>
        /// <param name="sender">Phone number or alphanumeric sender name.</param>
        /// <param name="validity">After how many minutes this channel is considered as failed and the next channel is attempted.       Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used..</param>
        /// <param name="ttl">After how many seconds this channel is considered as failed and the next channel is attempted.       Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used..</param>
        /// <param name="text">Plaintext content for Viber.</param>
        /// <param name="imageUrl">URL for the embedded image    Valid combinations:    1) image_url,    2) text, image_url, button_url, button_text.</param>
        /// <param name="buttonUrl">URL of the button, must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_text&#39;&#39; and &#39;&#39;image_url&#39;&#39; (optional).</param>
        /// <param name="buttonText">Must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_url&#39;&#39;, &#39;&#39;button_text&#39;&#39;, &#39;&#39;image_url&#39;&#39; (optional).</param>
        /// <param name="channel">The channel used to deliver the message (default to ChannelEnum.Viber).</param>
        /// <param name="video">video.</param>
        public Viber(string sender = default(string), int validity = default(int), int ttl = default(int), string text = default(string), string imageUrl = default(string), string buttonUrl = default(string), string buttonText = default(string), ChannelEnum? channel = ChannelEnum.Viber, ViberVideo video = default(ViberVideo))
        {
            this.Sender = sender;
            this.Validity = validity;
            this.Ttl = ttl;
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.ButtonUrl = buttonUrl;
            this.ButtonText = buttonText;
            this.Channel = channel;
            this.Video = video;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Phone number or alphanumeric sender name
        /// </summary>
        /// <value>Phone number or alphanumeric sender name</value>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// After how many minutes this channel is considered as failed and the next channel is attempted.       Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used.
        /// </summary>
        /// <value>After how many minutes this channel is considered as failed and the next channel is attempted.       Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used.</value>
        /// <example>360</example>
        [DataMember(Name = "validity", EmitDefaultValue = false)]
        public int Validity { get; set; }

        /// <summary>
        /// After how many seconds this channel is considered as failed and the next channel is attempted.       Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used.
        /// </summary>
        /// <value>After how many seconds this channel is considered as failed and the next channel is attempted.       Only one of \&quot;ttl\&quot; and \&quot;validity\&quot; can be used.</value>
        /// <example>21600</example>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public int Ttl { get; set; }

        /// <summary>
        /// Plaintext content for Viber
        /// </summary>
        /// <value>Plaintext content for Viber</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// URL for the embedded image    Valid combinations:    1) image_url,    2) text, image_url, button_url, button_text
        /// </summary>
        /// <value>URL for the embedded image    Valid combinations:    1) image_url,    2) text, image_url, button_url, button_text</value>
        [DataMember(Name = "image_url", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// URL of the button, must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_text&#39;&#39; and &#39;&#39;image_url&#39;&#39; (optional)
        /// </summary>
        /// <value>URL of the button, must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_text&#39;&#39; and &#39;&#39;image_url&#39;&#39; (optional)</value>
        [DataMember(Name = "button_url", EmitDefaultValue = false)]
        public string ButtonUrl { get; set; }

        /// <summary>
        /// Must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_url&#39;&#39;, &#39;&#39;button_text&#39;&#39;, &#39;&#39;image_url&#39;&#39; (optional)
        /// </summary>
        /// <value>Must be specified along with &#39;&#39;text&#39;&#39;, &#39;&#39;button_url&#39;&#39;, &#39;&#39;button_text&#39;&#39;, &#39;&#39;image_url&#39;&#39; (optional)</value>
        [DataMember(Name = "button_text", EmitDefaultValue = false)]
        public string ButtonText { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name = "video", EmitDefaultValue = false)]
        public ViberVideo Video { get; set; }

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
            sb.Append("class Viber {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ButtonUrl: ").Append(ButtonUrl).Append("\n");
            sb.Append("  ButtonText: ").Append(ButtonText).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
