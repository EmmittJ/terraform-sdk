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
    public string? FilesystemName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filesystem_name")?.Value;
        set => this.WithProperty("filesystem_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public string? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group")?.Value;
        set => this.WithProperty("group", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The owner attribute.
    /// </summary>
    public string? Owner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner")?.Value;
        set => this.WithProperty("owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public string? Resource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource")?.Value;
        set => this.WithProperty("resource", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public string? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id")?.Value;
        set => this.WithProperty("storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
