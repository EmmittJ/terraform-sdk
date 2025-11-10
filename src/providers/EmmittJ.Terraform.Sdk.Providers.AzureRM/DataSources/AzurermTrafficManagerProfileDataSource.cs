using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerProfileDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_traffic_manager_profile.
/// </summary>
public class AzurermTrafficManagerProfileDataSource : TerraformDataSource
{
    public AzurermTrafficManagerProfileDataSource(string name) : base("azurerm_traffic_manager_profile", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    [TerraformPropertyName("traffic_view_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TrafficViewEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermTrafficManagerProfileDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    [TerraformPropertyName("dns_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DnsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dns_config");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fqdn");

    /// <summary>
    /// The monitor_config attribute.
    /// </summary>
    [TerraformPropertyName("monitor_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MonitorConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "monitor_config");

    /// <summary>
    /// The profile_status attribute.
    /// </summary>
    [TerraformPropertyName("profile_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProfileStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "profile_status");

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    [TerraformPropertyName("traffic_routing_method")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrafficRoutingMethod => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "traffic_routing_method");

}
