using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcIpamPoolTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_vpc_ipam_pool resource.
/// </summary>
public partial class AwsVpcIpamPool : TerraformResource
{
    public AwsVpcIpamPool(string name) : base("aws_vpc_ipam_pool", name)
    {
    }

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressFamily is required")]
    [TerraformProperty("address_family")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AddressFamily { get; set; }

    /// <summary>
    /// The allocation_default_netmask_length attribute.
    /// </summary>
    [TerraformProperty("allocation_default_netmask_length")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AllocationDefaultNetmaskLength { get; set; }

    /// <summary>
    /// The allocation_max_netmask_length attribute.
    /// </summary>
    [TerraformProperty("allocation_max_netmask_length")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AllocationMaxNetmaskLength { get; set; }

    /// <summary>
    /// The allocation_min_netmask_length attribute.
    /// </summary>
    [TerraformProperty("allocation_min_netmask_length")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AllocationMinNetmaskLength { get; set; }

    /// <summary>
    /// The allocation_resource_tags attribute.
    /// </summary>
    [TerraformProperty("allocation_resource_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AllocationResourceTags { get; set; }

    /// <summary>
    /// The auto_import attribute.
    /// </summary>
    [TerraformProperty("auto_import")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoImport { get; set; }

    /// <summary>
    /// The aws_service attribute.
    /// </summary>
    [TerraformProperty("aws_service")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AwsService { get; set; }

    /// <summary>
    /// The cascade attribute.
    /// </summary>
    [TerraformProperty("cascade")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Cascade { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipam_scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamScopeId is required")]
    [TerraformProperty("ipam_scope_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpamScopeId { get; set; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformProperty("locale")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Locale { get; set; }

    /// <summary>
    /// The public_ip_source attribute.
    /// </summary>
    [TerraformProperty("public_ip_source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicIpSource { get; set; }

    /// <summary>
    /// The publicly_advertisable attribute.
    /// </summary>
    [TerraformProperty("publicly_advertisable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PubliclyAdvertisable { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_ipam_pool_id attribute.
    /// </summary>
    [TerraformProperty("source_ipam_pool_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceIpamPoolId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsVpcIpamPoolTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The ipam_scope_type attribute.
    /// </summary>
    [TerraformProperty("ipam_scope_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpamScopeType { get; }

    /// <summary>
    /// The pool_depth attribute.
    /// </summary>
    [TerraformProperty("pool_depth")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PoolDepth { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
