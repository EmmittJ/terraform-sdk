using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_share_dataset_blob_storage resource.
/// </summary>
public class AzurermDataShareDatasetBlobStorage : TerraformResource
{
    public AzurermDataShareDatasetBlobStorage(string name) : base("azurerm_data_share_dataset_blob_storage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("display_name");
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerName
    {
        get => GetProperty<TerraformProperty<string>>("container_name");
        set => this.WithProperty("container_name", value);
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
    /// The file_path attribute.
    /// </summary>
    public TerraformProperty<string>? FilePath
    {
        get => GetProperty<TerraformProperty<string>>("file_path");
        set => this.WithProperty("file_path", value);
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public TerraformProperty<string>? FolderPath
    {
        get => GetProperty<TerraformProperty<string>>("folder_path");
        set => this.WithProperty("folder_path", value);
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
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

}
