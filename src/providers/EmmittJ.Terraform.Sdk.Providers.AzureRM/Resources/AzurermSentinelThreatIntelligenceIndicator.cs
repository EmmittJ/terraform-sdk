using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The hashes attribute.
    /// </summary>
    public TerraformMap<string>? Hashes
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "hashes").ResolveNodes(ctx));
        set => SetArgument("hashes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    public TerraformValue<string>? SourceName
    {
        get => new TerraformReference<string>(this, "source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
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
    public TerraformValue<string>? Language
    {
        get => new TerraformReference<string>(this, "language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The marking_ref attribute.
    /// </summary>
    public TerraformValue<string>? MarkingRef
    {
        get => new TerraformReference<string>(this, "marking_ref");
        set => SetArgument("marking_ref", value);
    }

    /// <summary>
    /// The selectors attribute.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_sentinel_threat_intelligence_indicator Terraform resource.
/// Manages a azurerm_sentinel_threat_intelligence_indicator resource.
/// </summary>
public partial class AzurermSentinelThreatIntelligenceIndicator(string name) : TerraformResource("azurerm_sentinel_threat_intelligence_indicator", name)
{
    /// <summary>
    /// The confidence attribute.
    /// </summary>
    public TerraformValue<double>? Confidence
    {
        get => new TerraformReference<double>(this, "confidence");
        set => SetArgument("confidence", value);
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string>? CreatedBy
    {
        get => new TerraformReference<string>(this, "created_by");
        set => SetArgument("created_by", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    public TerraformValue<string> Extension
    {
        get => new TerraformReference<string>(this, "extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The language attribute.
    /// </summary>
    public TerraformValue<string>? Language
    {
        get => new TerraformReference<string>(this, "language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The object_marking_refs attribute.
    /// </summary>
    public TerraformList<string>? ObjectMarkingRefs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "object_marking_refs").ResolveNodes(ctx));
        set => SetArgument("object_marking_refs", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => new TerraformReference<string>(this, "pattern");
        set => SetArgument("pattern", value);
    }

    /// <summary>
    /// The pattern_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternType is required")]
    public required TerraformValue<string> PatternType
    {
        get => new TerraformReference<string>(this, "pattern_type");
        set => SetArgument("pattern_type", value);
    }

    /// <summary>
    /// The pattern_version attribute.
    /// </summary>
    public TerraformValue<string>? PatternVersion
    {
        get => new TerraformReference<string>(this, "pattern_version");
        set => SetArgument("pattern_version", value);
    }

    /// <summary>
    /// The revoked attribute.
    /// </summary>
    public TerraformValue<bool>? Revoked
    {
        get => new TerraformReference<bool>(this, "revoked");
        set => SetArgument("revoked", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The threat_types attribute.
    /// </summary>
    public TerraformList<string>? ThreatTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "threat_types").ResolveNodes(ctx));
        set => SetArgument("threat_types", value);
    }

    /// <summary>
    /// The validate_from_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidateFromUtc is required")]
    public required TerraformValue<string> ValidateFromUtc
    {
        get => new TerraformReference<string>(this, "validate_from_utc");
        set => SetArgument("validate_from_utc", value);
    }

    /// <summary>
    /// The validate_until_utc attribute.
    /// </summary>
    public TerraformValue<string>? ValidateUntilUtc
    {
        get => new TerraformReference<string>(this, "validate_until_utc");
        set => SetArgument("validate_until_utc", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// ExternalReference block (nesting mode: list).
    /// </summary>
    public AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock? ExternalReference
    {
        get => GetArgument<AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock>("external_reference");
        set => SetArgument("external_reference", value);
    }

    /// <summary>
    /// GranularMarking block (nesting mode: list).
    /// </summary>
    public AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock? GranularMarking
    {
        get => GetArgument<AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock>("granular_marking");
        set => SetArgument("granular_marking", value);
    }

    /// <summary>
    /// KillChainPhase block (nesting mode: list).
    /// </summary>
    public AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock? KillChainPhase
    {
        get => GetArgument<AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock>("kill_chain_phase");
        set => SetArgument("kill_chain_phase", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
