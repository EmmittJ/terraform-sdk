using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageBlob.
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
/// Represents a azurerm_storage_blob Terraform resource.
/// Manages a azurerm_storage_blob resource.
/// </summary>
public partial class AzurermStorageBlob(string name) : TerraformResource("azurerm_storage_blob", name)
{
    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformValue<string>? AccessTier
    {
        get => GetArgument<TerraformValue<string>>("access_tier");
        set => SetArgument("access_tier", value);
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformValue<string>? CacheControl
    {
        get => GetArgument<TerraformValue<string>>("cache_control");
        set => SetArgument("cache_control", value);
    }

    /// <summary>
    /// The content_md5 attribute.
    /// </summary>
    public TerraformValue<string>? ContentMd5
    {
        get => GetArgument<TerraformValue<string>>("content_md5");
        set => SetArgument("content_md5", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string>? ContentType
    {
        get => GetArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The encryption_scope attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionScope
    {
        get => GetArgument<TerraformValue<string>>("encryption_scope");
        set => SetArgument("encryption_scope", value);
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
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
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
    /// The parallelism attribute.
    /// </summary>
    public TerraformValue<double>? Parallelism
    {
        get => GetArgument<TerraformValue<double>>("parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<double>? Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The source_content attribute.
    /// </summary>
    public TerraformValue<string>? SourceContent
    {
        get => GetArgument<TerraformValue<string>>("source_content");
        set => SetArgument("source_content", value);
    }

    /// <summary>
    /// The source_uri attribute.
    /// </summary>
    public TerraformValue<string>? SourceUri
    {
        get => GetArgument<TerraformValue<string>>("source_uri");
        set => SetArgument("source_uri", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformValue<string> StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    public required TerraformValue<string> StorageContainerName
    {
        get => GetArgument<TerraformValue<string>>("storage_container_name");
        set => SetArgument("storage_container_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageBlobTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageBlobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
