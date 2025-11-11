using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerProfileDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    [TerraformPropertyName("traffic_view_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TrafficViewEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermTrafficManagerProfileDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    [TerraformPropertyName("dns_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DnsConfig => new TerraformReference(this, "dns_config");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

    /// <summary>
    /// The monitor_config attribute.
    /// </summary>
    [TerraformPropertyName("monitor_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MonitorConfig => new TerraformReference(this, "monitor_config");

    /// <summary>
    /// The profile_status attribute.
    /// </summary>
    [TerraformPropertyName("profile_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProfileStatus => new TerraformReference(this, "profile_status");

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    [TerraformPropertyName("traffic_routing_method")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TrafficRoutingMethod => new TerraformReference(this, "traffic_routing_method");

}
