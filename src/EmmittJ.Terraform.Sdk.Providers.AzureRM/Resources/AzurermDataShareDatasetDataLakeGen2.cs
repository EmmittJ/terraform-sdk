using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_share_dataset_data_lake_gen2 resource.
/// </summary>
public class AzurermDataShareDatasetDataLakeGen2 : TerraformResource
{
    public AzurermDataShareDatasetDataLakeGen2(string name) : base("azurerm_data_share_dataset_data_lake_gen2", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("display_name");
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
    /// The file_system_name attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemName
    {
        get => GetProperty<TerraformProperty<string>>("file_system_name");
        set => this.WithProperty("file_system_name", value);
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
    /// The share_id attribute.
    /// </summary>
    public TerraformProperty<string>? ShareId
    {
        get => GetProperty<TerraformProperty<string>>("share_id");
        set => this.WithProperty("share_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

}
