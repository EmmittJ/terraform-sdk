using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for hardware in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock : ITerraformBlock
{
    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CpuCount { get; set; }

    /// <summary>
    /// The dynamic_memory_max_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_memory_max_in_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DynamicMemoryMaxInMb { get; set; }

    /// <summary>
    /// The dynamic_memory_min_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_memory_min_in_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DynamicMemoryMinInMb { get; set; }

    /// <summary>
    /// The limit_cpu_for_migration_enabled attribute.
    /// </summary>
    [TerraformPropertyName("limit_cpu_for_migration_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LimitCpuForMigrationEnabled { get; set; }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("memory_in_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MemoryInMb { get; set; }

}

/// <summary>
/// Block type for infrastructure in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock : ITerraformBlock
{
    /// <summary>
    /// The checkpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("checkpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CheckpointType { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_cloud_id attribute.
    /// </summary>
    [TerraformPropertyName("system_center_virtual_machine_manager_cloud_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SystemCenterVirtualMachineManagerCloudId { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_inventory_item_id attribute.
    /// </summary>
    [TerraformPropertyName("system_center_virtual_machine_manager_inventory_item_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SystemCenterVirtualMachineManagerInventoryItemId { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_template_id attribute.
    /// </summary>
    [TerraformPropertyName("system_center_virtual_machine_manager_template_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SystemCenterVirtualMachineManagerTemplateId { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_virtual_machine_server_id attribute.
    /// </summary>
    [TerraformPropertyName("system_center_virtual_machine_manager_virtual_machine_server_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SystemCenterVirtualMachineManagerVirtualMachineServerId { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock : ITerraformBlock
{
    /// <summary>
    /// The ipv4_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_address_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ipv4AddressType { get; set; }

    /// <summary>
    /// The ipv6_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ipv6AddressType { get; set; }

    /// <summary>
    /// The mac_address_type attribute.
    /// </summary>
    [TerraformPropertyName("mac_address_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MacAddressType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualNetworkId { get; set; }

}

/// <summary>
/// Block type for operating_system in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock : ITerraformBlock
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformPropertyName("admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdminPassword { get; set; }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformPropertyName("computer_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ComputerName { get; set; }

}

/// <summary>
/// Block type for storage_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock : ITerraformBlock
{
    /// <summary>
    /// The bus attribute.
    /// </summary>
    [TerraformPropertyName("bus")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Bus { get; set; }

    /// <summary>
    /// The bus_type attribute.
    /// </summary>
    [TerraformPropertyName("bus_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BusType { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DiskSizeGb { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [TerraformPropertyName("lun")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Lun { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The storage_qos_policy_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_qos_policy_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageQosPolicyName { get; set; }

    /// <summary>
    /// The template_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("template_disk_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TemplateDiskId { get; set; }

    /// <summary>
    /// The vhd_type attribute.
    /// </summary>
    [TerraformPropertyName("vhd_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VhdType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_system_center_virtual_machine_manager_virtual_machine_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance : TerraformResource
{
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance(string name) : base("azurerm_system_center_virtual_machine_manager_virtual_machine_instance", name)
    {
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    [TerraformPropertyName("custom_location_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomLocationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopedResourceId is required")]
    [TerraformPropertyName("scoped_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScopedResourceId { get; set; }

    /// <summary>
    /// The system_center_virtual_machine_manager_availability_set_ids attribute.
    /// </summary>
    [TerraformPropertyName("system_center_virtual_machine_manager_availability_set_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SystemCenterVirtualMachineManagerAvailabilitySetIds { get; set; }

    /// <summary>
    /// Block for hardware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hardware block(s) allowed")]
    [TerraformPropertyName("hardware")]
    public TerraformList<TerraformBlock<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock>>? Hardware { get; set; } = new();

    /// <summary>
    /// Block for infrastructure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Infrastructure is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Infrastructure block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Infrastructure block(s) allowed")]
    [TerraformPropertyName("infrastructure")]
    public TerraformList<TerraformBlock<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock>>? Infrastructure { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_interface")]
    public TerraformList<TerraformBlock<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock>>? NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for operating_system.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperatingSystem block(s) allowed")]
    [TerraformPropertyName("operating_system")]
    public TerraformList<TerraformBlock<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock>>? OperatingSystem { get; set; } = new();

    /// <summary>
    /// Block for storage_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("storage_disk")]
    public TerraformList<TerraformBlock<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock>>? StorageDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

}
