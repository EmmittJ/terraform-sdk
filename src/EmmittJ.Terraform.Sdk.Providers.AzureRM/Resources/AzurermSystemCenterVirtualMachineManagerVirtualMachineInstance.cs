using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for hardware in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock : TerraformBlock
{
    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    public TerraformProperty<double>? CpuCount
    {
        get => GetProperty<TerraformProperty<double>>("cpu_count");
        set => WithProperty("cpu_count", value);
    }

    /// <summary>
    /// The dynamic_memory_max_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? DynamicMemoryMaxInMb
    {
        get => GetProperty<TerraformProperty<double>>("dynamic_memory_max_in_mb");
        set => WithProperty("dynamic_memory_max_in_mb", value);
    }

    /// <summary>
    /// The dynamic_memory_min_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? DynamicMemoryMinInMb
    {
        get => GetProperty<TerraformProperty<double>>("dynamic_memory_min_in_mb");
        set => WithProperty("dynamic_memory_min_in_mb", value);
    }

    /// <summary>
    /// The limit_cpu_for_migration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LimitCpuForMigrationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("limit_cpu_for_migration_enabled");
        set => WithProperty("limit_cpu_for_migration_enabled", value);
    }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? MemoryInMb
    {
        get => GetProperty<TerraformProperty<double>>("memory_in_mb");
        set => WithProperty("memory_in_mb", value);
    }

}

/// <summary>
/// Block type for infrastructure in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock : TerraformBlock
{
    /// <summary>
    /// The checkpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? CheckpointType
    {
        get => GetProperty<TerraformProperty<string>>("checkpoint_type");
        set => WithProperty("checkpoint_type", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_cloud_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerCloudId
    {
        get => GetProperty<TerraformProperty<string>>("system_center_virtual_machine_manager_cloud_id");
        set => WithProperty("system_center_virtual_machine_manager_cloud_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_inventory_item_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerInventoryItemId
    {
        get => GetProperty<TerraformProperty<string>>("system_center_virtual_machine_manager_inventory_item_id");
        set => WithProperty("system_center_virtual_machine_manager_inventory_item_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_template_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerTemplateId
    {
        get => GetProperty<TerraformProperty<string>>("system_center_virtual_machine_manager_template_id");
        set => WithProperty("system_center_virtual_machine_manager_template_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_virtual_machine_server_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerVirtualMachineServerId
    {
        get => GetProperty<TerraformProperty<string>>("system_center_virtual_machine_manager_virtual_machine_server_id");
        set => WithProperty("system_center_virtual_machine_manager_virtual_machine_server_id", value);
    }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The ipv4_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv4AddressType
    {
        get => GetProperty<TerraformProperty<string>>("ipv4_address_type");
        set => WithProperty("ipv4_address_type", value);
    }

    /// <summary>
    /// The ipv6_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6AddressType
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_address_type");
        set => WithProperty("ipv6_address_type", value);
    }

    /// <summary>
    /// The mac_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? MacAddressType
    {
        get => GetProperty<TerraformProperty<string>>("mac_address_type");
        set => WithProperty("mac_address_type", value);
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
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_id");
        set => WithProperty("virtual_network_id", value);
    }

}

/// <summary>
/// Block type for operating_system in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock : TerraformBlock
{
    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformProperty<string>>("admin_password");
        set => WithProperty("admin_password", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformProperty<string>? ComputerName
    {
        get => GetProperty<TerraformProperty<string>>("computer_name");
        set => WithProperty("computer_name", value);
    }

}

/// <summary>
/// Block type for storage_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock : TerraformBlock
{
    /// <summary>
    /// The bus attribute.
    /// </summary>
    public TerraformProperty<double>? Bus
    {
        get => GetProperty<TerraformProperty<double>>("bus");
        set => WithProperty("bus", value);
    }

    /// <summary>
    /// The bus_type attribute.
    /// </summary>
    public TerraformProperty<string>? BusType
    {
        get => GetProperty<TerraformProperty<string>>("bus_type");
        set => WithProperty("bus_type", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The storage_qos_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageQosPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("storage_qos_policy_name");
        set => WithProperty("storage_qos_policy_name", value);
    }

    /// <summary>
    /// The template_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateDiskId
    {
        get => GetProperty<TerraformProperty<string>>("template_disk_id");
        set => WithProperty("template_disk_id", value);
    }

    /// <summary>
    /// The vhd_type attribute.
    /// </summary>
    public TerraformProperty<string>? VhdType
    {
        get => GetProperty<TerraformProperty<string>>("vhd_type");
        set => WithProperty("vhd_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_system_center_virtual_machine_manager_virtual_machine_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance : TerraformResource
{
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstance(string name) : base("azurerm_system_center_virtual_machine_manager_virtual_machine_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    public required TerraformProperty<string> CustomLocationId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("custom_location_id");
        set => this.WithProperty("custom_location_id", value);
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
    /// The scoped_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopedResourceId is required")]
    public required TerraformProperty<string> ScopedResourceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scoped_resource_id");
        set => this.WithProperty("scoped_resource_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_availability_set_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SystemCenterVirtualMachineManagerAvailabilitySetIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("system_center_virtual_machine_manager_availability_set_ids");
        set => this.WithProperty("system_center_virtual_machine_manager_availability_set_ids", value);
    }

    /// <summary>
    /// Block for hardware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hardware block(s) allowed")]
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock>? Hardware
    {
        get => GetProperty<List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock>>("hardware");
        set => this.WithProperty("hardware", value);
    }

    /// <summary>
    /// Block for infrastructure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Infrastructure block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Infrastructure block(s) allowed")]
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock>? Infrastructure
    {
        get => GetProperty<List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock>>("infrastructure");
        set => this.WithProperty("infrastructure", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetProperty<List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock>>("network_interface");
        set => this.WithProperty("network_interface", value);
    }

    /// <summary>
    /// Block for operating_system.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperatingSystem block(s) allowed")]
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock>? OperatingSystem
    {
        get => GetProperty<List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock>>("operating_system");
        set => this.WithProperty("operating_system", value);
    }

    /// <summary>
    /// Block for storage_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock>? StorageDisk
    {
        get => GetProperty<List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock>>("storage_disk");
        set => this.WithProperty("storage_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
