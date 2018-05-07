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
    /// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
    /// </summary>
    /// <value>As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinySpecialItemType
    {
        
		/// <summary>
		/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "0")]
        None,
        
		/// <summary>
		/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "1")]
        SpecialCurrency,
        
		/// <summary>
		/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "8")]
        Armor,
        
		/// <summary>
		/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "9")]
        Weapon,
        
		/// <summary>
		/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "23")]
        Engram,
        
		/// <summary>
		/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "24")]
        Consumable,
        
		/// <summary>
		/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "25")]
        ExchangeMaterial,
        
		/// <summary>
		/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "27")]
        MissionReward,
        
		/// <summary>
		/// As you run into items that need to be classified for Milestone purposes in ways that we cannot infer via Babel or Bonbobo-sourced data, add a new classification here and use a string constant to represent it in the local item config file.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "29")]
        Currency
    }

}
