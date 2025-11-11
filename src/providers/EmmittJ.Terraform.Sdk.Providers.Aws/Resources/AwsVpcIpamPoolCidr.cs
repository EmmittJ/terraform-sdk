using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cidr_authorization_context in .
/// Nesting mode: list
/// </summary>
public partial class AwsVpcIpamPoolCidrCidrAuthorizationContextBlock : TerraformBlockBase
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformProperty("message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Message { get; set; }

    /// <summary>
    /// The signature attribute.
    /// </summary>
    [TerraformProperty("signature")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Signature { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcIpamPoolCidrTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_vpc_ipam_pool_cidr resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVpcIpamPoolCidr : TerraformResource
{
    public AwsVpcIpamPoolCidr(string name) : base("aws_vpc_ipam_pool_cidr", name)
    {
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [TerraformProperty("cidr")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Cidr { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    [TerraformProperty("ipam_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpamPoolId { get; set; }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    [TerraformProperty("netmask_length")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NetmaskLength { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for cidr_authorization_context.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrAuthorizationContext block(s) allowed")]
    [TerraformProperty("cidr_authorization_context")]
    public partial TerraformList<TerraformBlock<AwsVpcIpamPoolCidrCidrAuthorizationContextBlock>>? CidrAuthorizationContext { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsVpcIpamPoolCidrTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The ipam_pool_cidr_id attribute.
    /// </summary>
    [TerraformProperty("ipam_pool_cidr_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpamPoolCidrId { get; }

}
