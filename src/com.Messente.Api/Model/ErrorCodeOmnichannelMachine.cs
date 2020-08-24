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
    /// Machine-readable error code, &#39;null&#39; when the message has not been processed yet  Matches the following meanings    * 0 - No error   * 1 - Delivery failure   * 2 - Sending message expired   * 3 - Invalid number   * 4 - Error crediting account   * 5 - Invalid number format   * 6 - Too many identical messages   * 7 - Sender name not allowed   * 8 - Operator blacklisted   * 9 - Unroutable   * 10 - Seen   * 999 - General temporary error
    /// </summary>
    /// <value>Machine-readable error code, &#39;null&#39; when the message has not been processed yet  Matches the following meanings    * 0 - No error   * 1 - Delivery failure   * 2 - Sending message expired   * 3 - Invalid number   * 4 - Error crediting account   * 5 - Invalid number format   * 6 - Too many identical messages   * 7 - Sender name not allowed   * 8 - Operator blacklisted   * 9 - Unroutable   * 10 - Seen   * 999 - General temporary error</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ErrorCodeOmnichannelMachine
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 2,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 3,

        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        NUMBER_3 = 4,

        /// <summary>
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        [EnumMember(Value = "4")]
        NUMBER_4 = 5,

        /// <summary>
        /// Enum NUMBER_5 for value: 5
        /// </summary>
        [EnumMember(Value = "5")]
        NUMBER_5 = 6,

        /// <summary>
        /// Enum NUMBER_6 for value: 6
        /// </summary>
        [EnumMember(Value = "6")]
        NUMBER_6 = 7,

        /// <summary>
        /// Enum NUMBER_7 for value: 7
        /// </summary>
        [EnumMember(Value = "7")]
        NUMBER_7 = 8,

        /// <summary>
        /// Enum NUMBER_8 for value: 8
        /// </summary>
        [EnumMember(Value = "8")]
        NUMBER_8 = 9,

        /// <summary>
        /// Enum NUMBER_9 for value: 9
        /// </summary>
        [EnumMember(Value = "9")]
        NUMBER_9 = 10,

        /// <summary>
        /// Enum NUMBER_10 for value: 10
        /// </summary>
        [EnumMember(Value = "10")]
        NUMBER_10 = 11,

        /// <summary>
        /// Enum NUMBER_999 for value: 999
        /// </summary>
        [EnumMember(Value = "999")]
        NUMBER_999 = 12

    }

}
