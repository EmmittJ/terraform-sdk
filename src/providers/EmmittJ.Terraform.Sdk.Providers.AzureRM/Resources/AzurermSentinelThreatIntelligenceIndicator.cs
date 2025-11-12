using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for external_reference in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock() : TerraformBlock("external_reference")
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The hashes attribute.
    /// </summary>
    [TerraformProperty("hashes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Hashes { get; set; }


    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [TerraformProperty("source_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceName { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Url { get; set; }

}

/// <summary>
/// Block type for granular_marking in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock() : TerraformBlock("granular_marking")
{
    /// <summary>
    /// The language attribute.
    /// </summary>
    [TerraformProperty("language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Language { get; set; }

    /// <summary>
    /// The marking_ref attribute.
    /// </summary>
    [TerraformProperty("marking_ref")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MarkingRef { get; set; }

    /// <summary>
    /// The selectors attribute.
    /// </summary>
    [TerraformProperty("selectors")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Selectors { get; set; }

}

/// <summary>
/// Block type for kill_chain_phase in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock() : TerraformBlock("kill_chain_phase")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_sentinel_threat_intelligence_indicator resource.
/// </summary>
public partial class AzurermSentinelThreatIntelligenceIndicator : TerraformResource
{
    public AzurermSentinelThreatIntelligenceIndicator(string name) : base("azurerm_sentinel_threat_intelligence_indicator", name)
    {
    }

    /// <summary>
    /// The confidence attribute.
    /// </summary>
    [TerraformProperty("confidence")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Confidence { get; set; }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformProperty("created_by")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CreatedBy { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [TerraformProperty("extension")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Extension { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The language attribute.
    /// </summary>
    [TerraformProperty("language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Language { get; set; }

    /// <summary>
    /// The object_marking_refs attribute.
    /// </summary>
    [TerraformProperty("object_marking_refs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ObjectMarkingRefs { get; set; }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    [TerraformProperty("pattern")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Pattern { get; set; }

    /// <summary>
    /// The pattern_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternType is required")]
    [TerraformProperty("pattern_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PatternType { get; set; }

    /// <summary>
    /// The pattern_version attribute.
    /// </summary>
    [TerraformProperty("pattern_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PatternVersion { get; set; }

    /// <summary>
    /// The revoked attribute.
    /// </summary>
    [TerraformProperty("revoked")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Revoked { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Tags { get; set; }

    /// <summary>
    /// The threat_types attribute.
    /// </summary>
    [TerraformProperty("threat_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ThreatTypes { get; set; }

    /// <summary>
    /// The validate_from_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidateFromUtc is required")]
    [TerraformProperty("validate_from_utc")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ValidateFromUtc { get; set; }

    /// <summary>
    /// The validate_until_utc attribute.
    /// </summary>
    [TerraformProperty("validate_until_utc")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ValidateUntilUtc { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for external_reference.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("external_reference")]
    public TerraformList<AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock> ExternalReference { get; set; } = new();

    /// <summary>
    /// Block for granular_marking.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("granular_marking")]
    public TerraformList<AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock> GranularMarking { get; set; } = new();

    /// <summary>
    /// Block for kill_chain_phase.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("kill_chain_phase")]
    public TerraformList<AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock> KillChainPhase { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The created_on attribute.
    /// </summary>
    [TerraformProperty("created_on")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedOn { get; }

    /// <summary>
    /// The defanged attribute.
    /// </summary>
    [TerraformProperty("defanged")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Defanged { get; }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformProperty("external_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExternalId { get; }

    /// <summary>
    /// The external_last_updated_time_utc attribute.
    /// </summary>
    [TerraformProperty("external_last_updated_time_utc")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExternalLastUpdatedTimeUtc { get; }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformProperty("guid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Guid { get; }

    /// <summary>
    /// The indicator_type attribute.
    /// </summary>
    [TerraformProperty("indicator_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> IndicatorType { get; }

    /// <summary>
    /// The last_updated_time_utc attribute.
    /// </summary>
    [TerraformProperty("last_updated_time_utc")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedTimeUtc { get; }

    /// <summary>
    /// The parsed_pattern attribute.
    /// </summary>
    [TerraformProperty("parsed_pattern")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ParsedPattern { get; }

}
