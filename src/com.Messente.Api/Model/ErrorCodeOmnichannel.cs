/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber, WhatsApp and Telegram messages, blacklist phone numbers to make sure you're not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 1.1.0
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
    /// Matches the following error title.   This field is a constant    * 101 - Not found   * 102 - Forbidden   * 103 - Unauthorized   * 104 - Internal Server Error   * 105 - Invalid data   * 106 - Missing data   * 107 - Method not allowed
    /// </summary>
    /// <value>Matches the following error title.   This field is a constant    * 101 - Not found   * 102 - Forbidden   * 103 - Unauthorized   * 104 - Internal Server Error   * 105 - Invalid data   * 106 - Missing data   * 107 - Method not allowed</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ErrorCodeOmnichannel
    {
        /// <summary>
        /// Enum _101 for value: 101
        /// </summary>
        [EnumMember(Value = "101")]
        _101 = 1,

        /// <summary>
        /// Enum _102 for value: 102
        /// </summary>
        [EnumMember(Value = "102")]
        _102 = 2,

        /// <summary>
        /// Enum _103 for value: 103
        /// </summary>
        [EnumMember(Value = "103")]
        _103 = 3,

        /// <summary>
        /// Enum _104 for value: 104
        /// </summary>
        [EnumMember(Value = "104")]
        _104 = 4,

        /// <summary>
        /// Enum _105 for value: 105
        /// </summary>
        [EnumMember(Value = "105")]
        _105 = 5,

        /// <summary>
        /// Enum _106 for value: 106
        /// </summary>
        [EnumMember(Value = "106")]
        _106 = 6,

        /// <summary>
        /// Enum _107 for value: 107
        /// </summary>
        [EnumMember(Value = "107")]
        _107 = 7

    }

}
