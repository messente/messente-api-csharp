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
    /// Info about a phone number
    /// </summary>
    [DataContract]
    public partial class SyncNumberLookupResult :  IEquatable<SyncNumberLookupResult>
    {
        /// <summary>
        /// Status of the phone number
        /// </summary>
        /// <value>Status of the phone number</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            [EnumMember(Value = "ON")]
            ON = 1,

            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            [EnumMember(Value = "OFF")]
            OFF = 2,

            /// <summary>
            /// Enum INVALID for value: INVALID
            /// </summary>
            [EnumMember(Value = "INVALID")]
            INVALID = 3,

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 4

        }

        /// <summary>
        /// Status of the phone number
        /// </summary>
        /// <value>Status of the phone number</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncNumberLookupResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SyncNumberLookupResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncNumberLookupResult" /> class.
        /// </summary>
        /// <param name="number">Phone number in e.164 format (required).</param>
        /// <param name="roaming">Indicates if a number is roaming.</param>
        /// <param name="ported">Indicates if a number is ported.</param>
        /// <param name="roamingNetwork">roamingNetwork.</param>
        /// <param name="currentNetwork">currentNetwork.</param>
        /// <param name="originalNetwork">originalNetwork.</param>
        /// <param name="portedNetwork">portedNetwork.</param>
        /// <param name="status">Status of the phone number.</param>
        /// <param name="error">Indicates if any error occurred while handling the request.</param>
        public SyncNumberLookupResult(string number = default(string), bool? roaming = default(bool?), bool? ported = default(bool?), MobileNetwork roamingNetwork = default(MobileNetwork), MobileNetwork currentNetwork = default(MobileNetwork), MobileNetwork originalNetwork = default(MobileNetwork), MobileNetwork portedNetwork = default(MobileNetwork), StatusEnum? status = default(StatusEnum?), Object error = default(Object))
        {
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for SyncNumberLookupResult and cannot be null");
            }
            else
            {
                this.Number = number;
            }
            this.Roaming = roaming;
            this.Ported = ported;
            this.RoamingNetwork = roamingNetwork;
            this.CurrentNetwork = currentNetwork;
            this.OriginalNetwork = originalNetwork;
            this.PortedNetwork = portedNetwork;
            this.Status = status;
            this.Error = error;
        }
        
        /// <summary>
        /// Phone number in e.164 format
        /// </summary>
        /// <value>Phone number in e.164 format</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Indicates if a number is roaming
        /// </summary>
        /// <value>Indicates if a number is roaming</value>
        [DataMember(Name="roaming", EmitDefaultValue=false)]
        public bool? Roaming { get; set; }

        /// <summary>
        /// Indicates if a number is ported
        /// </summary>
        /// <value>Indicates if a number is ported</value>
        [DataMember(Name="ported", EmitDefaultValue=false)]
        public bool? Ported { get; set; }

        /// <summary>
        /// Gets or Sets RoamingNetwork
        /// </summary>
        [DataMember(Name="roamingNetwork", EmitDefaultValue=false)]
        public MobileNetwork RoamingNetwork { get; set; }

        /// <summary>
        /// Gets or Sets CurrentNetwork
        /// </summary>
        [DataMember(Name="currentNetwork", EmitDefaultValue=false)]
        public MobileNetwork CurrentNetwork { get; set; }

        /// <summary>
        /// Gets or Sets OriginalNetwork
        /// </summary>
        [DataMember(Name="originalNetwork", EmitDefaultValue=false)]
        public MobileNetwork OriginalNetwork { get; set; }

        /// <summary>
        /// Gets or Sets PortedNetwork
        /// </summary>
        [DataMember(Name="portedNetwork", EmitDefaultValue=false)]
        public MobileNetwork PortedNetwork { get; set; }


        /// <summary>
        /// Indicates if any error occurred while handling the request
        /// </summary>
        /// <value>Indicates if any error occurred while handling the request</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Object Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncNumberLookupResult {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Roaming: ").Append(Roaming).Append("\n");
            sb.Append("  Ported: ").Append(Ported).Append("\n");
            sb.Append("  RoamingNetwork: ").Append(RoamingNetwork).Append("\n");
            sb.Append("  CurrentNetwork: ").Append(CurrentNetwork).Append("\n");
            sb.Append("  OriginalNetwork: ").Append(OriginalNetwork).Append("\n");
            sb.Append("  PortedNetwork: ").Append(PortedNetwork).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as SyncNumberLookupResult);
        }

        /// <summary>
        /// Returns true if SyncNumberLookupResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SyncNumberLookupResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncNumberLookupResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Roaming == input.Roaming ||
                    (this.Roaming != null &&
                    this.Roaming.Equals(input.Roaming))
                ) && 
                (
                    this.Ported == input.Ported ||
                    (this.Ported != null &&
                    this.Ported.Equals(input.Ported))
                ) && 
                (
                    this.RoamingNetwork == input.RoamingNetwork ||
                    (this.RoamingNetwork != null &&
                    this.RoamingNetwork.Equals(input.RoamingNetwork))
                ) && 
                (
                    this.CurrentNetwork == input.CurrentNetwork ||
                    (this.CurrentNetwork != null &&
                    this.CurrentNetwork.Equals(input.CurrentNetwork))
                ) && 
                (
                    this.OriginalNetwork == input.OriginalNetwork ||
                    (this.OriginalNetwork != null &&
                    this.OriginalNetwork.Equals(input.OriginalNetwork))
                ) && 
                (
                    this.PortedNetwork == input.PortedNetwork ||
                    (this.PortedNetwork != null &&
                    this.PortedNetwork.Equals(input.PortedNetwork))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Roaming != null)
                    hashCode = hashCode * 59 + this.Roaming.GetHashCode();
                if (this.Ported != null)
                    hashCode = hashCode * 59 + this.Ported.GetHashCode();
                if (this.RoamingNetwork != null)
                    hashCode = hashCode * 59 + this.RoamingNetwork.GetHashCode();
                if (this.CurrentNetwork != null)
                    hashCode = hashCode * 59 + this.CurrentNetwork.GetHashCode();
                if (this.OriginalNetwork != null)
                    hashCode = hashCode * 59 + this.OriginalNetwork.GetHashCode();
                if (this.PortedNetwork != null)
                    hashCode = hashCode * 59 + this.PortedNetwork.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }
    }

}
