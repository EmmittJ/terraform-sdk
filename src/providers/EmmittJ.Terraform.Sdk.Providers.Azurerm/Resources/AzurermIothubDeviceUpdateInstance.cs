using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for diagnostic_storage_account in AzurermIothubDeviceUpdateInstance.
/// Nesting mode: list
/// </summary>
public class AzurermIothubDeviceUpdateInstanceDiagnosticStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "diagnostic_storage_account";

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformValue<string> ConnectionString
    {
        get => GetArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermIothubDeviceUpdateInstance.
/// Nesting mode: single
/// </summary>
public class AzurermIothubDeviceUpdateInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_iothub_device_update_instance Terraform resource.
/// Manages a azurerm_iothub_device_update_instance resource.
/// </summary>
public partial class AzurermIothubDeviceUpdateInstance(string name) : TerraformResource("azurerm_iothub_device_update_instance", name)
{
    /// <summary>
    /// The device_update_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceUpdateAccountId is required")]
    public required TerraformValue<string> DeviceUpdateAccountId
    {
        get => GetArgument<TerraformValue<string>>("device_update_account_id");
        set => SetArgument("device_update_account_id", value);
    }

    /// <summary>
    /// The diagnostic_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DiagnosticEnabled
    {
        get => GetArgument<TerraformValue<bool>>("diagnostic_enabled");
        set => SetArgument("diagnostic_enabled", value);
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
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformValue<string> IothubId
    {
        get => GetArgument<TerraformValue<string>>("iothub_id");
        set => SetArgument("iothub_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// DiagnosticStorageAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiagnosticStorageAccount block(s) allowed")]
    public TerraformList<AzurermIothubDeviceUpdateInstanceDiagnosticStorageAccountBlock>? DiagnosticStorageAccount
    {
        get => GetArgument<TerraformList<AzurermIothubDeviceUpdateInstanceDiagnosticStorageAccountBlock>>("diagnostic_storage_account");
        set => SetArgument("diagnostic_storage_account", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIothubDeviceUpdateInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIothubDeviceUpdateInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
