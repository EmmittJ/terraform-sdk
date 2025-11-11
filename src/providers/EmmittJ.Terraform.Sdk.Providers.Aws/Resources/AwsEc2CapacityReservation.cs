using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2CapacityReservationTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_ec2_capacity_reservation resource.
/// </summary>
public partial class AwsEc2CapacityReservation : TerraformResource
{
    public AwsEc2CapacityReservation(string name) : base("aws_ec2_capacity_reservation", name)
    {
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    [TerraformProperty("availability_zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EbsOptimized { get; set; }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [TerraformProperty("end_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndDate { get; set; }

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    [TerraformProperty("end_date_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndDateType { get; set; }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    [TerraformProperty("ephemeral_storage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EphemeralStorage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    [TerraformProperty("instance_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> InstanceCount { get; set; }

    /// <summary>
    /// The instance_match_criteria attribute.
    /// </summary>
    [TerraformProperty("instance_match_criteria")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceMatchCriteria { get; set; }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePlatform is required")]
    [TerraformProperty("instance_platform")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstancePlatform { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutpostArn { get; set; }

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    [TerraformProperty("placement_group_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlacementGroupArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

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
    /// The tenancy attribute.
    /// </summary>
    [TerraformProperty("tenancy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tenancy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEc2CapacityReservationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

}
