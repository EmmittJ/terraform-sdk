using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_pool_cidr_allocation resource.
/// </summary>
public partial class AwsVpcIpamPoolCidrAllocation : TerraformResource
{
    public AwsVpcIpamPoolCidrAllocation(string name) : base("aws_vpc_ipam_pool_cidr_allocation", name)
    {
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [TerraformProperty("cidr")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Cidr { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The disallowed_cidrs attribute.
    /// </summary>
    [TerraformProperty("disallowed_cidrs")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DisallowedCidrs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    [TerraformProperty("ipam_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IpamPoolId { get; set; }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    [TerraformProperty("netmask_length")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> NetmaskLength { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The ipam_pool_allocation_id attribute.
    /// </summary>
    [TerraformProperty("ipam_pool_allocation_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpamPoolAllocationId { get; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    [TerraformProperty("resource_owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceOwner { get; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceType { get; }

}
