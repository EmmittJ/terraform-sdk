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
        set => SetProperty("cpu_count", value);
    }

    /// <summary>
    /// The dynamic_memory_max_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? DynamicMemoryMaxInMb
    {
        set => SetProperty("dynamic_memory_max_in_mb", value);
    }

    /// <summary>
    /// The dynamic_memory_min_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? DynamicMemoryMinInMb
    {
        set => SetProperty("dynamic_memory_min_in_mb", value);
    }

    /// <summary>
    /// The limit_cpu_for_migration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LimitCpuForMigrationEnabled
    {
        set => SetProperty("limit_cpu_for_migration_enabled", value);
    }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? MemoryInMb
    {
        set => SetProperty("memory_in_mb", value);
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
        set => SetProperty("checkpoint_type", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_cloud_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerCloudId
    {
        set => SetProperty("system_center_virtual_machine_manager_cloud_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_inventory_item_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerInventoryItemId
    {
        set => SetProperty("system_center_virtual_machine_manager_inventory_item_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_template_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerTemplateId
    {
        set => SetProperty("system_center_virtual_machine_manager_template_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_virtual_machine_server_id attribute.
    /// </summary>
    public TerraformProperty<string>? SystemCenterVirtualMachineManagerVirtualMachineServerId
    {
        set => SetProperty("system_center_virtual_machine_manager_virtual_machine_server_id", value);
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
        set => SetProperty("ipv4_address_type", value);
    }

    /// <summary>
    /// The ipv6_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6AddressType
    {
        set => SetProperty("ipv6_address_type", value);
    }

    /// <summary>
    /// The mac_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? MacAddressType
    {
        set => SetProperty("mac_address_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        set => SetProperty("virtual_network_id", value);
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
        set => SetProperty("admin_password", value);
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public TerraformProperty<string>? ComputerName
    {
        set => SetProperty("computer_name", value);
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
        set => SetProperty("bus", value);
    }

    /// <summary>
    /// The bus_type attribute.
    /// </summary>
    public TerraformProperty<string>? BusType
    {
        set => SetProperty("bus_type", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    public TerraformProperty<double>? Lun
    {
        set => SetProperty("lun", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The storage_qos_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageQosPolicyName
    {
        set => SetProperty("storage_qos_policy_name", value);
    }

    /// <summary>
    /// The template_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateDiskId
    {
        set => SetProperty("template_disk_id", value);
    }

    /// <summary>
    /// The vhd_type attribute.
    /// </summary>
    public TerraformProperty<string>? VhdType
    {
        set => SetProperty("vhd_type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("custom_location_id");
        SetOutput("id");
        SetOutput("scoped_resource_id");
        SetOutput("system_center_virtual_machine_manager_availability_set_ids");
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomLocationId is required")]
    public required TerraformProperty<string> CustomLocationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_location_id");
        set => SetProperty("custom_location_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The scoped_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopedResourceId is required")]
    public required TerraformProperty<string> ScopedResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scoped_resource_id");
        set => SetProperty("scoped_resource_id", value);
    }

    /// <summary>
    /// The system_center_virtual_machine_manager_availability_set_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> SystemCenterVirtualMachineManagerAvailabilitySetIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("system_center_virtual_machine_manager_availability_set_ids");
        set => SetProperty("system_center_virtual_machine_manager_availability_set_ids", value);
    }

    /// <summary>
    /// Block for hardware.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hardware block(s) allowed")]
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceHardwareBlock>? Hardware
    {
        set => SetProperty("hardware", value);
    }

    /// <summary>
    /// Block for infrastructure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Infrastructure is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Infrastructure block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Infrastructure block(s) allowed")]
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceInfrastructureBlock>? Infrastructure
    {
        set => SetProperty("infrastructure", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceNetworkInterfaceBlock>? NetworkInterface
    {
        set => SetProperty("network_interface", value);
    }

    /// <summary>
    /// Block for operating_system.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperatingSystem block(s) allowed")]
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceOperatingSystemBlock>? OperatingSystem
    {
        set => SetProperty("operating_system", value);
    }

    /// <summary>
    /// Block for storage_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceStorageDiskBlock>? StorageDisk
    {
        set => SetProperty("storage_disk", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSystemCenterVirtualMachineManagerVirtualMachineInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
