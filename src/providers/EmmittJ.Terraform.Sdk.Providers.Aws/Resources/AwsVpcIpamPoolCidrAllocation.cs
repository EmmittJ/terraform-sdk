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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Cidr { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cidr");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The disallowed_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("disallowed_cidrs")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DisallowedCidrs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    [TerraformPropertyName("ipam_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpamPoolId { get; set; }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("netmask_length")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NetmaskLength { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "netmask_length");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The ipam_pool_allocation_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pool_allocation_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpamPoolAllocationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipam_pool_allocation_id");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_id");

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    [TerraformPropertyName("resource_owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceOwner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_owner");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_type");

}
