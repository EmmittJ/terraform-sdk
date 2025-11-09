using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_scale_set resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermVirtualMachineScaleSet : TerraformResource
{
    public AzurermVirtualMachineScaleSet(string name) : base("azurerm_virtual_machine_scale_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automatic_os_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticOsUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_os_upgrade");
        set => this.WithProperty("automatic_os_upgrade", value);
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
    /// The health_probe_id attribute.
    /// </summary>
    public TerraformProperty<string>? HealthProbeId
    {
        get => GetProperty<TerraformProperty<string>>("health_probe_id");
        set => this.WithProperty("health_probe_id", value);
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
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string>? Priority
    {
        get => GetProperty<TerraformProperty<string>>("priority");
        set => this.WithProperty("priority", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The upgrade_policy_mode attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradePolicyMode
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_policy_mode");
        set => this.WithProperty("upgrade_policy_mode", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Zones
    {
        get => GetProperty<TerraformProperty<List<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

}
