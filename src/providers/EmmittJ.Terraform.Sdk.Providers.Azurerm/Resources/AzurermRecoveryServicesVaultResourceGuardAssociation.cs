using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermRecoveryServicesVaultResourceGuardAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermRecoveryServicesVaultResourceGuardAssociationTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_recovery_services_vault_resource_guard_association Terraform resource.
/// Manages a azurerm_recovery_services_vault_resource_guard_association resource.
/// </summary>
public partial class AzurermRecoveryServicesVaultResourceGuardAssociation(string name) : TerraformResource("azurerm_recovery_services_vault_resource_guard_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_guard_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGuardId is required")]
    public required TerraformValue<string> ResourceGuardId
    {
        get => GetArgument<TerraformValue<string>>("resource_guard_id");
        set => SetArgument("resource_guard_id", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformValue<string> VaultId
    {
        get => GetArgument<TerraformValue<string>>("vault_id");
        set => SetArgument("vault_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRecoveryServicesVaultResourceGuardAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRecoveryServicesVaultResourceGuardAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
