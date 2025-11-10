using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBackupProtectedVmTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    [TerraformPropertyName("backup_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackupPolicyId { get; set; }

    /// <summary>
    /// The exclude_disk_luns attribute.
    /// </summary>
    [TerraformPropertyName("exclude_disk_luns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? ExcludeDiskLuns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The include_disk_luns attribute.
    /// </summary>
    [TerraformPropertyName("include_disk_luns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? IncludeDiskLuns { get; set; }

    /// <summary>
    /// The protection_state attribute.
    /// </summary>
    [TerraformPropertyName("protection_state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProtectionState { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protection_state");

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    [TerraformPropertyName("recovery_vault_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RecoveryVaultName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    [TerraformPropertyName("source_vm_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SourceVmId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_vm_id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBackupProtectedVmTimeoutsBlock>? Timeouts { get; set; } = new();

}
