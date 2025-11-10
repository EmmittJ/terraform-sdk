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
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The link attribute.
    /// </summary>
    public TerraformProperty<string>? Link
    {
        set => SetProperty("link", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
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
        set => SetProperty("domains", value);
    }

    /// <summary>
    /// The verticals attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Verticals
    {
        set => SetProperty("verticals", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformProperty<string> Kind
    {
        set => SetProperty("kind", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
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
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The link attribute.
    /// </summary>
    public TerraformProperty<string>? Link
    {
        set => SetProperty("link", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        set => SetProperty("tier", value);
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
        SetOutput("content_id");
        SetOutput("content_schema_version");
        SetOutput("custom_version");
        SetOutput("dependency");
        SetOutput("first_publish_date");
        SetOutput("icon_id");
        SetOutput("id");
        SetOutput("kind");
        SetOutput("last_publish_date");
        SetOutput("name");
        SetOutput("parent_id");
        SetOutput("preview_images");
        SetOutput("preview_images_dark");
        SetOutput("providers");
        SetOutput("threat_analysis_tactics");
        SetOutput("threat_analysis_techniques");
        SetOutput("version");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The content_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentId is required")]
    public required TerraformProperty<string> ContentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_id");
        set => SetProperty("content_id", value);
    }

    /// <summary>
    /// The content_schema_version attribute.
    /// </summary>
    public TerraformProperty<string> ContentSchemaVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_schema_version");
        set => SetProperty("content_schema_version", value);
    }

    /// <summary>
    /// The custom_version attribute.
    /// </summary>
    public TerraformProperty<string> CustomVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_version");
        set => SetProperty("custom_version", value);
    }

    /// <summary>
    /// The dependency attribute.
    /// </summary>
    public TerraformProperty<string> Dependency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dependency");
        set => SetProperty("dependency", value);
    }

    /// <summary>
    /// The first_publish_date attribute.
    /// </summary>
    public TerraformProperty<string> FirstPublishDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("first_publish_date");
        set => SetProperty("first_publish_date", value);
    }

    /// <summary>
    /// The icon_id attribute.
    /// </summary>
    public TerraformProperty<string> IconId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("icon_id");
        set => SetProperty("icon_id", value);
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
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformProperty<string> Kind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kind");
        set => SetProperty("kind", value);
    }

    /// <summary>
    /// The last_publish_date attribute.
    /// </summary>
    public TerraformProperty<string> LastPublishDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("last_publish_date");
        set => SetProperty("last_publish_date", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformProperty<string> ParentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_id");
        set => SetProperty("parent_id", value);
    }

    /// <summary>
    /// The preview_images attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreviewImages
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preview_images");
        set => SetProperty("preview_images", value);
    }

    /// <summary>
    /// The preview_images_dark attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreviewImagesDark
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preview_images_dark");
        set => SetProperty("preview_images_dark", value);
    }

    /// <summary>
    /// The providers attribute.
    /// </summary>
    public List<TerraformProperty<string>> Providers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("providers");
        set => SetProperty("providers", value);
    }

    /// <summary>
    /// The threat_analysis_tactics attribute.
    /// </summary>
    public List<TerraformProperty<string>> ThreatAnalysisTactics
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("threat_analysis_tactics");
        set => SetProperty("threat_analysis_tactics", value);
    }

    /// <summary>
    /// The threat_analysis_techniques attribute.
    /// </summary>
    public List<TerraformProperty<string>> ThreatAnalysisTechniques
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("threat_analysis_techniques");
        set => SetProperty("threat_analysis_techniques", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
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
    /// Block for author.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Author block(s) allowed")]
    public List<AzurermSentinelMetadataAuthorBlock>? Author
    {
        set => SetProperty("author", value);
    }

    /// <summary>
    /// Block for category.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    public List<AzurermSentinelMetadataCategoryBlock>? Category
    {
        set => SetProperty("category", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AzurermSentinelMetadataSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// Block for support.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Support block(s) allowed")]
    public List<AzurermSentinelMetadataSupportBlock>? Support
    {
        set => SetProperty("support", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelMetadataTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
