using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeGlobalNetworkEndpointTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_compute_global_network_endpoint resource.
/// </summary>
public partial class GoogleComputeGlobalNetworkEndpoint : TerraformResource
{
    public GoogleComputeGlobalNetworkEndpoint(string name) : base("google_compute_global_network_endpoint", name)
    {
    }

    /// <summary>
    /// Fully qualified domain name of network endpoint.
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_FQDN_PORT.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Fqdn { get; set; }

    /// <summary>
    /// The global network endpoint group this endpoint is part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkEndpointGroup is required")]
    [TerraformProperty("global_network_endpoint_group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GlobalNetworkEndpointGroup { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// IPv4 address external endpoint.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// Port number of the external endpoint.
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeGlobalNetworkEndpointTimeoutsBlock>? Timeouts { get; set; }

}
