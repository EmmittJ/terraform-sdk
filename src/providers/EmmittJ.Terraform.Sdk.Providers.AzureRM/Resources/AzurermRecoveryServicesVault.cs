using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for encryption in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRecoveryServicesVaultEncryptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfrastructureEncryptionEnabled is required")]
    [TerraformProperty("infrastructure_encryption_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> InfrastructureEncryptionEnabled { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformProperty("key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The use_system_assigned_identity attribute.
    /// </summary>
    [TerraformProperty("use_system_assigned_identity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseSystemAssignedIdentity { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRecoveryServicesVaultIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for monitoring in .
/// Nesting mode: list
/// </summary>
public partial class AzurermRecoveryServicesVaultMonitoringBlock : TerraformBlockBase
{
    /// <summary>
    /// The alerts_for_all_job_failures_enabled attribute.
    /// </summary>
    [TerraformProperty("alerts_for_all_job_failures_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AlertsForAllJobFailuresEnabled { get; set; }

    /// <summary>
    /// The alerts_for_critical_operation_failures_enabled attribute.
    /// </summary>
    [TerraformProperty("alerts_for_critical_operation_failures_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AlertsForCriticalOperationFailuresEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermRecoveryServicesVaultTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_recovery_services_vault resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermRecoveryServicesVault : TerraformResource
{
    public AzurermRecoveryServicesVault(string name) : base("azurerm_recovery_services_vault", name)
    {
    }

    /// <summary>
    /// The classic_vmware_replication_enabled attribute.
    /// </summary>
    [TerraformProperty("classic_vmware_replication_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ClassicVmwareReplicationEnabled { get; set; }

    /// <summary>
    /// The cross_region_restore_enabled attribute.
    /// </summary>
    [TerraformProperty("cross_region_restore_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CrossRegionRestoreEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The immutability attribute.
    /// </summary>
    [TerraformProperty("immutability")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Immutability { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The soft_delete_enabled attribute.
    /// </summary>
    [TerraformProperty("soft_delete_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SoftDeleteEnabled { get; set; }

    /// <summary>
    /// The storage_mode_type attribute.
    /// </summary>
    [TerraformProperty("storage_mode_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageModeType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    [TerraformProperty("encryption")]
    public TerraformList<TerraformBlock<AzurermRecoveryServicesVaultEncryptionBlock>>? Encryption { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermRecoveryServicesVaultIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    [TerraformProperty("monitoring")]
    public TerraformList<TerraformBlock<AzurermRecoveryServicesVaultMonitoringBlock>>? Monitoring { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermRecoveryServicesVaultTimeoutsBlock>? Timeouts { get; set; }

}
