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
    /// A container for number lookup response
    /// </summary>
    [DataContract(Name = "SyncNumberLookupSuccess")]
    public partial class SyncNumberLookupSuccess : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncNumberLookupSuccess" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SyncNumberLookupSuccess()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncNumberLookupSuccess" /> class.
        /// </summary>
        /// <param name="requestId">ID of the request (required).</param>
        /// <param name="result">A container for phone number info objects (required).</param>
        public SyncNumberLookupSuccess(string requestId = default(string), List<SyncNumberLookupResult> result = default(List<SyncNumberLookupResult>))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for SyncNumberLookupSuccess and cannot be null");
            }
            this.RequestId = requestId;
            // to ensure "result" is required (not null)
            if (result == null)
            {
                throw new ArgumentNullException("result is a required property for SyncNumberLookupSuccess and cannot be null");
            }
            this.Result = result;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// ID of the request
        /// </summary>
        /// <value>ID of the request</value>
        [DataMember(Name = "request_id", IsRequired = true, EmitDefaultValue = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// A container for phone number info objects
        /// </summary>
        /// <value>A container for phone number info objects</value>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = true)]
        public List<SyncNumberLookupResult> Result { get; set; }

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
            sb.Append("class SyncNumberLookupSuccess {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
