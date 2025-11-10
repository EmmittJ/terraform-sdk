using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_default_vpc resource.
/// </summary>
public class AwsDefaultVpc : TerraformResource
{
    public AwsDefaultVpc(string name) : base("aws_default_vpc", name)
    {
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("assign_generated_ipv6_cidr_block")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AssignGeneratedIpv6CidrBlock { get; set; }

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns_hostnames")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableDnsHostnames { get; set; }

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableDnsSupport { get; set; }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    [TerraformPropertyName("enable_network_address_usage_metrics")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableNetworkAddressUsageMetrics { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_network_address_usage_metrics");

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Ipv6CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_cidr_block");

    /// <summary>
    /// The ipv6_cidr_block_network_border_group attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block_network_border_group")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Ipv6CidrBlockNetworkBorderGroup { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_cidr_block_network_border_group");

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_ipam_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ipv6IpamPoolId { get; set; }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Ipv6NetmaskLength { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CidrBlock => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cidr_block");

    /// <summary>
    /// The default_network_acl_id attribute.
    /// </summary>
    [TerraformPropertyName("default_network_acl_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultNetworkAclId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_network_acl_id");

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultRouteTableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_route_table_id");

    /// <summary>
    /// The default_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("default_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_security_group_id");

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    [TerraformPropertyName("dhcp_options_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DhcpOptionsId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dhcp_options_id");

    /// <summary>
    /// The existing_default_vpc attribute.
    /// </summary>
    [TerraformPropertyName("existing_default_vpc")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExistingDefaultVpc => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "existing_default_vpc");

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    [TerraformPropertyName("instance_tenancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceTenancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_tenancy");

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6AssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_association_id");

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("main_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MainRouteTableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "main_route_table_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

}
