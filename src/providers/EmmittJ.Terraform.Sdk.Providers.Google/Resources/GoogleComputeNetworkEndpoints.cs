using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_endpoints in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeNetworkEndpointsNetworkEndpointsBlock : ITerraformBlock
{
    /// <summary>
    /// The name for a specific VM instance that the IP address belongs to.
    /// This is required for network endpoints of type GCE_VM_IP_PORT.
    /// The instance must be in the same zone as the network endpoint group.
    /// </summary>
    [TerraformPropertyName("instance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Instance { get; set; }

    /// <summary>
    /// IPv4 address of network endpoint. The IP address must belong
    /// to a VM in GCE (either the primary IP or as part of an aliased IP
    /// range).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    [TerraformPropertyName("ip_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpAddress { get; set; }

    /// <summary>
    /// Port number of network endpoint.
    /// **Note** &#39;port&#39; is required unless the Network Endpoint Group is created
    /// with the type of &#39;GCE_VM_IP&#39;
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkEndpointsTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_network_endpoints resource.
/// </summary>
public class GoogleComputeNetworkEndpoints : TerraformResource
{
    public GoogleComputeNetworkEndpoints(string name) : base("google_compute_network_endpoints", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The network endpoint group these endpoints are part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkEndpointGroup is required")]
    [TerraformPropertyName("network_endpoint_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkEndpointGroup { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Zone where the containing network endpoint group is located.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

    /// <summary>
    /// Block for network_endpoints.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("network_endpoints")]
    public TerraformSet<TerraformBlock<GoogleComputeNetworkEndpointsNetworkEndpointsBlock>>? NetworkEndpoints { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeNetworkEndpointsTimeoutsBlock>? Timeouts { get; set; } = new();

}
