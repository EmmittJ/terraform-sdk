using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcIpamPoolDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcIpamPoolDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_ipam_pool.
/// </summary>
public partial class AwsVpcIpamPoolDataSource : TerraformDataSource
{
    public AwsVpcIpamPoolDataSource(string name) : base("aws_vpc_ipam_pool", name)
    {
    }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    [TerraformProperty("allocation_resource_tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> AllocationResourceTags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [TerraformProperty("ipam_pool_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpamPoolId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsVpcIpamPoolDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsVpcIpamPoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [TerraformProperty("address_family")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AddressFamily { get; }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    [TerraformProperty("allocation_default_netmask_length")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AllocationDefaultNetmaskLength { get; }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    [TerraformProperty("allocation_max_netmask_length")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AllocationMaxNetmaskLength { get; }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    [TerraformProperty("allocation_min_netmask_length")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AllocationMinNetmaskLength { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    [TerraformProperty("auto_import")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AutoImport { get; }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    [TerraformProperty("aws_service")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AwsService { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The ipam_scope_id attribute.
    /// </summary>
    [TerraformProperty("ipam_scope_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpamScopeId { get; }

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    [TerraformProperty("ipam_scope_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpamScopeType { get; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformProperty("locale")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Locale { get; }

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    [TerraformProperty("pool_depth")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PoolDepth { get; }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    [TerraformProperty("publicly_advertisable")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PubliclyAdvertisable { get; }

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    [TerraformProperty("source_ipam_pool_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceIpamPoolId { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
