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
    public string? FilePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_path")?.Value;
        set => this.WithProperty("file_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_system_name attribute.
    /// </summary>
    public string? FileSystemName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_name")?.Value;
        set => this.WithProperty("file_system_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public string? FolderPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder_path")?.Value;
        set => this.WithProperty("folder_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    public string? ShareId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("share_id")?.Value;
        set => this.WithProperty("share_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

}
