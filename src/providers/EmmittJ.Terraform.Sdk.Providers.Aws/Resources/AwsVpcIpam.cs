using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for operating_regions in .
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamOperatingRegionsBlock
{
    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    [TerraformPropertyName("region_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RegionName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamTimeoutsBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    public TerraformValue<bool>? Cascade { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enable_private_gua attribute.
    /// </summary>
    [TerraformPropertyName("enable_private_gua")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnablePrivateGua { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The metered_account attribute.
    /// </summary>
    [TerraformPropertyName("metered_account")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MeteredAccount { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Tier { get; set; }

    /// <summary>
    /// Block for operating_regions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatingRegions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OperatingRegions block(s) required")]
    [TerraformPropertyName("operating_regions")]
    public TerraformSet<TerraformBlock<AwsVpcIpamOperatingRegionsBlock>>? OperatingRegions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpamTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    [TerraformPropertyName("default_resource_discovery_association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultResourceDiscoveryAssociationId => new TerraformReference(this, "default_resource_discovery_association_id");

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    [TerraformPropertyName("default_resource_discovery_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultResourceDiscoveryId => new TerraformReference(this, "default_resource_discovery_id");

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("private_default_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateDefaultScopeId => new TerraformReference(this, "private_default_scope_id");

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("public_default_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicDefaultScopeId => new TerraformReference(this, "public_default_scope_id");

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    [TerraformPropertyName("scope_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ScopeCount => new TerraformReference(this, "scope_count");

}
