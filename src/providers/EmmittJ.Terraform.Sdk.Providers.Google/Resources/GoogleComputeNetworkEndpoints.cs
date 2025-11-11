using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_endpoints in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeNetworkEndpointsNetworkEndpointsBlock : TerraformBlockBase
{
    /// <summary>
    /// The name for a specific VM instance that the IP address belongs to.
    /// This is required for network endpoints of type GCE_VM_IP_PORT.
    /// The instance must be in the same zone as the network endpoint group.
    /// </summary>
    [TerraformProperty("instance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Instance { get; set; }

    /// <summary>
    /// IPv4 address of network endpoint. The IP address must belong
    /// to a VM in GCE (either the primary IP or as part of an aliased IP
    /// range).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    [TerraformProperty("ip_address")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IpAddress { get; set; }

    /// <summary>
    /// Port number of network endpoint.
    /// **Note** &#39;port&#39; is required unless the Network Endpoint Group is created
    /// with the type of &#39;GCE_VM_IP&#39;
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeNetworkEndpointsTimeoutsBlock : TerraformBlockBase
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_network_endpoints resource.
/// </summary>
public partial class GoogleComputeNetworkEndpoints : TerraformResource
{
    public GoogleComputeNetworkEndpoints(string name) : base("google_compute_network_endpoints", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The network endpoint group these endpoints are part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkEndpointGroup is required")]
    [TerraformProperty("network_endpoint_group")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkEndpointGroup { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Zone where the containing network endpoint group is located.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for network_endpoints.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("network_endpoints")]
    public TerraformSet<TerraformBlock<GoogleComputeNetworkEndpointsNetworkEndpointsBlock>>? NetworkEndpoints { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeNetworkEndpointsTimeoutsBlock>? Timeouts { get; set; }

}
