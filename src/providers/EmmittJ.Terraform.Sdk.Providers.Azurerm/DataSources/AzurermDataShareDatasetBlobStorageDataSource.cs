using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataShareDatasetBlobStorageDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_data_share_dataset_blob_storage Terraform data source.
/// Retrieves information about a azurerm_data_share_dataset_blob_storage.
/// </summary>
public partial class AzurermDataShareDatasetBlobStorageDataSource(string name) : TerraformDataSource("azurerm_data_share_dataset_blob_storage", name)
{
    /// <summary>
    /// The data_share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareId is required")]
    public required TerraformValue<string> DataShareId
    {
        get => new TerraformReference<string>(this, "data_share_id");
        set => SetArgument("data_share_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformValue<string> FilePath
    {
        get => new TerraformReference<string>(this, "file_path");
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public TerraformValue<string> FolderPath
    {
        get => new TerraformReference<string>(this, "folder_path");
    }

    /// <summary>
    /// The storage_account attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageAccount
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "storage_account").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
