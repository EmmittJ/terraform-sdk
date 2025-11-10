using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionNetworkEndpointTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_compute_region_network_endpoint resource.
/// </summary>
public class GoogleComputeRegionNetworkEndpoint : TerraformResource
{
    public GoogleComputeRegionNetworkEndpoint(string name) : base("google_compute_region_network_endpoint", name)
    {
    }

    /// <summary>
    /// Fully qualified domain name of network endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_FQDN_PORT.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Fqdn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// IPv4 address external endpoint.
    /// 
    /// This can only be specified when network_endpoint_type of the NEG is INTERNET_IP_PORT.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpAddress { get; set; }

    /// <summary>
    /// Port number of network endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Port { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Region where the containing network endpoint group is located.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The network endpoint group this endpoint is part of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionNetworkEndpointGroup is required")]
    [TerraformPropertyName("region_network_endpoint_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RegionNetworkEndpointGroup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRegionNetworkEndpointTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("network_endpoint_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NetworkEndpointId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "network_endpoint_id");

}
