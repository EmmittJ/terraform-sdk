using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerAppEnvironmentStorage.
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppEnvironmentStorageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_container_app_environment_storage Terraform resource.
/// Manages a azurerm_container_app_environment_storage resource.
/// </summary>
public partial class AzurermContainerAppEnvironmentStorage(string name) : TerraformResource("azurerm_container_app_environment_storage", name)
{
    /// <summary>
    /// The Storage Account Access Key.
    /// </summary>
    public TerraformValue<string>? AccessKey
    {
        get => GetArgument<TerraformValue<string>>("access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The access mode to connect this storage to the Container App. Possible values include `ReadOnly` and `ReadWrite`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessMode is required")]
    public required TerraformValue<string> AccessMode
    {
        get => GetArgument<TerraformValue<string>>("access_mode");
        set => SetArgument("access_mode", value);
    }

    /// <summary>
    /// The Azure Storage Account in which the Share to be used is located.
    /// </summary>
    public TerraformValue<string>? AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The ID of the Container App Environment to which this storage belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerAppEnvironmentId is required")]
    public required TerraformValue<string> ContainerAppEnvironmentId
    {
        get => GetArgument<TerraformValue<string>>("container_app_environment_id");
        set => SetArgument("container_app_environment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name for this Storage.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nfs_server_url attribute.
    /// </summary>
    public TerraformValue<string>? NfsServerUrl
    {
        get => GetArgument<TerraformValue<string>>("nfs_server_url");
        set => SetArgument("nfs_server_url", value);
    }

    /// <summary>
    /// The name of the Azure Storage Share to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformValue<string> ShareName
    {
        get => GetArgument<TerraformValue<string>>("share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerAppEnvironmentStorageTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerAppEnvironmentStorageTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
