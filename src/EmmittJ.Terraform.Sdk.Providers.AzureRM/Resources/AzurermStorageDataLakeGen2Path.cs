using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_data_lake_gen2_path resource.
/// </summary>
public class AzurermStorageDataLakeGen2Path : TerraformResource
{
    public AzurermStorageDataLakeGen2Path(string name) : base("azurerm_storage_data_lake_gen2_path", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The filesystem_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FilesystemName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filesystem_name");
        set => this.WithProperty("filesystem_name", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group");
        set => this.WithProperty("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Owner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner");
        set => this.WithProperty("owner", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Resource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource");
        set => this.WithProperty("resource", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

}
