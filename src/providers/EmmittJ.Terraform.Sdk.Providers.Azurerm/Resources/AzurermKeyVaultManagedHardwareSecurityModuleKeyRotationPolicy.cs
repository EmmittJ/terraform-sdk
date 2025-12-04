using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_managed_hardware_security_module_key_rotation_policy Terraform resource.
/// Manages a azurerm_key_vault_managed_hardware_security_module_key_rotation_policy resource.
/// </summary>
public partial class AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicy(string name) : TerraformResource("azurerm_key_vault_managed_hardware_security_module_key_rotation_policy", name)
{
    /// <summary>
    /// The expire_after attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpireAfter is required")]
    public required TerraformValue<string> ExpireAfter
    {
        get => GetArgument<TerraformValue<string>>("expire_after");
        set => SetArgument("expire_after", value);
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
    /// The managed_hsm_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedHsmKeyId is required")]
    public required TerraformValue<string> ManagedHsmKeyId
    {
        get => GetArgument<TerraformValue<string>>("managed_hsm_key_id");
        set => SetArgument("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The time_after_creation attribute.
    /// </summary>
    public TerraformValue<string>? TimeAfterCreation
    {
        get => GetArgument<TerraformValue<string>>("time_after_creation");
        set => SetArgument("time_after_creation", value);
    }

    /// <summary>
    /// The time_before_expiry attribute.
    /// </summary>
    public TerraformValue<string>? TimeBeforeExpiry
    {
        get => GetArgument<TerraformValue<string>>("time_before_expiry");
        set => SetArgument("time_before_expiry", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultManagedHardwareSecurityModuleKeyRotationPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
