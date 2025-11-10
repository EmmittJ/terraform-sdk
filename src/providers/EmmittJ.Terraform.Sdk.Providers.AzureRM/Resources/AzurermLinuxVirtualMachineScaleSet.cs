using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock : ITerraformBlock
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for admin_ssh_key in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock : ITerraformBlock
{
    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    [TerraformPropertyName("public_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PublicKey { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for automatic_instance_repair in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock : ITerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformPropertyName("action")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Action { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "action");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The grace_period attribute.
    /// </summary>
    [TerraformPropertyName("grace_period")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GracePeriod { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "grace_period");

}

/// <summary>
/// Block type for automatic_os_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The disable_automatic_rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableAutomaticRollback is required")]
    [TerraformPropertyName("disable_automatic_rollback")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> DisableAutomaticRollback { get; set; }

    /// <summary>
    /// The enable_automatic_os_upgrade attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableAutomaticOsUpgrade is required")]
    [TerraformPropertyName("enable_automatic_os_upgrade")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> EnableAutomaticOsUpgrade { get; set; }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock : ITerraformBlock
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountUri { get; set; }

}

/// <summary>
/// Block type for data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetDataDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformPropertyName("caching")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Caching { get; set; }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [TerraformPropertyName("create_option")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreateOption { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformPropertyName("disk_size_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DiskSizeGb { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformPropertyName("lun")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Lun { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformPropertyName("storage_account_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountType { get; set; }

    /// <summary>
    /// The ultra_ssd_disk_iops_read_write attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_disk_iops_read_write")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> UltraSsdDiskIopsReadWrite { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "ultra_ssd_disk_iops_read_write");

    /// <summary>
    /// The ultra_ssd_disk_mbps_read_write attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_disk_mbps_read_write")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> UltraSsdDiskMbpsReadWrite { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "ultra_ssd_disk_mbps_read_write");

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetExtensionBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    [TerraformPropertyName("auto_upgrade_minor_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_upgrade_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    [TerraformPropertyName("force_update_tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForceUpdateTag { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformPropertyName("protected_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProtectedSettings { get; set; }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    [TerraformPropertyName("provision_after_extensions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ProvisionAfterExtensions { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Publisher { get; set; }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformPropertyName("settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Settings { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    [TerraformPropertyName("type_handler_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TypeHandlerVersion { get; set; }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock : ITerraformBlock
{
    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    [TerraformPropertyName("configuration_blob_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConfigurationBlobUri { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformPropertyName("order")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Order { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tag { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    [TerraformPropertyName("version_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VersionId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock : ITerraformBlock
{
    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    [TerraformPropertyName("auxiliary_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuxiliaryMode { get; set; }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    [TerraformPropertyName("auxiliary_sku")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuxiliarySku { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DnsServers { get; set; }

    /// <summary>
    /// The enable_accelerated_networking attribute.
    /// </summary>
    [TerraformPropertyName("enable_accelerated_networking")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAcceleratedNetworking { get; set; }

    /// <summary>
    /// The enable_ip_forwarding attribute.
    /// </summary>
    [TerraformPropertyName("enable_ip_forwarding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableIpForwarding { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("network_security_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkSecurityGroupId { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Primary { get; set; }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetOsDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformPropertyName("caching")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "disk_size_gb");

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("secure_vm_disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("security_encryption_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecurityEncryptionType { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformPropertyName("storage_account_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountType { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetPlanBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformPropertyName("product")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Publisher { get; set; }

}

/// <summary>
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The cross_zone_upgrades_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cross_zone_upgrades_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CrossZoneUpgradesEnabled { get; set; }

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxBatchInstancePercent is required")]
    [TerraformPropertyName("max_batch_instance_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxBatchInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyInstancePercent is required")]
    [TerraformPropertyName("max_unhealthy_instance_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxUnhealthyInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyUpgradedInstancePercent is required")]
    [TerraformPropertyName("max_unhealthy_upgraded_instance_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>
    /// The maximum_surge_instances_enabled attribute.
    /// </summary>
    [TerraformPropertyName("maximum_surge_instances_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MaximumSurgeInstancesEnabled { get; set; }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PauseTimeBetweenBatches is required")]
    [TerraformPropertyName("pause_time_between_batches")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PauseTimeBetweenBatches { get; set; }

    /// <summary>
    /// The prioritize_unhealthy_instances_enabled attribute.
    /// </summary>
    [TerraformPropertyName("prioritize_unhealthy_instances_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PrioritizeUnhealthyInstancesEnabled { get; set; }

}

/// <summary>
/// Block type for scale_in in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetScaleInBlock : ITerraformBlock
{
    /// <summary>
    /// The force_deletion_enabled attribute.
    /// </summary>
    [TerraformPropertyName("force_deletion_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDeletionEnabled { get; set; }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [TerraformPropertyName("rule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Rule { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSecretBlock : ITerraformBlock
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock : ITerraformBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformPropertyName("offer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

}

/// <summary>
/// Block type for spot_restore in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Timeout { get; set; }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Timeout { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_linux_virtual_machine_scale_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLinuxVirtualMachineScaleSet : TerraformResource
{
    public AzurermLinuxVirtualMachineScaleSet(string name) : base("azurerm_linux_virtual_machine_scale_set", name)
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformPropertyName("admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformPropertyName("admin_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AdminUsername { get; set; }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CapacityReservationGroupId { get; set; }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("computer_name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ComputerNamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "computer_name_prefix");

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformPropertyName("custom_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomData { get; set; }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [TerraformPropertyName("disable_password_authentication")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisablePasswordAuthentication { get; set; }

    /// <summary>
    /// The do_not_run_extensions_on_overprovisioned_machines attribute.
    /// </summary>
    [TerraformPropertyName("do_not_run_extensions_on_overprovisioned_machines")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DoNotRunExtensionsOnOverprovisionedMachines { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeZone { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_host_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EvictionPolicy { get; set; }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    [TerraformPropertyName("extension_operations_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExtensionOperationsEnabled { get; set; }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    [TerraformPropertyName("extensions_time_budget")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExtensionsTimeBudget { get; set; }

    /// <summary>
    /// The health_probe_id attribute.
    /// </summary>
    [TerraformPropertyName("health_probe_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthProbeId { get; set; }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    [TerraformPropertyName("host_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Instances { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    [TerraformPropertyName("max_bid_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxBidPrice { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The overprovision attribute.
    /// </summary>
    [TerraformPropertyName("overprovision")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Overprovision { get; set; }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [TerraformPropertyName("platform_fault_domain_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PlatformFaultDomainCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "platform_fault_domain_count");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Priority { get; set; }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformPropertyName("provision_vm_agent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ProvisionVmAgent { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The resilient_vm_creation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("resilient_vm_creation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ResilientVmCreationEnabled { get; set; }

    /// <summary>
    /// The resilient_vm_deletion_enabled attribute.
    /// </summary>
    [TerraformPropertyName("resilient_vm_deletion_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ResilientVmDeletionEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformPropertyName("secure_boot_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SecureBootEnabled { get; set; }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    [TerraformPropertyName("single_placement_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SinglePlacementGroup { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformPropertyName("source_image_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceImageId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UpgradeMode { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserData { get; set; }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vtpm_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VtpmEnabled { get; set; }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    [TerraformPropertyName("zone_balance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ZoneBalance { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformPropertyName("additional_capabilities")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; } = new();

    /// <summary>
    /// Block for admin_ssh_key.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("admin_ssh_key")]
    public TerraformSet<TerraformBlock<AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock>>? AdminSshKey { get; set; } = new();

    /// <summary>
    /// Block for automatic_instance_repair.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    [TerraformPropertyName("automatic_instance_repair")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock>>? AutomaticInstanceRepair { get; set; } = new();

    /// <summary>
    /// Block for automatic_os_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticOsUpgradePolicy block(s) allowed")]
    [TerraformPropertyName("automatic_os_upgrade_policy")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock>>? AutomaticOsUpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformPropertyName("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock>>? BootDiagnostics { get; set; } = new();

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("data_disk")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetDataDiskBlock>>? DataDisk { get; set; } = new();

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("extension")]
    public TerraformSet<TerraformBlock<AzurermLinuxVirtualMachineScaleSetExtensionBlock>>? Extension { get; set; } = new();

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    [TerraformPropertyName("gallery_application")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock>>? GalleryApplication { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterface is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    [TerraformPropertyName("network_interface")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock>>? NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformPropertyName("os_disk")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetOsDiskBlock>>? OsDisk { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformPropertyName("plan")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetPlanBlock>>? Plan { get; set; } = new();

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    [TerraformPropertyName("rolling_upgrade_policy")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock>>? RollingUpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for scale_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleIn block(s) allowed")]
    [TerraformPropertyName("scale_in")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetScaleInBlock>>? ScaleIn { get; set; } = new();

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("secret")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetSecretBlock>>? Secret { get; set; } = new();

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformPropertyName("source_image_reference")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock>>? SourceImageReference { get; set; } = new();

    /// <summary>
    /// Block for spot_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotRestore block(s) allowed")]
    [TerraformPropertyName("spot_restore")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock>>? SpotRestore { get; set; } = new();

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformPropertyName("termination_notification")]
    public TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock>>? TerminationNotification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLinuxVirtualMachineScaleSetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformPropertyName("unique_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UniqueId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "unique_id");

}
