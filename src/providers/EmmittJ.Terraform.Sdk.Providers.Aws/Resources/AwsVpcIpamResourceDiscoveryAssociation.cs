using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_vpc_ipam_resource_discovery_association resource.
/// </summary>
public class AwsVpcIpamResourceDiscoveryAssociation : TerraformResource
{
    public AwsVpcIpamResourceDiscoveryAssociation(string name) : base("aws_vpc_ipam_resource_discovery_association", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ipam_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamId is required")]
    [TerraformPropertyName("ipam_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpamId { get; set; }

    /// <summary>
    /// The ipam_resource_discovery_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamResourceDiscoveryId is required")]
    [TerraformPropertyName("ipam_resource_discovery_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpamResourceDiscoveryId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The ipam_arn attribute.
    /// </summary>
    [TerraformPropertyName("ipam_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpamArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipam_arn");

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    [TerraformPropertyName("ipam_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpamRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipam_region");

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [TerraformPropertyName("is_default")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsDefault => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_default");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
