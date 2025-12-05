using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageContainerImmutabilityPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerImmutabilityPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_container_immutability_policy Terraform resource.
/// Manages a azurerm_storage_container_immutability_policy resource.
/// </summary>
public partial class AzurermStorageContainerImmutabilityPolicy(string name) : TerraformResource("azurerm_storage_container_immutability_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The immutability_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImmutabilityPeriodInDays is required")]
    public required TerraformValue<double> ImmutabilityPeriodInDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("immutability_period_in_days");
        set => SetArgument("immutability_period_in_days", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformValue<bool>? Locked
    {
        get => GetArgument<TerraformValue<bool>>("locked");
        set => SetArgument("locked", value);
    }

    /// <summary>
    /// The protected_append_writes_all_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ProtectedAppendWritesAllEnabled
    {
        get => GetArgument<TerraformValue<bool>>("protected_append_writes_all_enabled");
        set => SetArgument("protected_append_writes_all_enabled", value);
    }

    /// <summary>
    /// The protected_append_writes_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ProtectedAppendWritesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("protected_append_writes_enabled");
        set => SetArgument("protected_append_writes_enabled", value);
    }

    /// <summary>
    /// The storage_container_resource_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerResourceManagerId is required")]
    public required TerraformValue<string> StorageContainerResourceManagerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_container_resource_manager_id");
        set => SetArgument("storage_container_resource_manager_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageContainerImmutabilityPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageContainerImmutabilityPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
