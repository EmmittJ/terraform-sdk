using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc resource.
/// </summary>
public class AwsVpc : TerraformResource
{
    public AwsVpc(string name) : base("aws_vpc", name)
    {
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("assign_generated_ipv6_cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AssignGeneratedIpv6CidrBlock { get; set; }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CidrBlock { get; set; } = default!;

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns_hostnames")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableDnsHostnames { get; set; } = default!;

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns_support")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableDnsSupport { get; set; }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    [TerraformPropertyName("enable_network_address_usage_metrics")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableNetworkAddressUsageMetrics { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    [TerraformPropertyName("instance_tenancy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceTenancy { get; set; }

    /// <summary>
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_ipam_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ipv4IpamPoolId { get; set; }

    /// <summary>
    /// The ipv4_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Ipv4NetmaskLength { get; set; }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Ipv6CidrBlock { get; set; } = default!;

    /// <summary>
    /// The ipv6_cidr_block_network_border_group attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block_network_border_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Ipv6CidrBlockNetworkBorderGroup { get; set; } = default!;

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_ipam_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ipv6IpamPoolId { get; set; }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Ipv6NetmaskLength { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The default_network_acl_id attribute.
    /// </summary>
    [TerraformPropertyName("default_network_acl_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultNetworkAclId => new TerraformReference(this, "default_network_acl_id");

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultRouteTableId => new TerraformReference(this, "default_route_table_id");

    /// <summary>
    /// The default_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("default_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultSecurityGroupId => new TerraformReference(this, "default_security_group_id");

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    [TerraformPropertyName("dhcp_options_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DhcpOptionsId => new TerraformReference(this, "dhcp_options_id");

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6AssociationId => new TerraformReference(this, "ipv6_association_id");

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("main_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MainRouteTableId => new TerraformReference(this, "main_route_table_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

}
