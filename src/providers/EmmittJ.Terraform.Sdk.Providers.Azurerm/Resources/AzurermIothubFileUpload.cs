using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermIothubFileUpload.
/// Nesting mode: single
/// </summary>
public class AzurermIothubFileUploadTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_iothub_file_upload Terraform resource.
/// Manages a azurerm_iothub_file_upload resource.
/// </summary>
public partial class AzurermIothubFileUpload(string name) : TerraformResource("azurerm_iothub_file_upload", name)
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformValue<string> ConnectionString
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<string>? DefaultTtl
    {
        get => GetArgument<TerraformValue<string>>("default_ttl");
        set => SetArgument("default_ttl", value);
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
    /// The identity_id attribute.
    /// </summary>
    public TerraformValue<string>? IdentityId
    {
        get => GetArgument<TerraformValue<string>>("identity_id");
        set => SetArgument("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformValue<string> IothubId
    {
        get => GetRequiredArgument<TerraformValue<string>>("iothub_id");
        set => SetArgument("iothub_id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformValue<string>? LockDuration
    {
        get => GetArgument<TerraformValue<string>>("lock_duration");
        set => SetArgument("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxDeliveryCount
    {
        get => GetArgument<TerraformValue<double>>("max_delivery_count");
        set => SetArgument("max_delivery_count", value);
    }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? NotificationsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("notifications_enabled");
        set => SetArgument("notifications_enabled", value);
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    public TerraformValue<string>? SasTtl
    {
        get => GetArgument<TerraformValue<string>>("sas_ttl");
        set => SetArgument("sas_ttl", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIothubFileUploadTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIothubFileUploadTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
