using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cidr_authorization_context in .
/// Nesting mode: list
/// </summary>
public class AwsVpcIpamPoolCidrCidrAuthorizationContextBlock
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformPropertyName("message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Message { get; set; }

    /// <summary>
    /// The signature attribute.
    /// </summary>
    [TerraformPropertyName("signature")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Signature { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolCidrTimeoutsBlock
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
/// Manages a aws_vpc_ipam_pool_cidr resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpcIpamPoolCidr : TerraformResource
{
    public AwsVpcIpamPoolCidr(string name) : base("aws_vpc_ipam_pool_cidr", name)
    {
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [TerraformPropertyName("cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Cidr { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    [TerraformPropertyName("ipam_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IpamPoolId { get; set; }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("netmask_length")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NetmaskLength { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for cidr_authorization_context.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrAuthorizationContext block(s) allowed")]
    [TerraformPropertyName("cidr_authorization_context")]
    public TerraformList<TerraformBlock<AwsVpcIpamPoolCidrCidrAuthorizationContextBlock>>? CidrAuthorizationContext { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpamPoolCidrTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The ipam_pool_cidr_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pool_cidr_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpamPoolCidrId => new TerraformReference(this, "ipam_pool_cidr_id");

}
