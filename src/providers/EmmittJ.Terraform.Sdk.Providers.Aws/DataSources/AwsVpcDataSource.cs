using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc.
/// </summary>
public class AwsVpcDataSource : TerraformDataSource
{
    public AwsVpcDataSource(string name) : base("aws_vpc", name)
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CidrBlock { get; set; } = default!;

    /// <summary>
    /// The default attribute.
    /// </summary>
    [TerraformPropertyName("default")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Default { get; set; } = default!;

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    [TerraformPropertyName("dhcp_options_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DhcpOptionsId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> State { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cidr_block_associations attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block_associations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CidrBlockAssociations => new TerraformReference(this, "cidr_block_associations");

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns_hostnames")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableDnsHostnames => new TerraformReference(this, "enable_dns_hostnames");

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    [TerraformPropertyName("enable_dns_support")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableDnsSupport => new TerraformReference(this, "enable_dns_support");

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    [TerraformPropertyName("enable_network_address_usage_metrics")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableNetworkAddressUsageMetrics => new TerraformReference(this, "enable_network_address_usage_metrics");

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    [TerraformPropertyName("instance_tenancy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceTenancy => new TerraformReference(this, "instance_tenancy");

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6AssociationId => new TerraformReference(this, "ipv6_association_id");

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6CidrBlock => new TerraformReference(this, "ipv6_cidr_block");

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
