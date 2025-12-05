using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermIothubDpsSharedAccessPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermIothubDpsSharedAccessPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_iothub_dps_shared_access_policy Terraform resource.
/// Manages a azurerm_iothub_dps_shared_access_policy resource.
/// </summary>
public partial class AzurermIothubDpsSharedAccessPolicy(string name) : TerraformResource("azurerm_iothub_dps_shared_access_policy", name)
{
    /// <summary>
    /// The enrollment_read attribute.
    /// </summary>
    public TerraformValue<bool>? EnrollmentRead
    {
        get => GetArgument<TerraformValue<bool>>("enrollment_read");
        set => SetArgument("enrollment_read", value);
    }

    /// <summary>
    /// The enrollment_write attribute.
    /// </summary>
    public TerraformValue<bool>? EnrollmentWrite
    {
        get => GetArgument<TerraformValue<bool>>("enrollment_write");
        set => SetArgument("enrollment_write", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iothub_dps_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubDpsName is required")]
    public required TerraformValue<string> IothubDpsName
    {
        get => GetRequiredArgument<TerraformValue<string>>("iothub_dps_name");
        set => SetArgument("iothub_dps_name", value);
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
    /// The registration_read attribute.
    /// </summary>
    public TerraformValue<bool>? RegistrationRead
    {
        get => GetArgument<TerraformValue<bool>>("registration_read");
        set => SetArgument("registration_read", value);
    }

    /// <summary>
    /// The registration_write attribute.
    /// </summary>
    public TerraformValue<bool>? RegistrationWrite
    {
        get => GetArgument<TerraformValue<bool>>("registration_write");
        set => SetArgument("registration_write", value);
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
    /// The service_config attribute.
    /// </summary>
    public TerraformValue<bool>? ServiceConfig
    {
        get => GetArgument<TerraformValue<bool>>("service_config");
        set => SetArgument("service_config", value);
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => CreateReference("primary_connection_string");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
        => CreateReference("primary_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => CreateReference("secondary_connection_string");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
        => CreateReference("secondary_key");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIothubDpsSharedAccessPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIothubDpsSharedAccessPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
