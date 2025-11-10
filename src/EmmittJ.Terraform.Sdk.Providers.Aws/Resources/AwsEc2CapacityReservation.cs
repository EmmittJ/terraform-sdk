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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    public required TerraformProperty<string> AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<bool>? EbsOptimized
    {
        get => GetProperty<TerraformProperty<bool>>("ebs_optimized");
        set => this.WithProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformProperty<string>? EndDate
    {
        get => GetProperty<TerraformProperty<string>>("end_date");
        set => this.WithProperty("end_date", value);
    }

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    public TerraformProperty<string>? EndDateType
    {
        get => GetProperty<TerraformProperty<string>>("end_date_type");
        set => this.WithProperty("end_date_type", value);
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformProperty<bool>? EphemeralStorage
    {
        get => GetProperty<TerraformProperty<bool>>("ephemeral_storage");
        set => this.WithProperty("ephemeral_storage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformProperty<double> InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_match_criteria attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceMatchCriteria
    {
        get => GetProperty<TerraformProperty<string>>("instance_match_criteria");
        set => this.WithProperty("instance_match_criteria", value);
    }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePlatform is required")]
    public required TerraformProperty<string> InstancePlatform
    {
        get => GetProperty<TerraformProperty<string>>("instance_platform");
        set => this.WithProperty("instance_platform", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OutpostArn
    {
        get => GetProperty<TerraformProperty<string>>("outpost_arn");
        set => this.WithProperty("outpost_arn", value);
    }

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("placement_group_arn");
        set => this.WithProperty("placement_group_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? Tenancy
    {
        get => GetProperty<TerraformProperty<string>>("tenancy");
        set => this.WithProperty("tenancy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2CapacityReservationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2CapacityReservationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
