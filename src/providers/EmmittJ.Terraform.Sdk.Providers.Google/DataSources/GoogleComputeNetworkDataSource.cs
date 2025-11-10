using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_network.
/// </summary>
public class GoogleComputeNetworkDataSource : TerraformDataSource
{
    public GoogleComputeNetworkDataSource(string name) : base("google_compute_network", name)
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
    /// The network_profile attribute.
    /// </summary>
    [TerraformPropertyName("network_profile")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkProfile { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The gateway_ipv4 attribute.
    /// </summary>
    [TerraformPropertyName("gateway_ipv4")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayIpv4 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_ipv4");

    /// <summary>
    /// The internal_ipv6_range attribute.
    /// </summary>
    [TerraformPropertyName("internal_ipv6_range")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InternalIpv6Range => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "internal_ipv6_range");

    /// <summary>
    /// The network_id attribute.
    /// </summary>
    [TerraformPropertyName("network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NetworkId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "network_id");

    /// <summary>
    /// The numeric_id attribute.
    /// </summary>
    [TerraformPropertyName("numeric_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NumericId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "numeric_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The subnetworks_self_links attribute.
    /// </summary>
    [TerraformPropertyName("subnetworks_self_links")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SubnetworksSelfLinks => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "subnetworks_self_links");

}
