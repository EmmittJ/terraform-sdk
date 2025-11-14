using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_backup_protected_vm resource.
/// </summary>
public class AzurermBackupProtectedVm : TerraformResource
{
    public AzurermBackupProtectedVm(string name) : base("azurerm_backup_protected_vm", name)
    {
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [TerraformArgument("backup_policy_id")]
    public TerraformValue<string>? BackupPolicyId
    {
        get => new TerraformReference<string>(this, "backup_policy_id");
        set => SetArgument("backup_policy_id", value);
    }

    /// <summary>
    /// The exclude_disk_luns attribute.
    /// </summary>
    [TerraformArgument("exclude_disk_luns")]
    public TerraformSet<double>? ExcludeDiskLuns
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "exclude_disk_luns").ResolveNodes(ctx));
        set => SetArgument("exclude_disk_luns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_disk_luns attribute.
    /// </summary>
    [TerraformArgument("include_disk_luns")]
    public TerraformSet<double>? IncludeDiskLuns
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "include_disk_luns").ResolveNodes(ctx));
        set => SetArgument("include_disk_luns", value);
    }

    /// <summary>
    /// The protection_state attribute.
    /// </summary>
    [TerraformArgument("protection_state")]
    public TerraformValue<string> ProtectionState
    {
        get => new TerraformReference<string>(this, "protection_state");
        set => SetArgument("protection_state", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformArgument("recovery_vault_name")]
    public required TerraformValue<string> RecoveryVaultName
    {
        get => new TerraformReference<string>(this, "recovery_vault_name");
        set => SetArgument("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    [TerraformArgument("source_vm_id")]
    public TerraformValue<string> SourceVmId
    {
        get => new TerraformReference<string>(this, "source_vm_id");
        set => SetArgument("source_vm_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermBackupProtectedVmTimeoutsBlock Timeouts { get; set; } = new();

}
