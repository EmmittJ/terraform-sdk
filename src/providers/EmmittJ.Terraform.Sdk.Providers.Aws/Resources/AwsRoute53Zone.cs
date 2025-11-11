using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53ZoneTimeoutsBlock : TerraformBlockBase
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
/// Block type for vpc in .
/// Nesting mode: set
/// </summary>
public partial class AwsRoute53ZoneVpcBlock : TerraformBlockBase
{
    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// The vpc_region attribute.
    /// </summary>
    [TerraformProperty("vpc_region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VpcRegion { get; set; }

}

/// <summary>
/// Manages a aws_route53_zone resource.
/// </summary>
public partial class AwsRoute53Zone : TerraformResource
{
    public AwsRoute53Zone(string name) : base("aws_route53_zone", name)
    {
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The delegation_set_id attribute.
    /// </summary>
    [TerraformProperty("delegation_set_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DelegationSetId { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    public partial TerraformBlock<AwsRoute53ZoneTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("vpc")]
    public partial TerraformSet<TerraformBlock<AwsRoute53ZoneVpcBlock>>? Vpc { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    [TerraformProperty("name_servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> NameServers { get; }

    /// <summary>
    /// The primary_name_server attribute.
    /// </summary>
    [TerraformProperty("primary_name_server")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryNameServer { get; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformProperty("zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ZoneId { get; }

}
