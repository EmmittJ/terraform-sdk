using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for author in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelMetadataAuthorBlock : TerraformBlockBase
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The link attribute.
    /// </summary>
    [TerraformProperty("link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Link { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for category in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelMetadataCategoryBlock : TerraformBlockBase
{
    /// <summary>
    /// The domains attribute.
    /// </summary>
    [TerraformProperty("domains")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Domains { get; set; }

    /// <summary>
    /// The verticals attribute.
    /// </summary>
    [TerraformProperty("verticals")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Verticals { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelMetadataSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformProperty("kind")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Kind { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for support in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelMetadataSupportBlock : TerraformBlockBase
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The link attribute.
    /// </summary>
    [TerraformProperty("link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Link { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformProperty("tier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Tier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelMetadataTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_sentinel_metadata resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSentinelMetadata : TerraformResource
{
    public AzurermSentinelMetadata(string name) : base("azurerm_sentinel_metadata", name)
    {
    }

    /// <summary>
    /// The content_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentId is required")]
    [TerraformProperty("content_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContentId { get; set; }

    /// <summary>
    /// The content_schema_version attribute.
    /// </summary>
    [TerraformProperty("content_schema_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContentSchemaVersion { get; set; }

    /// <summary>
    /// The custom_version attribute.
    /// </summary>
    [TerraformProperty("custom_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomVersion { get; set; }

    /// <summary>
    /// The dependency attribute.
    /// </summary>
    [TerraformProperty("dependency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Dependency { get; set; }

    /// <summary>
    /// The first_publish_date attribute.
    /// </summary>
    [TerraformProperty("first_publish_date")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FirstPublishDate { get; set; }

    /// <summary>
    /// The icon_id attribute.
    /// </summary>
    [TerraformProperty("icon_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IconId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformProperty("kind")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Kind { get; set; }

    /// <summary>
    /// The last_publish_date attribute.
    /// </summary>
    [TerraformProperty("last_publish_date")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LastPublishDate { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    [TerraformProperty("parent_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ParentId { get; set; }

    /// <summary>
    /// The preview_images attribute.
    /// </summary>
    [TerraformProperty("preview_images")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? PreviewImages { get; set; }

    /// <summary>
    /// The preview_images_dark attribute.
    /// </summary>
    [TerraformProperty("preview_images_dark")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? PreviewImagesDark { get; set; }

    /// <summary>
    /// The providers attribute.
    /// </summary>
    [TerraformProperty("providers")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Providers { get; set; }

    /// <summary>
    /// The threat_analysis_tactics attribute.
    /// </summary>
    [TerraformProperty("threat_analysis_tactics")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ThreatAnalysisTactics { get; set; }

    /// <summary>
    /// The threat_analysis_techniques attribute.
    /// </summary>
    [TerraformProperty("threat_analysis_techniques")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ThreatAnalysisTechniques { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for author.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Author block(s) allowed")]
    [TerraformProperty("author")]
    public TerraformList<TerraformBlock<AzurermSentinelMetadataAuthorBlock>>? Author { get; set; }

    /// <summary>
    /// Block for category.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    [TerraformProperty("category")]
    public TerraformList<TerraformBlock<AzurermSentinelMetadataCategoryBlock>>? Category { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public TerraformList<TerraformBlock<AzurermSentinelMetadataSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for support.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Support block(s) allowed")]
    [TerraformProperty("support")]
    public TerraformList<TerraformBlock<AzurermSentinelMetadataSupportBlock>>? Support { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSentinelMetadataTimeoutsBlock>? Timeouts { get; set; }

}
