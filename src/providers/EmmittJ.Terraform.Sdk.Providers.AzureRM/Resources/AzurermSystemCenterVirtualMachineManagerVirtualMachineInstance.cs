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
/// Block type for hardware in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hardware";

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformArgument("cpu_count")]
    public TerraformValue<double>? CpuCount
    {
        get => new TerraformReference<double>(this, "cpu_count");
        set => SetArgument("cpu_count", value);
    }

    /// <summary>
    /// The dynamic_memory_max_in_mb attribute.
    /// </summary>
    [TerraformArgument("dynamic_memory_max_in_mb")]
    public TerraformValue<double>? DynamicMemoryMaxInMb
    {
        get => new TerraformReference<double>(this, "dynamic_memory_max_in_mb");
        set => SetArgument("dynamic_memory_max_in_mb", value);
    }

    /// <summary>
    /// The dynamic_memory_min_in_mb attribute.
    /// </summary>
    [TerraformArgument("dynamic_memory_min_in_mb")]
    public TerraformValue<double>? DynamicMemoryMinInMb
    {
        get => new TerraformReference<double>(this, "dynamic_memory_min_in_mb");
        set => SetArgument("dynamic_memory_min_in_mb", value);
    }

    /// <summary>
    /// The limit_cpu_for_migration_enabled attribute.
    /// </summary>
    [TerraformArgument("limit_cpu_for_migration_enabled")]
    public TerraformValue<bool>? LimitCpuForMigrationEnabled
    {
        get => new TerraformReference<bool>(this, "limit_cpu_for_migration_enabled");
        set => SetArgument("limit_cpu_for_migration_enabled", value);
    }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    [TerraformArgument("memory_in_mb")]
    public TerraformValue<double>? MemoryInMb
    {
        get => new TerraformReference<double>(this, "memory_in_mb");
        set => SetArgument("memory_in_mb", value);
    }

}

