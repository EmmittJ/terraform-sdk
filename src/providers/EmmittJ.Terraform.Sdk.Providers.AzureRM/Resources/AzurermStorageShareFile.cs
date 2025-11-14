using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageShareFileTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_storage_share_file resource.
/// </summary>
public class AzurermStorageShareFile : TerraformResource
{
    public AzurermStorageShareFile(string name) : base("azurerm_storage_share_file", name)
    {
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformArgument("content_disposition")]
    public TerraformValue<string>? ContentDisposition
    {
        get => new TerraformReference<string>(this, "content_disposition");
        set => SetArgument("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformArgument("content_encoding")]
    public TerraformValue<string>? ContentEncoding
    {
        get => new TerraformReference<string>(this, "content_encoding");
        set => SetArgument("content_encoding", value);
    }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    [TerraformArgument("content_md5")]
    public TerraformValue<string>? ContentMd5
    {
        get => new TerraformReference<string>(this, "content_md5");
        set => SetArgument("content_md5", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformArgument("content_type")]
    public TerraformValue<string>? ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformArgument("metadata")]
    public TerraformMap<string>? Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformArgument("source")]
    public TerraformValue<string>? Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The storage_share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageShareId is required")]
    [TerraformArgument("storage_share_id")]
    public required TerraformValue<string> StorageShareId
    {
        get => new TerraformReference<string>(this, "storage_share_id");
        set => SetArgument("storage_share_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageShareFileTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    [TerraformArgument("content_length")]
    public TerraformValue<double> ContentLength
    {
        get => new TerraformReference<double>(this, "content_length");
    }

}
