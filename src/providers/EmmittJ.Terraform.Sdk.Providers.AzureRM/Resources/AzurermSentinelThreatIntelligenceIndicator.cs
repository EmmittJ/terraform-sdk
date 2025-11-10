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
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The hashes attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Hashes
    {
        set => SetProperty("hashes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    public TerraformProperty<string>? SourceName
    {
        set => SetProperty("source_name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        set => SetProperty("url", value);
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
        set => SetProperty("language", value);
    }

    /// <summary>
    /// The marking_ref attribute.
    /// </summary>
    public TerraformProperty<string>? MarkingRef
    {
        set => SetProperty("marking_ref", value);
    }

    /// <summary>
    /// The selectors attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Selectors
    {
        set => SetProperty("selectors", value);
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
        set => SetProperty("name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("created_on");
        SetOutput("defanged");
        SetOutput("external_id");
        SetOutput("external_last_updated_time_utc");
        SetOutput("guid");
        SetOutput("indicator_type");
        SetOutput("last_updated_time_utc");
        SetOutput("parsed_pattern");
        SetOutput("confidence");
        SetOutput("created_by");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("extension");
        SetOutput("id");
        SetOutput("language");
        SetOutput("object_marking_refs");
        SetOutput("pattern");
        SetOutput("pattern_type");
        SetOutput("pattern_version");
        SetOutput("revoked");
        SetOutput("source");
        SetOutput("tags");
        SetOutput("threat_types");
        SetOutput("validate_from_utc");
        SetOutput("validate_until_utc");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The confidence attribute.
    /// </summary>
    public TerraformProperty<double> Confidence
    {
        get => GetRequiredOutput<TerraformProperty<double>>("confidence");
        set => SetProperty("confidence", value);
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformProperty<string> CreatedBy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("created_by");
        set => SetProperty("created_by", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    public TerraformProperty<string> Extension
    {
        get => GetRequiredOutput<TerraformProperty<string>>("extension");
        set => SetProperty("extension", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The language attribute.
    /// </summary>
    public TerraformProperty<string> Language
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language");
        set => SetProperty("language", value);
    }

    /// <summary>
    /// The object_marking_refs attribute.
    /// </summary>
    public List<TerraformProperty<string>> ObjectMarkingRefs
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("object_marking_refs");
        set => SetProperty("object_marking_refs", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformProperty<string> Pattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pattern");
        set => SetProperty("pattern", value);
    }

    /// <summary>
    /// The pattern_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternType is required")]
    public required TerraformProperty<string> PatternType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pattern_type");
        set => SetProperty("pattern_type", value);
    }

    /// <summary>
    /// The pattern_version attribute.
    /// </summary>
    public TerraformProperty<string> PatternVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pattern_version");
        set => SetProperty("pattern_version", value);
    }

    /// <summary>
    /// The revoked attribute.
    /// </summary>
    public TerraformProperty<bool> Revoked
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("revoked");
        set => SetProperty("revoked", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source");
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public List<TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The threat_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> ThreatTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("threat_types");
        set => SetProperty("threat_types", value);
    }

    /// <summary>
    /// The validate_from_utc attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidateFromUtc is required")]
    public required TerraformProperty<string> ValidateFromUtc
    {
        get => GetRequiredOutput<TerraformProperty<string>>("validate_from_utc");
        set => SetProperty("validate_from_utc", value);
    }

    /// <summary>
    /// The validate_until_utc attribute.
    /// </summary>
    public TerraformProperty<string> ValidateUntilUtc
    {
        get => GetRequiredOutput<TerraformProperty<string>>("validate_until_utc");
        set => SetProperty("validate_until_utc", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for external_reference.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelThreatIntelligenceIndicatorExternalReferenceBlock>? ExternalReference
    {
        set => SetProperty("external_reference", value);
    }

    /// <summary>
    /// Block for granular_marking.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelThreatIntelligenceIndicatorGranularMarkingBlock>? GranularMarking
    {
        set => SetProperty("granular_marking", value);
    }

    /// <summary>
    /// Block for kill_chain_phase.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelThreatIntelligenceIndicatorKillChainPhaseBlock>? KillChainPhase
    {
        set => SetProperty("kill_chain_phase", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelThreatIntelligenceIndicatorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
