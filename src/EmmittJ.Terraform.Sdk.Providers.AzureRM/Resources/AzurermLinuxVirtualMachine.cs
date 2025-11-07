using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_linux_virtual_machine resource.
/// </summary>
public class AzurermLinuxVirtualMachine : TerraformResource
{
    public AzurermLinuxVirtualMachine(string name) : base("azurerm_linux_virtual_machine", name)
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
    public TerraformProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformProperty<string>>("admin_password");
        set => this.WithProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformProperty<string>? AdminUsername
    {
        get => GetProperty<TerraformProperty<string>>("admin_username");
        set => this.WithProperty("admin_username", value);
    }

    /// <summary>
    /// The allow_extension_operations attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowExtensionOperations
    {
        get => GetProperty<TerraformProperty<bool>>("allow_extension_operations");
        set => this.WithProperty("allow_extension_operations", value);
    }

    /// <summary>
    /// The availability_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilitySetId
    {
        get => GetProperty<TerraformProperty<string>>("availability_set_id");
        set => this.WithProperty("availability_set_id", value);
    }

    /// <summary>
    /// The bypass_platform_safety_checks_on_user_schedule_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BypassPlatformSafetyChecksOnUserScheduleEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("bypass_platform_safety_checks_on_user_schedule_enabled");
        set => this.WithProperty("bypass_platform_safety_checks_on_user_schedule_enabled", value);
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
    /// The computer_name attribute.
    /// </summary>
    public TerraformProperty<string>? ComputerName
    {
        get => GetProperty<TerraformProperty<string>>("computer_name");
        set => this.WithProperty("computer_name", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformProperty<string>? CustomData
    {
        get => GetProperty<TerraformProperty<string>>("custom_data");
        set => this.WithProperty("custom_data", value);
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? DedicatedHostGroupId
    {
        get => GetProperty<TerraformProperty<string>>("dedicated_host_group_id");
        set => this.WithProperty("dedicated_host_group_id", value);
    }

    /// <summary>
    /// The dedicated_host_id attribute.
    /// </summary>
    public TerraformProperty<string>? DedicatedHostId
    {
        get => GetProperty<TerraformProperty<string>>("dedicated_host_id");
        set => this.WithProperty("dedicated_host_id", value);
    }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    public TerraformProperty<bool>? DisablePasswordAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("disable_password_authentication");
        set => this.WithProperty("disable_password_authentication", value);
    }

    /// <summary>
    /// The disk_controller_type attribute.
    /// </summary>
    public TerraformProperty<string>? DiskControllerType
    {
        get => GetProperty<TerraformProperty<string>>("disk_controller_type");
        set => this.WithProperty("disk_controller_type", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? NetworkInterfaceIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("network_interface_ids");
        set => this.WithProperty("network_interface_ids", value);
    }

    /// <summary>
    /// The os_managed_disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? OsManagedDiskId
    {
        get => GetProperty<TerraformProperty<string>>("os_managed_disk_id");
        set => this.WithProperty("os_managed_disk_id", value);
    }

    /// <summary>
    /// The patch_assessment_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PatchAssessmentMode
    {
        get => GetProperty<TerraformProperty<string>>("patch_assessment_mode");
        set => this.WithProperty("patch_assessment_mode", value);
    }

    /// <summary>
    /// The patch_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PatchMode
    {
        get => GetProperty<TerraformProperty<string>>("patch_mode");
        set => this.WithProperty("patch_mode", value);
    }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    public TerraformProperty<double>? PlatformFaultDomain
    {
        get => GetProperty<TerraformProperty<double>>("platform_fault_domain");
        set => this.WithProperty("platform_fault_domain", value);
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
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformProperty<bool>? ProvisionVmAgent
    {
        get => GetProperty<TerraformProperty<bool>>("provision_vm_agent");
        set => this.WithProperty("provision_vm_agent", value);
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
    /// The reboot_setting attribute.
    /// </summary>
    public TerraformProperty<string>? RebootSetting
    {
        get => GetProperty<TerraformProperty<string>>("reboot_setting");
        set => this.WithProperty("reboot_setting", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SecureBootEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("secure_boot_enabled");
        set => this.WithProperty("secure_boot_enabled", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<string>? Size
    {
        get => GetProperty<TerraformProperty<string>>("size");
        set => this.WithProperty("size", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineScaleSetId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_scale_set_id");
        set => this.WithProperty("virtual_machine_scale_set_id", value);
    }

    /// <summary>
    /// The vm_agent_platform_updates_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? VmAgentPlatformUpdatesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vm_agent_platform_updates_enabled");
        set => this.WithProperty("vm_agent_platform_updates_enabled", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VtpmEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vtpm_enabled");
        set => this.WithProperty("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
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
