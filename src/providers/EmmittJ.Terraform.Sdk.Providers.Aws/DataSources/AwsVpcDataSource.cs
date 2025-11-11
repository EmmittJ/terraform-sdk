using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc.
/// </summary>
public partial class AwsVpcDataSource : TerraformDataSource
{
    public AwsVpcDataSource(string name) : base("aws_vpc", name)
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CidrBlock { get; set; }

    /// <summary>
    /// The default attribute.
    /// </summary>
    [TerraformProperty("default")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Default { get; set; }

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    [TerraformProperty("dhcp_options_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DhcpOptionsId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> State { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsVpcDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsVpcDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cidr_block_associations attribute.
    /// </summary>
    [TerraformProperty("cidr_block_associations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CidrBlockAssociations { get; }

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    [TerraformProperty("enable_dns_hostnames")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableDnsHostnames { get; }

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    [TerraformProperty("enable_dns_support")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableDnsSupport { get; }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    [TerraformProperty("enable_network_address_usage_metrics")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableNetworkAddressUsageMetrics { get; }

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    [TerraformProperty("instance_tenancy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceTenancy { get; }

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    [TerraformProperty("ipv6_association_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ipv6AssociationId { get; }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("ipv6_cidr_block")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ipv6CidrBlock { get; }

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    [TerraformProperty("main_route_table_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MainRouteTableId { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

}
