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
public class AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_data_share_dataset_blob_storage.
/// </summary>
public class AzurermDataShareDatasetBlobStorageDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetBlobStorageDataSource(string name) : base("azurerm_data_share_dataset_blob_storage", name)
    {
    }

    /// <summary>
    /// The data_share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareId is required")]
    [TerraformArgument("data_share_id")]
    public required TerraformValue<string> DataShareId
    {
        get => new TerraformReference<string>(this, "data_share_id");
        set => SetArgument("data_share_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformArgument("container_name")]
    public TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    [TerraformArgument("file_path")]
    public TerraformValue<string> FilePath
    {
        get => new TerraformReference<string>(this, "file_path");
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [TerraformArgument("folder_path")]
    public TerraformValue<string> FolderPath
    {
        get => new TerraformReference<string>(this, "folder_path");
    }

    /// <summary>
    /// The storage_account attribute.
    /// </summary>
    [TerraformArgument("storage_account")]
    public TerraformList<object> StorageAccount
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "storage_account").ResolveNodes(ctx));
    }

}
