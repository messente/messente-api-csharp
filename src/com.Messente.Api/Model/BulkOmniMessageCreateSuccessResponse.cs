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
    /// Response received after successfully created bulk omnimessage.
    /// </summary>
    [DataContract(Name = "BulkOmniMessageCreateSuccessResponse")]
    public partial class BulkOmniMessageCreateSuccessResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOmniMessageCreateSuccessResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkOmniMessageCreateSuccessResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkOmniMessageCreateSuccessResponse" /> class.
        /// </summary>
        /// <param name="messages">List of responses for each Omnimessage in the bulk. These can be errors or successful responses (required).</param>
        public BulkOmniMessageCreateSuccessResponse(List<BulkOmniMessageCreateSuccessResponseMessagesInner> messages = default(List<BulkOmniMessageCreateSuccessResponseMessagesInner>))
        {
            // to ensure "messages" is required (not null)
            if (messages == null)
            {
                throw new ArgumentNullException("messages is a required property for BulkOmniMessageCreateSuccessResponse and cannot be null");
            }
            this.Messages = messages;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// List of responses for each Omnimessage in the bulk. These can be errors or successful responses
        /// </summary>
        /// <value>List of responses for each Omnimessage in the bulk. These can be errors or successful responses</value>
        [DataMember(Name = "messages", IsRequired = true, EmitDefaultValue = true)]
        public List<BulkOmniMessageCreateSuccessResponseMessagesInner> Messages { get; set; }

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
            sb.Append("class BulkOmniMessageCreateSuccessResponse {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
