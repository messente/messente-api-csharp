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
    /// Set the priority of the message.   Messages are processed starting with in highest priority queue first and lowest priority queue last.   This for example allows to prioritize OTP messages over marketing traffic.    Possible values:  - low - regular - high    
    /// </summary>
    /// <value>Set the priority of the message.   Messages are processed starting with in highest priority queue first and lowest priority queue last.   This for example allows to prioritize OTP messages over marketing traffic.    Possible values:  - low - regular - high    </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Priority
    {
        /// <summary>
        /// Enum Low for value: low
        /// </summary>
        [EnumMember(Value = "low")]
        Low = 1,

        /// <summary>
        /// Enum Regular for value: regular
        /// </summary>
        [EnumMember(Value = "regular")]
        Regular = 2,

        /// <summary>
        /// Enum High for value: high
        /// </summary>
        [EnumMember(Value = "high")]
        High = 3

    }

}
