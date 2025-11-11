using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolTimeoutsBlock
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
/// Manages a aws_vpc_ipam_pool resource.
/// </summary>
public class AwsVpcIpamPool : TerraformResource
{
    public AwsVpcIpamPool(string name) : base("aws_vpc_ipam_pool", name)
    {
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    [TerraformPropertyName("address_family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AddressFamily { get; set; }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_default_netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AllocationDefaultNetmaskLength { get; set; }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_max_netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AllocationMaxNetmaskLength { get; set; }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_min_netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AllocationMinNetmaskLength { get; set; }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    [TerraformPropertyName("allocation_resource_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? AllocationResourceTags { get; set; }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    [TerraformPropertyName("auto_import")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoImport { get; set; }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    [TerraformPropertyName("aws_service")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AwsService { get; set; }

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
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ipam_scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamScopeId is required")]
    [TerraformPropertyName("ipam_scope_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IpamScopeId { get; set; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Locale { get; set; }

    /// <summary>
    /// The public_ip_source attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicIpSource { get; set; }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    [TerraformPropertyName("publicly_advertisable")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PubliclyAdvertisable { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("source_ipam_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceIpamPoolId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpamPoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    [TerraformPropertyName("ipam_scope_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpamScopeType => new TerraformReference(this, "ipam_scope_type");

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    [TerraformPropertyName("pool_depth")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PoolDepth => new TerraformReference(this, "pool_depth");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
