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
public class AzurermStorageBlobDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_storage_blob.
/// </summary>
public class AzurermStorageBlobDataSource : TerraformDataSource
{
    public AzurermStorageBlobDataSource(string name) : base("azurerm_storage_blob", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageBlobDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformArgument("access_tier")]
    public TerraformValue<string> AccessTier
    {
        get => new TerraformReference<string>(this, "access_tier");
    }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    [TerraformArgument("content_md5")]
    public TerraformValue<string> ContentMd5
    {
        get => new TerraformReference<string>(this, "content_md5");
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformArgument("content_type")]
    public TerraformValue<string> ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
    }

    /// <summary>
    /// The encryption_scope attribute.
    /// </summary>
    [TerraformArgument("encryption_scope")]
    public TerraformValue<string> EncryptionScope
    {
        get => new TerraformReference<string>(this, "encryption_scope");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformArgument("url")]
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
