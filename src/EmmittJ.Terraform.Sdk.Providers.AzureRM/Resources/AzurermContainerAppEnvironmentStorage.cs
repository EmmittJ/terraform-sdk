using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentStorageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? AccessKey
    {
        get => GetProperty<TerraformProperty<string>>("access_key");
        set => this.WithProperty("access_key", value);
    }

    /// <summary>
    /// The access mode to connect this storage to the Container App. Possible values include `ReadOnly` and `ReadWrite`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessMode is required")]
    public required TerraformProperty<string> AccessMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("access_mode");
        set => this.WithProperty("access_mode", value);
    }

    /// <summary>
    /// The Azure Storage Account in which the Share to be used is located.
    /// </summary>
    public TerraformProperty<string>? AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The ID of the Container App Environment to which this storage belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformProperty<string> ContainerAppEnvironmentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("container_app_environment_id");
        set => this.WithProperty("container_app_environment_id", value);
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
    /// The name for this Storage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The nfs_server_url attribute.
    /// </summary>
    public TerraformProperty<string>? NfsServerUrl
    {
        get => GetProperty<TerraformProperty<string>>("nfs_server_url");
        set => this.WithProperty("nfs_server_url", value);
    }

    /// <summary>
    /// The name of the Azure Storage Share to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformProperty<string> ShareName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("share_name");
        set => this.WithProperty("share_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerAppEnvironmentStorageTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerAppEnvironmentStorageTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
