using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_metadata resource.
/// </summary>
public class AzurermSentinelMetadata : TerraformResource
{
    public AzurermSentinelMetadata(string name) : base("azurerm_sentinel_metadata", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The content_id attribute.
    /// </summary>
    public string? ContentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_id")?.Value;
        set => this.WithProperty("content_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_schema_version attribute.
    /// </summary>
    public string? ContentSchemaVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_schema_version")?.Value;
        set => this.WithProperty("content_schema_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_version attribute.
    /// </summary>
    public string? CustomVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_version")?.Value;
        set => this.WithProperty("custom_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dependency attribute.
    /// </summary>
    public string? Dependency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dependency")?.Value;
        set => this.WithProperty("dependency", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The first_publish_date attribute.
    /// </summary>
    public string? FirstPublishDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("first_publish_date")?.Value;
        set => this.WithProperty("first_publish_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The icon_id attribute.
    /// </summary>
    public string? IconId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("icon_id")?.Value;
        set => this.WithProperty("icon_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kind attribute.
    /// </summary>
    public string? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind")?.Value;
        set => this.WithProperty("kind", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The last_publish_date attribute.
    /// </summary>
    public string? LastPublishDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("last_publish_date")?.Value;
        set => this.WithProperty("last_publish_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public string? ParentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_id")?.Value;
        set => this.WithProperty("parent_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preview_images attribute.
    /// </summary>
    public List<string>? PreviewImages
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preview_images")?.Value;
        set => this.WithProperty("preview_images", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The preview_images_dark attribute.
    /// </summary>
    public List<string>? PreviewImagesDark
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preview_images_dark")?.Value;
        set => this.WithProperty("preview_images_dark", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The providers attribute.
    /// </summary>
    public List<string>? Providers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("providers")?.Value;
        set => this.WithProperty("providers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The threat_analysis_tactics attribute.
    /// </summary>
    public List<string>? ThreatAnalysisTactics
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("threat_analysis_tactics")?.Value;
        set => this.WithProperty("threat_analysis_tactics", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The threat_analysis_techniques attribute.
    /// </summary>
    public List<string>? ThreatAnalysisTechniques
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("threat_analysis_techniques")?.Value;
        set => this.WithProperty("threat_analysis_techniques", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
