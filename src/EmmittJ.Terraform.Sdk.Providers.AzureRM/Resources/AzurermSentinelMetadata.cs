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
    public TerraformLiteralProperty<string>? ContentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_id");
        set => this.WithProperty("content_id", value);
    }

    /// <summary>
    /// The content_schema_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentSchemaVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_schema_version");
        set => this.WithProperty("content_schema_version", value);
    }

    /// <summary>
    /// The custom_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_version");
        set => this.WithProperty("custom_version", value);
    }

    /// <summary>
    /// The dependency attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Dependency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dependency");
        set => this.WithProperty("dependency", value);
    }

    /// <summary>
    /// The first_publish_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FirstPublishDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("first_publish_date");
        set => this.WithProperty("first_publish_date", value);
    }

    /// <summary>
    /// The icon_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IconId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("icon_id");
        set => this.WithProperty("icon_id", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The last_publish_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LastPublishDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("last_publish_date");
        set => this.WithProperty("last_publish_date", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ParentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_id");
        set => this.WithProperty("parent_id", value);
    }

    /// <summary>
    /// The preview_images attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? PreviewImages
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preview_images");
        set => this.WithProperty("preview_images", value);
    }

    /// <summary>
    /// The preview_images_dark attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? PreviewImagesDark
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preview_images_dark");
        set => this.WithProperty("preview_images_dark", value);
    }

    /// <summary>
    /// The providers attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Providers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("providers");
        set => this.WithProperty("providers", value);
    }

    /// <summary>
    /// The threat_analysis_tactics attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ThreatAnalysisTactics
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("threat_analysis_tactics");
        set => this.WithProperty("threat_analysis_tactics", value);
    }

    /// <summary>
    /// The threat_analysis_techniques attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ThreatAnalysisTechniques
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("threat_analysis_techniques");
        set => this.WithProperty("threat_analysis_techniques", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
