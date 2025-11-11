using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamPoolDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPoolDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> AllocationResourceTags { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpamPoolId { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcIpamPoolDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpamPoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [TerraformPropertyName("address_family")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AddressFamily => new TerraformReference(this, "address_family");

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_default_netmask_length")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocationDefaultNetmaskLength => new TerraformReference(this, "allocation_default_netmask_length");

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_max_netmask_length")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocationMaxNetmaskLength => new TerraformReference(this, "allocation_max_netmask_length");

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("allocation_min_netmask_length")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocationMinNetmaskLength => new TerraformReference(this, "allocation_min_netmask_length");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    [TerraformPropertyName("auto_import")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoImport => new TerraformReference(this, "auto_import");

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    [TerraformPropertyName("aws_service")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AwsService => new TerraformReference(this, "aws_service");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The ipam_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("ipam_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpamScopeId => new TerraformReference(this, "ipam_scope_id");

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    [TerraformPropertyName("ipam_scope_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpamScopeType => new TerraformReference(this, "ipam_scope_type");

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Locale => new TerraformReference(this, "locale");

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    [TerraformPropertyName("pool_depth")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PoolDepth => new TerraformReference(this, "pool_depth");

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    [TerraformPropertyName("publicly_advertisable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PubliclyAdvertisable => new TerraformReference(this, "publicly_advertisable");

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("source_ipam_pool_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceIpamPoolId => new TerraformReference(this, "source_ipam_pool_id");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
