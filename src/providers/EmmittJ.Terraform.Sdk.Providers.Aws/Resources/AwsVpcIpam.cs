using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for operating_regions in .
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamOperatingRegionsBlock : ITerraformBlock
{
    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    [TerraformPropertyName("region_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RegionName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_vpc_ipam resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpcIpam : TerraformResource
{
    public AwsVpcIpam(string name) : base("aws_vpc_ipam", name)
    {
    }

    /// <summary>
    /// The cascade attribute.
    /// </summary>
    [TerraformPropertyName("cascade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Cascade { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The enable_private_gua attribute.
    /// </summary>
    [TerraformPropertyName("enable_private_gua")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnablePrivateGua { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The metered_account attribute.
    /// </summary>
    [TerraformPropertyName("metered_account")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MeteredAccount { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metered_account");

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
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tier { get; set; }

    /// <summary>
    /// Block for operating_regions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatingRegions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OperatingRegions block(s) required")]
    [TerraformPropertyName("operating_regions")]
    public TerraformSet<TerraformBlock<AwsVpcIpamOperatingRegionsBlock>>? OperatingRegions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpamTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    [TerraformPropertyName("default_resource_discovery_association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultResourceDiscoveryAssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_resource_discovery_association_id");

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    [TerraformPropertyName("default_resource_discovery_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultResourceDiscoveryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_resource_discovery_id");

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("private_default_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateDefaultScopeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_default_scope_id");

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("public_default_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicDefaultScopeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_default_scope_id");

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    [TerraformPropertyName("scope_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ScopeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "scope_count");

}
