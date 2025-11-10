using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2CapacityBlockReservationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_ec2_capacity_block_reservation resource.
/// </summary>
public class AwsEc2CapacityBlockReservation : TerraformResource
{
    public AwsEc2CapacityBlockReservation(string name) : base("aws_ec2_capacity_block_reservation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("availability_zone");
        SetOutput("created_date");
        SetOutput("ebs_optimized");
        SetOutput("end_date");
        SetOutput("end_date_type");
        SetOutput("id");
        SetOutput("instance_count");
        SetOutput("instance_type");
        SetOutput("outpost_arn");
        SetOutput("placement_group_arn");
        SetOutput("reservation_type");
        SetOutput("start_date");
        SetOutput("tags_all");
        SetOutput("tenancy");
        SetOutput("capacity_block_offering_id");
        SetOutput("instance_platform");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityBlockOfferingId is required")]
    public required TerraformProperty<string> CapacityBlockOfferingId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capacity_block_offering_id");
        set => SetProperty("capacity_block_offering_id", value);
    }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePlatform is required")]
    public required TerraformProperty<string> InstancePlatform
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_platform");
        set => SetProperty("instance_platform", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2CapacityBlockReservationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformExpression EbsOptimized => this["ebs_optimized"];

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformExpression EndDate => this["end_date"];

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    public TerraformExpression EndDateType => this["end_date_type"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformExpression InstanceCount => this["instance_count"];

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    public TerraformExpression PlacementGroupArn => this["placement_group_arn"];

    /// <summary>
    /// The reservation_type attribute.
    /// </summary>
    public TerraformExpression ReservationType => this["reservation_type"];

    /// <summary>
    /// The start_date attribute.
    /// </summary>
    public TerraformExpression StartDate => this["start_date"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformExpression Tenancy => this["tenancy"];

}
