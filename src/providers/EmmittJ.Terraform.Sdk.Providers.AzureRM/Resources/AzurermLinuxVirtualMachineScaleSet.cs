using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformProperty("ultra_ssd_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for admin_ssh_key in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    [TerraformProperty("public_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PublicKey { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for automatic_instance_repair in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock : TerraformBlockBase
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformProperty("action")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The grace_period attribute.
    /// </summary>
    [TerraformProperty("grace_period")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GracePeriod { get; set; }

}

/// <summary>
/// Block type for automatic_os_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The disable_automatic_rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableAutomaticRollback is required")]
    [TerraformProperty("disable_automatic_rollback")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> DisableAutomaticRollback { get; set; }

    /// <summary>
    /// The enable_automatic_os_upgrade attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableAutomaticOsUpgrade is required")]
    [TerraformProperty("enable_automatic_os_upgrade")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> EnableAutomaticOsUpgrade { get; set; }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock : TerraformBlockBase
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    [TerraformProperty("storage_account_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountUri { get; set; }

}

/// <summary>
/// Block type for data_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetDataDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformProperty("caching")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Caching { get; set; }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [TerraformProperty("create_option")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CreateOption { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformProperty("disk_size_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformProperty("lun")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Lun { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformProperty("storage_account_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountType { get; set; }

    /// <summary>
    /// The ultra_ssd_disk_iops_read_write attribute.
    /// </summary>
    [TerraformProperty("ultra_ssd_disk_iops_read_write")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>
    /// The ultra_ssd_disk_mbps_read_write attribute.
    /// </summary>
    [TerraformProperty("ultra_ssd_disk_mbps_read_write")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformProperty("write_accelerator_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetExtensionBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    [TerraformProperty("auto_upgrade_minor_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_upgrade_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    [TerraformProperty("force_update_tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForceUpdateTag { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformProperty("protected_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProtectedSettings { get; set; }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    [TerraformProperty("provision_after_extensions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformProperty("settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Settings { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    [TerraformProperty("type_handler_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TypeHandlerVersion { get; set; }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock : TerraformBlockBase
{
    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    [TerraformProperty("configuration_blob_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigurationBlobUri { get; set; }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformProperty("order")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Order { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    [TerraformProperty("version_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VersionId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock : TerraformBlockBase
{
    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    [TerraformProperty("auxiliary_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuxiliaryMode { get; set; }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    [TerraformProperty("auxiliary_sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuxiliarySku { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The enable_accelerated_networking attribute.
    /// </summary>
    [TerraformProperty("enable_accelerated_networking")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableAcceleratedNetworking { get; set; }

    /// <summary>
    /// The enable_ip_forwarding attribute.
    /// </summary>
    [TerraformProperty("enable_ip_forwarding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableIpForwarding { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformProperty("network_security_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NetworkSecurityGroupId { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformProperty("primary")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Primary { get; set; }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetOsDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformProperty("caching")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Caching { get; set; }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DiskEncryptionSetId { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    [TerraformProperty("secure_vm_disk_encryption_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    [TerraformProperty("security_encryption_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityEncryptionType { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformProperty("storage_account_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountType { get; set; }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformProperty("write_accelerator_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WriteAcceleratorEnabled { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetPlanBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformProperty("product")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Product { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Publisher { get; set; }

}

/// <summary>
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The cross_zone_upgrades_enabled attribute.
    /// </summary>
    [TerraformProperty("cross_zone_upgrades_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CrossZoneUpgradesEnabled { get; set; }

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxBatchInstancePercent is required")]
    [TerraformProperty("max_batch_instance_percent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxBatchInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyInstancePercent is required")]
    [TerraformProperty("max_unhealthy_instance_percent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxUnhealthyInstancePercent { get; set; }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyUpgradedInstancePercent is required")]
    [TerraformProperty("max_unhealthy_upgraded_instance_percent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>
    /// The maximum_surge_instances_enabled attribute.
    /// </summary>
    [TerraformProperty("maximum_surge_instances_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MaximumSurgeInstancesEnabled { get; set; }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PauseTimeBetweenBatches is required")]
    [TerraformProperty("pause_time_between_batches")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PauseTimeBetweenBatches { get; set; }

    /// <summary>
    /// The prioritize_unhealthy_instances_enabled attribute.
    /// </summary>
    [TerraformProperty("prioritize_unhealthy_instances_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrioritizeUnhealthyInstancesEnabled { get; set; }

}

/// <summary>
/// Block type for scale_in in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetScaleInBlock : TerraformBlockBase
{
    /// <summary>
    /// The force_deletion_enabled attribute.
    /// </summary>
    [TerraformProperty("force_deletion_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDeletionEnabled { get; set; }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    [TerraformProperty("rule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Rule { get; set; }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetSecretBlock : TerraformBlockBase
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultId { get; set; }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformProperty("offer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for spot_restore in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLinuxVirtualMachineScaleSetTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_linux_virtual_machine_scale_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLinuxVirtualMachineScaleSet : TerraformResource
{
    public AzurermLinuxVirtualMachineScaleSet(string name) : base("azurerm_linux_virtual_machine_scale_set", name)
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformProperty("admin_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdminPassword { get; set; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    [TerraformProperty("admin_username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminUsername { get; set; }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformProperty("capacity_reservation_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CapacityReservationGroupId { get; set; }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    [TerraformProperty("computer_name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ComputerNamePrefix { get; set; }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformProperty("custom_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomData { get; set; }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    [TerraformProperty("disable_password_authentication")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisablePasswordAuthentication { get; set; }

    /// <summary>
    /// The do_not_run_extensions_on_overprovisioned_machines attribute.
    /// </summary>
    [TerraformProperty("do_not_run_extensions_on_overprovisioned_machines")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DoNotRunExtensionsOnOverprovisionedMachines { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformProperty("encryption_at_host_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EncryptionAtHostEnabled { get; set; }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformProperty("eviction_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EvictionPolicy { get; set; }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    [TerraformProperty("extension_operations_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExtensionOperationsEnabled { get; set; }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    [TerraformProperty("extensions_time_budget")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExtensionsTimeBudget { get; set; }

    /// <summary>
    /// The health_probe_id attribute.
    /// </summary>
    [TerraformProperty("health_probe_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthProbeId { get; set; }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    [TerraformProperty("host_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformProperty("instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Instances { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    [TerraformProperty("max_bid_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxBidPrice { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The overprovision attribute.
    /// </summary>
    [TerraformProperty("overprovision")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Overprovision { get; set; }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [TerraformProperty("platform_fault_domain_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PlatformFaultDomainCount { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    [TerraformProperty("provision_vm_agent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ProvisionVmAgent { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformProperty("proximity_placement_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The resilient_vm_creation_enabled attribute.
    /// </summary>
    [TerraformProperty("resilient_vm_creation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ResilientVmCreationEnabled { get; set; }

    /// <summary>
    /// The resilient_vm_deletion_enabled attribute.
    /// </summary>
    [TerraformProperty("resilient_vm_deletion_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ResilientVmDeletionEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformProperty("secure_boot_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SecureBootEnabled { get; set; }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    [TerraformProperty("single_placement_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SinglePlacementGroup { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformProperty("source_image_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceImageId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    [TerraformProperty("upgrade_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UpgradeMode { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformProperty("vtpm_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VtpmEnabled { get; set; }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    [TerraformProperty("zone_balance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZoneBalance { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformProperty("additional_capabilities")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; }

    /// <summary>
    /// Block for admin_ssh_key.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("admin_ssh_key")]
    public partial TerraformSet<TerraformBlock<AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock>>? AdminSshKey { get; set; }

    /// <summary>
    /// Block for automatic_instance_repair.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    [TerraformProperty("automatic_instance_repair")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock>>? AutomaticInstanceRepair { get; set; }

    /// <summary>
    /// Block for automatic_os_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticOsUpgradePolicy block(s) allowed")]
    [TerraformProperty("automatic_os_upgrade_policy")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock>>? AutomaticOsUpgradePolicy { get; set; }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformProperty("boot_diagnostics")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock>>? BootDiagnostics { get; set; }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("data_disk")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetDataDiskBlock>>? DataDisk { get; set; }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("extension")]
    public partial TerraformSet<TerraformBlock<AzurermLinuxVirtualMachineScaleSetExtensionBlock>>? Extension { get; set; }

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    [TerraformProperty("gallery_application")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock>>? GalleryApplication { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterface is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    [TerraformProperty("network_interface")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock>>? NetworkInterface { get; set; }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformProperty("os_disk")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetOsDiskBlock>>? OsDisk { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformProperty("plan")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetPlanBlock>>? Plan { get; set; }

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    [TerraformProperty("rolling_upgrade_policy")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock>>? RollingUpgradePolicy { get; set; }

    /// <summary>
    /// Block for scale_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleIn block(s) allowed")]
    [TerraformProperty("scale_in")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetScaleInBlock>>? ScaleIn { get; set; }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("secret")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetSecretBlock>>? Secret { get; set; }

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformProperty("source_image_reference")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock>>? SourceImageReference { get; set; }

    /// <summary>
    /// Block for spot_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotRestore block(s) allowed")]
    [TerraformProperty("spot_restore")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock>>? SpotRestore { get; set; }

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformProperty("termination_notification")]
    public partial TerraformList<TerraformBlock<AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock>>? TerminationNotification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermLinuxVirtualMachineScaleSetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformProperty("unique_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UniqueId { get; }

}
