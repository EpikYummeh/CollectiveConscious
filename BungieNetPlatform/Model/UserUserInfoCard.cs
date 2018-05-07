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
    /// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
    /// </summary>
    [DataContract]
    public partial class UserUserInfoCard :  IEquatable<UserUserInfoCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUserInfoCard" /> class.
        /// </summary>
        /// <param name="SupplementalDisplayName">A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc..</param>
        /// <param name="IconPath">URL the Icon if available..</param>
        /// <param name="MembershipType">Type of the membership..</param>
        /// <param name="MembershipId">Membership ID as they user is known in the Accounts service.</param>
        /// <param name="DisplayName">Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API..</param>
        public UserUserInfoCard(string SupplementalDisplayName = default(string), string IconPath = default(string), BungieMembershipType MembershipType = default(BungieMembershipType), long? MembershipId = default(long?), string DisplayName = default(string))
        {
            this.SupplementalDisplayName = SupplementalDisplayName;
            this.IconPath = IconPath;
            this.MembershipType = MembershipType;
            this.MembershipId = MembershipId;
            this.DisplayName = DisplayName;
        }
        
        /// <summary>
        /// A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.
        /// </summary>
        /// <value>A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.</value>
        [DataMember(Name="supplementalDisplayName", EmitDefaultValue=false)]
        public string SupplementalDisplayName { get; set; }

        /// <summary>
        /// URL the Icon if available.
        /// </summary>
        /// <value>URL the Icon if available.</value>
        [DataMember(Name="iconPath", EmitDefaultValue=false)]
        public string IconPath { get; set; }

        /// <summary>
        /// Type of the membership.
        /// </summary>
        /// <value>Type of the membership.</value>
        [DataMember(Name="membershipType", EmitDefaultValue=false)]
        public BungieMembershipType MembershipType { get; set; }

        /// <summary>
        /// Membership ID as they user is known in the Accounts service
        /// </summary>
        /// <value>Membership ID as they user is known in the Accounts service</value>
        [DataMember(Name="membershipId", EmitDefaultValue=false)]
        public long? MembershipId { get; set; }

        /// <summary>
        /// Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.
        /// </summary>
        /// <value>Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUserInfoCard {\n");
            sb.Append("  SupplementalDisplayName: ").Append(SupplementalDisplayName).Append("\n");
            sb.Append("  IconPath: ").Append(IconPath).Append("\n");
            sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
            sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(input as UserUserInfoCard);
        }

        /// <summary>
        /// Returns true if UserUserInfoCard instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUserInfoCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUserInfoCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupplementalDisplayName == input.SupplementalDisplayName ||
                    (this.SupplementalDisplayName != null &&
                    this.SupplementalDisplayName.Equals(input.SupplementalDisplayName))
                ) && 
                (
                    this.IconPath == input.IconPath ||
                    (this.IconPath != null &&
                    this.IconPath.Equals(input.IconPath))
                ) && 
                (
                    this.MembershipType == input.MembershipType ||
                    (this.MembershipType != null &&
                    this.MembershipType.Equals(input.MembershipType))
                ) && 
                (
                    this.MembershipId == input.MembershipId ||
                    (this.MembershipId != null &&
                    this.MembershipId.Equals(input.MembershipId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.SupplementalDisplayName != null)
                    hashCode = hashCode * 59 + this.SupplementalDisplayName.GetHashCode();
                if (this.IconPath != null)
                    hashCode = hashCode * 59 + this.IconPath.GetHashCode();
                if (this.MembershipType != null)
                    hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
                if (this.MembershipId != null)
                    hashCode = hashCode * 59 + this.MembershipId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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