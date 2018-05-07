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
    /// TrendingTrendingEntryDestinyActivity
    /// </summary>
    [DataContract]
    public partial class TrendingTrendingEntryDestinyActivity :  IEquatable<TrendingTrendingEntryDestinyActivity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTrendingEntryDestinyActivity" /> class.
        /// </summary>
        /// <param name="ActivityHash">ActivityHash.</param>
        /// <param name="Status">Status.</param>
        public TrendingTrendingEntryDestinyActivity(uint? ActivityHash = default(uint?), DestinyActivitiesDestinyPublicActivityStatus Status = default(DestinyActivitiesDestinyPublicActivityStatus))
        {
            this.ActivityHash = ActivityHash;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets ActivityHash
        /// </summary>
        [DataMember(Name="activityHash", EmitDefaultValue=false)]
        public uint? ActivityHash { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public DestinyActivitiesDestinyPublicActivityStatus Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrendingTrendingEntryDestinyActivity {\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as TrendingTrendingEntryDestinyActivity);
        }

        /// <summary>
        /// Returns true if TrendingTrendingEntryDestinyActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of TrendingTrendingEntryDestinyActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrendingTrendingEntryDestinyActivity input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
