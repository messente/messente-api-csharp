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
    /// An omnimessage
    /// </summary>
    [DataContract]
    public partial class Omnimessage :  IEquatable<Omnimessage>
    {
        /// <summary>
        /// Gets or Sets TextStore
        /// </summary>
        [DataMember(Name="text_store", EmitDefaultValue=false)]
        public TextStore? TextStore { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Omnimessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Omnimessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Omnimessage" /> class.
        /// </summary>
        /// <param name="to">Phone number in e.164 format (required).</param>
        /// <param name="messages">An array of messages (required).</param>
        /// <param name="dlrUrl">URL where the delivery report will be sent.</param>
        /// <param name="textStore">textStore.</param>
        /// <param name="timeToSend">Optional parameter for sending messages at some specific time in the future.   Time must be specified in the ISO-8601 format.   If no timezone is specified, then the timezone is assumed to be UTC.    Examples:    * Time specified with timezone: 2018-06-22T09:05:07+00:00 Time specified in UTC: 2018-06-22T09:05:07Z   * Time specified without timezone: 2018-06-22T09:05 (equivalent to 2018-06-22T09:05+00:00).</param>
        public Omnimessage(string to = default(string), List<Object> messages = default(List<Object>), string dlrUrl = default(string), TextStore? textStore = default(TextStore?), DateTime? timeToSend = default(DateTime?))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for Omnimessage and cannot be null");
            }
            else
            {
                this.To = to;
            }
            // to ensure "messages" is required (not null)
            if (messages == null)
            {
                throw new InvalidDataException("messages is a required property for Omnimessage and cannot be null");
            }
            else
            {
                this.Messages = messages;
            }
            this.DlrUrl = dlrUrl;
            this.TextStore = textStore;
            this.TimeToSend = timeToSend;
        }
        
        /// <summary>
        /// Phone number in e.164 format
        /// </summary>
        /// <value>Phone number in e.164 format</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// An array of messages
        /// </summary>
        /// <value>An array of messages</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<Object> Messages { get; set; }

        /// <summary>
        /// URL where the delivery report will be sent
        /// </summary>
        /// <value>URL where the delivery report will be sent</value>
        [DataMember(Name="dlr_url", EmitDefaultValue=false)]
        public string DlrUrl { get; set; }


        /// <summary>
        /// Optional parameter for sending messages at some specific time in the future.   Time must be specified in the ISO-8601 format.   If no timezone is specified, then the timezone is assumed to be UTC.    Examples:    * Time specified with timezone: 2018-06-22T09:05:07+00:00 Time specified in UTC: 2018-06-22T09:05:07Z   * Time specified without timezone: 2018-06-22T09:05 (equivalent to 2018-06-22T09:05+00:00)
        /// </summary>
        /// <value>Optional parameter for sending messages at some specific time in the future.   Time must be specified in the ISO-8601 format.   If no timezone is specified, then the timezone is assumed to be UTC.    Examples:    * Time specified with timezone: 2018-06-22T09:05:07+00:00 Time specified in UTC: 2018-06-22T09:05:07Z   * Time specified without timezone: 2018-06-22T09:05 (equivalent to 2018-06-22T09:05+00:00)</value>
        [DataMember(Name="time_to_send", EmitDefaultValue=false)]
        public DateTime? TimeToSend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Omnimessage {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  DlrUrl: ").Append(DlrUrl).Append("\n");
            sb.Append("  TextStore: ").Append(TextStore).Append("\n");
            sb.Append("  TimeToSend: ").Append(TimeToSend).Append("\n");
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
            return this.Equals(input as Omnimessage);
        }

        /// <summary>
        /// Returns true if Omnimessage instances are equal
        /// </summary>
        /// <param name="input">Instance of Omnimessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Omnimessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.DlrUrl == input.DlrUrl ||
                    (this.DlrUrl != null &&
                    this.DlrUrl.Equals(input.DlrUrl))
                ) && 
                (
                    this.TextStore == input.TextStore ||
                    (this.TextStore != null &&
                    this.TextStore.Equals(input.TextStore))
                ) && 
                (
                    this.TimeToSend == input.TimeToSend ||
                    (this.TimeToSend != null &&
                    this.TimeToSend.Equals(input.TimeToSend))
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
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.DlrUrl != null)
                    hashCode = hashCode * 59 + this.DlrUrl.GetHashCode();
                if (this.TextStore != null)
                    hashCode = hashCode * 59 + this.TextStore.GetHashCode();
                if (this.TimeToSend != null)
                    hashCode = hashCode * 59 + this.TimeToSend.GetHashCode();
                return hashCode;
            }
        }
    }

}
