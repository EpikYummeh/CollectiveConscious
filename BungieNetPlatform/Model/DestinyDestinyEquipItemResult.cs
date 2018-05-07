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
    /// The results of an Equipping operation performed through the Destiny API.
    /// </summary>
    [DataContract]
    public partial class DestinyDestinyEquipItemResult :  IEquatable<DestinyDestinyEquipItemResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDestinyEquipItemResult" /> class.
        /// </summary>
        /// <param name="ItemInstanceId">The instance ID of the item in question (all items that can be equipped must, but definition, be Instanced and thus have an Instance ID that you can use to refer to them).</param>
        /// <param name="EquipStatus">A PlatformErrorCodes enum indicating whether it succeeded, and if it failed why..</param>
        public DestinyDestinyEquipItemResult(long? ItemInstanceId = default(long?), ExceptionsPlatformErrorCodes EquipStatus = default(ExceptionsPlatformErrorCodes))
        {
            this.ItemInstanceId = ItemInstanceId;
            this.EquipStatus = EquipStatus;
        }
        
        /// <summary>
        /// The instance ID of the item in question (all items that can be equipped must, but definition, be Instanced and thus have an Instance ID that you can use to refer to them)
        /// </summary>
        /// <value>The instance ID of the item in question (all items that can be equipped must, but definition, be Instanced and thus have an Instance ID that you can use to refer to them)</value>
        [DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
        public long? ItemInstanceId { get; set; }

        /// <summary>
        /// A PlatformErrorCodes enum indicating whether it succeeded, and if it failed why.
        /// </summary>
        /// <value>A PlatformErrorCodes enum indicating whether it succeeded, and if it failed why.</value>
        [DataMember(Name="equipStatus", EmitDefaultValue=false)]
        public ExceptionsPlatformErrorCodes EquipStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDestinyEquipItemResult {\n");
            sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
            sb.Append("  EquipStatus: ").Append(EquipStatus).Append("\n");
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
            return this.Equals(input as DestinyDestinyEquipItemResult);
        }

        /// <summary>
        /// Returns true if DestinyDestinyEquipItemResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDestinyEquipItemResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDestinyEquipItemResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemInstanceId == input.ItemInstanceId ||
                    (this.ItemInstanceId != null &&
                    this.ItemInstanceId.Equals(input.ItemInstanceId))
                ) && 
                (
                    this.EquipStatus == input.EquipStatus ||
                    (this.EquipStatus != null &&
                    this.EquipStatus.Equals(input.EquipStatus))
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
                if (this.ItemInstanceId != null)
                    hashCode = hashCode * 59 + this.ItemInstanceId.GetHashCode();
                if (this.EquipStatus != null)
                    hashCode = hashCode * 59 + this.EquipStatus.GetHashCode();
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