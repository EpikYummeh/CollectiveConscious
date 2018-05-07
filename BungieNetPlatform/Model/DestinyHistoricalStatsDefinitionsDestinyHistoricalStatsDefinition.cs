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
    /// DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition
    /// </summary>
    [DataContract]
    public partial class DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition :  IEquatable<DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition>, IValidatableObject
    {
        /// <summary>
        /// Optional icon for the statistic
        /// </summary>
        /// <value>Optional icon for the statistic</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MergeMethodEnum
        {
            
            /// <summary>
            /// Enum Add for 0
            /// </summary>
            [EnumMember(Value = "0")]
            Add = 0,
            
            /// <summary>
            /// Enum Min for 1
            /// </summary>
            [EnumMember(Value = "1")]
            Min = 1,
            
            /// <summary>
            /// Enum Max for 2
            /// </summary>
            [EnumMember(Value = "2")]
            Max = 2
        }

        /// <summary>
        /// Optional icon for the statistic
        /// </summary>
        /// <value>Optional icon for the statistic</value>
        [DataMember(Name="mergeMethod", EmitDefaultValue=false)]
        public MergeMethodEnum? MergeMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition" /> class.
        /// </summary>
        /// <param name="StatId">Unique programmer friendly ID for this stat.</param>
        /// <param name="Group">Statistic group.</param>
        /// <param name="PeriodTypes">Time periods the statistic covers.</param>
        /// <param name="Modes">Game modes where this statistic can be reported..</param>
        /// <param name="Category">Category for the stat..</param>
        /// <param name="StatName">Display name.</param>
        /// <param name="StatDescription">Description of a stat if applicable..</param>
        /// <param name="UnitType">Unit, if any, for the statistic.</param>
        /// <param name="IconImage">Optional URI to an icon for the statistic.</param>
        /// <param name="MergeMethod">Optional icon for the statistic.</param>
        /// <param name="UnitLabel">Localized Unit Name for the stat..</param>
        /// <param name="Weight">Weight assigned to this stat indicating its relative impressiveness..</param>
        /// <param name="MedalTierHash">The tier associated with this medal - be it implicitly or explicitly..</param>
        public DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition(string StatId = default(string), DestinyHistoricalStatsDefinitionsDestinyStatsGroupType Group = default(DestinyHistoricalStatsDefinitionsDestinyStatsGroupType), List<DestinyHistoricalStatsDefinitionsPeriodType> PeriodTypes = default(List<DestinyHistoricalStatsDefinitionsPeriodType>), List<DestinyHistoricalStatsDefinitionsDestinyActivityModeType> Modes = default(List<DestinyHistoricalStatsDefinitionsDestinyActivityModeType>), DestinyHistoricalStatsDefinitionsDestinyStatsCategoryType Category = default(DestinyHistoricalStatsDefinitionsDestinyStatsCategoryType), string StatName = default(string), string StatDescription = default(string), DestinyHistoricalStatsDefinitionsUnitType UnitType = default(DestinyHistoricalStatsDefinitionsUnitType), string IconImage = default(string), MergeMethodEnum? MergeMethod = default(MergeMethodEnum?), string UnitLabel = default(string), int? Weight = default(int?), uint? MedalTierHash = default(uint?))
        {
            this.StatId = StatId;
            this.Group = Group;
            this.PeriodTypes = PeriodTypes;
            this.Modes = Modes;
            this.Category = Category;
            this.StatName = StatName;
            this.StatDescription = StatDescription;
            this.UnitType = UnitType;
            this.IconImage = IconImage;
            this.MergeMethod = MergeMethod;
            this.UnitLabel = UnitLabel;
            this.Weight = Weight;
            this.MedalTierHash = MedalTierHash;
        }
        
        /// <summary>
        /// Unique programmer friendly ID for this stat
        /// </summary>
        /// <value>Unique programmer friendly ID for this stat</value>
        [DataMember(Name="statId", EmitDefaultValue=false)]
        public string StatId { get; set; }

        /// <summary>
        /// Statistic group
        /// </summary>
        /// <value>Statistic group</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public DestinyHistoricalStatsDefinitionsDestinyStatsGroupType Group { get; set; }

        /// <summary>
        /// Time periods the statistic covers
        /// </summary>
        /// <value>Time periods the statistic covers</value>
        [DataMember(Name="periodTypes", EmitDefaultValue=false)]
        public List<DestinyHistoricalStatsDefinitionsPeriodType> PeriodTypes { get; set; }

        /// <summary>
        /// Game modes where this statistic can be reported.
        /// </summary>
        /// <value>Game modes where this statistic can be reported.</value>
        [DataMember(Name="modes", EmitDefaultValue=false)]
        public List<DestinyHistoricalStatsDefinitionsDestinyActivityModeType> Modes { get; set; }

        /// <summary>
        /// Category for the stat.
        /// </summary>
        /// <value>Category for the stat.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public DestinyHistoricalStatsDefinitionsDestinyStatsCategoryType Category { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        /// <value>Display name</value>
        [DataMember(Name="statName", EmitDefaultValue=false)]
        public string StatName { get; set; }

        /// <summary>
        /// Description of a stat if applicable.
        /// </summary>
        /// <value>Description of a stat if applicable.</value>
        [DataMember(Name="statDescription", EmitDefaultValue=false)]
        public string StatDescription { get; set; }

        /// <summary>
        /// Unit, if any, for the statistic
        /// </summary>
        /// <value>Unit, if any, for the statistic</value>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public DestinyHistoricalStatsDefinitionsUnitType UnitType { get; set; }

        /// <summary>
        /// Optional URI to an icon for the statistic
        /// </summary>
        /// <value>Optional URI to an icon for the statistic</value>
        [DataMember(Name="iconImage", EmitDefaultValue=false)]
        public string IconImage { get; set; }


        /// <summary>
        /// Localized Unit Name for the stat.
        /// </summary>
        /// <value>Localized Unit Name for the stat.</value>
        [DataMember(Name="unitLabel", EmitDefaultValue=false)]
        public string UnitLabel { get; set; }

        /// <summary>
        /// Weight assigned to this stat indicating its relative impressiveness.
        /// </summary>
        /// <value>Weight assigned to this stat indicating its relative impressiveness.</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// The tier associated with this medal - be it implicitly or explicitly.
        /// </summary>
        /// <value>The tier associated with this medal - be it implicitly or explicitly.</value>
        [DataMember(Name="medalTierHash", EmitDefaultValue=false)]
        public uint? MedalTierHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition {\n");
            sb.Append("  StatId: ").Append(StatId).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  PeriodTypes: ").Append(PeriodTypes).Append("\n");
            sb.Append("  Modes: ").Append(Modes).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  StatName: ").Append(StatName).Append("\n");
            sb.Append("  StatDescription: ").Append(StatDescription).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  IconImage: ").Append(IconImage).Append("\n");
            sb.Append("  MergeMethod: ").Append(MergeMethod).Append("\n");
            sb.Append("  UnitLabel: ").Append(UnitLabel).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  MedalTierHash: ").Append(MedalTierHash).Append("\n");
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
            return this.Equals(input as DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition);
        }

        /// <summary>
        /// Returns true if DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatId == input.StatId ||
                    (this.StatId != null &&
                    this.StatId.Equals(input.StatId))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.PeriodTypes == input.PeriodTypes ||
                    this.PeriodTypes != null &&
                    this.PeriodTypes.SequenceEqual(input.PeriodTypes)
                ) && 
                (
                    this.Modes == input.Modes ||
                    this.Modes != null &&
                    this.Modes.SequenceEqual(input.Modes)
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.StatName == input.StatName ||
                    (this.StatName != null &&
                    this.StatName.Equals(input.StatName))
                ) && 
                (
                    this.StatDescription == input.StatDescription ||
                    (this.StatDescription != null &&
                    this.StatDescription.Equals(input.StatDescription))
                ) && 
                (
                    this.UnitType == input.UnitType ||
                    (this.UnitType != null &&
                    this.UnitType.Equals(input.UnitType))
                ) && 
                (
                    this.IconImage == input.IconImage ||
                    (this.IconImage != null &&
                    this.IconImage.Equals(input.IconImage))
                ) && 
                (
                    this.MergeMethod == input.MergeMethod ||
                    (this.MergeMethod != null &&
                    this.MergeMethod.Equals(input.MergeMethod))
                ) && 
                (
                    this.UnitLabel == input.UnitLabel ||
                    (this.UnitLabel != null &&
                    this.UnitLabel.Equals(input.UnitLabel))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.MedalTierHash == input.MedalTierHash ||
                    (this.MedalTierHash != null &&
                    this.MedalTierHash.Equals(input.MedalTierHash))
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
                if (this.StatId != null)
                    hashCode = hashCode * 59 + this.StatId.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.PeriodTypes != null)
                    hashCode = hashCode * 59 + this.PeriodTypes.GetHashCode();
                if (this.Modes != null)
                    hashCode = hashCode * 59 + this.Modes.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.StatName != null)
                    hashCode = hashCode * 59 + this.StatName.GetHashCode();
                if (this.StatDescription != null)
                    hashCode = hashCode * 59 + this.StatDescription.GetHashCode();
                if (this.UnitType != null)
                    hashCode = hashCode * 59 + this.UnitType.GetHashCode();
                if (this.IconImage != null)
                    hashCode = hashCode * 59 + this.IconImage.GetHashCode();
                if (this.MergeMethod != null)
                    hashCode = hashCode * 59 + this.MergeMethod.GetHashCode();
                if (this.UnitLabel != null)
                    hashCode = hashCode * 59 + this.UnitLabel.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.MedalTierHash != null)
                    hashCode = hashCode * 59 + this.MedalTierHash.GetHashCode();
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
