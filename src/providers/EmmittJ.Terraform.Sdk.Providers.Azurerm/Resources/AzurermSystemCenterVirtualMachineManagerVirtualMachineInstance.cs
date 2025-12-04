using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for hardware in AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance.
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
    public TerraformValue<double>? CpuCount
    {
        get => GetArgument<TerraformValue<double>>("cpu_count");
        set => SetArgument("cpu_count", value);
    }

    /// <summary>
    /// The dynamic_memory_max_in_mb attribute.
    /// </summary>
    public TerraformValue<double>? DynamicMemoryMaxInMb
    {
        get => GetArgument<TerraformValue<double>>("dynamic_memory_max_in_mb");
        set => SetArgument("dynamic_memory_max_in_mb", value);
    }

    /// <summary>
    /// The dynamic_memory_min_in_mb attribute.
    /// </summary>
    public TerraformValue<double>? DynamicMemoryMinInMb
    {
        get => GetArgument<TerraformValue<double>>("dynamic_memory_min_in_mb");
        set => SetArgument("dynamic_memory_min_in_mb", value);
    }

    /// <summary>
    /// The limit_cpu_for_migration_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LimitCpuForMigrationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("limit_cpu_for_migration_enabled");
        set => SetArgument("limit_cpu_for_migration_enabled", value);
    }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    public TerraformValue<double>? MemoryInMb
    {
        get => GetArgument<TerraformValue<double>>("memory_in_mb");
        set => SetArgument("memory_in_mb", value);
    }

}


/// <summary>
/// Block type for infrastructure in AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance.
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
    public TerraformValue<string>? CheckpointType
    {
        get => GetArgument<TerraformValue<string>>("checkpoint_type");
        set => SetArgument("checkpoint_type", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_cloud_id attribute.
    /// </summary>
    public TerraformValue<string>? SystemCenterVirtualMachineManagerCloudId
    {
        get => GetArgument<TerraformValue<string>>("system_center_virtual_machine_manager_cloud_id");
        set => SetArgument("system_center_virtual_machine_manager_cloud_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_inventory_item_id attribute.
    /// </summary>
    public TerraformValue<string>? SystemCenterVirtualMachineManagerInventoryItemId
    {
        get => GetArgument<TerraformValue<string>>("system_center_virtual_machine_manager_inventory_item_id");
        set => SetArgument("system_center_virtual_machine_manager_inventory_item_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_template_id attribute.
    /// </summary>
    public TerraformValue<string>? SystemCenterVirtualMachineManagerTemplateId
    {
        get => GetArgument<TerraformValue<string>>("system_center_virtual_machine_manager_template_id");
        set => SetArgument("system_center_virtual_machine_manager_template_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_virtual_machine_server_id attribute.
    /// </summary>
    public TerraformValue<string>? SystemCenterVirtualMachineManagerVirtualMachineServerId
    {
        get => GetArgument<TerraformValue<string>>("system_center_virtual_machine_manager_virtual_machine_server_id");
        set => SetArgument("system_center_virtual_machine_manager_virtual_machine_server_id", value);
    }

}


/// <summary>
/// Block type for network_interface in AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance.
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
    public TerraformValue<string>? Ipv4AddressType
    {
        get => GetArgument<TerraformValue<string>>("ipv4_address_type");
        set => SetArgument("ipv4_address_type", value);
    }

    /// <summary>
    /// The ipv6_address_type attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6AddressType
    {
        get => GetArgument<TerraformValue<string>>("ipv6_address_type");
        set => SetArgument("ipv6_address_type", value);
    }

    /// <summary>
    /// The mac_address_type attribute.
    /// </summary>
    public TerraformValue<string>? MacAddressType
    {
        get => GetArgument<TerraformValue<string>>("mac_address_type");
        set => SetArgument("mac_address_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

}


/// <summary>
/// Block type for operating_system in AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance.
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
    public TerraformValue<string>? AdminPassword
    {
        get => GetArgument<TerraformValue<string>>("admin_password");
        set => SetArgument("admin_password", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformValue<string>? ComputerName
    {
        get => GetArgument<TerraformValue<string>>("computer_name");
        set => SetArgument("computer_name", value);
    }

}


/// <summary>
/// Block type for storage_disk in AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance.
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
    public TerraformValue<double>? Bus
    {
        get => GetArgument<TerraformValue<double>>("bus");
        set => SetArgument("bus", value);
    }

    /// <summary>
    /// The bus_type attribute.
    /// </summary>
    public TerraformValue<string>? BusType
    {
        get => GetArgument<TerraformValue<string>>("bus_type");
        set => SetArgument("bus_type", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformValue<double>? DiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    public TerraformValue<double>? Lun
    {
        get => GetArgument<TerraformValue<double>>("lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_qos_policy_name attribute.
    /// </summary>
    public TerraformValue<string>? StorageQosPolicyName
    {
        get => GetArgument<TerraformValue<string>>("storage_qos_policy_name");
        set => SetArgument("storage_qos_policy_name", value);
    }

    /// <summary>
    /// The template_disk_id attribute.
    /// </summary>
    public TerraformValue<string>? TemplateDiskId
    {
        get => GetArgument<TerraformValue<string>>("template_disk_id");
        set => SetArgument("template_disk_id", value);
    }

    /// <summary>
    /// The vhd_type attribute.
    /// </summary>
    public TerraformValue<string>? VhdType
    {
        get => GetArgument<TerraformValue<string>>("vhd_type");
        set => SetArgument("vhd_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_system_center_virtual_machine_manager_virtual_machine_instance Terraform resource.
/// Manages a azurerm_system_center_virtual_machine_manager_virtual_machine_instance resource.
/// </summary>
public partial class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance(string name) : TerraformResource("azurerm_system_center_virtual_machine_manager_virtual_machine_instance", name)
{
    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    public required TerraformValue<string> CustomLocationId
    {
        get => GetArgument<TerraformValue<string>>("custom_location_id");
        set => SetArgument("custom_location_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopedResourceId is required")]
    public required TerraformValue<string> ScopedResourceId
    {
        get => GetArgument<TerraformValue<string>>("scoped_resource_id");
        set => SetArgument("scoped_resource_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_availability_set_ids attribute.
    /// </summary>
    public TerraformList<string>? SystemCenterVirtualMachineManagerAvailabilitySetIds
    {
        get => GetArgument<TerraformList<string>>("system_center_virtual_machine_manager_availability_set_ids");
        set => SetArgument("system_center_virtual_machine_manager_availability_set_ids", value);
    }

    /// <summary>
    /// Hardware block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hardware block(s) allowed")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock>? Hardware
    {
        get => GetArgument<TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock>>("hardware");
        set => SetArgument("hardware", value);
    }

    /// <summary>
    /// Infrastructure block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Infrastructure is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Infrastructure block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Infrastructure block(s) allowed")]
    public required TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock> Infrastructure
    {
        get => GetRequiredArgument<TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock>>("infrastructure");
        set => SetArgument("infrastructure", value);
    }

    /// <summary>
    /// NetworkInterface block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetArgument<TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock>>("network_interface");
        set => SetArgument("network_interface", value);
    }

    /// <summary>
    /// OperatingSystem block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperatingSystem block(s) allowed")]
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock>? OperatingSystem
    {
        get => GetArgument<TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock>>("operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// StorageDisk block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock>? StorageDisk
    {
        get => GetArgument<TerraformList<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock>>("storage_disk");
        set => SetArgument("storage_disk", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
