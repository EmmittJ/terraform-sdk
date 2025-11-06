using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_app_environment_storage resource.
/// </summary>
public class AzurermContainerAppEnvironmentStorage : TerraformResource
{
    public AzurermContainerAppEnvironmentStorage(string name) : base("azurerm_container_app_environment_storage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The Storage Account Access Key.
    /// </summary>
    public string? AccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_key")?.Value;
        set => this.WithProperty("access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The access mode to connect this storage to the Container App. Possible values include `ReadOnly` and `ReadWrite`.
    /// </summary>
    public string? AccessMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_mode")?.Value;
        set => this.WithProperty("access_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Azure Storage Account in which the Share to be used is located.
    /// </summary>
    public string? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name")?.Value;
        set => this.WithProperty("account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the Container App Environment to which this storage belongs.
    /// </summary>
    public string? ContainerAppEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_app_environment_id")?.Value;
        set => this.WithProperty("container_app_environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name for this Storage.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The nfs_server_url attribute.
    /// </summary>
    public string? NfsServerUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("nfs_server_url")?.Value;
        set => this.WithProperty("nfs_server_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the Azure Storage Share to use.
    /// </summary>
    public string? ShareName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("share_name")?.Value;
        set => this.WithProperty("share_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
