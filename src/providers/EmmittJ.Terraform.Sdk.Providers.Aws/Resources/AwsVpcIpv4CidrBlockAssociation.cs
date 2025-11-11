using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpv4CidrBlockAssociationTimeoutsBlock
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
/// Manages a aws_vpc_ipv4_cidr_block_association resource.
/// </summary>
public class AwsVpcIpv4CidrBlockAssociation : TerraformResource
{
    public AwsVpcIpv4CidrBlockAssociation(string name) : base("aws_vpc_ipv4_cidr_block_association", name)
    {
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformPropertyName("cidr_block")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CidrBlock { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    public TerraformBlock<AwsVpcIpv4CidrBlockAssociationTimeoutsBlock>? Timeouts { get; set; }

}
