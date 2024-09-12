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
    /// Info about the network related to the phone number
    /// </summary>
    [DataContract(Name = "MobileNetwork")]
    public partial class MobileNetwork : IValidatableObject
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
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Mobile country and mobile network code
        /// </summary>
        /// <value>Mobile country and mobile network code</value>
        [DataMember(Name = "mccmnc", EmitDefaultValue = false)]
        public string Mccmnc { get; set; }

        /// <summary>
        /// Mobile network name
        /// </summary>
        /// <value>Mobile network name</value>
        [DataMember(Name = "networkName", EmitDefaultValue = false)]
        public string NetworkName { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name = "countryName", EmitDefaultValue = false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Country prefix
        /// </summary>
        /// <value>Country prefix</value>
        [DataMember(Name = "countryPrefix", EmitDefaultValue = false)]
        public string CountryPrefix { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        /// <value>Country code</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

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
            sb.Append("class MobileNetwork {\n");
            sb.Append("  Mccmnc: ").Append(Mccmnc).Append("\n");
            sb.Append("  NetworkName: ").Append(NetworkName).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  CountryPrefix: ").Append(CountryPrefix).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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