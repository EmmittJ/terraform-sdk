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
    public TerraformProperty<string>? ContentId
    {
        get => GetProperty<TerraformProperty<string>>("content_id");
        set => this.WithProperty("content_id", value);
    }

    /// <summary>
    /// The content_schema_version attribute.
    /// </summary>
    public TerraformProperty<string>? ContentSchemaVersion
    {
        get => GetProperty<TerraformProperty<string>>("content_schema_version");
        set => this.WithProperty("content_schema_version", value);
    }

    /// <summary>
    /// The custom_version attribute.
    /// </summary>
    public TerraformProperty<string>? CustomVersion
    {
        get => GetProperty<TerraformProperty<string>>("custom_version");
        set => this.WithProperty("custom_version", value);
    }

    /// <summary>
    /// The dependency attribute.
    /// </summary>
    public TerraformProperty<string>? Dependency
    {
        get => GetProperty<TerraformProperty<string>>("dependency");
        set => this.WithProperty("dependency", value);
    }

    /// <summary>
    /// The first_publish_date attribute.
    /// </summary>
    public TerraformProperty<string>? FirstPublishDate
    {
        get => GetProperty<TerraformProperty<string>>("first_publish_date");
        set => this.WithProperty("first_publish_date", value);
    }

    /// <summary>
    /// The icon_id attribute.
    /// </summary>
    public TerraformProperty<string>? IconId
    {
        get => GetProperty<TerraformProperty<string>>("icon_id");
        set => this.WithProperty("icon_id", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The last_publish_date attribute.
    /// </summary>
    public TerraformProperty<string>? LastPublishDate
    {
        get => GetProperty<TerraformProperty<string>>("last_publish_date");
        set => this.WithProperty("last_publish_date", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformProperty<string>? ParentId
    {
        get => GetProperty<TerraformProperty<string>>("parent_id");
        set => this.WithProperty("parent_id", value);
    }

    /// <summary>
    /// The preview_images attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PreviewImages
    {
        get => GetProperty<TerraformProperty<List<string>>>("preview_images");
        set => this.WithProperty("preview_images", value);
    }

    /// <summary>
    /// The preview_images_dark attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PreviewImagesDark
    {
        get => GetProperty<TerraformProperty<List<string>>>("preview_images_dark");
        set => this.WithProperty("preview_images_dark", value);
    }

    /// <summary>
    /// The providers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Providers
    {
        get => GetProperty<TerraformProperty<List<string>>>("providers");
        set => this.WithProperty("providers", value);
    }

    /// <summary>
    /// The threat_analysis_tactics attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ThreatAnalysisTactics
    {
        get => GetProperty<TerraformProperty<List<string>>>("threat_analysis_tactics");
        set => this.WithProperty("threat_analysis_tactics", value);
    }

    /// <summary>
    /// The threat_analysis_techniques attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ThreatAnalysisTechniques
    {
        get => GetProperty<TerraformProperty<List<string>>>("threat_analysis_techniques");
        set => this.WithProperty("threat_analysis_techniques", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
