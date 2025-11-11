using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2CapacityBlockReservationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_ec2_capacity_block_reservation resource.
/// </summary>
public partial class AwsEc2CapacityBlockReservation : TerraformResource
{
    public AwsEc2CapacityBlockReservation(string name) : base("aws_ec2_capacity_block_reservation", name)
    {
    }

    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityBlockOfferingId is required")]
    [TerraformProperty("capacity_block_offering_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CapacityBlockOfferingId { get; set; }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePlatform is required")]
    [TerraformProperty("instance_platform")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstancePlatform { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEc2CapacityBlockReservationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EbsOptimized { get; }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [TerraformProperty("end_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndDate { get; }

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    [TerraformProperty("end_date_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndDateType { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> InstanceCount { get; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceType { get; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutpostArn { get; }

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    [TerraformProperty("placement_group_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlacementGroupArn { get; }

    /// <summary>
    /// The reservation_type attribute.
    /// </summary>
    [TerraformProperty("reservation_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReservationType { get; }

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformProperty("start_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartDate { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformProperty("tenancy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tenancy { get; }

}
