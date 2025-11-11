using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBackupProtectedVmTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_backup_protected_vm resource.
/// </summary>
public partial class AzurermBackupProtectedVm : TerraformResource
{
    public AzurermBackupProtectedVm(string name) : base("azurerm_backup_protected_vm", name)
    {
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [TerraformProperty("backup_policy_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackupPolicyId { get; set; }

    /// <summary>
    /// The exclude_disk_luns attribute.
    /// </summary>
    [TerraformProperty("exclude_disk_luns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? ExcludeDiskLuns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_disk_luns attribute.
    /// </summary>
    [TerraformProperty("include_disk_luns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? IncludeDiskLuns { get; set; }

    /// <summary>
    /// The protection_state attribute.
    /// </summary>
    [TerraformProperty("protection_state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProtectionState { get; set; }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformProperty("recovery_vault_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RecoveryVaultName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    [TerraformProperty("source_vm_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SourceVmId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermBackupProtectedVmTimeoutsBlock>? Timeouts { get; set; }

}
