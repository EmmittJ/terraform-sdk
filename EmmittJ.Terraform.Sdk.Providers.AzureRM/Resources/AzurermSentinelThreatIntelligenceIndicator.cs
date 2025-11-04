using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("created_on");
        this.DeclareOutput("defanged");
        this.DeclareOutput("external_id");
        this.DeclareOutput("external_last_updated_time_utc");
        this.DeclareOutput("guid");
        this.DeclareOutput("indicator_type");
        this.DeclareOutput("last_updated_time_utc");
        this.DeclareOutput("parsed_pattern");
    }

    /// <summary>
    /// The confidence attribute.
    /// </summary>
    public double? Confidence
    {
        get => GetProperty<TerraformLiteralProperty<double>>("confidence")?.Value;
        set => this.WithProperty("confidence", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public string? CreatedBy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("created_by")?.Value;
        set => this.WithProperty("created_by", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    public string? Extension
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extension")?.Value;
        set => this.WithProperty("extension", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The language attribute.
    /// </summary>
    public string? Language
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language")?.Value;
        set => this.WithProperty("language", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_marking_refs attribute.
    /// </summary>
    public List<string>? ObjectMarkingRefs
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("object_marking_refs")?.Value;
        set => this.WithProperty("object_marking_refs", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    public string? Pattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pattern")?.Value;
        set => this.WithProperty("pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pattern_type attribute.
    /// </summary>
    public string? PatternType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pattern_type")?.Value;
        set => this.WithProperty("pattern_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pattern_version attribute.
    /// </summary>
    public string? PatternVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pattern_version")?.Value;
        set => this.WithProperty("pattern_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revoked attribute.
    /// </summary>
    public bool? Revoked
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("revoked")?.Value;
        set => this.WithProperty("revoked", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public string? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source")?.Value;
        set => this.WithProperty("source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public List<string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The threat_types attribute.
    /// </summary>
    public List<string>? ThreatTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("threat_types")?.Value;
        set => this.WithProperty("threat_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The validate_from_utc attribute.
    /// </summary>
    public string? ValidateFromUtc
    {
        get => GetProperty<TerraformLiteralProperty<string>>("validate_from_utc")?.Value;
        set => this.WithProperty("validate_from_utc", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The validate_until_utc attribute.
    /// </summary>
    public string? ValidateUntilUtc
    {
        get => GetProperty<TerraformLiteralProperty<string>>("validate_until_utc")?.Value;
        set => this.WithProperty("validate_until_utc", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
