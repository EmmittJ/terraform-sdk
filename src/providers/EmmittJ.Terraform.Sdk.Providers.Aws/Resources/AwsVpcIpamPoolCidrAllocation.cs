using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_pool_cidr_allocation resource.
/// </summary>
public class AwsVpcIpamPoolCidrAllocation : TerraformResource
{
    public AwsVpcIpamPoolCidrAllocation(string name) : base("aws_vpc_ipam_pool_cidr_allocation", name)
    {
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [TerraformPropertyName("cidr")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Cidr { get; set; } = default!;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The disallowed_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("disallowed_cidrs")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DisallowedCidrs { get; set; }

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
    /// The ipam_pool_allocation_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pool_allocation_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpamPoolAllocationId => new TerraformReference(this, "ipam_pool_allocation_id");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceId => new TerraformReference(this, "resource_id");

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    [TerraformPropertyName("resource_owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceOwner => new TerraformReference(this, "resource_owner");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceType => new TerraformReference(this, "resource_type");

}
