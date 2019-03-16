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
    /// Textual value which corresponds to ErrorCodePhonebook
    /// </summary>
    /// <value>Textual value which corresponds to ErrorCodePhonebook</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ErrorTitlePhonebook
    {
        /// <summary>
        /// Enum Invaliddata for value: Invalid data
        /// </summary>
        [EnumMember(Value = "Invalid data")]
        Invaliddata = 1,

        /// <summary>
        /// Enum Unauthorized for value: Unauthorized
        /// </summary>
        [EnumMember(Value = "Unauthorized")]
        Unauthorized = 2,

        /// <summary>
        /// Enum Missingresource for value: Missing resource
        /// </summary>
        [EnumMember(Value = "Missing resource")]
        Missingresource = 3,

        /// <summary>
        /// Enum Conflict for value: Conflict
        /// </summary>
        [EnumMember(Value = "Conflict")]
        Conflict = 4,

        /// <summary>
        /// Enum Clienterror for value: Client error
        /// </summary>
        [EnumMember(Value = "Client error")]
        Clienterror = 5,

        /// <summary>
        /// Enum Generalerror for value: General error
        /// </summary>
        [EnumMember(Value = "General error")]
        Generalerror = 6

    }

}
