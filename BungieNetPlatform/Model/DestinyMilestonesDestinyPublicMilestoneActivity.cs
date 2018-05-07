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
    /// A milestone may have one or more conceptual Activities associated with it, and each of those conceptual activities could have a variety of variants, modes, tiers, what-have-you. Our attempts to determine what qualifies as a conceptual activity are, unfortunately, janky. So if you see missing modes or modes that don&#39;t seem appropriate to you, let us know and I&#39;ll buy you a beer if we ever meet up in person.
    /// </summary>
    [DataContract]
    public partial class DestinyMilestonesDestinyPublicMilestoneActivity :  IEquatable<DestinyMilestonesDestinyPublicMilestoneActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyPublicMilestoneActivity" /> class.
        /// </summary>
        /// <param name="ActivityHash">The hash identifier of the activity that&#39;s been chosen to be considered the canonical \&quot;conceptual\&quot; activity definition. This may have many variants, defined herein..</param>
        /// <param name="ModifierHashes">The activity may have 0-to-many modifiers: if it does, this will contain the hashes to the DestinyActivityModifierDefinition that defines the modifier being applied..</param>
        /// <param name="Variants">Every relevant variation of this conceptual activity, including the conceptual activity itself, have variants defined here..</param>
        public DestinyMilestonesDestinyPublicMilestoneActivity(uint? ActivityHash = default(uint?), List<uint?> ModifierHashes = default(List<uint?>), List<DestinyMilestonesDestinyPublicMilestoneActivityVariant> Variants = default(List<DestinyMilestonesDestinyPublicMilestoneActivityVariant>))
        {
            this.ActivityHash = ActivityHash;
            this.ModifierHashes = ModifierHashes;
            this.Variants = Variants;
        }
        
        /// <summary>
        /// The hash identifier of the activity that&#39;s been chosen to be considered the canonical \&quot;conceptual\&quot; activity definition. This may have many variants, defined herein.
        /// </summary>
        /// <value>The hash identifier of the activity that&#39;s been chosen to be considered the canonical \&quot;conceptual\&quot; activity definition. This may have many variants, defined herein.</value>
        [DataMember(Name="activityHash", EmitDefaultValue=false)]
        public uint? ActivityHash { get; set; }

        /// <summary>
        /// The activity may have 0-to-many modifiers: if it does, this will contain the hashes to the DestinyActivityModifierDefinition that defines the modifier being applied.
        /// </summary>
        /// <value>The activity may have 0-to-many modifiers: if it does, this will contain the hashes to the DestinyActivityModifierDefinition that defines the modifier being applied.</value>
        [DataMember(Name="modifierHashes", EmitDefaultValue=false)]
        public List<uint?> ModifierHashes { get; set; }

        /// <summary>
        /// Every relevant variation of this conceptual activity, including the conceptual activity itself, have variants defined here.
        /// </summary>
        /// <value>Every relevant variation of this conceptual activity, including the conceptual activity itself, have variants defined here.</value>
        [DataMember(Name="variants", EmitDefaultValue=false)]
        public List<DestinyMilestonesDestinyPublicMilestoneActivityVariant> Variants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyPublicMilestoneActivity {\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
            sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyPublicMilestoneActivity);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyPublicMilestoneActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyPublicMilestoneActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyPublicMilestoneActivity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivityHash == input.ActivityHash ||
                    (this.ActivityHash != null &&
                    this.ActivityHash.Equals(input.ActivityHash))
                ) && 
                (
                    this.ModifierHashes == input.ModifierHashes ||
                    this.ModifierHashes != null &&
                    this.ModifierHashes.SequenceEqual(input.ModifierHashes)
                ) && 
                (
                    this.Variants == input.Variants ||
                    this.Variants != null &&
                    this.Variants.SequenceEqual(input.Variants)
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
                if (this.ActivityHash != null)
                    hashCode = hashCode * 59 + this.ActivityHash.GetHashCode();
                if (this.ModifierHashes != null)
                    hashCode = hashCode * 59 + this.ModifierHashes.GetHashCode();
                if (this.Variants != null)
                    hashCode = hashCode * 59 + this.Variants.GetHashCode();
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
