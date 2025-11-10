using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for external_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The hashes attribute.
    /// </summary>
    [TerraformPropertyName("hashes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Hashes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [TerraformPropertyName("source_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceName { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Url { get; set; }

}

/// <summary>
/// Block type for granular_marking in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock : ITerraformBlock
{
    /// <summary>
    /// The language attribute.
    /// </summary>
    [TerraformPropertyName("language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Language { get; set; }

    /// <summary>
    /// The marking_ref attribute.
    /// </summary>
    [TerraformPropertyName("marking_ref")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MarkingRef { get; set; }

    /// <summary>
    /// The selectors attribute.
    /// </summary>
    [TerraformPropertyName("selectors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Selectors { get; set; }

}

/// <summary>
/// Block type for kill_chain_phase in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_sentinel_threat_intelligence_indicator resource.
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicator : TerraformResource
{
    public AzurermSentinelThreatIntelligenceIndicator(string name) : base("azurerm_sentinel_threat_intelligence_indicator", name)
    {
    }

    /// <summary>
    /// The confidence attribute.
    /// </summary>
    [TerraformPropertyName("confidence")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Confidence { get; set; }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformPropertyName("created_by")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreatedBy { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [TerraformPropertyName("extension")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Extension { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "extension");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The language attribute.
    /// </summary>
    [TerraformPropertyName("language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Language { get; set; }

    /// <summary>
    /// The object_marking_refs attribute.
    /// </summary>
    [TerraformPropertyName("object_marking_refs")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ObjectMarkingRefs { get; set; }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    [TerraformPropertyName("pattern")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Pattern { get; set; }

    /// <summary>
    /// The pattern_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternType is required")]
    [TerraformPropertyName("pattern_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PatternType { get; set; }

    /// <summary>
    /// The pattern_version attribute.
    /// </summary>
    [TerraformPropertyName("pattern_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PatternVersion { get; set; }

    /// <summary>
    /// The revoked attribute.
    /// </summary>
    [TerraformPropertyName("revoked")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Revoked { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Source { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The threat_types attribute.
    /// </summary>
    [TerraformPropertyName("threat_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ThreatTypes { get; set; }

    /// <summary>
    /// The validate_from_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidateFromUtc is required")]
    [TerraformPropertyName("validate_from_utc")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ValidateFromUtc { get; set; }

    /// <summary>
    /// The validate_until_utc attribute.
    /// </summary>
    [TerraformPropertyName("validate_until_utc")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ValidateUntilUtc { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; }

    /// <summary>
    /// Block for external_reference.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("external_reference")]
    public TerraformList<TerraformBlock<AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock>>? ExternalReference { get; set; } = new();

    /// <summary>
    /// Block for granular_marking.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("granular_marking")]
    public TerraformList<TerraformBlock<AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock>>? GranularMarking { get; set; } = new();

    /// <summary>
    /// Block for kill_chain_phase.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("kill_chain_phase")]
    public TerraformList<TerraformBlock<AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock>>? KillChainPhase { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The created_on attribute.
    /// </summary>
    [TerraformPropertyName("created_on")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedOn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_on");

    /// <summary>
    /// The defanged attribute.
    /// </summary>
    [TerraformPropertyName("defanged")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Defanged => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "defanged");

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformPropertyName("external_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExternalId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "external_id");

    /// <summary>
    /// The external_last_updated_time_utc attribute.
    /// </summary>
    [TerraformPropertyName("external_last_updated_time_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExternalLastUpdatedTimeUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "external_last_updated_time_utc");

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformPropertyName("guid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Guid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "guid");

    /// <summary>
    /// The indicator_type attribute.
    /// </summary>
    [TerraformPropertyName("indicator_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> IndicatorType => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "indicator_type");

    /// <summary>
    /// The last_updated_time_utc attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_time_utc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedTimeUtc => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_time_utc");

    /// <summary>
    /// The parsed_pattern attribute.
    /// </summary>
    [TerraformPropertyName("parsed_pattern")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ParsedPattern => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "parsed_pattern");

}
