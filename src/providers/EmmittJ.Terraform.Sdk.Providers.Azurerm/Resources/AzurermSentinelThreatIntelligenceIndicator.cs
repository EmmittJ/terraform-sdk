using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for external_reference in AzurermSentinelThreatIntelligenceIndicator.
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
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The hashes attribute.
    /// </summary>
    public TerraformMap<string>? Hashes
    {
        get => GetArgument<TerraformMap<string>>("hashes");
        set => SetArgument("hashes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    public TerraformValue<string>? SourceName
    {
        get => GetArgument<TerraformValue<string>>("source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for granular_marking in AzurermSentinelThreatIntelligenceIndicator.
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
        get => GetArgument<TerraformValue<string>>("language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The marking_ref attribute.
    /// </summary>
    public TerraformValue<string>? MarkingRef
    {
        get => GetArgument<TerraformValue<string>>("marking_ref");
        set => SetArgument("marking_ref", value);
    }

    /// <summary>
    /// The selectors attribute.
    /// </summary>
    public TerraformList<string>? Selectors
    {
        get => GetArgument<TerraformList<string>>("selectors");
        set => SetArgument("selectors", value);
    }

}


/// <summary>
/// Block type for kill_chain_phase in AzurermSentinelThreatIntelligenceIndicator.
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSentinelThreatIntelligenceIndicator.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<double>>("confidence");
        set => SetArgument("confidence", value);
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string>? CreatedBy
    {
        get => GetArgument<TerraformValue<string>>("created_by");
        set => SetArgument("created_by", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    public TerraformValue<string> Extension
    {
        get => GetArgument<TerraformValue<string>>("extension") ?? AsReference("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The language attribute.
    /// </summary>
    public TerraformValue<string>? Language
    {
        get => GetArgument<TerraformValue<string>>("language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The object_marking_refs attribute.
    /// </summary>
    public TerraformList<string>? ObjectMarkingRefs
    {
        get => GetArgument<TerraformList<string>>("object_marking_refs");
        set => SetArgument("object_marking_refs", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetRequiredArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

    /// <summary>
    /// The pattern_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternType is required")]
    public required TerraformValue<string> PatternType
    {
        get => GetRequiredArgument<TerraformValue<string>>("pattern_type");
        set => SetArgument("pattern_type", value);
    }

    /// <summary>
    /// The pattern_version attribute.
    /// </summary>
    public TerraformValue<string>? PatternVersion
    {
        get => GetArgument<TerraformValue<string>>("pattern_version");
        set => SetArgument("pattern_version", value);
    }

    /// <summary>
    /// The revoked attribute.
    /// </summary>
    public TerraformValue<bool>? Revoked
    {
        get => GetArgument<TerraformValue<bool>>("revoked");
        set => SetArgument("revoked", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => GetArgument<TerraformList<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The threat_types attribute.
    /// </summary>
    public TerraformList<string>? ThreatTypes
    {
        get => GetArgument<TerraformList<string>>("threat_types");
        set => SetArgument("threat_types", value);
    }

    /// <summary>
    /// The validate_from_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidateFromUtc is required")]
    public required TerraformValue<string> ValidateFromUtc
    {
        get => GetRequiredArgument<TerraformValue<string>>("validate_from_utc");
        set => SetArgument("validate_from_utc", value);
    }

    /// <summary>
    /// The validate_until_utc attribute.
    /// </summary>
    public TerraformValue<string>? ValidateUntilUtc
    {
        get => GetArgument<TerraformValue<string>>("validate_until_utc");
        set => SetArgument("validate_until_utc", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The created_on attribute.
    /// </summary>
    public TerraformValue<string> CreatedOn
        => AsReference("created_on");

    /// <summary>
    /// The defanged attribute.
    /// </summary>
    public TerraformValue<bool> Defanged
        => AsReference("defanged");

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformValue<string> ExternalId
        => AsReference("external_id");

    /// <summary>
    /// The external_last_updated_time_utc attribute.
    /// </summary>
    public TerraformValue<string> ExternalLastUpdatedTimeUtc
        => AsReference("external_last_updated_time_utc");

    /// <summary>
    /// The guid attribute.
    /// </summary>
    public TerraformValue<string> Guid
        => AsReference("guid");

    /// <summary>
    /// The indicator_type attribute.
    /// </summary>
    public TerraformList<string> IndicatorType
        => AsReference("indicator_type");

    /// <summary>
    /// The last_updated_time_utc attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTimeUtc
        => AsReference("last_updated_time_utc");

    /// <summary>
    /// The parsed_pattern attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ParsedPattern
        => AsReference("parsed_pattern");

    /// <summary>
    /// ExternalReference block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock>? ExternalReference
    {
        get => GetArgument<TerraformList<AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock>>("external_reference");
        set => SetArgument("external_reference", value);
    }

    /// <summary>
    /// GranularMarking block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock>? GranularMarking
    {
        get => GetArgument<TerraformList<AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock>>("granular_marking");
        set => SetArgument("granular_marking", value);
    }

    /// <summary>
    /// KillChainPhase block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock>? KillChainPhase
    {
        get => GetArgument<TerraformList<AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock>>("kill_chain_phase");
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
