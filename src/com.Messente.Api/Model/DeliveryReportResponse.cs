/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.1.1
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
    /// A container for successful delivery report response
    /// </summary>
    [DataContract]
    public partial class DeliveryReportResponse :  IEquatable<DeliveryReportResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryReportResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeliveryReportResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryReportResponse" /> class.
        /// </summary>
        /// <param name="statuses">Contains the delivery reports for each channel, ordered by send order (required).</param>
        /// <param name="to">Phone number in e.164 format (required).</param>
        /// <param name="omnimessageId">Unique identifier for the omnimessage (required).</param>
        public DeliveryReportResponse(List<DeliveryResult> statuses = default(List<DeliveryResult>), string to = default(string), string omnimessageId = default(string))
        {
            // to ensure "statuses" is required (not null)
            if (statuses == null)
            {
                throw new InvalidDataException("statuses is a required property for DeliveryReportResponse and cannot be null");
            }
            else
            {
                this.Statuses = statuses;
            }
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for DeliveryReportResponse and cannot be null");
            }
            else
            {
                this.To = to;
            }
            // to ensure "omnimessageId" is required (not null)
            if (omnimessageId == null)
            {
                throw new InvalidDataException("omnimessageId is a required property for DeliveryReportResponse and cannot be null");
            }
            else
            {
                this.OmnimessageId = omnimessageId;
            }
        }
        
        /// <summary>
        /// Contains the delivery reports for each channel, ordered by send order
        /// </summary>
        /// <value>Contains the delivery reports for each channel, ordered by send order</value>
        [DataMember(Name="statuses", EmitDefaultValue=false)]
        public List<DeliveryResult> Statuses { get; set; }

        /// <summary>
        /// Phone number in e.164 format
        /// </summary>
        /// <value>Phone number in e.164 format</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Unique identifier for the omnimessage
        /// </summary>
        /// <value>Unique identifier for the omnimessage</value>
        [DataMember(Name="omnimessage_id", EmitDefaultValue=false)]
        public string OmnimessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryReportResponse {\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  OmnimessageId: ").Append(OmnimessageId).Append("\n");
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
            return this.Equals(input as DeliveryReportResponse);
        }

        /// <summary>
        /// Returns true if DeliveryReportResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryReportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryReportResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Statuses == input.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(input.Statuses)
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.OmnimessageId == input.OmnimessageId ||
                    (this.OmnimessageId != null &&
                    this.OmnimessageId.Equals(input.OmnimessageId))
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
                if (this.Statuses != null)
                    hashCode = hashCode * 59 + this.Statuses.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.OmnimessageId != null)
                    hashCode = hashCode * 59 + this.OmnimessageId.GetHashCode();
                return hashCode;
            }
        }
    }

}
