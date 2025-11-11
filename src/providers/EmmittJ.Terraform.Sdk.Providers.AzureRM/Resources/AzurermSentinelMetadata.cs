using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for author in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataAuthorBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The link attribute.
    /// </summary>
    [TerraformPropertyName("link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Link { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for category in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataCategoryBlock
{
    /// <summary>
    /// The domains attribute.
    /// </summary>
    [TerraformPropertyName("domains")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Domains { get; set; }

    /// <summary>
    /// The verticals attribute.
    /// </summary>
    [TerraformPropertyName("verticals")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Verticals { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataSourceBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformPropertyName("kind")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Kind { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for support in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataSupportBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The link attribute.
    /// </summary>
    [TerraformPropertyName("link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Link { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformPropertyName("tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Tier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelMetadataTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_sentinel_metadata resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSentinelMetadata : TerraformResource
{
    public AzurermSentinelMetadata(string name) : base("azurerm_sentinel_metadata", name)
    {
    }

    /// <summary>
    /// The content_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentId is required")]
    [TerraformPropertyName("content_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContentId { get; set; }

    /// <summary>
    /// The content_schema_version attribute.
    /// </summary>
    [TerraformPropertyName("content_schema_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentSchemaVersion { get; set; }

    /// <summary>
    /// The custom_version attribute.
    /// </summary>
    [TerraformPropertyName("custom_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomVersion { get; set; }

    /// <summary>
    /// The dependency attribute.
    /// </summary>
    [TerraformPropertyName("dependency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Dependency { get; set; }

    /// <summary>
    /// The first_publish_date attribute.
    /// </summary>
    [TerraformPropertyName("first_publish_date")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FirstPublishDate { get; set; }

    /// <summary>
    /// The icon_id attribute.
    /// </summary>
    [TerraformPropertyName("icon_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IconId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformPropertyName("kind")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Kind { get; set; }

    /// <summary>
    /// The last_publish_date attribute.
    /// </summary>
    [TerraformPropertyName("last_publish_date")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LastPublishDate { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    [TerraformPropertyName("parent_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ParentId { get; set; }

    /// <summary>
    /// The preview_images attribute.
    /// </summary>
    [TerraformPropertyName("preview_images")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreviewImages { get; set; }

    /// <summary>
    /// The preview_images_dark attribute.
    /// </summary>
    [TerraformPropertyName("preview_images_dark")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreviewImagesDark { get; set; }

    /// <summary>
    /// The providers attribute.
    /// </summary>
    [TerraformPropertyName("providers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Providers { get; set; }

    /// <summary>
    /// The threat_analysis_tactics attribute.
    /// </summary>
    [TerraformPropertyName("threat_analysis_tactics")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ThreatAnalysisTactics { get; set; }

    /// <summary>
    /// The threat_analysis_techniques attribute.
    /// </summary>
    [TerraformPropertyName("threat_analysis_techniques")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ThreatAnalysisTechniques { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for author.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Author block(s) allowed")]
    [TerraformPropertyName("author")]
    public TerraformList<TerraformBlock<AzurermSentinelMetadataAuthorBlock>>? Author { get; set; }

    /// <summary>
    /// Block for category.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    [TerraformPropertyName("category")]
    public TerraformList<TerraformBlock<AzurermSentinelMetadataCategoryBlock>>? Category { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AzurermSentinelMetadataSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for support.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Support block(s) allowed")]
    [TerraformPropertyName("support")]
    public TerraformList<TerraformBlock<AzurermSentinelMetadataSupportBlock>>? Support { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSentinelMetadataTimeoutsBlock>? Timeouts { get; set; }

}
