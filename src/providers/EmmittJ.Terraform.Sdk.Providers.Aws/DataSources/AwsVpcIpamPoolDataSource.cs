using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamPoolDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_ipam_pool.
/// </summary>
public class AwsVpcIpamPoolDataSource : TerraformDataSource
{
    public AwsVpcIpamPoolDataSource(string name) : base("aws_vpc_ipam_pool", name)
    {
    }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    [TerraformPropertyName("allocation_resource_tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AllocationResourceTags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "allocation_resource_tags");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Id { get; set; }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpamPoolId { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcIpamPoolDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpamPoolDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [TerraformPropertyName("address_family")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AddressFamily => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address_family");

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_default_netmask_length")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AllocationDefaultNetmaskLength => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocation_default_netmask_length");

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_max_netmask_length")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AllocationMaxNetmaskLength => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocation_max_netmask_length");

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_min_netmask_length")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AllocationMinNetmaskLength => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocation_min_netmask_length");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    [TerraformPropertyName("auto_import")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoImport => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_import");

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    [TerraformPropertyName("aws_service")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AwsService => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_service");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The ipam_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpamScopeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipam_scope_id");

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    [TerraformPropertyName("ipam_scope_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpamScopeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipam_scope_type");

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Locale => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "locale");

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    [TerraformPropertyName("pool_depth")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PoolDepth => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "pool_depth");

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    [TerraformPropertyName("publicly_advertisable")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PubliclyAdvertisable => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "publicly_advertisable");

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("source_ipam_pool_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceIpamPoolId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_ipam_pool_id");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
