/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber and WhatsApp messages, blacklist phone numbers to make sure you're not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 0.0.1
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
    /// Textual value which corresponds to ErrorCodeOmnichannel
    /// </summary>
    /// <value>Textual value which corresponds to ErrorCodeOmnichannel</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ErrorTitleOmnichannel
    {
        /// <summary>
        /// Enum Notfound for value: Not found
        /// </summary>
        [EnumMember(Value = "Not found")]
        Notfound = 1,

        /// <summary>
        /// Enum Forbidden for value: Forbidden
        /// </summary>
        [EnumMember(Value = "Forbidden")]
        Forbidden = 2,

        /// <summary>
        /// Enum Unauthorized for value: Unauthorized
        /// </summary>
        [EnumMember(Value = "Unauthorized")]
        Unauthorized = 3,

        /// <summary>
        /// Enum Invaliddata for value: Invalid data
        /// </summary>
        [EnumMember(Value = "Invalid data")]
        Invaliddata = 4,

        /// <summary>
        /// Enum InternalServerError for value: Internal Server Error
        /// </summary>
        [EnumMember(Value = "Internal Server Error")]
        InternalServerError = 5,

        /// <summary>
        /// Enum Missingdata for value: Missing data
        /// </summary>
        [EnumMember(Value = "Missing data")]
        Missingdata = 6,

        /// <summary>
        /// Enum Methodnotallowed for value: Method not allowed
        /// </summary>
        [EnumMember(Value = "Method not allowed")]
        Methodnotallowed = 7

    }

}