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
    /// In an attempt to categorize items by type, usage, and other interesting properties, we created DestinyItemCategoryDefinition: information about types that is assembled using a set of heuristics that examine the properties of an item such as what inventory bucket it&#39;s in, its item type name, and whether it has or is missing certain blocks of data.  This heuristic is imperfect, however. If you find an item miscategorized, let us know on the Bungie API forums!  We then populate all of the categories that we think an item belongs to in its DestinyInventoryItemDefinition.itemCategoryHashes property. You can use that to provide your own custom item filtering, sorting, aggregating... go nuts on it! And let us know if you see more categories that you wish would be added!
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyItemCategoryDefinition :  IEquatable<DestinyDefinitionsDestinyItemCategoryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemCategoryDefinition" /> class.
        /// </summary>
        /// <param name="DisplayProperties">DisplayProperties.</param>
        /// <param name="Visible">If True, this category should be visible in UI. Sometimes we make categories that we don&#39;t think are interesting externally. It&#39;s up to you if you want to skip on showing them..</param>
        /// <param name="ShortTitle">A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn&#39;t exist for D2... yet..</param>
        /// <param name="ItemTypeRegex">The janky regular expression we used against the item type to try and discern whether the item belongs to this category..</param>
        /// <param name="ItemTypeRegexNot">If the item type matches this janky regex, it does *not* belong to this category..</param>
        /// <param name="OriginBucketIdentifier">If the item belongs to this bucket, it does belong to this category..</param>
        /// <param name="GrantDestinyItemType">If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that&#39;s a story that requires more alcohol..</param>
        /// <param name="GrantDestinySubType">If an item belongs to this category, it will also receive this subtype enum value.  I know what you&#39;re thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \&quot;grant\&quot; enums. Now you can see one reason why we moved away from these enums... but they&#39;re so convenient when they work, aren&#39;t they?.</param>
        /// <param name="GrantDestinyClass">If an item belongs to this category, it will also get this class restriction enum value.  See the other \&quot;grant\&quot;-prefixed properties on this definition for my color commentary..</param>
        /// <param name="GroupedCategoryHashes">If this category is a \&quot;parent\&quot; category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That&#39;s what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday).</param>
        /// <param name="Hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="Index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="Redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsDestinyItemCategoryDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), bool? Visible = default(bool?), string ShortTitle = default(string), string ItemTypeRegex = default(string), string ItemTypeRegexNot = default(string), string OriginBucketIdentifier = default(string), DestinyDestinyItemType GrantDestinyItemType = default(DestinyDestinyItemType), DestinyDestinyItemSubType GrantDestinySubType = default(DestinyDestinyItemSubType), DestinyDestinyClass GrantDestinyClass = default(DestinyDestinyClass), List<uint?> GroupedCategoryHashes = default(List<uint?>), uint? Hash = default(uint?), int? Index = default(int?), bool? Redacted = default(bool?))
        {
            this.DisplayProperties = DisplayProperties;
            this.Visible = Visible;
            this.ShortTitle = ShortTitle;
            this.ItemTypeRegex = ItemTypeRegex;
            this.ItemTypeRegexNot = ItemTypeRegexNot;
            this.OriginBucketIdentifier = OriginBucketIdentifier;
            this.GrantDestinyItemType = GrantDestinyItemType;
            this.GrantDestinySubType = GrantDestinySubType;
            this.GrantDestinyClass = GrantDestinyClass;
            this.GroupedCategoryHashes = GroupedCategoryHashes;
            this.Hash = Hash;
            this.Index = Index;
            this.Redacted = Redacted;
        }
        
        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// If True, this category should be visible in UI. Sometimes we make categories that we don&#39;t think are interesting externally. It&#39;s up to you if you want to skip on showing them.
        /// </summary>
        /// <value>If True, this category should be visible in UI. Sometimes we make categories that we don&#39;t think are interesting externally. It&#39;s up to you if you want to skip on showing them.</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn&#39;t exist for D2... yet.
        /// </summary>
        /// <value>A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn&#39;t exist for D2... yet.</value>
        [DataMember(Name="shortTitle", EmitDefaultValue=false)]
        public string ShortTitle { get; set; }

        /// <summary>
        /// The janky regular expression we used against the item type to try and discern whether the item belongs to this category.
        /// </summary>
        /// <value>The janky regular expression we used against the item type to try and discern whether the item belongs to this category.</value>
        [DataMember(Name="itemTypeRegex", EmitDefaultValue=false)]
        public string ItemTypeRegex { get; set; }

        /// <summary>
        /// If the item type matches this janky regex, it does *not* belong to this category.
        /// </summary>
        /// <value>If the item type matches this janky regex, it does *not* belong to this category.</value>
        [DataMember(Name="itemTypeRegexNot", EmitDefaultValue=false)]
        public string ItemTypeRegexNot { get; set; }

        /// <summary>
        /// If the item belongs to this bucket, it does belong to this category.
        /// </summary>
        /// <value>If the item belongs to this bucket, it does belong to this category.</value>
        [DataMember(Name="originBucketIdentifier", EmitDefaultValue=false)]
        public string OriginBucketIdentifier { get; set; }

        /// <summary>
        /// If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that&#39;s a story that requires more alcohol.
        /// </summary>
        /// <value>If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that&#39;s a story that requires more alcohol.</value>
        [DataMember(Name="grantDestinyItemType", EmitDefaultValue=false)]
        public DestinyDestinyItemType GrantDestinyItemType { get; set; }

        /// <summary>
        /// If an item belongs to this category, it will also receive this subtype enum value.  I know what you&#39;re thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \&quot;grant\&quot; enums. Now you can see one reason why we moved away from these enums... but they&#39;re so convenient when they work, aren&#39;t they?
        /// </summary>
        /// <value>If an item belongs to this category, it will also receive this subtype enum value.  I know what you&#39;re thinking - what if it belongs to multiple categories that provide sub-types?  The last one processed wins, as is the case with all of these \&quot;grant\&quot; enums. Now you can see one reason why we moved away from these enums... but they&#39;re so convenient when they work, aren&#39;t they?</value>
        [DataMember(Name="grantDestinySubType", EmitDefaultValue=false)]
        public DestinyDestinyItemSubType GrantDestinySubType { get; set; }

        /// <summary>
        /// If an item belongs to this category, it will also get this class restriction enum value.  See the other \&quot;grant\&quot;-prefixed properties on this definition for my color commentary.
        /// </summary>
        /// <value>If an item belongs to this category, it will also get this class restriction enum value.  See the other \&quot;grant\&quot;-prefixed properties on this definition for my color commentary.</value>
        [DataMember(Name="grantDestinyClass", EmitDefaultValue=false)]
        public DestinyDestinyClass GrantDestinyClass { get; set; }

        /// <summary>
        /// If this category is a \&quot;parent\&quot; category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That&#39;s what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday)
        /// </summary>
        /// <value>If this category is a \&quot;parent\&quot; category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.  In this way, you can build up a visual hierarchy of item categories. That&#39;s what we did, and you can do it too. I believe in you. Yes, you, Carl.  (I hope someone named Carl reads this someday)</value>
        [DataMember(Name="groupedCategoryHashes", EmitDefaultValue=false)]
        public List<uint?> GroupedCategoryHashes { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public uint? Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        /// <value>The index of the entity as it was found in the investment tables.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
        [DataMember(Name="redacted", EmitDefaultValue=false)]
        public bool? Redacted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemCategoryDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  ShortTitle: ").Append(ShortTitle).Append("\n");
            sb.Append("  ItemTypeRegex: ").Append(ItemTypeRegex).Append("\n");
            sb.Append("  ItemTypeRegexNot: ").Append(ItemTypeRegexNot).Append("\n");
            sb.Append("  OriginBucketIdentifier: ").Append(OriginBucketIdentifier).Append("\n");
            sb.Append("  GrantDestinyItemType: ").Append(GrantDestinyItemType).Append("\n");
            sb.Append("  GrantDestinySubType: ").Append(GrantDestinySubType).Append("\n");
            sb.Append("  GrantDestinyClass: ").Append(GrantDestinyClass).Append("\n");
            sb.Append("  GroupedCategoryHashes: ").Append(GroupedCategoryHashes).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyDefinitionsDestinyItemCategoryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemCategoryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemCategoryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemCategoryDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
                ) && 
                (
                    this.ShortTitle == input.ShortTitle ||
                    (this.ShortTitle != null &&
                    this.ShortTitle.Equals(input.ShortTitle))
                ) && 
                (
                    this.ItemTypeRegex == input.ItemTypeRegex ||
                    (this.ItemTypeRegex != null &&
                    this.ItemTypeRegex.Equals(input.ItemTypeRegex))
                ) && 
                (
                    this.ItemTypeRegexNot == input.ItemTypeRegexNot ||
                    (this.ItemTypeRegexNot != null &&
                    this.ItemTypeRegexNot.Equals(input.ItemTypeRegexNot))
                ) && 
                (
                    this.OriginBucketIdentifier == input.OriginBucketIdentifier ||
                    (this.OriginBucketIdentifier != null &&
                    this.OriginBucketIdentifier.Equals(input.OriginBucketIdentifier))
                ) && 
                (
                    this.GrantDestinyItemType == input.GrantDestinyItemType ||
                    (this.GrantDestinyItemType != null &&
                    this.GrantDestinyItemType.Equals(input.GrantDestinyItemType))
                ) && 
                (
                    this.GrantDestinySubType == input.GrantDestinySubType ||
                    (this.GrantDestinySubType != null &&
                    this.GrantDestinySubType.Equals(input.GrantDestinySubType))
                ) && 
                (
                    this.GrantDestinyClass == input.GrantDestinyClass ||
                    (this.GrantDestinyClass != null &&
                    this.GrantDestinyClass.Equals(input.GrantDestinyClass))
                ) && 
                (
                    this.GroupedCategoryHashes == input.GroupedCategoryHashes ||
                    this.GroupedCategoryHashes != null &&
                    this.GroupedCategoryHashes.SequenceEqual(input.GroupedCategoryHashes)
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Redacted == input.Redacted ||
                    (this.Redacted != null &&
                    this.Redacted.Equals(input.Redacted))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DisplayProperties != null)
                    hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
                if (this.ShortTitle != null)
                    hashCode = hashCode * 59 + this.ShortTitle.GetHashCode();
                if (this.ItemTypeRegex != null)
                    hashCode = hashCode * 59 + this.ItemTypeRegex.GetHashCode();
                if (this.ItemTypeRegexNot != null)
                    hashCode = hashCode * 59 + this.ItemTypeRegexNot.GetHashCode();
                if (this.OriginBucketIdentifier != null)
                    hashCode = hashCode * 59 + this.OriginBucketIdentifier.GetHashCode();
                if (this.GrantDestinyItemType != null)
                    hashCode = hashCode * 59 + this.GrantDestinyItemType.GetHashCode();
                if (this.GrantDestinySubType != null)
                    hashCode = hashCode * 59 + this.GrantDestinySubType.GetHashCode();
                if (this.GrantDestinyClass != null)
                    hashCode = hashCode * 59 + this.GrantDestinyClass.GetHashCode();
                if (this.GroupedCategoryHashes != null)
                    hashCode = hashCode * 59 + this.GroupedCategoryHashes.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Redacted != null)
                    hashCode = hashCode * 59 + this.Redacted.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
