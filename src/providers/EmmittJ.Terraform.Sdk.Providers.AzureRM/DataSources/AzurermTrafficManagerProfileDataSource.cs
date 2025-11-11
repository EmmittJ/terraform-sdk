using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermTrafficManagerProfileDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_traffic_manager_profile.
/// </summary>
public partial class AzurermTrafficManagerProfileDataSource : TerraformDataSource
{
    public AzurermTrafficManagerProfileDataSource(string name) : base("azurerm_traffic_manager_profile", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    [TerraformProperty("traffic_view_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TrafficViewEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermTrafficManagerProfileDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    [TerraformProperty("dns_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DnsConfig { get; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The monitor_config attribute.
    /// </summary>
    [TerraformProperty("monitor_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MonitorConfig { get; }

    /// <summary>
    /// The profile_status attribute.
    /// </summary>
    [TerraformProperty("profile_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProfileStatus { get; }

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    [TerraformProperty("traffic_routing_method")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TrafficRoutingMethod { get; }

}
