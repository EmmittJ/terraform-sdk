using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UltraSsdEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ultra_ssd_enabled");
        set => WithProperty("ultra_ssd_enabled", value);
    }

}

/// <summary>
/// Block type for automatic_instance_repair in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The grace_period attribute.
    /// </summary>
    public TerraformProperty<string>? GracePeriod
    {
        get => GetProperty<TerraformProperty<string>>("grace_period");
        set => WithProperty("grace_period", value);
    }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountUri
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_uri");
        set => WithProperty("storage_account_uri", value);
    }

}

/// <summary>
/// Block type for data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformProperty<string> Caching
    {
        get => GetRequiredProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformProperty<string>? CreateOption
    {
        get => GetProperty<TerraformProperty<string>>("create_option");
        set => WithProperty("create_option", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    public TerraformProperty<double>? Lun
    {
        get => GetProperty<TerraformProperty<double>>("lun");
        set => WithProperty("lun", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_type");
        set => WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_iops_read_write attribute.
    /// </summary>
    public TerraformProperty<double>? UltraSsdDiskIopsReadWrite
    {
        get => GetProperty<TerraformProperty<double>>("ultra_ssd_disk_iops_read_write");
        set => WithProperty("ultra_ssd_disk_iops_read_write", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_mbps_read_write attribute.
    /// </summary>
    public TerraformProperty<double>? UltraSsdDiskMbpsReadWrite
    {
        get => GetProperty<TerraformProperty<double>>("ultra_ssd_disk_mbps_read_write");
        set => WithProperty("ultra_ssd_disk_mbps_read_write", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WriteAcceleratorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("write_accelerator_enabled");
        set => WithProperty("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetExtensionBlock : TerraformBlock
{
    /// <summary>
    /// The auto_upgrade_minor_version_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoUpgradeMinorVersionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_upgrade_minor_version_enabled");
        set => WithProperty("auto_upgrade_minor_version_enabled", value);
    }

    /// <summary>
    /// The extensions_to_provision_after_vm_creation attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExtensionsToProvisionAfterVmCreation
    {
        get => GetProperty<List<TerraformProperty<string>>>("extensions_to_provision_after_vm_creation");
        set => WithProperty("extensions_to_provision_after_vm_creation", value);
    }

    /// <summary>
    /// The failure_suppression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FailureSuppressionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("failure_suppression_enabled");
        set => WithProperty("failure_suppression_enabled", value);
    }

    /// <summary>
    /// The force_extension_execution_on_change attribute.
    /// </summary>
    public TerraformProperty<string>? ForceExtensionExecutionOnChange
    {
        get => GetProperty<TerraformProperty<string>>("force_extension_execution_on_change");
        set => WithProperty("force_extension_execution_on_change", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformProperty<string>? ProtectedSettings
    {
        get => GetProperty<TerraformProperty<string>>("protected_settings");
        set => WithProperty("protected_settings", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetRequiredProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string>? Settings
    {
        get => GetProperty<TerraformProperty<string>>("settings");
        set => WithProperty("settings", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    public required TerraformProperty<string> TypeHandlerVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type_handler_version");
        set => WithProperty("type_handler_version", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AuxiliaryMode
    {
        get => GetProperty<TerraformProperty<string>>("auxiliary_mode");
        set => WithProperty("auxiliary_mode", value);
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    public TerraformProperty<string>? AuxiliarySku
    {
        get => GetProperty<TerraformProperty<string>>("auxiliary_sku");
        set => WithProperty("auxiliary_sku", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DnsServers
    {
        get => GetProperty<List<TerraformProperty<string>>>("dns_servers");
        set => WithProperty("dns_servers", value);
    }

    /// <summary>
    /// The enable_accelerated_networking attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAcceleratedNetworking
    {
        get => GetProperty<TerraformProperty<bool>>("enable_accelerated_networking");
        set => WithProperty("enable_accelerated_networking", value);
    }

    /// <summary>
    /// The enable_ip_forwarding attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableIpForwarding
    {
        get => GetProperty<TerraformProperty<bool>>("enable_ip_forwarding");
        set => WithProperty("enable_ip_forwarding", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("network_security_group_id");
        set => WithProperty("network_security_group_id", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformProperty<bool>? Primary
    {
        get => GetProperty<TerraformProperty<bool>>("primary");
        set => WithProperty("primary", value);
    }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformProperty<string> Caching
    {
        get => GetRequiredProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_type");
        set => WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WriteAcceleratorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("write_accelerator_enabled");
        set => WithProperty("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for os_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock : TerraformBlock
{
    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformProperty<string>? CustomData
    {
        get => GetProperty<TerraformProperty<string>>("custom_data");
        set => WithProperty("custom_data", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetPlanBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        get => GetRequiredProperty<TerraformProperty<string>>("product");
        set => WithProperty("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetRequiredProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

}

/// <summary>
/// Block type for priority_mix in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock : TerraformBlock
{
    /// <summary>
    /// The base_regular_count attribute.
    /// </summary>
    public TerraformProperty<double>? BaseRegularCount
    {
        get => GetProperty<TerraformProperty<double>>("base_regular_count");
        set => WithProperty("base_regular_count", value);
    }

    /// <summary>
    /// The regular_percentage_above_base attribute.
    /// </summary>
    public TerraformProperty<double>? RegularPercentageAboveBase
    {
        get => GetProperty<TerraformProperty<double>>("regular_percentage_above_base");
        set => WithProperty("regular_percentage_above_base", value);
    }

}

/// <summary>
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The cross_zone_upgrades_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CrossZoneUpgradesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cross_zone_upgrades_enabled");
        set => WithProperty("cross_zone_upgrades_enabled", value);
    }

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxBatchInstancePercent is required")]
    public required TerraformProperty<double> MaxBatchInstancePercent
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_batch_instance_percent");
        set => WithProperty("max_batch_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyInstancePercent is required")]
    public required TerraformProperty<double> MaxUnhealthyInstancePercent
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_unhealthy_instance_percent");
        set => WithProperty("max_unhealthy_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyUpgradedInstancePercent is required")]
    public required TerraformProperty<double> MaxUnhealthyUpgradedInstancePercent
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_unhealthy_upgraded_instance_percent");
        set => WithProperty("max_unhealthy_upgraded_instance_percent", value);
    }

    /// <summary>
    /// The maximum_surge_instances_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MaximumSurgeInstancesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("maximum_surge_instances_enabled");
        set => WithProperty("maximum_surge_instances_enabled", value);
    }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PauseTimeBetweenBatches is required")]
    public required TerraformProperty<string> PauseTimeBetweenBatches
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pause_time_between_batches");
        set => WithProperty("pause_time_between_batches", value);
    }

    /// <summary>
    /// The prioritize_unhealthy_instances_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrioritizeUnhealthyInstancesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("prioritize_unhealthy_instances_enabled");
        set => WithProperty("prioritize_unhealthy_instances_enabled", value);
    }

}

/// <summary>
/// Block type for sku_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock : TerraformBlock
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    public required TerraformProperty<string> AllocationStrategy
    {
        get => GetRequiredProperty<TerraformProperty<string>>("allocation_strategy");
        set => WithProperty("allocation_strategy", value);
    }

    /// <summary>
    /// The vm_sizes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSizes is required")]
    public HashSet<TerraformProperty<string>>? VmSizes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vm_sizes");
        set => WithProperty("vm_sizes", value);
    }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformProperty<string> Offer
    {
        get => GetRequiredProperty<TerraformProperty<string>>("offer");
        set => WithProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetRequiredProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sku");
        set => WithProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => WithProperty("timeout", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_orchestrated_virtual_machine_scale_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermOrchestratedVirtualMachineScaleSet : TerraformResource
{
    public AzurermOrchestratedVirtualMachineScaleSet(string name) : base("azurerm_orchestrated_virtual_machine_scale_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("unique_id");
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("capacity_reservation_group_id");
        set => this.WithProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionAtHostEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_at_host_enabled");
        set => this.WithProperty("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("eviction_policy");
        set => this.WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExtensionOperationsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("extension_operations_enabled");
        set => this.WithProperty("extension_operations_enabled", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformProperty<string>? ExtensionsTimeBudget
    {
        get => GetProperty<TerraformProperty<string>>("extensions_time_budget");
        set => this.WithProperty("extensions_time_budget", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformProperty<double>? Instances
    {
        get => GetProperty<TerraformProperty<double>>("instances");
        set => this.WithProperty("instances", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformProperty<double>? MaxBidPrice
    {
        get => GetProperty<TerraformProperty<double>>("max_bid_price");
        set => this.WithProperty("max_bid_price", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_api_version attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkApiVersion
    {
        get => GetProperty<TerraformProperty<string>>("network_api_version");
        set => this.WithProperty("network_api_version", value);
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformFaultDomainCount is required")]
    public required TerraformProperty<double> PlatformFaultDomainCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("platform_fault_domain_count");
        set => this.WithProperty("platform_fault_domain_count", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string>? Priority
    {
        get => GetProperty<TerraformProperty<string>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("proximity_placement_group_id");
        set => this.WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    public TerraformProperty<bool>? SinglePlacementGroup
    {
        get => GetProperty<TerraformProperty<bool>>("single_placement_group");
        set => this.WithProperty("single_placement_group", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceImageId
    {
        get => GetProperty<TerraformProperty<string>>("source_image_id");
        set => this.WithProperty("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeMode
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_mode");
        set => this.WithProperty("upgrade_mode", value);
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? UserDataBase64
    {
        get => GetProperty<TerraformProperty<string>>("user_data_base64");
        set => this.WithProperty("user_data_base64", value);
    }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneBalance
    {
        get => GetProperty<TerraformProperty<bool>>("zone_balance");
        set => this.WithProperty("zone_balance", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock>>("additional_capabilities");
        set => this.WithProperty("additional_capabilities", value);
    }

    /// <summary>
    /// Block for automatic_instance_repair.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock>? AutomaticInstanceRepair
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock>>("automatic_instance_repair");
        set => this.WithProperty("automatic_instance_repair", value);
    }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock>>("boot_diagnostics");
        set => this.WithProperty("boot_diagnostics", value);
    }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock>? DataDisk
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock>>("data_disk");
        set => this.WithProperty("data_disk", value);
    }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermOrchestratedVirtualMachineScaleSetExtensionBlock>? Extension
    {
        get => GetProperty<HashSet<AzurermOrchestratedVirtualMachineScaleSetExtensionBlock>>("extension");
        set => this.WithProperty("extension", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock>>("network_interface");
        set => this.WithProperty("network_interface", value);
    }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock>? OsDisk
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock>>("os_disk");
        set => this.WithProperty("os_disk", value);
    }

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock>? OsProfile
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock>>("os_profile");
        set => this.WithProperty("os_profile", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetPlanBlock>? Plan
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetPlanBlock>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// Block for priority_mix.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PriorityMix block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock>? PriorityMix
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock>>("priority_mix");
        set => this.WithProperty("priority_mix", value);
    }

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock>? RollingUpgradePolicy
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock>>("rolling_upgrade_policy");
        set => this.WithProperty("rolling_upgrade_policy", value);
    }

    /// <summary>
    /// Block for sku_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SkuProfile block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock>? SkuProfile
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock>>("sku_profile");
        set => this.WithProperty("sku_profile", value);
    }

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock>? SourceImageReference
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock>>("source_image_reference");
        set => this.WithProperty("source_image_reference", value);
    }

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    public List<AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock>? TerminationNotification
    {
        get => GetProperty<List<AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock>>("termination_notification");
        set => this.WithProperty("termination_notification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
