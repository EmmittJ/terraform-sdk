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
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_capabilities";

    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    [TerraformArgument("ultra_ssd_enabled")]
    public TerraformValue<bool>? UltraSsdEnabled
    {
        get => new TerraformReference<bool>(this, "ultra_ssd_enabled");
        set => SetArgument("ultra_ssd_enabled", value);
    }

}

/// <summary>
/// Block type for automatic_instance_repair in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_instance_repair";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformArgument("action")]
    public TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The grace_period attribute.
    /// </summary>
    [TerraformArgument("grace_period")]
    public TerraformValue<string> GracePeriod
    {
        get => new TerraformReference<string>(this, "grace_period");
        set => SetArgument("grace_period", value);
    }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_diagnostics";

    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    [TerraformArgument("storage_account_uri")]
    public TerraformValue<string>? StorageAccountUri
    {
        get => new TerraformReference<string>(this, "storage_account_uri");
        set => SetArgument("storage_account_uri", value);
    }

}

/// <summary>
/// Block type for data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disk";

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformArgument("caching")]
    public required TerraformValue<string> Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    [TerraformArgument("create_option")]
    public TerraformValue<string>? CreateOption
    {
        get => new TerraformReference<string>(this, "create_option");
        set => SetArgument("create_option", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_set_id")]
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("disk_size_gb")]
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [TerraformArgument("lun")]
    public TerraformValue<double> Lun
    {
        get => new TerraformReference<double>(this, "lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformArgument("storage_account_type")]
    public required TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_iops_read_write attribute.
    /// </summary>
    [TerraformArgument("ultra_ssd_disk_iops_read_write")]
    public TerraformValue<double> UltraSsdDiskIopsReadWrite
    {
        get => new TerraformReference<double>(this, "ultra_ssd_disk_iops_read_write");
        set => SetArgument("ultra_ssd_disk_iops_read_write", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_mbps_read_write attribute.
    /// </summary>
    [TerraformArgument("ultra_ssd_disk_mbps_read_write")]
    public TerraformValue<double> UltraSsdDiskMbpsReadWrite
    {
        get => new TerraformReference<double>(this, "ultra_ssd_disk_mbps_read_write");
        set => SetArgument("ultra_ssd_disk_mbps_read_write", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformArgument("write_accelerator_enabled")]
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetExtensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extension";

    /// <summary>
    /// The auto_upgrade_minor_version_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_upgrade_minor_version_enabled")]
    public TerraformValue<bool>? AutoUpgradeMinorVersionEnabled
    {
        get => new TerraformReference<bool>(this, "auto_upgrade_minor_version_enabled");
        set => SetArgument("auto_upgrade_minor_version_enabled", value);
    }

    /// <summary>
    /// The extensions_to_provision_after_vm_creation attribute.
    /// </summary>
    [TerraformArgument("extensions_to_provision_after_vm_creation")]
    public TerraformList<string>? ExtensionsToProvisionAfterVmCreation
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "extensions_to_provision_after_vm_creation").ResolveNodes(ctx));
        set => SetArgument("extensions_to_provision_after_vm_creation", value);
    }

    /// <summary>
    /// The failure_suppression_enabled attribute.
    /// </summary>
    [TerraformArgument("failure_suppression_enabled")]
    public TerraformValue<bool>? FailureSuppressionEnabled
    {
        get => new TerraformReference<bool>(this, "failure_suppression_enabled");
        set => SetArgument("failure_suppression_enabled", value);
    }

    /// <summary>
    /// The force_extension_execution_on_change attribute.
    /// </summary>
    [TerraformArgument("force_extension_execution_on_change")]
    public TerraformValue<string>? ForceExtensionExecutionOnChange
    {
        get => new TerraformReference<string>(this, "force_extension_execution_on_change");
        set => SetArgument("force_extension_execution_on_change", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformArgument("protected_settings")]
    public TerraformValue<string>? ProtectedSettings
    {
        get => new TerraformReference<string>(this, "protected_settings");
        set => SetArgument("protected_settings", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformArgument("settings")]
    public TerraformValue<string>? Settings
    {
        get => new TerraformReference<string>(this, "settings");
        set => SetArgument("settings", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    [TerraformArgument("type_handler_version")]
    public required TerraformValue<string> TypeHandlerVersion
    {
        get => new TerraformReference<string>(this, "type_handler_version");
        set => SetArgument("type_handler_version", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformArgument("identity_ids")]
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface";

    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    [TerraformArgument("auxiliary_mode")]
    public TerraformValue<string>? AuxiliaryMode
    {
        get => new TerraformReference<string>(this, "auxiliary_mode");
        set => SetArgument("auxiliary_mode", value);
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    [TerraformArgument("auxiliary_sku")]
    public TerraformValue<string>? AuxiliarySku
    {
        get => new TerraformReference<string>(this, "auxiliary_sku");
        set => SetArgument("auxiliary_sku", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformArgument("dns_servers")]
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The enable_accelerated_networking attribute.
    /// </summary>
    [TerraformArgument("enable_accelerated_networking")]
    public TerraformValue<bool>? EnableAcceleratedNetworking
    {
        get => new TerraformReference<bool>(this, "enable_accelerated_networking");
        set => SetArgument("enable_accelerated_networking", value);
    }

    /// <summary>
    /// The enable_ip_forwarding attribute.
    /// </summary>
    [TerraformArgument("enable_ip_forwarding")]
    public TerraformValue<bool>? EnableIpForwarding
    {
        get => new TerraformReference<bool>(this, "enable_ip_forwarding");
        set => SetArgument("enable_ip_forwarding", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    [TerraformArgument("network_security_group_id")]
    public TerraformValue<string>? NetworkSecurityGroupId
    {
        get => new TerraformReference<string>(this, "network_security_group_id");
        set => SetArgument("network_security_group_id", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformArgument("primary")]
    public TerraformValue<bool>? Primary
    {
        get => new TerraformReference<bool>(this, "primary");
        set => SetArgument("primary", value);
    }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_disk";

    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    [TerraformArgument("caching")]
    public required TerraformValue<string> Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_set_id")]
    public TerraformValue<string>? DiskEncryptionSetId
    {
        get => new TerraformReference<string>(this, "disk_encryption_set_id");
        set => SetArgument("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("disk_size_gb")]
    public TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    [TerraformArgument("storage_account_type")]
    public required TerraformValue<string> StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    [TerraformArgument("write_accelerator_enabled")]
    public TerraformValue<bool>? WriteAcceleratorEnabled
    {
        get => new TerraformReference<bool>(this, "write_accelerator_enabled");
        set => SetArgument("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for os_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile";

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    [TerraformArgument("custom_data")]
    public TerraformValue<string>? CustomData
    {
        get => new TerraformReference<string>(this, "custom_data");
        set => SetArgument("custom_data", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetPlanBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plan";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    [TerraformArgument("product")]
    public required TerraformValue<string> Product
    {
        get => new TerraformReference<string>(this, "product");
        set => SetArgument("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

}

/// <summary>
/// Block type for priority_mix in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "priority_mix";

    /// <summary>
    /// The base_regular_count attribute.
    /// </summary>
    [TerraformArgument("base_regular_count")]
    public TerraformValue<double>? BaseRegularCount
    {
        get => new TerraformReference<double>(this, "base_regular_count");
        set => SetArgument("base_regular_count", value);
    }

    /// <summary>
    /// The regular_percentage_above_base attribute.
    /// </summary>
    [TerraformArgument("regular_percentage_above_base")]
    public TerraformValue<double>? RegularPercentageAboveBase
    {
        get => new TerraformReference<double>(this, "regular_percentage_above_base");
        set => SetArgument("regular_percentage_above_base", value);
    }

}

/// <summary>
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rolling_upgrade_policy";

    /// <summary>
    /// The cross_zone_upgrades_enabled attribute.
    /// </summary>
    [TerraformArgument("cross_zone_upgrades_enabled")]
    public TerraformValue<bool>? CrossZoneUpgradesEnabled
    {
        get => new TerraformReference<bool>(this, "cross_zone_upgrades_enabled");
        set => SetArgument("cross_zone_upgrades_enabled", value);
    }

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxBatchInstancePercent is required")]
    [TerraformArgument("max_batch_instance_percent")]
    public required TerraformValue<double> MaxBatchInstancePercent
    {
        get => new TerraformReference<double>(this, "max_batch_instance_percent");
        set => SetArgument("max_batch_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyInstancePercent is required")]
    [TerraformArgument("max_unhealthy_instance_percent")]
    public required TerraformValue<double> MaxUnhealthyInstancePercent
    {
        get => new TerraformReference<double>(this, "max_unhealthy_instance_percent");
        set => SetArgument("max_unhealthy_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyUpgradedInstancePercent is required")]
    [TerraformArgument("max_unhealthy_upgraded_instance_percent")]
    public required TerraformValue<double> MaxUnhealthyUpgradedInstancePercent
    {
        get => new TerraformReference<double>(this, "max_unhealthy_upgraded_instance_percent");
        set => SetArgument("max_unhealthy_upgraded_instance_percent", value);
    }

    /// <summary>
    /// The maximum_surge_instances_enabled attribute.
    /// </summary>
    [TerraformArgument("maximum_surge_instances_enabled")]
    public TerraformValue<bool>? MaximumSurgeInstancesEnabled
    {
        get => new TerraformReference<bool>(this, "maximum_surge_instances_enabled");
        set => SetArgument("maximum_surge_instances_enabled", value);
    }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PauseTimeBetweenBatches is required")]
    [TerraformArgument("pause_time_between_batches")]
    public required TerraformValue<string> PauseTimeBetweenBatches
    {
        get => new TerraformReference<string>(this, "pause_time_between_batches");
        set => SetArgument("pause_time_between_batches", value);
    }

    /// <summary>
    /// The prioritize_unhealthy_instances_enabled attribute.
    /// </summary>
    [TerraformArgument("prioritize_unhealthy_instances_enabled")]
    public TerraformValue<bool>? PrioritizeUnhealthyInstancesEnabled
    {
        get => new TerraformReference<bool>(this, "prioritize_unhealthy_instances_enabled");
        set => SetArgument("prioritize_unhealthy_instances_enabled", value);
    }

}

/// <summary>
/// Block type for sku_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku_profile";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    [TerraformArgument("allocation_strategy")]
    public required TerraformValue<string> AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// The vm_sizes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSizes is required")]
    [TerraformArgument("vm_sizes")]
    public required TerraformSet<string> VmSizes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vm_sizes").ResolveNodes(ctx));
        set => SetArgument("vm_sizes", value);
    }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_image_reference";

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformArgument("offer")]
    public required TerraformValue<string> Offer
    {
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "termination_notification";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformArgument("timeout")]
    public TerraformValue<string>? Timeout
    {
        get => new TerraformReference<string>(this, "timeout");
        set => SetArgument("timeout", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("capacity_reservation_group_id")]
    public TerraformValue<string>? CapacityReservationGroupId
    {
        get => new TerraformReference<string>(this, "capacity_reservation_group_id");
        set => SetArgument("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    [TerraformArgument("encryption_at_host_enabled")]
    public TerraformValue<bool>? EncryptionAtHostEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_at_host_enabled");
        set => SetArgument("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformArgument("eviction_policy")]
    public TerraformValue<string>? EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
        set => SetArgument("eviction_policy", value);
    }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    [TerraformArgument("extension_operations_enabled")]
    public TerraformValue<bool>? ExtensionOperationsEnabled
    {
        get => new TerraformReference<bool>(this, "extension_operations_enabled");
        set => SetArgument("extension_operations_enabled", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    [TerraformArgument("extensions_time_budget")]
    public TerraformValue<string>? ExtensionsTimeBudget
    {
        get => new TerraformReference<string>(this, "extensions_time_budget");
        set => SetArgument("extensions_time_budget", value);
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
    /// The instances attribute.
    /// </summary>
    [TerraformArgument("instances")]
    public TerraformValue<double> Instances
    {
        get => new TerraformReference<double>(this, "instances");
        set => SetArgument("instances", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string>? LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    [TerraformArgument("max_bid_price")]
    public TerraformValue<double>? MaxBidPrice
    {
        get => new TerraformReference<double>(this, "max_bid_price");
        set => SetArgument("max_bid_price", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_api_version attribute.
    /// </summary>
    [TerraformArgument("network_api_version")]
    public TerraformValue<string>? NetworkApiVersion
    {
        get => new TerraformReference<string>(this, "network_api_version");
        set => SetArgument("network_api_version", value);
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformFaultDomainCount is required")]
    [TerraformArgument("platform_fault_domain_count")]
    public required TerraformValue<double> PlatformFaultDomainCount
    {
        get => new TerraformReference<double>(this, "platform_fault_domain_count");
        set => SetArgument("platform_fault_domain_count", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformArgument("priority")]
    public TerraformValue<string>? Priority
    {
        get => new TerraformReference<string>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    [TerraformArgument("proximity_placement_group_id")]
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
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
    /// The single_placement_group attribute.
    /// </summary>
    [TerraformArgument("single_placement_group")]
    public TerraformValue<bool> SinglePlacementGroup
    {
        get => new TerraformReference<bool>(this, "single_placement_group");
        set => SetArgument("single_placement_group", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string>? SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformArgument("source_image_id")]
    public TerraformValue<string>? SourceImageId
    {
        get => new TerraformReference<string>(this, "source_image_id");
        set => SetArgument("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    [TerraformArgument("upgrade_mode")]
    public TerraformValue<string>? UpgradeMode
    {
        get => new TerraformReference<string>(this, "upgrade_mode");
        set => SetArgument("upgrade_mode", value);
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformArgument("user_data_base64")]
    public TerraformValue<string>? UserDataBase64
    {
        get => new TerraformReference<string>(this, "user_data_base64");
        set => SetArgument("user_data_base64", value);
    }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    [TerraformArgument("zone_balance")]
    public TerraformValue<bool>? ZoneBalance
    {
        get => new TerraformReference<bool>(this, "zone_balance");
        set => SetArgument("zone_balance", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    [TerraformArgument("additional_capabilities")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetAdditionalCapabilitiesBlock> AdditionalCapabilities { get; set; } = new();

    /// <summary>
    /// Block for automatic_instance_repair.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    [TerraformArgument("automatic_instance_repair")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetAutomaticInstanceRepairBlock> AutomaticInstanceRepair { get; set; } = new();

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    [TerraformArgument("boot_diagnostics")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetBootDiagnosticsBlock> BootDiagnostics { get; set; } = new();

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("data_disk")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetDataDiskBlock> DataDisk { get; set; } = new();

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("extension")]
    public TerraformSet<AzurermOrchestratedVirtualMachineScaleSetExtensionBlock> Extension { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("network_interface")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetNetworkInterfaceBlock> NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    [TerraformArgument("os_disk")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsDiskBlock> OsDisk { get; set; } = new();

    /// <summary>
    /// Block for os_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    [TerraformArgument("os_profile")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetOsProfileBlock> OsProfile { get; set; } = new();

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformArgument("plan")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetPlanBlock> Plan { get; set; } = new();

    /// <summary>
    /// Block for priority_mix.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PriorityMix block(s) allowed")]
    [TerraformArgument("priority_mix")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetPriorityMixBlock> PriorityMix { get; set; } = new();

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    [TerraformArgument("rolling_upgrade_policy")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetRollingUpgradePolicyBlock> RollingUpgradePolicy { get; set; } = new();

    /// <summary>
    /// Block for sku_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SkuProfile block(s) allowed")]
    [TerraformArgument("sku_profile")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetSkuProfileBlock> SkuProfile { get; set; } = new();

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    [TerraformArgument("source_image_reference")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetSourceImageReferenceBlock> SourceImageReference { get; set; } = new();

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    [TerraformArgument("termination_notification")]
    public TerraformList<AzurermOrchestratedVirtualMachineScaleSetTerminationNotificationBlock> TerminationNotification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOrchestratedVirtualMachineScaleSetTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    [TerraformArgument("unique_id")]
    public TerraformValue<string> UniqueId
    {
        get => new TerraformReference<string>(this, "unique_id");
    }

}
