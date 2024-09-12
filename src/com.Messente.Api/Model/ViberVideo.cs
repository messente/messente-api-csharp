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
    /// Viber video object
    /// </summary>
    [DataContract(Name = "ViberVideo")]
    public partial class ViberVideo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViberVideo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ViberVideo()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViberVideo" /> class.
        /// </summary>
        /// <param name="url">URL pointing to the video resource. (required).</param>
        /// <param name="thumbnail">URL pointing to the video thumbnail resource. (required).</param>
        /// <param name="fileSize">Size of the video file in bytes. Cannot be larger than 200MB. (required).</param>
        /// <param name="duration">Duration of the video in seconds. Cannot be longer than 600 seconds. (required).</param>
        public ViberVideo(string url = default(string), string thumbnail = default(string), int fileSize = default(int), List<WhatsAppParameter> duration = default(List<WhatsAppParameter>))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for ViberVideo and cannot be null");
            }
            this.Url = url;
            // to ensure "thumbnail" is required (not null)
            if (thumbnail == null)
            {
                throw new ArgumentNullException("thumbnail is a required property for ViberVideo and cannot be null");
            }
            this.Thumbnail = thumbnail;
            this.FileSize = fileSize;
            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new ArgumentNullException("duration is a required property for ViberVideo and cannot be null");
            }
            this.Duration = duration;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// URL pointing to the video resource.
        /// </summary>
        /// <value>URL pointing to the video resource.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// URL pointing to the video thumbnail resource.
        /// </summary>
        /// <value>URL pointing to the video thumbnail resource.</value>
        [DataMember(Name = "thumbnail", IsRequired = true, EmitDefaultValue = true)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Size of the video file in bytes. Cannot be larger than 200MB.
        /// </summary>
        /// <value>Size of the video file in bytes. Cannot be larger than 200MB.</value>
        [DataMember(Name = "file_size", IsRequired = true, EmitDefaultValue = true)]
        public int FileSize { get; set; }

        /// <summary>
        /// Duration of the video in seconds. Cannot be longer than 600 seconds.
        /// </summary>
        /// <value>Duration of the video in seconds. Cannot be longer than 600 seconds.</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public List<WhatsAppParameter> Duration { get; set; }

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
            sb.Append("class ViberVideo {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
