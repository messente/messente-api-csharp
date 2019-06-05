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
    /// Matches the following error title.   This field is a constant.    * 201 - Invalid data   * 202 - Unauthorized   * 203 - Missing resource   * 204 - Conflict   * 244 - Client error   * 205 - General error
    /// </summary>
    /// <value>Matches the following error title.   This field is a constant.    * 201 - Invalid data   * 202 - Unauthorized   * 203 - Missing resource   * 204 - Conflict   * 244 - Client error   * 205 - General error</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ErrorCodePhonebook
    {
        /// <summary>
        /// Enum _201 for value: 201
        /// </summary>
        [EnumMember(Value = "201")]
        _201 = 1,

        /// <summary>
        /// Enum _202 for value: 202
        /// </summary>
        [EnumMember(Value = "202")]
        _202 = 2,

        /// <summary>
        /// Enum _203 for value: 203
        /// </summary>
        [EnumMember(Value = "203")]
        _203 = 3,

        /// <summary>
        /// Enum _204 for value: 204
        /// </summary>
        [EnumMember(Value = "204")]
        _204 = 4,

        /// <summary>
        /// Enum _244 for value: 244
        /// </summary>
        [EnumMember(Value = "244")]
        _244 = 5,

        /// <summary>
        /// Enum _205 for value: 205
        /// </summary>
        [EnumMember(Value = "205")]
        _205 = 6

    }

}
