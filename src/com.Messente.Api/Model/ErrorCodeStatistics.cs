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
    /// Matches the following error title.   This field is a constant  * 100 - Client Error * 103 - Unauthorized * 104 - Invalid data * 105 - Internal Server Error
    /// </summary>
    /// <value>Matches the following error title.   This field is a constant  * 100 - Client Error * 103 - Unauthorized * 104 - Invalid data * 105 - Internal Server Error</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ErrorCodeStatistics
    {
        /// <summary>
        /// Enum _100 for value: 100
        /// </summary>
        [EnumMember(Value = "100")]
        _100 = 1,

        /// <summary>
        /// Enum _103 for value: 103
        /// </summary>
        [EnumMember(Value = "103")]
        _103 = 2,

        /// <summary>
        /// Enum _104 for value: 104
        /// </summary>
        [EnumMember(Value = "104")]
        _104 = 3,

        /// <summary>
        /// Enum _105 for value: 105
        /// </summary>
        [EnumMember(Value = "105")]
        _105 = 4
    }

}