/// <summary>
/// Block type for infrastructure in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "infrastructure";

    /// <summary>
    /// The checkpoint_type attribute.
    /// </summary>
    [TerraformArgument("checkpoint_type")]
    public TerraformValue<string>? CheckpointType
    {
        get => new TerraformReference<string>(this, "checkpoint_type");
        set => SetArgument("checkpoint_type", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_cloud_id attribute.
    /// </summary>
    [TerraformArgument("system_center_virtual_machine_manager_cloud_id")]
    public TerraformValue<string>? SystemCenterVirtualMachineManagerCloudId
    {
        get => new TerraformReference<string>(this, "system_center_virtual_machine_manager_cloud_id");
        set => SetArgument("system_center_virtual_machine_manager_cloud_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_inventory_item_id attribute.
    /// </summary>
    [TerraformArgument("system_center_virtual_machine_manager_inventory_item_id")]
    public TerraformValue<string>? SystemCenterVirtualMachineManagerInventoryItemId
    {
        get => new TerraformReference<string>(this, "system_center_virtual_machine_manager_inventory_item_id");
        set => SetArgument("system_center_virtual_machine_manager_inventory_item_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_template_id attribute.
    /// </summary>
    [TerraformArgument("system_center_virtual_machine_manager_template_id")]
    public TerraformValue<string>? SystemCenterVirtualMachineManagerTemplateId
    {
        get => new TerraformReference<string>(this, "system_center_virtual_machine_manager_template_id");
        set => SetArgument("system_center_virtual_machine_manager_template_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_virtual_machine_server_id attribute.
    /// </summary>
    [TerraformArgument("system_center_virtual_machine_manager_virtual_machine_server_id")]
    public TerraformValue<string>? SystemCenterVirtualMachineManagerVirtualMachineServerId
    {
        get => new TerraformReference<string>(this, "system_center_virtual_machine_manager_virtual_machine_server_id");
        set => SetArgument("system_center_virtual_machine_manager_virtual_machine_server_id", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface";

    /// <summary>
    /// The ipv4_address_type attribute.
    /// </summary>
    [TerraformArgument("ipv4_address_type")]
    public TerraformValue<string>? Ipv4AddressType
    {
        get => new TerraformReference<string>(this, "ipv4_address_type");
        set => SetArgument("ipv4_address_type", value);
    }

    /// <summary>
    /// The ipv6_address_type attribute.
    /// </summary>
    [TerraformArgument("ipv6_address_type")]
    public TerraformValue<string>? Ipv6AddressType
    {
        get => new TerraformReference<string>(this, "ipv6_address_type");
        set => SetArgument("ipv6_address_type", value);
    }

    /// <summary>
    /// The mac_address_type attribute.
    /// </summary>
    [TerraformArgument("mac_address_type")]
    public TerraformValue<string>? MacAddressType
    {
        get => new TerraformReference<string>(this, "mac_address_type");
        set => SetArgument("mac_address_type", value);
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
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformArgument("virtual_network_id")]
    public TerraformValue<string>? VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

}

/// <summary>
/// Block type for operating_system in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operating_system";

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformArgument("admin_password")]
    public TerraformValue<string>? AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    [TerraformArgument("computer_name")]
    public TerraformValue<string>? ComputerName
    {
        get => new TerraformReference<string>(this, "computer_name");
        set => SetArgument("computer_name", value);
    }

}

/// <summary>
/// Block type for storage_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_disk";

    /// <summary>
    /// The bus attribute.
    /// </summary>
    [TerraformArgument("bus")]
    public TerraformValue<double>? Bus
    {
        get => new TerraformReference<double>(this, "bus");
        set => SetArgument("bus", value);
    }

    /// <summary>
    /// The bus_type attribute.
    /// </summary>
    [TerraformArgument("bus_type")]
    public TerraformValue<string>? BusType
    {
        get => new TerraformReference<string>(this, "bus_type");
        set => SetArgument("bus_type", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformArgument("disk_size_gb")]
    public TerraformValue<double>? DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [TerraformArgument("lun")]
    public TerraformValue<double>? Lun
    {
        get => new TerraformReference<double>(this, "lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_qos_policy_name attribute.
    /// </summary>
    [TerraformArgument("storage_qos_policy_name")]
    public TerraformValue<string>? StorageQosPolicyName
    {
        get => new TerraformReference<string>(this, "storage_qos_policy_name");
        set => SetArgument("storage_qos_policy_name", value);
    }

    /// <summary>
    /// The template_disk_id attribute.
    /// </summary>
    [TerraformArgument("template_disk_id")]
    public TerraformValue<string>? TemplateDiskId
    {
        get => new TerraformReference<string>(this, "template_disk_id");
        set => SetArgument("template_disk_id", value);
    }

    /// <summary>
    /// The vhd_type attribute.
    /// </summary>
    [TerraformArgument("vhd_type")]
    public TerraformValue<string>? VhdType
    {
        get => new TerraformReference<string>(this, "vhd_type");
        set => SetArgument("vhd_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("custom_location_id")]
    public required TerraformValue<string> CustomLocationId
    {
        get => new TerraformReference<string>(this, "custom_location_id");
        set => SetArgument("custom_location_id", value);
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
    /// The scoped_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopedResourceId is required")]
    [TerraformArgument("scoped_resource_id")]
    public required TerraformValue<string> ScopedResourceId
    {
        get => new TerraformReference<string>(this, "scoped_resource_id");
        set => SetArgument("scoped_resource_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_availability_set_ids attribute.
    /// </summary>
    [TerraformArgument("system_center_virtual_machine_manager_availability_set_ids")]
    public TerraformList<string>? SystemCenterVirtualMachineManagerAvailabilitySetIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "system_center_virtual_machine_manager_availability_set_ids").ResolveNodes(ctx));
        set => SetArgument("system_center_virtual_machine_manager_availability_set_ids", value);
    }

    /// <summary>
    /// Block for hardware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hardware block(s) allowed")]
    [TerraformArgument("hardware")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock> Hardware { get; set; } = new();

    /// <summary>
    /// Block for infrastructure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Infrastructure is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Infrastructure block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Infrastructure block(s) allowed")]
    [TerraformArgument("infrastructure")]
    public required TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock> Infrastructure { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("network_interface")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock> NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for operating_system.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperatingSystem block(s) allowed")]
    [TerraformArgument("operating_system")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock> OperatingSystem { get; set; } = new();

    /// <summary>
    /// Block for storage_disk.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("storage_disk")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock> StorageDisk { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock Timeouts { get; set; } = new();

}
