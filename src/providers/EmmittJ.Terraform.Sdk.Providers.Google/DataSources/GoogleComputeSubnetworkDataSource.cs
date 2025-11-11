using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_subnetwork.
/// </summary>
public partial class GoogleComputeSubnetworkDataSource : TerraformDataSource
{
    public GoogleComputeSubnetworkDataSource(string name) : base("google_compute_subnetwork", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SelfLink { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The external_ipv6_prefix attribute.
    /// </summary>
    [TerraformProperty("external_ipv6_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExternalIpv6Prefix { get; }

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    [TerraformProperty("gateway_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GatewayAddress { get; }

    /// <summary>
    /// The internal_ipv6_prefix attribute.
    /// </summary>
    [TerraformProperty("internal_ipv6_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InternalIpv6Prefix { get; }

    /// <summary>
    /// The ip_cidr_range attribute.
    /// </summary>
    [TerraformProperty("ip_cidr_range")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpCidrRange { get; }

    /// <summary>
    /// The ipv6_access_type attribute.
    /// </summary>
    [TerraformProperty("ipv6_access_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ipv6AccessType { get; }

    /// <summary>
    /// The network attribute.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Network { get; }

    /// <summary>
    /// The private_ip_google_access attribute.
    /// </summary>
    [TerraformProperty("private_ip_google_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PrivateIpGoogleAccess { get; }

    /// <summary>
    /// The secondary_ip_range attribute.
    /// </summary>
    [TerraformProperty("secondary_ip_range")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SecondaryIpRange { get; }

    /// <summary>
    /// The stack_type attribute.
    /// </summary>
    [TerraformProperty("stack_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StackType { get; }

    /// <summary>
    /// The subnetwork_id attribute.
    /// </summary>
    [TerraformProperty("subnetwork_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SubnetworkId { get; }

}
