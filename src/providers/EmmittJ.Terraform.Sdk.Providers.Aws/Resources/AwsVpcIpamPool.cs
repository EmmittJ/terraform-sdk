using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolTimeoutsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> AddressFamily { get; set; }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_default_netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AllocationDefaultNetmaskLength { get; set; }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_max_netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AllocationMaxNetmaskLength { get; set; }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_min_netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AllocationMinNetmaskLength { get; set; }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    [TerraformPropertyName("allocation_resource_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AllocationResourceTags { get; set; }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    [TerraformPropertyName("auto_import")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoImport { get; set; }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    [TerraformPropertyName("aws_service")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AwsService { get; set; }

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
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ipam_scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamScopeId is required")]
    [TerraformPropertyName("ipam_scope_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpamScopeId { get; set; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Locale { get; set; }

    /// <summary>
    /// The public_ip_source attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicIpSource { get; set; }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    [TerraformPropertyName("publicly_advertisable")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PubliclyAdvertisable { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("source_ipam_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceIpamPoolId { get; set; }

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
    public TerraformBlock<AwsVpcIpamPoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    [TerraformPropertyName("ipam_scope_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpamScopeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipam_scope_type");

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    [TerraformPropertyName("pool_depth")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PoolDepth => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "pool_depth");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
