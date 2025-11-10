using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpv6CidrBlockAssociationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AssignGeneratedIpv6CidrBlock { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "assign_generated_ipv6_cidr_block");

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
    /// The ipv6_pool attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_pool")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Ipv6Pool { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_pool");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpv6CidrBlockAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The ip_source attribute.
    /// </summary>
    [TerraformPropertyName("ip_source")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpSource => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_source");

    /// <summary>
    /// The ipv6_address_attribute attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address_attribute")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ipv6AddressAttribute => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipv6_address_attribute");

}
