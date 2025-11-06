using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_orchestrated_virtual_machine_scale_set resource.
/// </summary>
public class AzurermOrchestratedVirtualMachineScaleSet : TerraformResource
{
    public AzurermOrchestratedVirtualMachineScaleSet(string name) : base("azurerm_orchestrated_virtual_machine_scale_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("unique_id");
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
    /// The network_api_version attribute.
    /// </summary>
    public string? NetworkApiVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_api_version")?.Value;
        set => this.WithProperty("network_api_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public string? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proximity_placement_group_id")?.Value;
        set => this.WithProperty("proximity_placement_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The single_placement_group attribute.
    /// </summary>
    public bool? SinglePlacementGroup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("single_placement_group")?.Value;
        set => this.WithProperty("single_placement_group", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The upgrade_mode attribute.
    /// </summary>
    public string? UpgradeMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("upgrade_mode")?.Value;
        set => this.WithProperty("upgrade_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public string? UserDataBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data_base64")?.Value;
        set => this.WithProperty("user_data_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
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
