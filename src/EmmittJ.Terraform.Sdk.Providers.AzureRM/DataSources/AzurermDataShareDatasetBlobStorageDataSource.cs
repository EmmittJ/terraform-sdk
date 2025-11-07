using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("container_name");
        this.DeclareOutput("display_name");
        this.DeclareOutput("file_path");
        this.DeclareOutput("folder_path");
        this.DeclareOutput("storage_account");
    }

    /// <summary>
    /// The data_share_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataShareId
    {
        get => GetProperty<TerraformProperty<string>>("data_share_id");
        set => this.WithProperty("data_share_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
