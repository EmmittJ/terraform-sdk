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
public class AzurermStorageBlobTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_blob resource.
/// </summary>
public class AzurermStorageBlob : TerraformResource
{
    public AzurermStorageBlob(string name) : base("azurerm_storage_blob", name)
    {
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformArgument("access_tier")]
    public TerraformValue<string> AccessTier
    {
        get => new TerraformReference<string>(this, "access_tier");
        set => SetArgument("access_tier", value);
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformArgument("cache_control")]
    public TerraformValue<string>? CacheControl
    {
        get => new TerraformReference<string>(this, "cache_control");
        set => SetArgument("cache_control", value);
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
    /// The encryption_scope attribute.
    /// </summary>
    [TerraformArgument("encryption_scope")]
    public TerraformValue<string>? EncryptionScope
    {
        get => new TerraformReference<string>(this, "encryption_scope");
        set => SetArgument("encryption_scope", value);
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
    public TerraformMap<string> Metadata
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
    /// The parallelism attribute.
    /// </summary>
    [TerraformArgument("parallelism")]
    public TerraformValue<double>? Parallelism
    {
        get => new TerraformReference<double>(this, "parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformArgument("size")]
    public TerraformValue<double>? Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
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
    /// The source_content attribute.
    /// </summary>
    [TerraformArgument("source_content")]
    public TerraformValue<string>? SourceContent
    {
        get => new TerraformReference<string>(this, "source_content");
        set => SetArgument("source_content", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    [TerraformArgument("source_uri")]
    public TerraformValue<string>? SourceUri
    {
        get => new TerraformReference<string>(this, "source_uri");
        set => SetArgument("source_uri", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformArgument("storage_account_name")]
    public required TerraformValue<string> StorageAccountName
    {
        get => new TerraformReference<string>(this, "storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    [TerraformArgument("storage_container_name")]
    public required TerraformValue<string> StorageContainerName
    {
        get => new TerraformReference<string>(this, "storage_container_name");
        set => SetArgument("storage_container_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageBlobTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
