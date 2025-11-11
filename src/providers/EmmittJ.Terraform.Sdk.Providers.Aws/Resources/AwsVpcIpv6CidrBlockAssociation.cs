using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpv6CidrBlockAssociationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_vpc_ipv6_cidr_block_association resource.
/// </summary>
public class AwsVpcIpv6CidrBlockAssociation : TerraformResource
{
    public AwsVpcIpv6CidrBlockAssociation(string name) : base("aws_vpc_ipv6_cidr_block_association", name)
    {
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("assign_generated_ipv6_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AssignGeneratedIpv6CidrBlock { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Ipv6CidrBlock { get; set; } = default!;

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
    /// The ipv6_pool attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_pool")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Ipv6Pool { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpv6CidrBlockAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The ip_source attribute.
    /// </summary>
    [TerraformPropertyName("ip_source")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpSource => new TerraformReference(this, "ip_source");

    /// <summary>
    /// The ipv6_address_attribute attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_attribute")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6AddressAttribute => new TerraformReference(this, "ipv6_address_attribute");

}
