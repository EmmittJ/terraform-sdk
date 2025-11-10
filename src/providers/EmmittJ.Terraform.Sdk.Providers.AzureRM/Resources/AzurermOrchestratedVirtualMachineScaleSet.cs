using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock : ITerraformBlock
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ultra_ssd_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for automatic_instance_repair in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock : ITerraformBlock
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
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock : ITerraformBlock
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
public class AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock : ITerraformBlock
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
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "disk_size_gb");

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [TerraformPropertyName("lun")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Lun { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "lun");

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
public class AzurermOrchestratedVirtualMachineScaleSetExtensionBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_upgrade_minor_version_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_upgrade_minor_version_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoUpgradeMinorVersionEnabled { get; set; }

    /// <summary>
    /// The extensions_to_provision_after_vm_creation attribute.
    /// </summary>
    [TerraformPropertyName("extensions_to_provision_after_vm_creation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ExtensionsToProvisionAfterVmCreation { get; set; }

    /// <summary>
    /// The failure_suppression_enabled attribute.
    /// </summary>
    [TerraformPropertyName("failure_suppression_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FailureSuppressionEnabled { get; set; }

    /// <summary>
    /// The force_extension_execution_on_change attribute.
    /// </summary>
    [TerraformPropertyName("force_extension_execution_on_change")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForceExtensionExecutionOnChange { get; set; }

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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformPropertyName("identity_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

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
public class AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock : ITerraformBlock
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
public class AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock : ITerraformBlock
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
/// Block type for os_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformPropertyName("custom_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomData { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetPlanBlock : ITerraformBlock
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
/// Block type for priority_mix in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock : ITerraformBlock
{
    /// <summary>
    /// The base_regular_count attribute.
    /// </summary>
    [TerraformPropertyName("base_regular_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BaseRegularCount { get; set; }

    /// <summary>
    /// The regular_percentage_above_base attribute.
    /// </summary>
    [TerraformPropertyName("regular_percentage_above_base")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RegularPercentageAboveBase { get; set; }

}

/// <summary>
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock : ITerraformBlock
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
/// Block type for sku_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    [TerraformPropertyName("allocation_strategy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AllocationStrategy { get; set; }

    /// <summary>
    /// The vm_sizes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSizes is required")]
    [TerraformPropertyName("vm_sizes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? VmSizes { get; set; }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock : ITerraformBlock
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
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock : ITerraformBlock
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
public class AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_orchestrated_virtual_machine_scale_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermOrchestratedVirtualMachineScaleSet : TerraformResource
{
    public AzurermOrchestratedVirtualMachineScaleSet(string name) : base("azurerm_orchestrated_virtual_machine_scale_set", name)
    {
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformPropertyName("capacity_reservation_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CapacityReservationGroupId { get; set; }

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
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Instances { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "instances");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LicenseType { get; set; }

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
    /// The network_api_version attribute.
    /// </summary>
    [TerraformPropertyName("network_api_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkApiVersion { get; set; }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformFaultDomainCount is required")]
    [TerraformPropertyName("platform_fault_domain_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> PlatformFaultDomainCount { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Priority { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformPropertyName("proximity_placement_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    [TerraformPropertyName("single_placement_group")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SinglePlacementGroup { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "single_placement_group");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SkuName { get; set; }

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
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("user_data_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserDataBase64 { get; set; }

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
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock>>? AdditionalCapabilities { get; set; } = new();

    /// <summary>
    /// Block for automatic_instance_repair.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    [TerraformPropertyName("automatic_instance_repair")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock>>? AutomaticInstanceRepair { get; set; } = new();

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformPropertyName("boot_diagnostics")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock>>? BootDiagnostics { get; set; } = new();

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("data_disk")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock>>? DataDisk { get; set; } = new();

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("extension")]
    public TerraformSet<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetExtensionBlock>>? Extension { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_interface")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock>>? NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformPropertyName("os_disk")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock>>? OsDisk { get; set; } = new();

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    [TerraformPropertyName("os_profile")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock>>? OsProfile { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformPropertyName("plan")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetPlanBlock>>? Plan { get; set; } = new();

    /// <summary>
    /// Block for priority_mix.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PriorityMix block(s) allowed")]
    [TerraformPropertyName("priority_mix")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock>>? PriorityMix { get; set; } = new();

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    [TerraformPropertyName("rolling_upgrade_policy")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock>>? RollingUpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for sku_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SkuProfile block(s) allowed")]
    [TerraformPropertyName("sku_profile")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock>>? SkuProfile { get; set; } = new();

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformPropertyName("source_image_reference")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock>>? SourceImageReference { get; set; } = new();

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformPropertyName("termination_notification")]
    public TerraformList<TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock>>? TerminationNotification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformPropertyName("unique_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UniqueId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "unique_id");

}
