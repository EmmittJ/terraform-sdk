using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock() : TerraformBlock("additional_capabilities")
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformProperty("ultra_ssd_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UltraSsdEnabled { get; set; }

}

/// <summary>
/// Block type for automatic_instance_repair in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock() : TerraformBlock("automatic_instance_repair")
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
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock() : TerraformBlock("boot_diagnostics")
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
public partial class AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock() : TerraformBlock("data_disk")
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
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [TerraformProperty("lun")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Lun { get; set; }

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
public partial class AzurermOrchestratedVirtualMachineScaleSetExtensionBlock() : TerraformBlock("extension")
{
    /// <summary>
    /// The auto_upgrade_minor_version_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_upgrade_minor_version_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoUpgradeMinorVersionEnabled { get; set; }

    /// <summary>
    /// The extensions_to_provision_after_vm_creation attribute.
    /// </summary>
    [TerraformProperty("extensions_to_provision_after_vm_creation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExtensionsToProvisionAfterVmCreation { get; set; }

    /// <summary>
    /// The failure_suppression_enabled attribute.
    /// </summary>
    [TerraformProperty("failure_suppression_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FailureSuppressionEnabled { get; set; }

    /// <summary>
    /// The force_extension_execution_on_change attribute.
    /// </summary>
    [TerraformProperty("force_extension_execution_on_change")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForceExtensionExecutionOnChange { get; set; }

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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformProperty("identity_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> IdentityIds { get; set; }

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
public partial class AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock() : TerraformBlock("network_interface")
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
public partial class AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock() : TerraformBlock("os_disk")
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
/// Block type for os_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock() : TerraformBlock("os_profile")
{
    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformProperty("custom_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomData { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetPlanBlock() : TerraformBlock("plan")
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
/// Block type for priority_mix in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock() : TerraformBlock("priority_mix")
{
    /// <summary>
    /// The base_regular_count attribute.
    /// </summary>
    [TerraformProperty("base_regular_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BaseRegularCount { get; set; }

    /// <summary>
    /// The regular_percentage_above_base attribute.
    /// </summary>
    [TerraformProperty("regular_percentage_above_base")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RegularPercentageAboveBase { get; set; }

}

/// <summary>
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock() : TerraformBlock("rolling_upgrade_policy")
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
/// Block type for sku_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock() : TerraformBlock("sku_profile")
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    [TerraformProperty("allocation_strategy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AllocationStrategy { get; set; }

    /// <summary>
    /// The vm_sizes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSizes is required")]
    [TerraformProperty("vm_sizes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> VmSizes { get; set; }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock() : TerraformBlock("source_image_reference")
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
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock() : TerraformBlock("termination_notification")
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
public partial class AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_orchestrated_virtual_machine_scale_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermOrchestratedVirtualMachineScaleSet : TerraformResource
{
    public AzurermOrchestratedVirtualMachineScaleSet(string name) : base("azurerm_orchestrated_virtual_machine_scale_set", name)
    {
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    [TerraformProperty("capacity_reservation_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CapacityReservationGroupId { get; set; }

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
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformProperty("instances")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Instances { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LicenseType { get; set; }

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
    /// The network_api_version attribute.
    /// </summary>
    [TerraformProperty("network_api_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NetworkApiVersion { get; set; }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformFaultDomainCount is required")]
    [TerraformProperty("platform_fault_domain_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> PlatformFaultDomainCount { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformProperty("proximity_placement_group_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProximityPlacementGroupId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    [TerraformProperty("single_placement_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SinglePlacementGroup { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SkuName { get; set; }

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
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformProperty("user_data_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserDataBase64 { get; set; }

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
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock> AdditionalCapabilities { get; set; } = new();

    /// <summary>
    /// Block for automatic_instance_repair.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    [TerraformProperty("automatic_instance_repair")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock> AutomaticInstanceRepair { get; set; } = new();

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformProperty("boot_diagnostics")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock> BootDiagnostics { get; set; } = new();

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("data_disk")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock> DataDisk { get; set; } = new();

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("extension")]
    public TerraformSet<AzurermOrchestratedVirtualMachineScaleSetExtensionBlock> Extension { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_interface")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock> NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformProperty("os_disk")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock> OsDisk { get; set; } = new();

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    [TerraformProperty("os_profile")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock> OsProfile { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformProperty("plan")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetPlanBlock> Plan { get; set; } = new();

    /// <summary>
    /// Block for priority_mix.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PriorityMix block(s) allowed")]
    [TerraformProperty("priority_mix")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock> PriorityMix { get; set; } = new();

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    [TerraformProperty("rolling_upgrade_policy")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock> RollingUpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for sku_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SkuProfile block(s) allowed")]
    [TerraformProperty("sku_profile")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock> SkuProfile { get; set; } = new();

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformProperty("source_image_reference")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock> SourceImageReference { get; set; } = new();

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformProperty("termination_notification")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock> TerminationNotification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformProperty("unique_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UniqueId { get; }

}
