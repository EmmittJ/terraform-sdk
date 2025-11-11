using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermTrafficManagerProfileDnsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The relative_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeName is required")]
    [TerraformProperty("relative_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RelativeName { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    [TerraformProperty("ttl")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Ttl { get; set; }

}

/// <summary>
/// Block type for monitor_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermTrafficManagerProfileMonitorConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The expected_status_code_ranges attribute.
    /// </summary>
    [TerraformProperty("expected_status_code_ranges")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ExpectedStatusCodeRanges { get; set; }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? IntervalInSeconds { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TimeoutInSeconds { get; set; }

    /// <summary>
    /// The tolerated_number_of_failures attribute.
    /// </summary>
    [TerraformProperty("tolerated_number_of_failures")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ToleratedNumberOfFailures { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermTrafficManagerProfileTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_traffic_manager_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermTrafficManagerProfile : TerraformResource
{
    public AzurermTrafficManagerProfile(string name) : base("azurerm_traffic_manager_profile", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_return attribute.
    /// </summary>
    [TerraformProperty("max_return")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxReturn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The profile_status attribute.
    /// </summary>
    [TerraformProperty("profile_status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProfileStatus { get; set; }

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
    /// The traffic_routing_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficRoutingMethod is required")]
    [TerraformProperty("traffic_routing_method")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TrafficRoutingMethod { get; set; }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    [TerraformProperty("traffic_view_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TrafficViewEnabled { get; set; }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DnsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    [TerraformProperty("dns_config")]
    public TerraformList<TerraformBlock<AzurermTrafficManagerProfileDnsConfigBlock>>? DnsConfig { get; set; }

    /// <summary>
    /// Block for monitor_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitorConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorConfig block(s) allowed")]
    [TerraformProperty("monitor_config")]
    public TerraformList<TerraformBlock<AzurermTrafficManagerProfileMonitorConfigBlock>>? MonitorConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermTrafficManagerProfileTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fqdn { get; }

}
