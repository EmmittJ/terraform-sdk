using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_windows_virtual_machine resource.
/// </summary>
public class AzurermWindowsVirtualMachine : TerraformResource
{
    public AzurermWindowsVirtualMachine(string name) : base("azurerm_windows_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("private_ip_address");
        this.DeclareOutput("private_ip_addresses");
        this.DeclareOutput("public_ip_address");
        this.DeclareOutput("public_ip_addresses");
        this.DeclareOutput("virtual_machine_id");
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public string? AdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_password")?.Value;
        set => this.WithProperty("admin_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public string? AdminUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_username")?.Value;
        set => this.WithProperty("admin_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    public bool? AllowExtensionOperations
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_extension_operations")?.Value;
        set => this.WithProperty("allow_extension_operations", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The automatic_updates_enabled attribute.
    /// </summary>
    public bool? AutomaticUpdatesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_updates_enabled")?.Value;
        set => this.WithProperty("automatic_updates_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    public string? AvailabilitySetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_set_id")?.Value;
        set => this.WithProperty("availability_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    public bool? BypassPlatformSafetyChecksOnUserScheduleEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bypass_platform_safety_checks_on_user_schedule_enabled")?.Value;
        set => this.WithProperty("bypass_platform_safety_checks_on_user_schedule_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public string? CapacityReservationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_reservation_group_id")?.Value;
        set => this.WithProperty("capacity_reservation_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The computer_name attribute.
    /// </summary>
    public string? ComputerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("computer_name")?.Value;
        set => this.WithProperty("computer_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public string? CustomData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_data")?.Value;
        set => this.WithProperty("custom_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    public string? DedicatedHostGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dedicated_host_group_id")?.Value;
        set => this.WithProperty("dedicated_host_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    public string? DedicatedHostId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dedicated_host_id")?.Value;
        set => this.WithProperty("dedicated_host_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    public string? DiskControllerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_controller_type")?.Value;
        set => this.WithProperty("disk_controller_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public string? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone")?.Value;
        set => this.WithProperty("edge_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? EnableAutomaticUpdates
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_automatic_updates")?.Value;
        set => this.WithProperty("enable_automatic_updates", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public bool? EncryptionAtHostEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encryption_at_host_enabled")?.Value;
        set => this.WithProperty("encryption_at_host_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public string? EvictionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eviction_policy")?.Value;
        set => this.WithProperty("eviction_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public string? ExtensionsTimeBudget
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extensions_time_budget")?.Value;
        set => this.WithProperty("extensions_time_budget", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hotpatching_enabled attribute.
    /// </summary>
    public bool? HotpatchingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hotpatching_enabled")?.Value;
        set => this.WithProperty("hotpatching_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public string? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type")?.Value;
        set => this.WithProperty("license_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public double? MaxBidPrice
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_bid_price")?.Value;
        set => this.WithProperty("max_bid_price", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public List<string>? NetworkInterfaceIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("network_interface_ids")?.Value;
        set => this.WithProperty("network_interface_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    public string? OsManagedDiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_managed_disk_id")?.Value;
        set => this.WithProperty("os_managed_disk_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    public string? PatchAssessmentMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("patch_assessment_mode")?.Value;
        set => this.WithProperty("patch_assessment_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    public string? PatchMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("patch_mode")?.Value;
        set => this.WithProperty("patch_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    public double? PlatformFaultDomain
    {
        get => GetProperty<TerraformLiteralProperty<double>>("platform_fault_domain")?.Value;
        set => this.WithProperty("platform_fault_domain", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public string? Priority
    {
        get => GetProperty<TerraformLiteralProperty<string>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public bool? ProvisionVmAgent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("provision_vm_agent")?.Value;
        set => this.WithProperty("provision_vm_agent", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public string? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proximity_placement_group_id")?.Value;
        set => this.WithProperty("proximity_placement_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reboot_setting attribute.
    /// </summary>
    public string? RebootSetting
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reboot_setting")?.Value;
        set => this.WithProperty("reboot_setting", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public bool? SecureBootEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("secure_boot_enabled")?.Value;
        set => this.WithProperty("secure_boot_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public string? Size
    {
        get => GetProperty<TerraformLiteralProperty<string>>("size")?.Value;
        set => this.WithProperty("size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public string? SourceImageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_image_id")?.Value;
        set => this.WithProperty("source_image_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public string? Timezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone")?.Value;
        set => this.WithProperty("timezone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public string? UserData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data")?.Value;
        set => this.WithProperty("user_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public string? VirtualMachineScaleSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_scale_set_id")?.Value;
        set => this.WithProperty("virtual_machine_scale_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? VmAgentPlatformUpdatesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("vm_agent_platform_updates_enabled")?.Value;
        set => this.WithProperty("vm_agent_platform_updates_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public bool? VtpmEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("vtpm_enabled")?.Value;
        set => this.WithProperty("vtpm_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddress => this["private_ip_address"];

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddresses => this["private_ip_addresses"];

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    public TerraformExpression PublicIpAddress => this["public_ip_address"];

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PublicIpAddresses => this["public_ip_addresses"];

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformExpression VirtualMachineId => this["virtual_machine_id"];

}
