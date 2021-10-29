/* 
 * Messente API
 *
 * [Messente](https://messente.com) is a global provider of messaging and user verification services.  * Send and receive SMS, Viber, WhatsApp and Telegram messages. * Manage contacts and groups. * Fetch detailed info about phone numbers. * Blacklist phone numbers to make sure you're not sending any unwanted messages.  Messente builds [tools](https://messente.com/documentation) to help organizations connect their services to people anywhere in the world.
 *
 * OpenAPI spec version: 2.0.0
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
    /// The human-readable equivalent for this field is contained in \&quot;error\&quot;.   This value is *null* if the message is still being processed
    /// </summary>
    /// <value>The human-readable equivalent for this field is contained in \&quot;error\&quot;.   This value is *null* if the message is still being processed</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Status
    {
        /// <summary>
        /// Enum ACK for value: ACK
        /// </summary>
        [EnumMember(Value = "ACK")]
        ACK = 1,

        /// <summary>
        /// Enum DELIVRD for value: DELIVRD
        /// </summary>
        [EnumMember(Value = "DELIVRD")]
        DELIVRD = 2,

        /// <summary>
        /// Enum UNDELIV for value: UNDELIV
        /// </summary>
        [EnumMember(Value = "UNDELIV")]
        UNDELIV = 3,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 4,

        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 5,

        /// <summary>
        /// Enum ACCEPTD for value: ACCEPTD
        /// </summary>
        [EnumMember(Value = "ACCEPTD")]
        ACCEPTD = 6,

        /// <summary>
        /// Enum REJECTD for value: REJECTD
        /// </summary>
        [EnumMember(Value = "REJECTD")]
        REJECTD = 7,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 8,

        /// <summary>
        /// Enum EXPIRED for value: EXPIRED
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED = 9,

        /// <summary>
        /// Enum NACK for value: NACK
        /// </summary>
        [EnumMember(Value = "NACK")]
        NACK = 10,

        /// <summary>
        /// Enum SEEN for value: SEEN
        /// </summary>
        [EnumMember(Value = "SEEN")]
        SEEN = 11

    }

}
