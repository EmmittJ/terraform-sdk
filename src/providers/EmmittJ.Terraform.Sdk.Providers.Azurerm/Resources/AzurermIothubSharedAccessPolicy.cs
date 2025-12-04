using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermIothubSharedAccessPolicy.
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
        get => GetArgument<TerraformValue<bool>>("device_connect");
        set => SetArgument("device_connect", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iothub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubName is required")]
    public required TerraformValue<string> IothubName
    {
        get => GetRequiredArgument<TerraformValue<string>>("iothub_name");
        set => SetArgument("iothub_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The registry_read attribute.
    /// </summary>
    public TerraformValue<bool>? RegistryRead
    {
        get => GetArgument<TerraformValue<bool>>("registry_read");
        set => SetArgument("registry_read", value);
    }

    /// <summary>
    /// The registry_write attribute.
    /// </summary>
    public TerraformValue<bool>? RegistryWrite
    {
        get => GetArgument<TerraformValue<bool>>("registry_write");
        set => SetArgument("registry_write", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_connect attribute.
    /// </summary>
    public TerraformValue<bool>? ServiceConnect
    {
        get => GetArgument<TerraformValue<bool>>("service_connect");
        set => SetArgument("service_connect", value);
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => AsReference("primary_connection_string");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => AsReference("secondary_connection_string");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
        => AsReference("secondary_key");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIothubSharedAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIothubSharedAccessPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
