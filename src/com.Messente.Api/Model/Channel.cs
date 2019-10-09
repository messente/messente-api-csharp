/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services. Use Messente API library to send and receive SMS, Viber, WhatsApp and Telegram messages, blacklist phone numbers to make sure you're not sending any unwanted messages, manage contacts and groups.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
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
    /// Defines the delivery channel
    /// </summary>
    /// <value>Defines the delivery channel</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Channel
    {
        /// <summary>
        /// Enum Sms for value: sms
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms = 1,

        /// <summary>
        /// Enum Viber for value: viber
        /// </summary>
        [EnumMember(Value = "viber")]
        Viber = 2,

        /// <summary>
        /// Enum Whatsapp for value: whatsapp
        /// </summary>
        [EnumMember(Value = "whatsapp")]
        Whatsapp = 3,

        /// <summary>
        /// Enum Telegram for value: telegram
        /// </summary>
        [EnumMember(Value = "telegram")]
        Telegram = 4

    }

}
