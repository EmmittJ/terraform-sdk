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
    /// The network_profile attribute.
    /// </summary>
    [TerraformPropertyName("network_profile")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkProfile { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The gateway_ipv4 attribute.
    /// </summary>
    [TerraformPropertyName("gateway_ipv4")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayIpv4 => new TerraformReference(this, "gateway_ipv4");

    /// <summary>
    /// The internal_ipv6_range attribute.
    /// </summary>
    [TerraformPropertyName("internal_ipv6_range")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InternalIpv6Range => new TerraformReference(this, "internal_ipv6_range");

    /// <summary>
    /// The network_id attribute.
    /// </summary>
    [TerraformPropertyName("network_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NetworkId => new TerraformReference(this, "network_id");

    /// <summary>
    /// The numeric_id attribute.
    /// </summary>
    [TerraformPropertyName("numeric_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NumericId => new TerraformReference(this, "numeric_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The subnetworks_self_links attribute.
    /// </summary>
    [TerraformPropertyName("subnetworks_self_links")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SubnetworksSelfLinks => new TerraformReference(this, "subnetworks_self_links");

}
