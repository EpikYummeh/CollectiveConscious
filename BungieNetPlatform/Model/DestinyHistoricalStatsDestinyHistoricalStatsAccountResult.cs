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
    /// DestinyHistoricalStatsDestinyHistoricalStatsAccountResult
    /// </summary>
    [DataContract]
    public partial class DestinyHistoricalStatsDestinyHistoricalStatsAccountResult :  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsAccountResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyHistoricalStatsDestinyHistoricalStatsAccountResult" /> class.
        /// </summary>
        /// <param name="MergedDeletedCharacters">MergedDeletedCharacters.</param>
        /// <param name="MergedAllCharacters">MergedAllCharacters.</param>
        /// <param name="Characters">Characters.</param>
        public DestinyHistoricalStatsDestinyHistoricalStatsAccountResult(DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedDeletedCharacters = default(DestinyHistoricalStatsDestinyHistoricalStatsWithMerged), DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedAllCharacters = default(DestinyHistoricalStatsDestinyHistoricalStatsWithMerged), List<DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter> Characters = default(List<DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter>))
        {
            this.MergedDeletedCharacters = MergedDeletedCharacters;
            this.MergedAllCharacters = MergedAllCharacters;
            this.Characters = Characters;
        }
        
        /// <summary>
        /// Gets or Sets MergedDeletedCharacters
        /// </summary>
        [DataMember(Name="mergedDeletedCharacters", EmitDefaultValue=false)]
        public DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedDeletedCharacters { get; set; }

        /// <summary>
        /// Gets or Sets MergedAllCharacters
        /// </summary>
        [DataMember(Name="mergedAllCharacters", EmitDefaultValue=false)]
        public DestinyHistoricalStatsDestinyHistoricalStatsWithMerged MergedAllCharacters { get; set; }

        /// <summary>
        /// Gets or Sets Characters
        /// </summary>
        [DataMember(Name="characters", EmitDefaultValue=false)]
        public List<DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter> Characters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyHistoricalStatsDestinyHistoricalStatsAccountResult {\n");
            sb.Append("  MergedDeletedCharacters: ").Append(MergedDeletedCharacters).Append("\n");
            sb.Append("  MergedAllCharacters: ").Append(MergedAllCharacters).Append("\n");
            sb.Append("  Characters: ").Append(Characters).Append("\n");
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
            return this.Equals(input as DestinyHistoricalStatsDestinyHistoricalStatsAccountResult);
        }

        /// <summary>
        /// Returns true if DestinyHistoricalStatsDestinyHistoricalStatsAccountResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyHistoricalStatsDestinyHistoricalStatsAccountResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsAccountResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MergedDeletedCharacters == input.MergedDeletedCharacters ||
                    (this.MergedDeletedCharacters != null &&
                    this.MergedDeletedCharacters.Equals(input.MergedDeletedCharacters))
                ) && 
                (
                    this.MergedAllCharacters == input.MergedAllCharacters ||
                    (this.MergedAllCharacters != null &&
                    this.MergedAllCharacters.Equals(input.MergedAllCharacters))
                ) && 
                (
                    this.Characters == input.Characters ||
                    this.Characters != null &&
                    this.Characters.SequenceEqual(input.Characters)
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
                if (this.MergedDeletedCharacters != null)
                    hashCode = hashCode * 59 + this.MergedDeletedCharacters.GetHashCode();
                if (this.MergedAllCharacters != null)
                    hashCode = hashCode * 59 + this.MergedAllCharacters.GetHashCode();
                if (this.Characters != null)
                    hashCode = hashCode * 59 + this.Characters.GetHashCode();
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
