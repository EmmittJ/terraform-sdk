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
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public string? CapacityReservationGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_reservation_group_id")?.Value;
        set => this.WithProperty("capacity_reservation_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    public string? ComputerNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("computer_name_prefix")?.Value;
        set => this.WithProperty("computer_name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The do_not_run_extensions_on_overprovisioned_machines attribute.
    /// </summary>
    public bool? DoNotRunExtensionsOnOverprovisionedMachines
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("do_not_run_extensions_on_overprovisioned_machines")?.Value;
        set => this.WithProperty("do_not_run_extensions_on_overprovisioned_machines", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The extension_operations_enabled attribute.
    /// </summary>
    public bool? ExtensionOperationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("extension_operations_enabled")?.Value;
        set => this.WithProperty("extension_operations_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The health_probe_id attribute.
    /// </summary>
    public string? HealthProbeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("health_probe_id")?.Value;
        set => this.WithProperty("health_probe_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public string? HostGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_group_id")?.Value;
        set => this.WithProperty("host_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instances attribute.
    /// </summary>
    public double? Instances
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instances")?.Value;
        set => this.WithProperty("instances", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The overprovision attribute.
    /// </summary>
    public bool? Overprovision
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("overprovision")?.Value;
        set => this.WithProperty("overprovision", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public double? PlatformFaultDomainCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("platform_fault_domain_count")?.Value;
        set => this.WithProperty("platform_fault_domain_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The resilient_vm_creation_enabled attribute.
    /// </summary>
    public bool? ResilientVmCreationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("resilient_vm_creation_enabled")?.Value;
        set => this.WithProperty("resilient_vm_creation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resilient_vm_deletion_enabled attribute.
    /// </summary>
    public bool? ResilientVmDeletionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("resilient_vm_deletion_enabled")?.Value;
        set => this.WithProperty("resilient_vm_deletion_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The single_placement_group attribute.
    /// </summary>
    public bool? SinglePlacementGroup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("single_placement_group")?.Value;
        set => this.WithProperty("single_placement_group", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The upgrade_mode attribute.
    /// </summary>
    public string? UpgradeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upgrade_mode")?.Value;
        set => this.WithProperty("upgrade_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The vtpm_enabled attribute.
    /// </summary>
    public bool? VtpmEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("vtpm_enabled")?.Value;
        set => this.WithProperty("vtpm_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    public bool? ZoneBalance
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_balance")?.Value;
        set => this.WithProperty("zone_balance", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<string>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones")?.Value;
        set => this.WithProperty("zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}
