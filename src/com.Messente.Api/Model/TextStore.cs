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
    /// Whether to store message content as is (plaintext), as a hashed value (sha256) or not at all (nostore)
    /// </summary>
    /// <value>Whether to store message content as is (plaintext), as a hashed value (sha256) or not at all (nostore)</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextStore
    {
        /// <summary>
        /// Enum Nostore for value: nostore
        /// </summary>
        [EnumMember(Value = "nostore")]
        Nostore = 1,

        /// <summary>
        /// Enum Plaintext for value: plaintext
        /// </summary>
        [EnumMember(Value = "plaintext")]
        Plaintext = 2,

        /// <summary>
        /// Enum Sha256 for value: sha256
        /// </summary>
        [EnumMember(Value = "sha256")]
        Sha256 = 3
    }

}
