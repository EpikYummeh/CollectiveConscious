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
    /// BNet&#39;s custom categorization of reward sources. We took a look at the existing ways that items could be spawned, and tried to make high-level categorizations of them. This needs to be re-evaluated for Destiny 2.
    /// </summary>
    /// <value>BNet&#39;s custom categorization of reward sources. We took a look at the existing ways that items could be spawned, and tried to make high-level categorizations of them. This needs to be re-evaluated for Destiny 2.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinyDefinitionsDestinyRewardSourceCategory
    {
        
		/// <summary>
		/// The source doesn&#39;t fit well into any of the other types.
		/// </summary>
		[EnumMember(Value = "0")]
        None,
        
		/// <summary>
		/// The source is directly related to the rewards gained by playing an activity or set of activities. This currently includes Quests and other action in-game.
		/// </summary>
		[EnumMember(Value = "1")]
        Activity,
        
		/// <summary>
		/// This source is directly related to items that Vendors sell.
		/// </summary>
		[EnumMember(Value = "2")]
        Vendor,
        
		/// <summary>
		/// This source is a custom aggregation of items that can be earned in many ways, but that share some other property in common that is useful to share. For instance, in Destiny 1 we would make &quot;Reward Sources&quot; for every game expansion: that way, you could search reward sources to see what items became available with any given Expansion.
		/// </summary>
		[EnumMember(Value = "3")]
        Aggregate
    }

}
