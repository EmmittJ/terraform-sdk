using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2HostTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ec2_host resource.
/// </summary>
public partial class AwsEc2Host : TerraformResource
{
    public AwsEc2Host(string name) : base("aws_ec2_host", name)
    {
    }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    [TerraformProperty("asset_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AssetId { get; set; }

    /// <summary>
    /// The auto_placement attribute.
    /// </summary>
    [TerraformProperty("auto_placement")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AutoPlacement { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    [TerraformProperty("availability_zone")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The host_recovery attribute.
    /// </summary>
    [TerraformProperty("host_recovery")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HostRecovery { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_family attribute.
    /// </summary>
    [TerraformProperty("instance_family")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceFamily { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OutpostArn { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsEc2HostTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

}
