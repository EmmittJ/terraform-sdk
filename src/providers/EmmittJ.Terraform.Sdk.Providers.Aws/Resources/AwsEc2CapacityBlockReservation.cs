using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2CapacityBlockReservationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

}

/// <summary>
/// Manages a aws_ec2_capacity_block_reservation resource.
/// </summary>
public class AwsEc2CapacityBlockReservation : TerraformResource
{
    public AwsEc2CapacityBlockReservation(string name) : base("aws_ec2_capacity_block_reservation", name)
    {
    }

    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityBlockOfferingId is required")]
    [TerraformPropertyName("capacity_block_offering_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CapacityBlockOfferingId { get; set; }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePlatform is required")]
    [TerraformPropertyName("instance_platform")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstancePlatform { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2CapacityBlockReservationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EbsOptimized => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ebs_optimized");

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    [TerraformPropertyName("end_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_date");

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    [TerraformPropertyName("end_date_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndDateType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_date_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> InstanceCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "instance_count");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_type");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outpost_arn");

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("placement_group_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlacementGroupArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "placement_group_arn");

    /// <summary>
    /// The reservation_type attribute.
    /// </summary>
    [TerraformPropertyName("reservation_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReservationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reservation_type");

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    [TerraformPropertyName("start_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_date");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    [TerraformPropertyName("tenancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tenancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenancy");

}
