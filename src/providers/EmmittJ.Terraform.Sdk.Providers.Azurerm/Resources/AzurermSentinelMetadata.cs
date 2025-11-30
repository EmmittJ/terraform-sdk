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
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The link attribute.
    /// </summary>
    public TerraformValue<string>? Link
    {
        get => new TerraformReference<string>(this, "link");
        set => SetArgument("link", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domains").ResolveNodes(ctx));
        set => SetArgument("domains", value);
    }

    /// <summary>
    /// The verticals attribute.
    /// </summary>
    public TerraformList<string>? Verticals
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "verticals").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
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
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The link attribute.
    /// </summary>
    public TerraformValue<string>? Link
    {
        get => new TerraformReference<string>(this, "link");
        set => SetArgument("link", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "content_id");
        set => SetArgument("content_id", value);
    }

    /// <summary>
    /// The content_schema_version attribute.
    /// </summary>
    public TerraformValue<string>? ContentSchemaVersion
    {
        get => new TerraformReference<string>(this, "content_schema_version");
        set => SetArgument("content_schema_version", value);
    }

    /// <summary>
    /// The custom_version attribute.
    /// </summary>
    public TerraformValue<string>? CustomVersion
    {
        get => new TerraformReference<string>(this, "custom_version");
        set => SetArgument("custom_version", value);
    }

    /// <summary>
    /// The dependency attribute.
    /// </summary>
    public TerraformValue<string>? Dependency
    {
        get => new TerraformReference<string>(this, "dependency");
        set => SetArgument("dependency", value);
    }

    /// <summary>
    /// The first_publish_date attribute.
    /// </summary>
    public TerraformValue<string>? FirstPublishDate
    {
        get => new TerraformReference<string>(this, "first_publish_date");
        set => SetArgument("first_publish_date", value);
    }

    /// <summary>
    /// The icon_id attribute.
    /// </summary>
    public TerraformValue<string>? IconId
    {
        get => new TerraformReference<string>(this, "icon_id");
        set => SetArgument("icon_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The last_publish_date attribute.
    /// </summary>
    public TerraformValue<string>? LastPublishDate
    {
        get => new TerraformReference<string>(this, "last_publish_date");
        set => SetArgument("last_publish_date", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    public required TerraformValue<string> ParentId
    {
        get => new TerraformReference<string>(this, "parent_id");
        set => SetArgument("parent_id", value);
    }

    /// <summary>
    /// The preview_images attribute.
    /// </summary>
    public TerraformList<string>? PreviewImages
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preview_images").ResolveNodes(ctx));
        set => SetArgument("preview_images", value);
    }

    /// <summary>
    /// The preview_images_dark attribute.
    /// </summary>
    public TerraformList<string>? PreviewImagesDark
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preview_images_dark").ResolveNodes(ctx));
        set => SetArgument("preview_images_dark", value);
    }

    /// <summary>
    /// The providers attribute.
    /// </summary>
    public TerraformList<string>? Providers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "providers").ResolveNodes(ctx));
        set => SetArgument("providers", value);
    }

    /// <summary>
    /// The threat_analysis_tactics attribute.
    /// </summary>
    public TerraformList<string>? ThreatAnalysisTactics
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "threat_analysis_tactics").ResolveNodes(ctx));
        set => SetArgument("threat_analysis_tactics", value);
    }

    /// <summary>
    /// The threat_analysis_techniques attribute.
    /// </summary>
    public TerraformList<string>? ThreatAnalysisTechniques
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "threat_analysis_techniques").ResolveNodes(ctx));
        set => SetArgument("threat_analysis_techniques", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
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
