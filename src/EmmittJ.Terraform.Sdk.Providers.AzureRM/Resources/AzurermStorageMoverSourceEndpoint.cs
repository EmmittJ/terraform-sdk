using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_mover_source_endpoint resource.
/// </summary>
public class AzurermStorageMoverSourceEndpoint : TerraformResource
{
    public AzurermStorageMoverSourceEndpoint(string name) : base("azurerm_storage_mover_source_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The export attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Export
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export");
        set => this.WithProperty("export", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Host
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host");
        set => this.WithProperty("host", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The nfs_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NfsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nfs_version");
        set => this.WithProperty("nfs_version", value);
    }

    /// <summary>
    /// The storage_mover_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageMoverId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_mover_id");
        set => this.WithProperty("storage_mover_id", value);
    }

}
