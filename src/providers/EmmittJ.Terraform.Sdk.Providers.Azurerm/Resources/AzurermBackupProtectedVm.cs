using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBackupProtectedVm.
/// Nesting mode: single
/// </summary>
public class AzurermBackupProtectedVmTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_backup_protected_vm Terraform resource.
/// Manages a azurerm_backup_protected_vm resource.
/// </summary>
public partial class AzurermBackupProtectedVm(string name) : TerraformResource("azurerm_backup_protected_vm", name)
{
    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    public TerraformValue<string>? BackupPolicyId
    {
        get => GetArgument<TerraformValue<string>>("backup_policy_id");
        set => SetArgument("backup_policy_id", value);
    }

    /// <summary>
    /// The exclude_disk_luns attribute.
    /// </summary>
    public TerraformSet<double>? ExcludeDiskLuns
    {
        get => GetArgument<TerraformSet<double>>("exclude_disk_luns");
        set => SetArgument("exclude_disk_luns", value);
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
    /// The include_disk_luns attribute.
    /// </summary>
    public TerraformSet<double>? IncludeDiskLuns
    {
        get => GetArgument<TerraformSet<double>>("include_disk_luns");
        set => SetArgument("include_disk_luns", value);
    }

    /// <summary>
    /// The protection_state attribute.
    /// </summary>
    public TerraformValue<string>? ProtectionState
    {
        get => GetArgument<TerraformValue<string>>("protection_state");
        set => SetArgument("protection_state", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => GetArgument<TerraformValue<string>>("recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceVmId
    {
        get => GetArgument<TerraformValue<string>>("source_vm_id");
        set => SetArgument("source_vm_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBackupProtectedVmTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBackupProtectedVmTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
