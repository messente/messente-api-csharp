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
    /// Info about the network related to the phone number
    /// </summary>
    [DataContract]
    public partial class MobileNetwork :  IEquatable<MobileNetwork>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileNetwork" /> class.
        /// </summary>
        /// <param name="mccmnc">Mobile country and mobile network code.</param>
        /// <param name="networkName">Mobile network name.</param>
        /// <param name="countryName">Country name.</param>
        /// <param name="countryPrefix">Country prefix.</param>
        /// <param name="countryCode">Country code.</param>
        public MobileNetwork(string mccmnc = default(string), string networkName = default(string), string countryName = default(string), string countryPrefix = default(string), string countryCode = default(string))
        {
            this.Mccmnc = mccmnc;
            this.NetworkName = networkName;
            this.CountryName = countryName;
            this.CountryPrefix = countryPrefix;
            this.CountryCode = countryCode;
        }
        
        /// <summary>
        /// Mobile country and mobile network code
        /// </summary>
        /// <value>Mobile country and mobile network code</value>
        [DataMember(Name="mccmnc", EmitDefaultValue=false)]
        public string Mccmnc { get; set; }

        /// <summary>
        /// Mobile network name
        /// </summary>
        /// <value>Mobile network name</value>
        [DataMember(Name="networkName", EmitDefaultValue=false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Country prefix
        /// </summary>
        /// <value>Country prefix</value>
        [DataMember(Name="countryPrefix", EmitDefaultValue=false)]
        public string CountryPrefix { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        /// <value>Country code</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobileNetwork {\n");
            sb.Append("  Mccmnc: ").Append(Mccmnc).Append("\n");
            sb.Append("  NetworkName: ").Append(NetworkName).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  CountryPrefix: ").Append(CountryPrefix).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as MobileNetwork);
        }

        /// <summary>
        /// Returns true if MobileNetwork instances are equal
        /// </summary>
        /// <param name="input">Instance of MobileNetwork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mccmnc == input.Mccmnc ||
                    (this.Mccmnc != null &&
                    this.Mccmnc.Equals(input.Mccmnc))
                ) && 
                (
                    this.NetworkName == input.NetworkName ||
                    (this.NetworkName != null &&
                    this.NetworkName.Equals(input.NetworkName))
                ) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
                ) && 
                (
                    this.CountryPrefix == input.CountryPrefix ||
                    (this.CountryPrefix != null &&
                    this.CountryPrefix.Equals(input.CountryPrefix))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                if (this.Mccmnc != null)
                    hashCode = hashCode * 59 + this.Mccmnc.GetHashCode();
                if (this.NetworkName != null)
                    hashCode = hashCode * 59 + this.NetworkName.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
                if (this.CountryPrefix != null)
                    hashCode = hashCode * 59 + this.CountryPrefix.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                return hashCode;
            }
        }
    }

}