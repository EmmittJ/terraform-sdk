using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for protected_settings_from_key_vault in AzurermVirtualMachineScaleSetExtension.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualMachineScaleSetExtensionProtectedSettingsFromKeyVaultBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protected_settings_from_key_vault";

    /// <summary>
    /// The secret_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretUrl is required")]
    public required TerraformValue<string> SecretUrl
    {
        get => GetArgument<TerraformValue<string>>("secret_url");
        set => SetArgument("secret_url", value);
    }

    /// <summary>
    /// The source_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceVaultId is required")]
    public required TerraformValue<string> SourceVaultId
    {
        get => GetArgument<TerraformValue<string>>("source_vault_id");
        set => SetArgument("source_vault_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualMachineScaleSetExtension.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineScaleSetExtensionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_machine_scale_set_extension Terraform resource.
/// Manages a azurerm_virtual_machine_scale_set_extension resource.
/// </summary>
public partial class AzurermVirtualMachineScaleSetExtension(string name) : TerraformResource("azurerm_virtual_machine_scale_set_extension", name)
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    public TerraformValue<bool>? AutoUpgradeMinorVersion
    {
        get => GetArgument<TerraformValue<bool>>("auto_upgrade_minor_version");
        set => SetArgument("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticUpgradeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("automatic_upgrade_enabled");
        set => SetArgument("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The failure_suppression_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FailureSuppressionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("failure_suppression_enabled");
        set => SetArgument("failure_suppression_enabled", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformValue<string>? ForceUpdateTag
    {
        get => GetArgument<TerraformValue<string>>("force_update_tag");
        set => SetArgument("force_update_tag", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformValue<string>? ProtectedSettings
    {
        get => GetArgument<TerraformValue<string>>("protected_settings");
        set => SetArgument("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public TerraformList<string>? ProvisionAfterExtensions
    {
        get => GetArgument<TerraformList<string>>("provision_after_extensions");
        set => SetArgument("provision_after_extensions", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformValue<string>? Settings
    {
        get => GetArgument<TerraformValue<string>>("settings");
        set => SetArgument("settings", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    public required TerraformValue<string> TypeHandlerVersion
    {
        get => GetArgument<TerraformValue<string>>("type_handler_version");
        set => SetArgument("type_handler_version", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineScaleSetId is required")]
    public required TerraformValue<string> VirtualMachineScaleSetId
    {
        get => GetArgument<TerraformValue<string>>("virtual_machine_scale_set_id");
        set => SetArgument("virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// ProtectedSettingsFromKeyVault block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtectedSettingsFromKeyVault block(s) allowed")]
    public TerraformList<AzurermVirtualMachineScaleSetExtensionProtectedSettingsFromKeyVaultBlock>? ProtectedSettingsFromKeyVault
    {
        get => GetArgument<TerraformList<AzurermVirtualMachineScaleSetExtensionProtectedSettingsFromKeyVaultBlock>>("protected_settings_from_key_vault");
        set => SetArgument("protected_settings_from_key_vault", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualMachineScaleSetExtensionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualMachineScaleSetExtensionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
