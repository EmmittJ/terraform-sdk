using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetAdditionalCapabilitiesBlock
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for additional_unattend_content in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetAdditionalUnattendContentBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The setting attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Setting is required")]
    [TerraformPropertyName("setting")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Setting { get; set; }

}

/// <summary>
/// Block type for automatic_instance_repair in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetAutomaticInstanceRepairBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformPropertyName("action")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Action { get; set; } = default!;

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The grace_period attribute.
    /// </summary>
    [TerraformPropertyName("grace_period")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> GracePeriod { get; set; } = default!;

}

/// <summary>
/// Block type for automatic_os_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock
{
    /// <summary>
    /// The disable_automatic_rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableAutomaticRollback is required")]
    [TerraformPropertyName("disable_automatic_rollback")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> DisableAutomaticRollback { get; set; }

    /// <summary>
    /// The enable_automatic_os_upgrade attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableAutomaticOsUpgrade is required")]
    [TerraformPropertyName("enable_automatic_os_upgrade")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> EnableAutomaticOsUpgrade { get; set; }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetBootDiagnosticsBlock
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountUri { get; set; }

}

/// <summary>
/// Block type for data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetDataDiskBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformPropertyName("caching")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Caching { get; set; }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [TerraformPropertyName("create_option")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateOption { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformPropertyName("disk_size_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformPropertyName("lun")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Lun { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformPropertyName("storage_account_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountType { get; set; }

    /// <summary>
    /// The ultra_ssd_disk_iops_read_write attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_disk_iops_read_write")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> UltraSsdDiskIopsReadWrite { get; set; } = default!;

    /// <summary>
    /// The ultra_ssd_disk_mbps_read_write attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_disk_mbps_read_write")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> UltraSsdDiskMbpsReadWrite { get; set; } = default!;

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetExtensionBlock
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    [TerraformPropertyName("auto_upgrade_minor_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_upgrade_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    [TerraformPropertyName("force_update_tag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ForceUpdateTag { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformPropertyName("protected_settings")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProtectedSettings { get; set; }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    [TerraformPropertyName("provision_after_extensions")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformPropertyName("settings")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Settings { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    [TerraformPropertyName("type_handler_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TypeHandlerVersion { get; set; }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetGalleryApplicationBlock
{
    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    [TerraformPropertyName("configuration_blob_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConfigurationBlobUri { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformPropertyName("order")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Order { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    [TerraformPropertyName("version_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VersionId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetNetworkInterfaceBlock
{
    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    [TerraformPropertyName("auxiliary_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuxiliaryMode { get; set; }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    [TerraformPropertyName("auxiliary_sku")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuxiliarySku { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The enable_accelerated_networking attribute.
    /// </summary>
    [TerraformPropertyName("enable_accelerated_networking")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAcceleratedNetworking { get; set; }

    /// <summary>
    /// The enable_ip_forwarding attribute.
    /// </summary>
    [TerraformPropertyName("enable_ip_forwarding")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableIpForwarding { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("network_security_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkSecurityGroupId { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Primary { get; set; }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetOsDiskBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformPropertyName("caching")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DiskSizeGb { get; set; } = default!;

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformPropertyName("secure_vm_disk_encryption_set_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("security_encryption_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityEncryptionType { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformPropertyName("storage_account_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountType { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("write_accelerator_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetPlanBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformPropertyName("product")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Publisher { get; set; }

}

/// <summary>
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetRollingUpgradePolicyBlock
{
    /// <summary>
    /// The cross_zone_upgrades_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cross_zone_upgrades_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CrossZoneUpgradesEnabled { get; set; }

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxBatchInstancePercent is required")]
    [TerraformPropertyName("max_batch_instance_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxBatchInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyInstancePercent is required")]
    [TerraformPropertyName("max_unhealthy_instance_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxUnhealthyInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyUpgradedInstancePercent is required")]
    [TerraformPropertyName("max_unhealthy_upgraded_instance_percent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>
    /// The maximum_surge_instances_enabled attribute.
    /// </summary>
    [TerraformPropertyName("maximum_surge_instances_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MaximumSurgeInstancesEnabled { get; set; }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PauseTimeBetweenBatches is required")]
    [TerraformPropertyName("pause_time_between_batches")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PauseTimeBetweenBatches { get; set; }

    /// <summary>
    /// The prioritize_unhealthy_instances_enabled attribute.
    /// </summary>
    [TerraformPropertyName("prioritize_unhealthy_instances_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrioritizeUnhealthyInstancesEnabled { get; set; }

}

/// <summary>
/// Block type for scale_in in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetScaleInBlock
{
    /// <summary>
    /// The force_deletion_enabled attribute.
    /// </summary>
    [TerraformPropertyName("force_deletion_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDeletionEnabled { get; set; }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [TerraformPropertyName("rule")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Rule { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetSecretBlock
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultId { get; set; }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetSourceImageReferenceBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformPropertyName("offer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for spot_restore in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetSpotRestoreBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetTerminationNotificationBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for winrm_listener in .
/// Nesting mode: set
/// </summary>
public class AzurermWindowsVirtualMachineScaleSetWinrmListenerBlock
{
    /// <summary>
    /// The certificate_url attribute.
    /// </summary>
    [TerraformPropertyName("certificate_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateUrl { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

}

/// <summary>
/// Manages a azurerm_windows_virtual_machine_scale_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWindowsVirtualMachineScaleSet : TerraformResource
{
    public AzurermWindowsVirtualMachineScaleSet(string name) : base("azurerm_windows_virtual_machine_scale_set", name)
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    [TerraformPropertyName("admin_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformPropertyName("admin_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdminUsername { get; set; }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CapacityReservationGroupId { get; set; }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("computer_name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ComputerNamePrefix { get; set; } = default!;

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformPropertyName("custom_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomData { get; set; }

    /// <summary>
    /// The do_not_run_extensions_on_overprovisioned_machines attribute.
    /// </summary>
    [TerraformPropertyName("do_not_run_extensions_on_overprovisioned_machines")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DoNotRunExtensionsOnOverprovisionedMachines { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    [TerraformPropertyName("enable_automatic_updates")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAutomaticUpdates { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_host_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformPropertyName("eviction_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EvictionPolicy { get; set; }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    [TerraformPropertyName("extension_operations_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExtensionOperationsEnabled { get; set; }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    [TerraformPropertyName("extensions_time_budget")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExtensionsTimeBudget { get; set; }

    /// <summary>
    /// The health_probe_id attribute.
    /// </summary>
    [TerraformPropertyName("health_probe_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HealthProbeId { get; set; }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    [TerraformPropertyName("host_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instances is required")]
    [TerraformPropertyName("instances")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Instances { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LicenseType { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    [TerraformPropertyName("max_bid_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxBidPrice { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The overprovision attribute.
    /// </summary>
    [TerraformPropertyName("overprovision")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Overprovision { get; set; }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [TerraformPropertyName("platform_fault_domain_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> PlatformFaultDomainCount { get; set; } = default!;

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformPropertyName("provision_vm_agent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ProvisionVmAgent { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The resilient_vm_creation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("resilient_vm_creation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ResilientVmCreationEnabled { get; set; }

    /// <summary>
    /// The resilient_vm_deletion_enabled attribute.
    /// </summary>
    [TerraformPropertyName("resilient_vm_deletion_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ResilientVmDeletionEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformPropertyName("secure_boot_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SecureBootEnabled { get; set; }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    [TerraformPropertyName("single_placement_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SinglePlacementGroup { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformPropertyName("source_image_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceImageId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Timezone { get; set; }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    [TerraformPropertyName("upgrade_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UpgradeMode { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformPropertyName("user_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vtpm_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VtpmEnabled { get; set; }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    [TerraformPropertyName("zone_balance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ZoneBalance { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformPropertyName("additional_capabilities")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; }

    /// <summary>
    /// Block for additional_unattend_content.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("additional_unattend_content")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetAdditionalUnattendContentBlock>>? AdditionalUnattendContent { get; set; }

    /// <summary>
    /// Block for automatic_instance_repair.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    [TerraformPropertyName("automatic_instance_repair")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetAutomaticInstanceRepairBlock>>? AutomaticInstanceRepair { get; set; }

    /// <summary>
    /// Block for automatic_os_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticOsUpgradePolicy block(s) allowed")]
    [TerraformPropertyName("automatic_os_upgrade_policy")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock>>? AutomaticOsUpgradePolicy { get; set; }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformPropertyName("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetBootDiagnosticsBlock>>? BootDiagnostics { get; set; }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("data_disk")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetDataDiskBlock>>? DataDisk { get; set; }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("extension")]
    public TerraformSet<TerraformBlock<AzurermWindowsVirtualMachineScaleSetExtensionBlock>>? Extension { get; set; }

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    [TerraformPropertyName("gallery_application")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetGalleryApplicationBlock>>? GalleryApplication { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterface is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    [TerraformPropertyName("network_interface")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformPropertyName("os_disk")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetOsDiskBlock>>? OsDisk { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformPropertyName("plan")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetPlanBlock>>? Plan { get; set; }

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    [TerraformPropertyName("rolling_upgrade_policy")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetRollingUpgradePolicyBlock>>? RollingUpgradePolicy { get; set; }

    /// <summary>
    /// Block for scale_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleIn block(s) allowed")]
    [TerraformPropertyName("scale_in")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetScaleInBlock>>? ScaleIn { get; set; }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("secret")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetSecretBlock>>? Secret { get; set; }

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformPropertyName("source_image_reference")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetSourceImageReferenceBlock>>? SourceImageReference { get; set; }

    /// <summary>
    /// Block for spot_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotRestore block(s) allowed")]
    [TerraformPropertyName("spot_restore")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetSpotRestoreBlock>>? SpotRestore { get; set; }

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformPropertyName("termination_notification")]
    public TerraformList<TerraformBlock<AzurermWindowsVirtualMachineScaleSetTerminationNotificationBlock>>? TerminationNotification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermWindowsVirtualMachineScaleSetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for winrm_listener.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("winrm_listener")]
    public TerraformSet<TerraformBlock<AzurermWindowsVirtualMachineScaleSetWinrmListenerBlock>>? WinrmListener { get; set; }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformPropertyName("unique_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UniqueId => new TerraformReference(this, "unique_id");

}
