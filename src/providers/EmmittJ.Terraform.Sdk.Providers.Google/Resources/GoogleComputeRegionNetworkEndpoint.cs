using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRegionNetworkEndpointTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_compute_region_network_endpoint resource.
/// </summary>
public partial class GoogleComputeRegionNetworkEndpoint : TerraformResource
{
    public GoogleComputeRegionNetworkEndpoint(string name) : base("google_compute_region_network_endpoint", name)
    {
    }

    /// <summary>
    /// Fully qualified domain name of network endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_FQDN_PORT.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Fqdn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// IPv4 address external endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_IP_PORT.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// Port number of network endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region where the containing network endpoint group is located.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The network endpoint group this endpoint is part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionNetworkEndpointGroup is required")]
    [TerraformProperty("region_network_endpoint_group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RegionNetworkEndpointGroup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeRegionNetworkEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("network_endpoint_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NetworkEndpointId { get; }

}
