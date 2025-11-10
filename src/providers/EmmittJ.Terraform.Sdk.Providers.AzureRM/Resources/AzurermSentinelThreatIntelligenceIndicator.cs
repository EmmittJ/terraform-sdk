using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for external_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The hashes attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Hashes
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("hashes");
        set => WithProperty("hashes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    public TerraformProperty<string>? SourceName
    {
        get => GetProperty<TerraformProperty<string>>("source_name");
        set => WithProperty("source_name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for granular_marking in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock : TerraformBlock
{
    /// <summary>
    /// The language attribute.
    /// </summary>
    public TerraformProperty<string>? Language
    {
        get => GetProperty<TerraformProperty<string>>("language");
        set => WithProperty("language", value);
    }

    /// <summary>
    /// The marking_ref attribute.
    /// </summary>
    public TerraformProperty<string>? MarkingRef
    {
        get => GetProperty<TerraformProperty<string>>("marking_ref");
        set => WithProperty("marking_ref", value);
    }

    /// <summary>
    /// The selectors attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Selectors
    {
        get => GetProperty<List<TerraformProperty<string>>>("selectors");
        set => WithProperty("selectors", value);
    }

}

/// <summary>
/// Block type for kill_chain_phase in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_sentinel_threat_intelligence_indicator resource.
/// </summary>
public class AzurermSentinelThreatIntelligenceIndicator : TerraformResource
{
    public AzurermSentinelThreatIntelligenceIndicator(string name) : base("azurerm_sentinel_threat_intelligence_indicator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputreated_on");
        this.WithOutputefanged");
        this.WithOutputxternal_id");
        this.WithOutputxternal_last_updated_time_utc");
        this.WithOutputuid");
        this.WithOutputndicator_type");
        this.WithOutputast_updated_time_utc");
        this.WithOutputarsed_pattern");
    }

    /// <summary>
    /// The confidence attribute.
    /// </summary>
    public TerraformProperty<double>? Confidence
    {
        get => GetProperty<TerraformProperty<double>>("confidence");
        set => this.WithProperty("confidence", value);
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformProperty<string>? CreatedBy
    {
        get => GetProperty<TerraformProperty<string>>("created_by");
        set => this.WithProperty("created_by", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    public TerraformProperty<string>? Extension
    {
        get => GetProperty<TerraformProperty<string>>("extension");
        set => this.WithProperty("extension", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The language attribute.
    /// </summary>
    public TerraformProperty<string>? Language
    {
        get => GetProperty<TerraformProperty<string>>("language");
        set => this.WithProperty("language", value);
    }

    /// <summary>
    /// The object_marking_refs attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ObjectMarkingRefs
    {
        get => GetProperty<List<TerraformProperty<string>>>("object_marking_refs");
        set => this.WithProperty("object_marking_refs", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformProperty<string> Pattern
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pattern");
        set => this.WithProperty("pattern", value);
    }

    /// <summary>
    /// The pattern_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternType is required")]
    public required TerraformProperty<string> PatternType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pattern_type");
        set => this.WithProperty("pattern_type", value);
    }

    /// <summary>
    /// The pattern_version attribute.
    /// </summary>
    public TerraformProperty<string>? PatternVersion
    {
        get => GetProperty<TerraformProperty<string>>("pattern_version");
        set => this.WithProperty("pattern_version", value);
    }

    /// <summary>
    /// The revoked attribute.
    /// </summary>
    public TerraformProperty<bool>? Revoked
    {
        get => GetProperty<TerraformProperty<bool>>("revoked");
        set => this.WithProperty("revoked", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Tags
    {
        get => GetProperty<List<TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The threat_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ThreatTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("threat_types");
        set => this.WithProperty("threat_types", value);
    }

    /// <summary>
    /// The validate_from_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidateFromUtc is required")]
    public required TerraformProperty<string> ValidateFromUtc
    {
        get => GetRequiredProperty<TerraformProperty<string>>("validate_from_utc");
        set => this.WithProperty("validate_from_utc", value);
    }

    /// <summary>
    /// The validate_until_utc attribute.
    /// </summary>
    public TerraformProperty<string>? ValidateUntilUtc
    {
        get => GetProperty<TerraformProperty<string>>("validate_until_utc");
        set => this.WithProperty("validate_until_utc", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for external_reference.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock>? ExternalReference
    {
        get => GetProperty<List<AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock>>("external_reference");
        set => this.WithProperty("external_reference", value);
    }

    /// <summary>
    /// Block for granular_marking.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock>? GranularMarking
    {
        get => GetProperty<List<AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock>>("granular_marking");
        set => this.WithProperty("granular_marking", value);
    }

    /// <summary>
    /// Block for kill_chain_phase.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock>? KillChainPhase
    {
        get => GetProperty<List<AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock>>("kill_chain_phase");
        set => this.WithProperty("kill_chain_phase", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The created_on attribute.
    /// </summary>
    public TerraformExpression CreatedOn => this["created_on"];

    /// <summary>
    /// The defanged attribute.
    /// </summary>
    public TerraformExpression Defanged => this["defanged"];

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformExpression ExternalId => this["external_id"];

    /// <summary>
    /// The external_last_updated_time_utc attribute.
    /// </summary>
    public TerraformExpression ExternalLastUpdatedTimeUtc => this["external_last_updated_time_utc"];

    /// <summary>
    /// The guid attribute.
    /// </summary>
    public TerraformExpression Guid => this["guid"];

    /// <summary>
    /// The indicator_type attribute.
    /// </summary>
    public TerraformExpression IndicatorType => this["indicator_type"];

    /// <summary>
    /// The last_updated_time_utc attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTimeUtc => this["last_updated_time_utc"];

    /// <summary>
    /// The parsed_pattern attribute.
    /// </summary>
    public TerraformExpression ParsedPattern => this["parsed_pattern"];

}
