using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2CapacityReservation.
/// Nesting mode: single
/// </summary>
public class AwsEc2CapacityReservationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ec2_capacity_reservation Terraform resource.
/// Manages a aws_ec2_capacity_reservation resource.
/// </summary>
public partial class AwsEc2CapacityReservation(string name) : TerraformResource("aws_ec2_capacity_reservation", name)
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    public required TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool>? EbsOptimized
    {
        get => new TerraformReference<bool>(this, "ebs_optimized");
        set => SetArgument("ebs_optimized", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformValue<string>? EndDate
    {
        get => new TerraformReference<string>(this, "end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    public TerraformValue<string>? EndDateType
    {
        get => new TerraformReference<string>(this, "end_date_type");
        set => SetArgument("end_date_type", value);
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformValue<bool>? EphemeralStorage
    {
        get => new TerraformReference<bool>(this, "ephemeral_storage");
        set => SetArgument("ephemeral_storage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformValue<double> InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The instance_match_criteria attribute.
    /// </summary>
    public TerraformValue<string>? InstanceMatchCriteria
    {
        get => new TerraformReference<string>(this, "instance_match_criteria");
        set => SetArgument("instance_match_criteria", value);
    }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePlatform is required")]
    public required TerraformValue<string> InstancePlatform
    {
        get => new TerraformReference<string>(this, "instance_platform");
        set => SetArgument("instance_platform", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string>? OutpostArn
    {
        get => new TerraformReference<string>(this, "outpost_arn");
        set => SetArgument("outpost_arn", value);
    }

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    public TerraformValue<string>? PlacementGroupArn
    {
        get => new TerraformReference<string>(this, "placement_group_arn");
        set => SetArgument("placement_group_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformValue<string>? Tenancy
    {
        get => new TerraformReference<string>(this, "tenancy");
        set => SetArgument("tenancy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2CapacityReservationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2CapacityReservationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
