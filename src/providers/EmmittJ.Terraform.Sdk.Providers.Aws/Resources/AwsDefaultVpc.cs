using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_default_vpc resource.
/// </summary>
public partial class AwsDefaultVpc : TerraformResource
{
    public AwsDefaultVpc(string name) : base("aws_default_vpc", name)
    {
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("assign_generated_ipv6_cidr_block")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AssignGeneratedIpv6CidrBlock { get; set; }

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    [TerraformProperty("enable_dns_hostnames")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableDnsHostnames { get; set; }

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    [TerraformProperty("enable_dns_support")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableDnsSupport { get; set; }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    [TerraformProperty("enable_network_address_usage_metrics")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableNetworkAddressUsageMetrics { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Ipv6CidrBlock { get; set; }

    /// <summary>
    /// The ipv6_cidr_block_network_border_group attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block_network_border_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Ipv6CidrBlockNetworkBorderGroup { get; set; }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    [TerraformProperty("ipv6_ipam_pool_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ipv6IpamPoolId { get; set; }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    [TerraformProperty("ipv6_netmask_length")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Ipv6NetmaskLength { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CidrBlock { get; }

    /// <summary>
    /// The default_network_acl_id attribute.
    /// </summary>
    [TerraformProperty("default_network_acl_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultNetworkAclId { get; }

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    [TerraformProperty("default_route_table_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultRouteTableId { get; }

    /// <summary>
    /// The default_security_group_id attribute.
    /// </summary>
    [TerraformProperty("default_security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSecurityGroupId { get; }

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    [TerraformProperty("dhcp_options_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DhcpOptionsId { get; }

    /// <summary>
    /// The existing_default_vpc attribute.
    /// </summary>
    [TerraformProperty("existing_default_vpc")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ExistingDefaultVpc { get; }

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    [TerraformProperty("instance_tenancy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceTenancy { get; }

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    [TerraformProperty("ipv6_association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ipv6AssociationId { get; }

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    [TerraformProperty("main_route_table_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MainRouteTableId { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

}
