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
    /// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
    /// </summary>
    /// <value>This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinyDestinyItemSubType
    {
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "0")]
        None,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "1")]
        Crucible,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "2")]
        Vanguard,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "5")]
        Exotic,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "6")]
        AutoRifle,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "7")]
        Shotgun,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "8")]
        Machinegun,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "9")]
        HandCannon,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "10")]
        RocketLauncher,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "11")]
        FusionRifle,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "12")]
        SniperRifle,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "13")]
        PulseRifle,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "14")]
        ScoutRifle,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "16")]
        Crm,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "17")]
        Sidearm,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "18")]
        Sword,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "19")]
        Mask,
        
		/// <summary>
		/// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
		/// </summary>
		[EnumMember(Value = "20")]
        Shader
    }

}
