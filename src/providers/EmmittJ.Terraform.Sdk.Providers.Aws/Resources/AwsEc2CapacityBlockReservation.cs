using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2CapacityBlockReservation.
/// Nesting mode: single
/// </summary>
public class AwsEc2CapacityBlockReservationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_ec2_capacity_block_reservation Terraform resource.
/// Manages a aws_ec2_capacity_block_reservation resource.
/// </summary>
public partial class AwsEc2CapacityBlockReservation(string name) : TerraformResource("aws_ec2_capacity_block_reservation", name)
{
    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityBlockOfferingId is required")]
    public required TerraformValue<string> CapacityBlockOfferingId
    {
        get => GetArgument<TerraformValue<string>>("capacity_block_offering_id");
        set => SetArgument("capacity_block_offering_id", value);
    }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePlatform is required")]
    public required TerraformValue<string> InstancePlatform
    {
        get => GetArgument<TerraformValue<string>>("instance_platform");
        set => SetArgument("instance_platform", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool> EbsOptimized
        => AsReference("ebs_optimized");

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformValue<string> EndDate
        => AsReference("end_date");

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    public TerraformValue<string> EndDateType
        => AsReference("end_date_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double> InstanceCount
        => AsReference("instance_count");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
        => AsReference("instance_type");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
        => AsReference("outpost_arn");

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroupArn
        => AsReference("placement_group_arn");

    /// <summary>
    /// The reservation_type attribute.
    /// </summary>
    public TerraformValue<string> ReservationType
        => AsReference("reservation_type");

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformValue<string> StartDate
        => AsReference("start_date");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformValue<string> Tenancy
        => AsReference("tenancy");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2CapacityBlockReservationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2CapacityBlockReservationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
