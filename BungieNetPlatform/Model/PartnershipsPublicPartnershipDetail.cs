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
    /// All the partnership info that&#39;s fit to expose externally, if we care to do so.
    /// </summary>
    [DataContract]
    public partial class PartnershipsPublicPartnershipDetail :  IEquatable<PartnershipsPublicPartnershipDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnershipsPublicPartnershipDetail" /> class.
        /// </summary>
        /// <param name="PartnerType">PartnerType.</param>
        /// <param name="Identifier">Identifier.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Icon">Icon.</param>
        public PartnershipsPublicPartnershipDetail(PartnershipsPartnershipType PartnerType = default(PartnershipsPartnershipType), string Identifier = default(string), string Name = default(string), string Icon = default(string))
        {
            this.PartnerType = PartnerType;
            this.Identifier = Identifier;
            this.Name = Name;
            this.Icon = Icon;
        }
        
        /// <summary>
        /// Gets or Sets PartnerType
        /// </summary>
        [DataMember(Name="partnerType", EmitDefaultValue=false)]
        public PartnershipsPartnershipType PartnerType { get; set; }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartnershipsPublicPartnershipDetail {\n");
            sb.Append("  PartnerType: ").Append(PartnerType).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
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
            return this.Equals(input as PartnershipsPublicPartnershipDetail);
        }

        /// <summary>
        /// Returns true if PartnershipsPublicPartnershipDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PartnershipsPublicPartnershipDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnershipsPublicPartnershipDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PartnerType == input.PartnerType ||
                    (this.PartnerType != null &&
                    this.PartnerType.Equals(input.PartnerType))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
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
                if (this.PartnerType != null)
                    hashCode = hashCode * 59 + this.PartnerType.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
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
