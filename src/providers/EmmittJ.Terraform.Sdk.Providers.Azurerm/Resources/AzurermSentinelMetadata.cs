using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for author in AzurermSentinelMetadata.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataAuthorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "author";

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The link attribute.
    /// </summary>
    public TerraformValue<string>? Link
    {
        get => GetArgument<TerraformValue<string>>("link");
        set => SetArgument("link", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for category in AzurermSentinelMetadata.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "category";

    /// <summary>
    /// The domains attribute.
    /// </summary>
    public TerraformList<string>? Domains
    {
        get => GetArgument<TerraformList<string>>("domains");
        set => SetArgument("domains", value);
    }

    /// <summary>
    /// The verticals attribute.
    /// </summary>
    public TerraformList<string>? Verticals
    {
        get => GetArgument<TerraformList<string>>("verticals");
        set => SetArgument("verticals", value);
    }

}


/// <summary>
/// Block type for source in AzurermSentinelMetadata.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for support in AzurermSentinelMetadata.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelMetadataSupportBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "support";

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The link attribute.
    /// </summary>
    public TerraformValue<string>? Link
    {
        get => GetArgument<TerraformValue<string>>("link");
        set => SetArgument("link", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSentinelMetadata.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelMetadataTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_sentinel_metadata Terraform resource.
/// Manages a azurerm_sentinel_metadata resource.
/// </summary>
public partial class AzurermSentinelMetadata(string name) : TerraformResource("azurerm_sentinel_metadata", name)
{
    /// <summary>
    /// The content_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentId is required")]
    public required TerraformValue<string> ContentId
    {
        get => GetArgument<TerraformValue<string>>("content_id");
        set => SetArgument("content_id", value);
    }

    /// <summary>
    /// The content_schema_version attribute.
    /// </summary>
    public TerraformValue<string>? ContentSchemaVersion
    {
        get => GetArgument<TerraformValue<string>>("content_schema_version");
        set => SetArgument("content_schema_version", value);
    }

    /// <summary>
    /// The custom_version attribute.
    /// </summary>
    public TerraformValue<string>? CustomVersion
    {
        get => GetArgument<TerraformValue<string>>("custom_version");
        set => SetArgument("custom_version", value);
    }

    /// <summary>
    /// The dependency attribute.
    /// </summary>
    public TerraformValue<string>? Dependency
    {
        get => GetArgument<TerraformValue<string>>("dependency");
        set => SetArgument("dependency", value);
    }

    /// <summary>
    /// The first_publish_date attribute.
    /// </summary>
    public TerraformValue<string>? FirstPublishDate
    {
        get => GetArgument<TerraformValue<string>>("first_publish_date");
        set => SetArgument("first_publish_date", value);
    }

    /// <summary>
    /// The icon_id attribute.
    /// </summary>
    public TerraformValue<string>? IconId
    {
        get => GetArgument<TerraformValue<string>>("icon_id");
        set => SetArgument("icon_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => GetArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The last_publish_date attribute.
    /// </summary>
    public TerraformValue<string>? LastPublishDate
    {
        get => GetArgument<TerraformValue<string>>("last_publish_date");
        set => SetArgument("last_publish_date", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformValue<string> ParentId
    {
        get => GetArgument<TerraformValue<string>>("parent_id");
        set => SetArgument("parent_id", value);
    }

    /// <summary>
    /// The preview_images attribute.
    /// </summary>
    public TerraformList<string>? PreviewImages
    {
        get => GetArgument<TerraformList<string>>("preview_images");
        set => SetArgument("preview_images", value);
    }

    /// <summary>
    /// The preview_images_dark attribute.
    /// </summary>
    public TerraformList<string>? PreviewImagesDark
    {
        get => GetArgument<TerraformList<string>>("preview_images_dark");
        set => SetArgument("preview_images_dark", value);
    }

    /// <summary>
    /// The providers attribute.
    /// </summary>
    public TerraformList<string>? Providers
    {
        get => GetArgument<TerraformList<string>>("providers");
        set => SetArgument("providers", value);
    }

    /// <summary>
    /// The threat_analysis_tactics attribute.
    /// </summary>
    public TerraformList<string>? ThreatAnalysisTactics
    {
        get => GetArgument<TerraformList<string>>("threat_analysis_tactics");
        set => SetArgument("threat_analysis_tactics", value);
    }

    /// <summary>
    /// The threat_analysis_techniques attribute.
    /// </summary>
    public TerraformList<string>? ThreatAnalysisTechniques
    {
        get => GetArgument<TerraformList<string>>("threat_analysis_techniques");
        set => SetArgument("threat_analysis_techniques", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Author block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Author block(s) allowed")]
    public TerraformList<AzurermSentinelMetadataAuthorBlock>? Author
    {
        get => GetArgument<TerraformList<AzurermSentinelMetadataAuthorBlock>>("author");
        set => SetArgument("author", value);
    }

    /// <summary>
    /// Category block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Category block(s) allowed")]
    public TerraformList<AzurermSentinelMetadataCategoryBlock>? Category
    {
        get => GetArgument<TerraformList<AzurermSentinelMetadataCategoryBlock>>("category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public TerraformList<AzurermSentinelMetadataSourceBlock>? Source
    {
        get => GetArgument<TerraformList<AzurermSentinelMetadataSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Support block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Support block(s) allowed")]
    public TerraformList<AzurermSentinelMetadataSupportBlock>? Support
    {
        get => GetArgument<TerraformList<AzurermSentinelMetadataSupportBlock>>("support");
        set => SetArgument("support", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelMetadataTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelMetadataTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
