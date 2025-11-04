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
    public string? ContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_name")?.Value;
        set => this.WithProperty("container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_share_id attribute.
    /// </summary>
    public string? DataShareId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_share_id")?.Value;
        set => this.WithProperty("data_share_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

}
