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
    /// This defines the properties of a \&quot;Talent Node Step\&quot;. When you see a talent node in game, the actual visible properties that you see (its icon, description, the perks and stats it provides) are not provided by the Node itself, but rather by the currently active Step on the node.  When a Talent Node is activated, the currently active step&#39;s benefits are conferred upon the item and character.  The currently active step on talent nodes are determined when an item is first instantiated. Sometimes it is random, sometimes it is more deterministic (particularly when a node has only a single step).  Note that, when dealing with Talent Node Steps, you must ensure that you have the latest version of content. stepIndex and nodeStepHash - two ways of identifying the step within a node - are both content version dependent, and thus are subject to change between content updates.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyNodeStepDefinition :  IEquatable<DestinyDefinitionsDestinyNodeStepDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyNodeStepDefinition" /> class.
        /// </summary>
        /// <param name="DisplayProperties">These are the display properties actually used to render the Talent Node. The currently active step&#39;s displayProperties are shown..</param>
        /// <param name="StepIndex">The index of this step in the list of Steps on the Talent Node.  Unfortunately, this is the closest thing we have to an identifier for the Step: steps are not provided a content version agnostic identifier. This means that, when you are dealing with talent nodes, you will need to first ensure that you have the latest version of content..</param>
        /// <param name="NodeStepHash">The hash of this node step. Unfortunately, while it can be used to uniquely identify the step within a node, it is also content version dependent and should not be relied on without ensuring you have the latest vesion of content..</param>
        /// <param name="InteractionDescription">If you can interact with this node in some way, this is the localized description of that interaction..</param>
        /// <param name="DamageType">An enum representing a damage type granted by activating this step, if any..</param>
        /// <param name="DamageTypeHash">If the step provides a damage type, this will be the hash identifier used to look up the damage type&#39;s DestinyDamageTypeDefinition..</param>
        /// <param name="ActivationRequirement">If the step has requirements for activation (they almost always do, if nothing else than for the Talent Grid&#39;s Progression to have reached a certain level), they will be defined here..</param>
        /// <param name="CanActivateNextStep">There was a time when talent nodes could be activated multiple times, and the effects of subsequent Steps would be compounded on each other, essentially \&quot;upgrading\&quot; the node. We have moved away from this, but theoretically the capability still exists.  I continue to return this in case it is used in the future: if true and this step is the current step in the node, you are allowed to activate the node a second time to receive the benefits of the next step in the node, which will then become the active step..</param>
        /// <param name="NextStepIndex">The stepIndex of the next step in the talent node, or -1 if this is the last step or if the next step to be chosen is random.  This doesn&#39;t really matter anymore unless canActivateNextStep begins to be used again..</param>
        /// <param name="IsNextStepRandom">If true, the next step to be chosen is random, and if you&#39;re allowed to activate the next step. (if canActivateNextStep &#x3D; true).</param>
        /// <param name="PerkHashes">The list of hash identifiers for Perks (DestinySandboxPerkDefinition) that are applied when this step is active. Perks provide a variety of benefits and modifications - examine DestinySandboxPerkDefinition to learn more..</param>
        /// <param name="StartProgressionBarAtProgress">When the Talent Grid&#39;s progression reaches this value, the circular \&quot;progress bar\&quot; that surrounds the talent node should be shown.  This also indicates the lower bound of said progress bar, with the upper bound being the progress required to reach activationRequirement.gridLevel. (at some point I should precalculate the upper bound and put it in the definition to save people time).</param>
        /// <param name="StatHashes">When the step provides stat benefits on the item or character, this is the list of hash identifiers for stats (DestinyStatDefinition) that are provided..</param>
        /// <param name="AffectsQuality">If this is true, the step affects the item&#39;s Quality in some way. See DestinyInventoryItemDefinition for more information about the meaning of Quality. I already made a joke about Zen and the Art of Motorcycle Maintenance elsewhere in the documentation, so I will avoid doing it again. Oops too late.</param>
        /// <param name="StepGroups">In Destiny 1, the Armory&#39;s Perk Filtering was driven by a concept of TalentNodeStepGroups: categorizations of talent nodes based on their functionality. While the Armory isn&#39;t a BNet-facing thing for now, and the new Armory will need to account for Sockets rather than Talent Nodes, this categorization capability feels useful enough to still keep around..</param>
        /// <param name="AffectsLevel">If true, this step can affect the level of the item. See DestinyInventoryItemDefintion for more information about item levels and their effect on stats..</param>
        /// <param name="SocketReplacements">If this step is activated, this will be a list of information used to replace socket items with new Plugs. See DestinyInventoryItemDefinition for more information about sockets and plugs..</param>
        public DestinyDefinitionsDestinyNodeStepDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), int? StepIndex = default(int?), uint? NodeStepHash = default(uint?), string InteractionDescription = default(string), DestinyDamageType DamageType = default(DestinyDamageType), uint? DamageTypeHash = default(uint?), DestinyDefinitionsDestinyNodeActivationRequirement ActivationRequirement = default(DestinyDefinitionsDestinyNodeActivationRequirement), bool? CanActivateNextStep = default(bool?), int? NextStepIndex = default(int?), bool? IsNextStepRandom = default(bool?), List<uint?> PerkHashes = default(List<uint?>), int? StartProgressionBarAtProgress = default(int?), List<uint?> StatHashes = default(List<uint?>), bool? AffectsQuality = default(bool?), DestinyDefinitionsDestinyTalentNodeStepGroups StepGroups = default(DestinyDefinitionsDestinyTalentNodeStepGroups), bool? AffectsLevel = default(bool?), List<DestinyDefinitionsDestinyNodeSocketReplaceResponse> SocketReplacements = default(List<DestinyDefinitionsDestinyNodeSocketReplaceResponse>))
        {
            this.DisplayProperties = DisplayProperties;
            this.StepIndex = StepIndex;
            this.NodeStepHash = NodeStepHash;
            this.InteractionDescription = InteractionDescription;
            this.DamageType = DamageType;
            this.DamageTypeHash = DamageTypeHash;
            this.ActivationRequirement = ActivationRequirement;
            this.CanActivateNextStep = CanActivateNextStep;
            this.NextStepIndex = NextStepIndex;
            this.IsNextStepRandom = IsNextStepRandom;
            this.PerkHashes = PerkHashes;
            this.StartProgressionBarAtProgress = StartProgressionBarAtProgress;
            this.StatHashes = StatHashes;
            this.AffectsQuality = AffectsQuality;
            this.StepGroups = StepGroups;
            this.AffectsLevel = AffectsLevel;
            this.SocketReplacements = SocketReplacements;
        }
        
        /// <summary>
        /// These are the display properties actually used to render the Talent Node. The currently active step&#39;s displayProperties are shown.
        /// </summary>
        /// <value>These are the display properties actually used to render the Talent Node. The currently active step&#39;s displayProperties are shown.</value>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// The index of this step in the list of Steps on the Talent Node.  Unfortunately, this is the closest thing we have to an identifier for the Step: steps are not provided a content version agnostic identifier. This means that, when you are dealing with talent nodes, you will need to first ensure that you have the latest version of content.
        /// </summary>
        /// <value>The index of this step in the list of Steps on the Talent Node.  Unfortunately, this is the closest thing we have to an identifier for the Step: steps are not provided a content version agnostic identifier. This means that, when you are dealing with talent nodes, you will need to first ensure that you have the latest version of content.</value>
        [DataMember(Name="stepIndex", EmitDefaultValue=false)]
        public int? StepIndex { get; set; }

        /// <summary>
        /// The hash of this node step. Unfortunately, while it can be used to uniquely identify the step within a node, it is also content version dependent and should not be relied on without ensuring you have the latest vesion of content.
        /// </summary>
        /// <value>The hash of this node step. Unfortunately, while it can be used to uniquely identify the step within a node, it is also content version dependent and should not be relied on without ensuring you have the latest vesion of content.</value>
        [DataMember(Name="nodeStepHash", EmitDefaultValue=false)]
        public uint? NodeStepHash { get; set; }

        /// <summary>
        /// If you can interact with this node in some way, this is the localized description of that interaction.
        /// </summary>
        /// <value>If you can interact with this node in some way, this is the localized description of that interaction.</value>
        [DataMember(Name="interactionDescription", EmitDefaultValue=false)]
        public string InteractionDescription { get; set; }

        /// <summary>
        /// An enum representing a damage type granted by activating this step, if any.
        /// </summary>
        /// <value>An enum representing a damage type granted by activating this step, if any.</value>
        [DataMember(Name="damageType", EmitDefaultValue=false)]
        public DestinyDamageType DamageType { get; set; }

        /// <summary>
        /// If the step provides a damage type, this will be the hash identifier used to look up the damage type&#39;s DestinyDamageTypeDefinition.
        /// </summary>
        /// <value>If the step provides a damage type, this will be the hash identifier used to look up the damage type&#39;s DestinyDamageTypeDefinition.</value>
        [DataMember(Name="damageTypeHash", EmitDefaultValue=false)]
        public uint? DamageTypeHash { get; set; }

        /// <summary>
        /// If the step has requirements for activation (they almost always do, if nothing else than for the Talent Grid&#39;s Progression to have reached a certain level), they will be defined here.
        /// </summary>
        /// <value>If the step has requirements for activation (they almost always do, if nothing else than for the Talent Grid&#39;s Progression to have reached a certain level), they will be defined here.</value>
        [DataMember(Name="activationRequirement", EmitDefaultValue=false)]
        public DestinyDefinitionsDestinyNodeActivationRequirement ActivationRequirement { get; set; }

        /// <summary>
        /// There was a time when talent nodes could be activated multiple times, and the effects of subsequent Steps would be compounded on each other, essentially \&quot;upgrading\&quot; the node. We have moved away from this, but theoretically the capability still exists.  I continue to return this in case it is used in the future: if true and this step is the current step in the node, you are allowed to activate the node a second time to receive the benefits of the next step in the node, which will then become the active step.
        /// </summary>
        /// <value>There was a time when talent nodes could be activated multiple times, and the effects of subsequent Steps would be compounded on each other, essentially \&quot;upgrading\&quot; the node. We have moved away from this, but theoretically the capability still exists.  I continue to return this in case it is used in the future: if true and this step is the current step in the node, you are allowed to activate the node a second time to receive the benefits of the next step in the node, which will then become the active step.</value>
        [DataMember(Name="canActivateNextStep", EmitDefaultValue=false)]
        public bool? CanActivateNextStep { get; set; }

        /// <summary>
        /// The stepIndex of the next step in the talent node, or -1 if this is the last step or if the next step to be chosen is random.  This doesn&#39;t really matter anymore unless canActivateNextStep begins to be used again.
        /// </summary>
        /// <value>The stepIndex of the next step in the talent node, or -1 if this is the last step or if the next step to be chosen is random.  This doesn&#39;t really matter anymore unless canActivateNextStep begins to be used again.</value>
        [DataMember(Name="nextStepIndex", EmitDefaultValue=false)]
        public int? NextStepIndex { get; set; }

        /// <summary>
        /// If true, the next step to be chosen is random, and if you&#39;re allowed to activate the next step. (if canActivateNextStep &#x3D; true)
        /// </summary>
        /// <value>If true, the next step to be chosen is random, and if you&#39;re allowed to activate the next step. (if canActivateNextStep &#x3D; true)</value>
        [DataMember(Name="isNextStepRandom", EmitDefaultValue=false)]
        public bool? IsNextStepRandom { get; set; }

        /// <summary>
        /// The list of hash identifiers for Perks (DestinySandboxPerkDefinition) that are applied when this step is active. Perks provide a variety of benefits and modifications - examine DestinySandboxPerkDefinition to learn more.
        /// </summary>
        /// <value>The list of hash identifiers for Perks (DestinySandboxPerkDefinition) that are applied when this step is active. Perks provide a variety of benefits and modifications - examine DestinySandboxPerkDefinition to learn more.</value>
        [DataMember(Name="perkHashes", EmitDefaultValue=false)]
        public List<uint?> PerkHashes { get; set; }

        /// <summary>
        /// When the Talent Grid&#39;s progression reaches this value, the circular \&quot;progress bar\&quot; that surrounds the talent node should be shown.  This also indicates the lower bound of said progress bar, with the upper bound being the progress required to reach activationRequirement.gridLevel. (at some point I should precalculate the upper bound and put it in the definition to save people time)
        /// </summary>
        /// <value>When the Talent Grid&#39;s progression reaches this value, the circular \&quot;progress bar\&quot; that surrounds the talent node should be shown.  This also indicates the lower bound of said progress bar, with the upper bound being the progress required to reach activationRequirement.gridLevel. (at some point I should precalculate the upper bound and put it in the definition to save people time)</value>
        [DataMember(Name="startProgressionBarAtProgress", EmitDefaultValue=false)]
        public int? StartProgressionBarAtProgress { get; set; }

        /// <summary>
        /// When the step provides stat benefits on the item or character, this is the list of hash identifiers for stats (DestinyStatDefinition) that are provided.
        /// </summary>
        /// <value>When the step provides stat benefits on the item or character, this is the list of hash identifiers for stats (DestinyStatDefinition) that are provided.</value>
        [DataMember(Name="statHashes", EmitDefaultValue=false)]
        public List<uint?> StatHashes { get; set; }

        /// <summary>
        /// If this is true, the step affects the item&#39;s Quality in some way. See DestinyInventoryItemDefinition for more information about the meaning of Quality. I already made a joke about Zen and the Art of Motorcycle Maintenance elsewhere in the documentation, so I will avoid doing it again. Oops too late
        /// </summary>
        /// <value>If this is true, the step affects the item&#39;s Quality in some way. See DestinyInventoryItemDefinition for more information about the meaning of Quality. I already made a joke about Zen and the Art of Motorcycle Maintenance elsewhere in the documentation, so I will avoid doing it again. Oops too late</value>
        [DataMember(Name="affectsQuality", EmitDefaultValue=false)]
        public bool? AffectsQuality { get; set; }

        /// <summary>
        /// In Destiny 1, the Armory&#39;s Perk Filtering was driven by a concept of TalentNodeStepGroups: categorizations of talent nodes based on their functionality. While the Armory isn&#39;t a BNet-facing thing for now, and the new Armory will need to account for Sockets rather than Talent Nodes, this categorization capability feels useful enough to still keep around.
        /// </summary>
        /// <value>In Destiny 1, the Armory&#39;s Perk Filtering was driven by a concept of TalentNodeStepGroups: categorizations of talent nodes based on their functionality. While the Armory isn&#39;t a BNet-facing thing for now, and the new Armory will need to account for Sockets rather than Talent Nodes, this categorization capability feels useful enough to still keep around.</value>
        [DataMember(Name="stepGroups", EmitDefaultValue=false)]
        public DestinyDefinitionsDestinyTalentNodeStepGroups StepGroups { get; set; }

        /// <summary>
        /// If true, this step can affect the level of the item. See DestinyInventoryItemDefintion for more information about item levels and their effect on stats.
        /// </summary>
        /// <value>If true, this step can affect the level of the item. See DestinyInventoryItemDefintion for more information about item levels and their effect on stats.</value>
        [DataMember(Name="affectsLevel", EmitDefaultValue=false)]
        public bool? AffectsLevel { get; set; }

        /// <summary>
        /// If this step is activated, this will be a list of information used to replace socket items with new Plugs. See DestinyInventoryItemDefinition for more information about sockets and plugs.
        /// </summary>
        /// <value>If this step is activated, this will be a list of information used to replace socket items with new Plugs. See DestinyInventoryItemDefinition for more information about sockets and plugs.</value>
        [DataMember(Name="socketReplacements", EmitDefaultValue=false)]
        public List<DestinyDefinitionsDestinyNodeSocketReplaceResponse> SocketReplacements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyNodeStepDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  StepIndex: ").Append(StepIndex).Append("\n");
            sb.Append("  NodeStepHash: ").Append(NodeStepHash).Append("\n");
            sb.Append("  InteractionDescription: ").Append(InteractionDescription).Append("\n");
            sb.Append("  DamageType: ").Append(DamageType).Append("\n");
            sb.Append("  DamageTypeHash: ").Append(DamageTypeHash).Append("\n");
            sb.Append("  ActivationRequirement: ").Append(ActivationRequirement).Append("\n");
            sb.Append("  CanActivateNextStep: ").Append(CanActivateNextStep).Append("\n");
            sb.Append("  NextStepIndex: ").Append(NextStepIndex).Append("\n");
            sb.Append("  IsNextStepRandom: ").Append(IsNextStepRandom).Append("\n");
            sb.Append("  PerkHashes: ").Append(PerkHashes).Append("\n");
            sb.Append("  StartProgressionBarAtProgress: ").Append(StartProgressionBarAtProgress).Append("\n");
            sb.Append("  StatHashes: ").Append(StatHashes).Append("\n");
            sb.Append("  AffectsQuality: ").Append(AffectsQuality).Append("\n");
            sb.Append("  StepGroups: ").Append(StepGroups).Append("\n");
            sb.Append("  AffectsLevel: ").Append(AffectsLevel).Append("\n");
            sb.Append("  SocketReplacements: ").Append(SocketReplacements).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyNodeStepDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyNodeStepDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyNodeStepDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyNodeStepDefinition input)
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
                    this.StepIndex == input.StepIndex ||
                    (this.StepIndex != null &&
                    this.StepIndex.Equals(input.StepIndex))
                ) && 
                (
                    this.NodeStepHash == input.NodeStepHash ||
                    (this.NodeStepHash != null &&
                    this.NodeStepHash.Equals(input.NodeStepHash))
                ) && 
                (
                    this.InteractionDescription == input.InteractionDescription ||
                    (this.InteractionDescription != null &&
                    this.InteractionDescription.Equals(input.InteractionDescription))
                ) && 
                (
                    this.DamageType == input.DamageType ||
                    (this.DamageType != null &&
                    this.DamageType.Equals(input.DamageType))
                ) && 
                (
                    this.DamageTypeHash == input.DamageTypeHash ||
                    (this.DamageTypeHash != null &&
                    this.DamageTypeHash.Equals(input.DamageTypeHash))
                ) && 
                (
                    this.ActivationRequirement == input.ActivationRequirement ||
                    (this.ActivationRequirement != null &&
                    this.ActivationRequirement.Equals(input.ActivationRequirement))
                ) && 
                (
                    this.CanActivateNextStep == input.CanActivateNextStep ||
                    (this.CanActivateNextStep != null &&
                    this.CanActivateNextStep.Equals(input.CanActivateNextStep))
                ) && 
                (
                    this.NextStepIndex == input.NextStepIndex ||
                    (this.NextStepIndex != null &&
                    this.NextStepIndex.Equals(input.NextStepIndex))
                ) && 
                (
                    this.IsNextStepRandom == input.IsNextStepRandom ||
                    (this.IsNextStepRandom != null &&
                    this.IsNextStepRandom.Equals(input.IsNextStepRandom))
                ) && 
                (
                    this.PerkHashes == input.PerkHashes ||
                    this.PerkHashes != null &&
                    this.PerkHashes.SequenceEqual(input.PerkHashes)
                ) && 
                (
                    this.StartProgressionBarAtProgress == input.StartProgressionBarAtProgress ||
                    (this.StartProgressionBarAtProgress != null &&
                    this.StartProgressionBarAtProgress.Equals(input.StartProgressionBarAtProgress))
                ) && 
                (
                    this.StatHashes == input.StatHashes ||
                    this.StatHashes != null &&
                    this.StatHashes.SequenceEqual(input.StatHashes)
                ) && 
                (
                    this.AffectsQuality == input.AffectsQuality ||
                    (this.AffectsQuality != null &&
                    this.AffectsQuality.Equals(input.AffectsQuality))
                ) && 
                (
                    this.StepGroups == input.StepGroups ||
                    (this.StepGroups != null &&
                    this.StepGroups.Equals(input.StepGroups))
                ) && 
                (
                    this.AffectsLevel == input.AffectsLevel ||
                    (this.AffectsLevel != null &&
                    this.AffectsLevel.Equals(input.AffectsLevel))
                ) && 
                (
                    this.SocketReplacements == input.SocketReplacements ||
                    this.SocketReplacements != null &&
                    this.SocketReplacements.SequenceEqual(input.SocketReplacements)
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
                if (this.StepIndex != null)
                    hashCode = hashCode * 59 + this.StepIndex.GetHashCode();
                if (this.NodeStepHash != null)
                    hashCode = hashCode * 59 + this.NodeStepHash.GetHashCode();
                if (this.InteractionDescription != null)
                    hashCode = hashCode * 59 + this.InteractionDescription.GetHashCode();
                if (this.DamageType != null)
                    hashCode = hashCode * 59 + this.DamageType.GetHashCode();
                if (this.DamageTypeHash != null)
                    hashCode = hashCode * 59 + this.DamageTypeHash.GetHashCode();
                if (this.ActivationRequirement != null)
                    hashCode = hashCode * 59 + this.ActivationRequirement.GetHashCode();
                if (this.CanActivateNextStep != null)
                    hashCode = hashCode * 59 + this.CanActivateNextStep.GetHashCode();
                if (this.NextStepIndex != null)
                    hashCode = hashCode * 59 + this.NextStepIndex.GetHashCode();
                if (this.IsNextStepRandom != null)
                    hashCode = hashCode * 59 + this.IsNextStepRandom.GetHashCode();
                if (this.PerkHashes != null)
                    hashCode = hashCode * 59 + this.PerkHashes.GetHashCode();
                if (this.StartProgressionBarAtProgress != null)
                    hashCode = hashCode * 59 + this.StartProgressionBarAtProgress.GetHashCode();
                if (this.StatHashes != null)
                    hashCode = hashCode * 59 + this.StatHashes.GetHashCode();
                if (this.AffectsQuality != null)
                    hashCode = hashCode * 59 + this.AffectsQuality.GetHashCode();
                if (this.StepGroups != null)
                    hashCode = hashCode * 59 + this.StepGroups.GetHashCode();
                if (this.AffectsLevel != null)
                    hashCode = hashCode * 59 + this.AffectsLevel.GetHashCode();
                if (this.SocketReplacements != null)
                    hashCode = hashCode * 59 + this.SocketReplacements.GetHashCode();
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