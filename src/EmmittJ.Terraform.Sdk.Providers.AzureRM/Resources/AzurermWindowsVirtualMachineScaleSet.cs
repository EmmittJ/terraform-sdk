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
    public TerraformLiteralProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_password");
        set => this.WithProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdminUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_username");
        set => this.WithProperty("admin_username", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CapacityReservationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_reservation_group_id");
        set => this.WithProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ComputerNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("computer_name_prefix");
        set => this.WithProperty("computer_name_prefix", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_data");
        set => this.WithProperty("custom_data", value);
    }

    /// <summary>
    /// The do_not_run_extensions_on_overprovisioned_machines attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DoNotRunExtensionsOnOverprovisionedMachines
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("do_not_run_extensions_on_overprovisioned_machines");
        set => this.WithProperty("do_not_run_extensions_on_overprovisioned_machines", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableAutomaticUpdates
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_automatic_updates");
        set => this.WithProperty("enable_automatic_updates", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EncryptionAtHostEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encryption_at_host_enabled");
        set => this.WithProperty("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eviction_policy");
        set => this.WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExtensionOperationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("extension_operations_enabled");
        set => this.WithProperty("extension_operations_enabled", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExtensionsTimeBudget
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extensions_time_budget");
        set => this.WithProperty("extensions_time_budget", value);
    }

    /// <summary>
    /// The health_probe_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HealthProbeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("health_probe_id");
        set => this.WithProperty("health_probe_id", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_group_id");
        set => this.WithProperty("host_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Instances
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instances");
        set => this.WithProperty("instances", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxBidPrice
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_bid_price");
        set => this.WithProperty("max_bid_price", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The overprovision attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Overprovision
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("overprovision");
        set => this.WithProperty("overprovision", value);
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PlatformFaultDomainCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("platform_fault_domain_count");
        set => this.WithProperty("platform_fault_domain_count", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Priority
    {
        get => GetProperty<TerraformLiteralProperty<string>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ProvisionVmAgent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("provision_vm_agent");
        set => this.WithProperty("provision_vm_agent", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proximity_placement_group_id");
        set => this.WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The resilient_vm_creation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ResilientVmCreationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("resilient_vm_creation_enabled");
        set => this.WithProperty("resilient_vm_creation_enabled", value);
    }

    /// <summary>
    /// The resilient_vm_deletion_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ResilientVmDeletionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("resilient_vm_deletion_enabled");
        set => this.WithProperty("resilient_vm_deletion_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SecureBootEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("secure_boot_enabled");
        set => this.WithProperty("secure_boot_enabled", value);
    }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SinglePlacementGroup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("single_placement_group");
        set => this.WithProperty("single_placement_group", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceImageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_image_id");
        set => this.WithProperty("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Timezone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
    }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UpgradeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upgrade_mode");
        set => this.WithProperty("upgrade_mode", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? VtpmEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("vtpm_enabled");
        set => this.WithProperty("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ZoneBalance
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_balance");
        set => this.WithProperty("zone_balance", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
