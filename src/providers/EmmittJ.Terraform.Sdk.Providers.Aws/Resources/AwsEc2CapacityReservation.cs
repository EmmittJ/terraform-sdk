using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2CapacityReservationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_ec2_capacity_reservation resource.
/// </summary>
public class AwsEc2CapacityReservation : TerraformResource
{
    public AwsEc2CapacityReservation(string name) : base("aws_ec2_capacity_reservation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("owner_id");
        SetOutput("availability_zone");
        SetOutput("ebs_optimized");
        SetOutput("end_date");
        SetOutput("end_date_type");
        SetOutput("ephemeral_storage");
        SetOutput("id");
        SetOutput("instance_count");
        SetOutput("instance_match_criteria");
        SetOutput("instance_platform");
        SetOutput("instance_type");
        SetOutput("outpost_arn");
        SetOutput("placement_group_arn");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tenancy");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    public required TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<bool> EbsOptimized
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ebs_optimized");
        set => SetProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformProperty<string> EndDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_date");
        set => SetProperty("end_date", value);
    }

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    public TerraformProperty<string> EndDateType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_date_type");
        set => SetProperty("end_date_type", value);
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformProperty<bool> EphemeralStorage
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ephemeral_storage");
        set => SetProperty("ephemeral_storage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformProperty<double> InstanceCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("instance_count");
        set => SetProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_match_criteria attribute.
    /// </summary>
    public TerraformProperty<string> InstanceMatchCriteria
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_match_criteria");
        set => SetProperty("instance_match_criteria", value);
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
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformProperty<string> OutpostArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("outpost_arn");
        set => SetProperty("outpost_arn", value);
    }

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    public TerraformProperty<string> PlacementGroupArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("placement_group_arn");
        set => SetProperty("placement_group_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformProperty<string> Tenancy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenancy");
        set => SetProperty("tenancy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2CapacityReservationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
