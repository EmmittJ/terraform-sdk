using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_blob_storage.
/// </summary>
public class AzurermDataShareDatasetBlobStorageDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetBlobStorageDataSource(string name) : base("azurerm_data_share_dataset_blob_storage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("container_name");
        SetOutput("display_name");
        SetOutput("file_path");
        SetOutput("folder_path");
        SetOutput("storage_account");
        SetOutput("data_share_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The data_share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareId is required")]
    public required TerraformProperty<string> DataShareId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_share_id");
        set => SetProperty("data_share_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataShareDatasetBlobStorageDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformExpression ContainerName => this["container_name"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformExpression FilePath => this["file_path"];

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public TerraformExpression FolderPath => this["folder_path"];

    /// <summary>
    /// The storage_account attribute.
    /// </summary>
    public TerraformExpression StorageAccount => this["storage_account"];

}
