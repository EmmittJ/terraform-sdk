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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The export attribute.
    /// </summary>
    public TerraformProperty<string>? Export
    {
        get => GetProperty<TerraformProperty<string>>("export");
        set => this.WithProperty("export", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    public TerraformProperty<string>? Host
    {
        get => GetProperty<TerraformProperty<string>>("host");
        set => this.WithProperty("host", value);
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
    /// The nfs_version attribute.
    /// </summary>
    public TerraformProperty<string>? NfsVersion
    {
        get => GetProperty<TerraformProperty<string>>("nfs_version");
        set => this.WithProperty("nfs_version", value);
    }

    /// <summary>
    /// The storage_mover_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageMoverId
    {
        get => GetProperty<TerraformProperty<string>>("storage_mover_id");
        set => this.WithProperty("storage_mover_id", value);
    }

}
