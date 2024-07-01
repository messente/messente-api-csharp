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
    /// Whatsapp media object.
    /// </summary>
    [DataContract(Name = "WhatsAppMedia")]
    public partial class WhatsAppMedia : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppMedia" /> class.
        /// </summary>
        /// <param name="id">The media object ID. Do not use this field when message type is set to text..</param>
        /// <param name="link">The protocol and URL of the media to be sent. Use only with HTTP/HTTPS URLs.       Do not use this field when message type is set to text..</param>
        /// <param name="caption">Media asset caption. Do not use with audio or sticker media..</param>
        /// <param name="filename">Describes the filename for the specific document. Use only with document media..</param>
        public WhatsAppMedia(string id = default(string), string link = default(string), string caption = default(string), string filename = default(string))
        {
            this.Id = id;
            this.Link = link;
            this.Caption = caption;
            this.Filename = filename;
        }

        /// <summary>
        /// The media object ID. Do not use this field when message type is set to text.
        /// </summary>
        /// <value>The media object ID. Do not use this field when message type is set to text.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The protocol and URL of the media to be sent. Use only with HTTP/HTTPS URLs.       Do not use this field when message type is set to text.
        /// </summary>
        /// <value>The protocol and URL of the media to be sent. Use only with HTTP/HTTPS URLs.       Do not use this field when message type is set to text.</value>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// Media asset caption. Do not use with audio or sticker media.
        /// </summary>
        /// <value>Media asset caption. Do not use with audio or sticker media.</value>
        [DataMember(Name = "caption", EmitDefaultValue = false)]
        public string Caption { get; set; }

        /// <summary>
        /// Describes the filename for the specific document. Use only with document media.
        /// </summary>
        /// <value>Describes the filename for the specific document. Use only with document media.</value>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        public string Filename { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WhatsAppMedia {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
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
