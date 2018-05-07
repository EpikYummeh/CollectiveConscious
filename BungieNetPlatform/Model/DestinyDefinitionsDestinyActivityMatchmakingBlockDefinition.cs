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
    /// Information about matchmaking and party size for the activity.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition :  IEquatable<DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition" /> class.
        /// </summary>
        /// <param name="IsMatchmade">If TRUE, the activity is matchmade. Otherwise, it requires explicit forming of a party..</param>
        /// <param name="MinParty">The minimum # of people in the fireteam for the activity to launch..</param>
        /// <param name="MaxParty">The maximum # of people allowed in a Fireteam..</param>
        /// <param name="MaxPlayers">The maximum # of people allowed across all teams in the activity..</param>
        /// <param name="RequiresGuardianOath">If true, you have to Solemnly Swear to be up to Nothing But Good(tm) to play..</param>
        public DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition(bool? IsMatchmade = default(bool?), int? MinParty = default(int?), int? MaxParty = default(int?), int? MaxPlayers = default(int?), bool? RequiresGuardianOath = default(bool?))
        {
            this.IsMatchmade = IsMatchmade;
            this.MinParty = MinParty;
            this.MaxParty = MaxParty;
            this.MaxPlayers = MaxPlayers;
            this.RequiresGuardianOath = RequiresGuardianOath;
        }
        
        /// <summary>
        /// If TRUE, the activity is matchmade. Otherwise, it requires explicit forming of a party.
        /// </summary>
        /// <value>If TRUE, the activity is matchmade. Otherwise, it requires explicit forming of a party.</value>
        [DataMember(Name="isMatchmade", EmitDefaultValue=false)]
        public bool? IsMatchmade { get; set; }

        /// <summary>
        /// The minimum # of people in the fireteam for the activity to launch.
        /// </summary>
        /// <value>The minimum # of people in the fireteam for the activity to launch.</value>
        [DataMember(Name="minParty", EmitDefaultValue=false)]
        public int? MinParty { get; set; }

        /// <summary>
        /// The maximum # of people allowed in a Fireteam.
        /// </summary>
        /// <value>The maximum # of people allowed in a Fireteam.</value>
        [DataMember(Name="maxParty", EmitDefaultValue=false)]
        public int? MaxParty { get; set; }

        /// <summary>
        /// The maximum # of people allowed across all teams in the activity.
        /// </summary>
        /// <value>The maximum # of people allowed across all teams in the activity.</value>
        [DataMember(Name="maxPlayers", EmitDefaultValue=false)]
        public int? MaxPlayers { get; set; }

        /// <summary>
        /// If true, you have to Solemnly Swear to be up to Nothing But Good(tm) to play.
        /// </summary>
        /// <value>If true, you have to Solemnly Swear to be up to Nothing But Good(tm) to play.</value>
        [DataMember(Name="requiresGuardianOath", EmitDefaultValue=false)]
        public bool? RequiresGuardianOath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition {\n");
            sb.Append("  IsMatchmade: ").Append(IsMatchmade).Append("\n");
            sb.Append("  MinParty: ").Append(MinParty).Append("\n");
            sb.Append("  MaxParty: ").Append(MaxParty).Append("\n");
            sb.Append("  MaxPlayers: ").Append(MaxPlayers).Append("\n");
            sb.Append("  RequiresGuardianOath: ").Append(RequiresGuardianOath).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMatchmade == input.IsMatchmade ||
                    (this.IsMatchmade != null &&
                    this.IsMatchmade.Equals(input.IsMatchmade))
                ) && 
                (
                    this.MinParty == input.MinParty ||
                    (this.MinParty != null &&
                    this.MinParty.Equals(input.MinParty))
                ) && 
                (
                    this.MaxParty == input.MaxParty ||
                    (this.MaxParty != null &&
                    this.MaxParty.Equals(input.MaxParty))
                ) && 
                (
                    this.MaxPlayers == input.MaxPlayers ||
                    (this.MaxPlayers != null &&
                    this.MaxPlayers.Equals(input.MaxPlayers))
                ) && 
                (
                    this.RequiresGuardianOath == input.RequiresGuardianOath ||
                    (this.RequiresGuardianOath != null &&
                    this.RequiresGuardianOath.Equals(input.RequiresGuardianOath))
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
                if (this.IsMatchmade != null)
                    hashCode = hashCode * 59 + this.IsMatchmade.GetHashCode();
                if (this.MinParty != null)
                    hashCode = hashCode * 59 + this.MinParty.GetHashCode();
                if (this.MaxParty != null)
                    hashCode = hashCode * 59 + this.MaxParty.GetHashCode();
                if (this.MaxPlayers != null)
                    hashCode = hashCode * 59 + this.MaxPlayers.GetHashCode();
                if (this.RequiresGuardianOath != null)
                    hashCode = hashCode * 59 + this.RequiresGuardianOath.GetHashCode();
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
