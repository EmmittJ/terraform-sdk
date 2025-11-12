using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for hardware in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock() : TerraformBlock("hardware")
{
    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformProperty("cpu_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CpuCount { get; set; }

    /// <summary>
    /// The dynamic_memory_max_in_mb attribute.
    /// </summary>
    [TerraformProperty("dynamic_memory_max_in_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DynamicMemoryMaxInMb { get; set; }

    /// <summary>
    /// The dynamic_memory_min_in_mb attribute.
    /// </summary>
    [TerraformProperty("dynamic_memory_min_in_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DynamicMemoryMinInMb { get; set; }

    /// <summary>
    /// The limit_cpu_for_migration_enabled attribute.
    /// </summary>
    [TerraformProperty("limit_cpu_for_migration_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LimitCpuForMigrationEnabled { get; set; }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    [TerraformProperty("memory_in_mb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MemoryInMb { get; set; }

}

/// <summary>
/// Block type for infrastructure in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock() : TerraformBlock("infrastructure")
{
    /// <summary>
    /// The checkpoint_type attribute.
    /// </summary>
    [TerraformProperty("checkpoint_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CheckpointType { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_cloud_id attribute.
    /// </summary>
    [TerraformProperty("system_center_virtual_machine_manager_cloud_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SystemCenterVirtualMachineManagerCloudId { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_inventory_item_id attribute.
    /// </summary>
    [TerraformProperty("system_center_virtual_machine_manager_inventory_item_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SystemCenterVirtualMachineManagerInventoryItemId { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_template_id attribute.
    /// </summary>
    [TerraformProperty("system_center_virtual_machine_manager_template_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SystemCenterVirtualMachineManagerTemplateId { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_virtual_machine_server_id attribute.
    /// </summary>
    [TerraformProperty("system_center_virtual_machine_manager_virtual_machine_server_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SystemCenterVirtualMachineManagerVirtualMachineServerId { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock() : TerraformBlock("network_interface")
{
    /// <summary>
    /// The ipv4_address_type attribute.
    /// </summary>
    [TerraformProperty("ipv4_address_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ipv4AddressType { get; set; }

    /// <summary>
    /// The ipv6_address_type attribute.
    /// </summary>
    [TerraformProperty("ipv6_address_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ipv6AddressType { get; set; }

    /// <summary>
    /// The mac_address_type attribute.
    /// </summary>
    [TerraformProperty("mac_address_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MacAddressType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VirtualNetworkId { get; set; }

}

/// <summary>
/// Block type for operating_system in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock() : TerraformBlock("operating_system")
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformProperty("admin_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdminPassword { get; set; }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformProperty("computer_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComputerName { get; set; }

}

/// <summary>
/// Block type for storage_disk in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock() : TerraformBlock("storage_disk")
{
    /// <summary>
    /// The bus attribute.
    /// </summary>
    [TerraformProperty("bus")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Bus { get; set; }

    /// <summary>
    /// The bus_type attribute.
    /// </summary>
    [TerraformProperty("bus_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BusType { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DiskSizeGb { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [TerraformProperty("lun")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Lun { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The storage_qos_policy_name attribute.
    /// </summary>
    [TerraformProperty("storage_qos_policy_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageQosPolicyName { get; set; }

    /// <summary>
    /// The template_disk_id attribute.
    /// </summary>
    [TerraformProperty("template_disk_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplateDiskId { get; set; }

    /// <summary>
    /// The vhd_type attribute.
    /// </summary>
    [TerraformProperty("vhd_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VhdType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_system_center_virtual_machine_manager_virtual_machine_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance : TerraformResource
{
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance(string name) : base("azurerm_system_center_virtual_machine_manager_virtual_machine_instance", name)
    {
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    [TerraformProperty("custom_location_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomLocationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopedResourceId is required")]
    [TerraformProperty("scoped_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScopedResourceId { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_availability_set_ids attribute.
    /// </summary>
    [TerraformProperty("system_center_virtual_machine_manager_availability_set_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SystemCenterVirtualMachineManagerAvailabilitySetIds { get; set; }

    /// <summary>
    /// Block for hardware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hardware block(s) allowed")]
    [TerraformProperty("hardware")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock> Hardware { get; set; } = new();

    /// <summary>
    /// Block for infrastructure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Infrastructure is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Infrastructure block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Infrastructure block(s) allowed")]
    [TerraformProperty("infrastructure")]
    public required TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock> Infrastructure { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_interface")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock> NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for operating_system.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperatingSystem block(s) allowed")]
    [TerraformProperty("operating_system")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock> OperatingSystem { get; set; } = new();

    /// <summary>
    /// Block for storage_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("storage_disk")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock> StorageDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock Timeouts { get; set; } = new();

}
