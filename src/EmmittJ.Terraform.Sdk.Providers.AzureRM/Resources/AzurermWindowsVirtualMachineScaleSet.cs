using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_windows_virtual_machine_scale_set resource.
/// </summary>
public class AzurermWindowsVirtualMachineScaleSet : TerraformResource
{
    public AzurermWindowsVirtualMachineScaleSet(string name) : base("azurerm_windows_virtual_machine_scale_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("unique_id");
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
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("capacity_reservation_group_id");
        set => this.WithProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ComputerNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("computer_name_prefix");
        set => this.WithProperty("computer_name_prefix", value);
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
    /// The do_not_run_extensions_on_overprovisioned_machines attribute.
    /// </summary>
    public TerraformProperty<bool>? DoNotRunExtensionsOnOverprovisionedMachines
    {
        get => GetProperty<TerraformProperty<bool>>("do_not_run_extensions_on_overprovisioned_machines");
        set => this.WithProperty("do_not_run_extensions_on_overprovisioned_machines", value);
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
    /// The enable_automatic_updates attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAutomaticUpdates
    {
        get => GetProperty<TerraformProperty<bool>>("enable_automatic_updates");
        set => this.WithProperty("enable_automatic_updates", value);
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
    /// The health_probe_id attribute.
    /// </summary>
    public TerraformProperty<string>? HealthProbeId
    {
        get => GetProperty<TerraformProperty<string>>("health_probe_id");
        set => this.WithProperty("health_probe_id", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostGroupId
    {
        get => GetProperty<TerraformProperty<string>>("host_group_id");
        set => this.WithProperty("host_group_id", value);
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
    /// The overprovision attribute.
    /// </summary>
    public TerraformProperty<bool>? Overprovision
    {
        get => GetProperty<TerraformProperty<bool>>("overprovision");
        set => this.WithProperty("overprovision", value);
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public TerraformProperty<double>? PlatformFaultDomainCount
    {
        get => GetProperty<TerraformProperty<double>>("platform_fault_domain_count");
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
    /// The resilient_vm_creation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ResilientVmCreationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("resilient_vm_creation_enabled");
        set => this.WithProperty("resilient_vm_creation_enabled", value);
    }

    /// <summary>
    /// The resilient_vm_deletion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ResilientVmDeletionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("resilient_vm_deletion_enabled");
        set => this.WithProperty("resilient_vm_deletion_enabled", value);
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
    /// The single_placement_group attribute.
    /// </summary>
    public TerraformProperty<bool>? SinglePlacementGroup
    {
        get => GetProperty<TerraformProperty<bool>>("single_placement_group");
        set => this.WithProperty("single_placement_group", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        get => GetProperty<TerraformProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
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
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
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
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
