using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_subnetwork.
/// </summary>
public class GoogleComputeSubnetworkDataSource : TerraformDataSource
{
    public GoogleComputeSubnetworkDataSource(string name) : base("google_compute_subnetwork", name)
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
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SelfLink { get; set; } = default!;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The external_ipv6_prefix attribute.
    /// </summary>
    [TerraformPropertyName("external_ipv6_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExternalIpv6Prefix => new TerraformReference(this, "external_ipv6_prefix");

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    [TerraformPropertyName("gateway_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayAddress => new TerraformReference(this, "gateway_address");

    /// <summary>
    /// The internal_ipv6_prefix attribute.
    /// </summary>
    [TerraformPropertyName("internal_ipv6_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InternalIpv6Prefix => new TerraformReference(this, "internal_ipv6_prefix");

    /// <summary>
    /// The ip_cidr_range attribute.
    /// </summary>
    [TerraformPropertyName("ip_cidr_range")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpCidrRange => new TerraformReference(this, "ip_cidr_range");

    /// <summary>
    /// The ipv6_access_type attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_access_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6AccessType => new TerraformReference(this, "ipv6_access_type");

    /// <summary>
    /// The network attribute.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Network => new TerraformReference(this, "network");

    /// <summary>
    /// The private_ip_google_access attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_google_access")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PrivateIpGoogleAccess => new TerraformReference(this, "private_ip_google_access");

    /// <summary>
    /// The secondary_ip_range attribute.
    /// </summary>
    [TerraformPropertyName("secondary_ip_range")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SecondaryIpRange => new TerraformReference(this, "secondary_ip_range");

    /// <summary>
    /// The stack_type attribute.
    /// </summary>
    [TerraformPropertyName("stack_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StackType => new TerraformReference(this, "stack_type");

    /// <summary>
    /// The subnetwork_id attribute.
    /// </summary>
    [TerraformPropertyName("subnetwork_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SubnetworkId => new TerraformReference(this, "subnetwork_id");

}
