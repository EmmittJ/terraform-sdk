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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SelfLink { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The external_ipv6_prefix attribute.
    /// </summary>
    [TerraformPropertyName("external_ipv6_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExternalIpv6Prefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "external_ipv6_prefix");

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    [TerraformPropertyName("gateway_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_address");

    /// <summary>
    /// The internal_ipv6_prefix attribute.
    /// </summary>
    [TerraformPropertyName("internal_ipv6_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InternalIpv6Prefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "internal_ipv6_prefix");

    /// <summary>
    /// The ip_cidr_range attribute.
    /// </summary>
    [TerraformPropertyName("ip_cidr_range")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpCidrRange => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_cidr_range");

    /// <summary>
    /// The ipv6_access_type attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_access_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6AccessType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_access_type");

    /// <summary>
    /// The network attribute.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Network => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// The private_ip_google_access attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_google_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PrivateIpGoogleAccess => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "private_ip_google_access");

    /// <summary>
    /// The secondary_ip_range attribute.
    /// </summary>
    [TerraformPropertyName("secondary_ip_range")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecondaryIpRange => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secondary_ip_range");

    /// <summary>
    /// The stack_type attribute.
    /// </summary>
    [TerraformPropertyName("stack_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StackType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stack_type");

    /// <summary>
    /// The subnetwork_id attribute.
    /// </summary>
    [TerraformPropertyName("subnetwork_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SubnetworkId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "subnetwork_id");

}
