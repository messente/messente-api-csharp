/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.3.0
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
    /// A container for statistics report settings
    /// </summary>
    [DataContract]
    public partial class StatisticsReportSettings :  IEquatable<StatisticsReportSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsReportSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StatisticsReportSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsReportSettings" /> class.
        /// </summary>
        /// <param name="startDate">Start date for the report (required).</param>
        /// <param name="endDate">End date for the report (required).</param>
        /// <param name="messageTypes">Optional list of message types (sms, viber, whatsapp, hlr, telegram).</param>
        public StatisticsReportSettings(DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), List<string> messageTypes = default(List<string>))
        {
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for StatisticsReportSettings and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new InvalidDataException("endDate is a required property for StatisticsReportSettings and cannot be null");
            }
            else
            {
                this.EndDate = endDate;
            }
            this.MessageTypes = messageTypes;
        }
        
        /// <summary>
        /// Start date for the report
        /// </summary>
        /// <value>Start date for the report</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date for the report
        /// </summary>
        /// <value>End date for the report</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Optional list of message types (sms, viber, whatsapp, hlr, telegram)
        /// </summary>
        /// <value>Optional list of message types (sms, viber, whatsapp, hlr, telegram)</value>
        [DataMember(Name="message_types", EmitDefaultValue=false)]
        public List<string> MessageTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticsReportSettings {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  MessageTypes: ").Append(MessageTypes).Append("\n");
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
            return this.Equals(input as StatisticsReportSettings);
        }

        /// <summary>
        /// Returns true if StatisticsReportSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of StatisticsReportSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatisticsReportSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.MessageTypes == input.MessageTypes ||
                    this.MessageTypes != null &&
                    this.MessageTypes.SequenceEqual(input.MessageTypes)
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.MessageTypes != null)
                    hashCode = hashCode * 59 + this.MessageTypes.GetHashCode();
                return hashCode;
            }
        }
    }

}
