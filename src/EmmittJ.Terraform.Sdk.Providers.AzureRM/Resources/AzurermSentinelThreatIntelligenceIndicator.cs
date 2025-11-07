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
    public TerraformLiteralProperty<double>? Confidence
    {
        get => GetProperty<TerraformLiteralProperty<double>>("confidence");
        set => this.WithProperty("confidence", value);
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreatedBy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("created_by");
        set => this.WithProperty("created_by", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Extension
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extension");
        set => this.WithProperty("extension", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The language attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Language
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language");
        set => this.WithProperty("language", value);
    }

    /// <summary>
    /// The object_marking_refs attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ObjectMarkingRefs
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("object_marking_refs");
        set => this.WithProperty("object_marking_refs", value);
    }

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Pattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pattern");
        set => this.WithProperty("pattern", value);
    }

    /// <summary>
    /// The pattern_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PatternType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pattern_type");
        set => this.WithProperty("pattern_type", value);
    }

    /// <summary>
    /// The pattern_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PatternVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pattern_version");
        set => this.WithProperty("pattern_version", value);
    }

    /// <summary>
    /// The revoked attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Revoked
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("revoked");
        set => this.WithProperty("revoked", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The threat_types attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ThreatTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("threat_types");
        set => this.WithProperty("threat_types", value);
    }

    /// <summary>
    /// The validate_from_utc attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ValidateFromUtc
    {
        get => GetProperty<TerraformLiteralProperty<string>>("validate_from_utc");
        set => this.WithProperty("validate_from_utc", value);
    }

    /// <summary>
    /// The validate_until_utc attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ValidateUntilUtc
    {
        get => GetProperty<TerraformLiteralProperty<string>>("validate_until_utc");
        set => this.WithProperty("validate_until_utc", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
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
