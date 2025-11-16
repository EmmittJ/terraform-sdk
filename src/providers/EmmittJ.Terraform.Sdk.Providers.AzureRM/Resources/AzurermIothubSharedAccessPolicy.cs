using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubSharedAccessPolicyTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_iothub_shared_access_policy Terraform resource.
/// Manages a azurerm_iothub_shared_access_policy resource.
/// </summary>
public partial class AzurermIothubSharedAccessPolicy(string name) : TerraformResource("azurerm_iothub_shared_access_policy", name)
{
    /// <summary>
    /// The device_connect attribute.
    /// </summary>
    public TerraformValue<bool>? DeviceConnect
    {
        get => new TerraformReference<bool>(this, "device_connect");
        set => SetArgument("device_connect", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iothub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubName is required")]
    public required TerraformValue<string> IothubName
    {
        get => new TerraformReference<string>(this, "iothub_name");
        set => SetArgument("iothub_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The registry_read attribute.
    /// </summary>
    public TerraformValue<bool>? RegistryRead
    {
        get => new TerraformReference<bool>(this, "registry_read");
        set => SetArgument("registry_read", value);
    }

    /// <summary>
    /// The registry_write attribute.
    /// </summary>
    public TerraformValue<bool>? RegistryWrite
    {
        get => new TerraformReference<bool>(this, "registry_write");
        set => SetArgument("registry_write", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_connect attribute.
    /// </summary>
    public TerraformValue<bool>? ServiceConnect
    {
        get => new TerraformReference<bool>(this, "service_connect");
        set => SetArgument("service_connect", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIothubSharedAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIothubSharedAccessPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
