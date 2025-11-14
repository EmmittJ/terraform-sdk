using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for external_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_reference";

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The hashes attribute.
    /// </summary>
    [TerraformArgument("hashes")]
    public TerraformMap<string>? Hashes
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "hashes").ResolveNodes(ctx));
        set => SetArgument("hashes", value);
    }


    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [TerraformArgument("source_name")]
    public TerraformValue<string>? SourceName
    {
        get => new TerraformReference<string>(this, "source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string>? Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for granular_marking in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "granular_marking";

    /// <summary>
    /// The language attribute.
    /// </summary>
    [TerraformArgument("language")]
    public TerraformValue<string>? Language
    {
        get => new TerraformReference<string>(this, "language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The marking_ref attribute.
    /// </summary>
    [TerraformArgument("marking_ref")]
    public TerraformValue<string>? MarkingRef
    {
        get => new TerraformReference<string>(this, "marking_ref");
        set => SetArgument("marking_ref", value);
    }

    /// <summary>
    /// The selectors attribute.
    /// </summary>
    [TerraformArgument("selectors")]
    public TerraformList<string>? Selectors
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "selectors").ResolveNodes(ctx));
        set => SetArgument("selectors", value);
    }

}

/// <summary>
/// Block type for kill_chain_phase in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kill_chain_phase";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("confidence")]
    public TerraformValue<double>? Confidence
    {
        get => new TerraformReference<double>(this, "confidence");
        set => SetArgument("confidence", value);
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformArgument("created_by")]
    public TerraformValue<string>? CreatedBy
    {
        get => new TerraformReference<string>(this, "created_by");
        set => SetArgument("created_by", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [TerraformArgument("extension")]
    public TerraformValue<string> Extension
    {
        get => new TerraformReference<string>(this, "extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The language attribute.
    /// </summary>
    [TerraformArgument("language")]
    public TerraformValue<string>? Language
    {
        get => new TerraformReference<string>(this, "language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The object_marking_refs attribute.
    /// </summary>
    [TerraformArgument("object_marking_refs")]
    public TerraformList<string>? ObjectMarkingRefs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "object_marking_refs").ResolveNodes(ctx));
        set => SetArgument("object_marking_refs", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    [TerraformArgument("pattern")]
    public required TerraformValue<string> Pattern
    {
        get => new TerraformReference<string>(this, "pattern");
        set => SetArgument("pattern", value);
    }

    /// <summary>
    /// The pattern_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternType is required")]
    [TerraformArgument("pattern_type")]
    public required TerraformValue<string> PatternType
    {
        get => new TerraformReference<string>(this, "pattern_type");
        set => SetArgument("pattern_type", value);
    }

    /// <summary>
    /// The pattern_version attribute.
    /// </summary>
    [TerraformArgument("pattern_version")]
    public TerraformValue<string>? PatternVersion
    {
        get => new TerraformReference<string>(this, "pattern_version");
        set => SetArgument("pattern_version", value);
    }

    /// <summary>
    /// The revoked attribute.
    /// </summary>
    [TerraformArgument("revoked")]
    public TerraformValue<bool>? Revoked
    {
        get => new TerraformReference<bool>(this, "revoked");
        set => SetArgument("revoked", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformArgument("source")]
    public required TerraformValue<string> Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformList<string>? Tags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The threat_types attribute.
    /// </summary>
    [TerraformArgument("threat_types")]
    public TerraformList<string>? ThreatTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "threat_types").ResolveNodes(ctx));
        set => SetArgument("threat_types", value);
    }

    /// <summary>
    /// The validate_from_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidateFromUtc is required")]
    [TerraformArgument("validate_from_utc")]
    public required TerraformValue<string> ValidateFromUtc
    {
        get => new TerraformReference<string>(this, "validate_from_utc");
        set => SetArgument("validate_from_utc", value);
    }

    /// <summary>
    /// The validate_until_utc attribute.
    /// </summary>
    [TerraformArgument("validate_until_utc")]
    public TerraformValue<string>? ValidateUntilUtc
    {
        get => new TerraformReference<string>(this, "validate_until_utc");
        set => SetArgument("validate_until_utc", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformArgument("workspace_id")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Block for external_reference.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("external_reference")]
    public TerraformList<AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock> ExternalReference { get; set; } = new();

    /// <summary>
    /// Block for granular_marking.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("granular_marking")]
    public TerraformList<AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock> GranularMarking { get; set; } = new();

    /// <summary>
    /// Block for kill_chain_phase.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("kill_chain_phase")]
    public TerraformList<AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock> KillChainPhase { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The created_on attribute.
    /// </summary>
    [TerraformArgument("created_on")]
    public TerraformValue<string> CreatedOn
    {
        get => new TerraformReference<string>(this, "created_on");
    }

    /// <summary>
    /// The defanged attribute.
    /// </summary>
    [TerraformArgument("defanged")]
    public TerraformValue<bool> Defanged
    {
        get => new TerraformReference<bool>(this, "defanged");
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformArgument("external_id")]
    public TerraformValue<string> ExternalId
    {
        get => new TerraformReference<string>(this, "external_id");
    }

    /// <summary>
    /// The external_last_updated_time_utc attribute.
    /// </summary>
    [TerraformArgument("external_last_updated_time_utc")]
    public TerraformValue<string> ExternalLastUpdatedTimeUtc
    {
        get => new TerraformReference<string>(this, "external_last_updated_time_utc");
    }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformArgument("guid")]
    public TerraformValue<string> Guid
    {
        get => new TerraformReference<string>(this, "guid");
    }

    /// <summary>
    /// The indicator_type attribute.
    /// </summary>
    [TerraformArgument("indicator_type")]
    public TerraformList<string> IndicatorType
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "indicator_type").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_updated_time_utc attribute.
    /// </summary>
    [TerraformArgument("last_updated_time_utc")]
    public TerraformValue<string> LastUpdatedTimeUtc
    {
        get => new TerraformReference<string>(this, "last_updated_time_utc");
    }

    /// <summary>
    /// The parsed_pattern attribute.
    /// </summary>
    [TerraformArgument("parsed_pattern")]
    public TerraformList<object> ParsedPattern
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "parsed_pattern").ResolveNodes(ctx));
    }

}
