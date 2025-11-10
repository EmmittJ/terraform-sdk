using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for author in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataAuthorBlock : TerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The link attribute.
    /// </summary>
    public TerraformProperty<string>? Link
    {
        get => GetProperty<TerraformProperty<string>>("link");
        set => WithProperty("link", value);
    }

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
/// Block type for category in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataCategoryBlock : TerraformBlock
{
    /// <summary>
    /// The domains attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Domains
    {
        get => GetProperty<List<TerraformProperty<string>>>("domains");
        set => WithProperty("domains", value);
    }

    /// <summary>
    /// The verticals attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Verticals
    {
        get => GetProperty<List<TerraformProperty<string>>>("verticals");
        set => WithProperty("verticals", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataSourceBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformProperty<string> Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => WithProperty("kind", value);
    }

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
/// Block type for support in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataSupportBlock : TerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The link attribute.
    /// </summary>
    public TerraformProperty<string>? Link
    {
        get => GetProperty<TerraformProperty<string>>("link");
        set => WithProperty("link", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => WithProperty("tier", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelMetadataTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_sentinel_metadata resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentId is required")]
    public required TerraformProperty<string> ContentId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformProperty<string> Kind
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformProperty<string> ParentId
    {
        get => GetProperty<TerraformProperty<string>>("parent_id");
        set => this.WithProperty("parent_id", value);
    }

    /// <summary>
    /// The preview_images attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PreviewImages
    {
        get => GetProperty<List<TerraformProperty<string>>>("preview_images");
        set => this.WithProperty("preview_images", value);
    }

    /// <summary>
    /// The preview_images_dark attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PreviewImagesDark
    {
        get => GetProperty<List<TerraformProperty<string>>>("preview_images_dark");
        set => this.WithProperty("preview_images_dark", value);
    }

    /// <summary>
    /// The providers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Providers
    {
        get => GetProperty<List<TerraformProperty<string>>>("providers");
        set => this.WithProperty("providers", value);
    }

    /// <summary>
    /// The threat_analysis_tactics attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ThreatAnalysisTactics
    {
        get => GetProperty<List<TerraformProperty<string>>>("threat_analysis_tactics");
        set => this.WithProperty("threat_analysis_tactics", value);
    }

    /// <summary>
    /// The threat_analysis_techniques attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ThreatAnalysisTechniques
    {
        get => GetProperty<List<TerraformProperty<string>>>("threat_analysis_techniques");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for author.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Author block(s) allowed")]
    public List<AzurermSentinelMetadataAuthorBlock>? Author
    {
        get => GetProperty<List<AzurermSentinelMetadataAuthorBlock>>("author");
        set => this.WithProperty("author", value);
    }

    /// <summary>
    /// Block for category.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    public List<AzurermSentinelMetadataCategoryBlock>? Category
    {
        get => GetProperty<List<AzurermSentinelMetadataCategoryBlock>>("category");
        set => this.WithProperty("category", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AzurermSentinelMetadataSourceBlock>? Source
    {
        get => GetProperty<List<AzurermSentinelMetadataSourceBlock>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// Block for support.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Support block(s) allowed")]
    public List<AzurermSentinelMetadataSupportBlock>? Support
    {
        get => GetProperty<List<AzurermSentinelMetadataSupportBlock>>("support");
        set => this.WithProperty("support", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelMetadataTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSentinelMetadataTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
