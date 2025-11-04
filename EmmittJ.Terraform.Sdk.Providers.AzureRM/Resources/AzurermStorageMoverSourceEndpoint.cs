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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The export attribute.
    /// </summary>
    public string? Export
    {
        get => GetProperty<TerraformLiteralProperty<string>>("export")?.Value;
        set => this.WithProperty("export", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    public string? Host
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host")?.Value;
        set => this.WithProperty("host", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The nfs_version attribute.
    /// </summary>
    public string? NfsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nfs_version")?.Value;
        set => this.WithProperty("nfs_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_mover_id attribute.
    /// </summary>
    public string? StorageMoverId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_mover_id")?.Value;
        set => this.WithProperty("storage_mover_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
