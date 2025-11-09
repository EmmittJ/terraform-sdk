using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_share_directory resource.
/// </summary>
public class AzurermStorageShareDirectory : TerraformResource
{
    public AzurermStorageShareDirectory(string name) : base("azurerm_storage_share_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The metadata attribute.
    /// </summary>
    public TerraformMapProperty<string>? Metadata
    {
        get => GetProperty<TerraformMapProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
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
    /// The storage_share_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageShareId
    {
        get => GetProperty<TerraformProperty<string>>("storage_share_id");
        set => this.WithProperty("storage_share_id", value);
    }

}
