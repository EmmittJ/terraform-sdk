using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcIpv6CidrBlockAssociationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_vpc_ipv6_cidr_block_association resource.
/// </summary>
public partial class AwsVpcIpv6CidrBlockAssociation : TerraformResource
{
    public AwsVpcIpv6CidrBlockAssociation(string name) : base("aws_vpc_ipv6_cidr_block_association", name)
    {
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    [TerraformProperty("assign_generated_ipv6_cidr_block")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AssignGeneratedIpv6CidrBlock { get; set; }

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
    /// The ipv6_pool attribute.
    /// </summary>
    [TerraformProperty("ipv6_pool")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Ipv6Pool { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsVpcIpv6CidrBlockAssociationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The ip_source attribute.
    /// </summary>
    [TerraformProperty("ip_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpSource { get; }

    /// <summary>
    /// The ipv6_address_attribute attribute.
    /// </summary>
    [TerraformProperty("ipv6_address_attribute")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ipv6AddressAttribute { get; }

}
