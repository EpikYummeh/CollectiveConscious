/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.1.1
 * Contact: support@bungie.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = BungieNetPlatform.Client.SwaggerDateConverter;

namespace BungieNetPlatform.Model
{
    /// <summary>
    /// Defines Forum.ForumPostSortEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ForumForumPostSortEnum
    {
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "0")]
        Default,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "1")]
        OldestFirst
    }

}
