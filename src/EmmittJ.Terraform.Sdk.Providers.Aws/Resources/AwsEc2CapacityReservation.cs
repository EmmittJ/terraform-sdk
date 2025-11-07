using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformLiteralProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EbsOptimized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ebs_optimized");
        set => this.WithProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date");
        set => this.WithProperty("end_date", value);
    }

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndDateType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date_type");
        set => this.WithProperty("end_date_type", value);
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EphemeralStorage
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ephemeral_storage");
        set => this.WithProperty("ephemeral_storage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_match_criteria attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceMatchCriteria
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_match_criteria");
        set => this.WithProperty("instance_match_criteria", value);
    }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstancePlatform
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_platform");
        set => this.WithProperty("instance_platform", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OutpostArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outpost_arn");
        set => this.WithProperty("outpost_arn", value);
    }

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlacementGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("placement_group_arn");
        set => this.WithProperty("placement_group_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tenancy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenancy");
        set => this.WithProperty("tenancy", value);
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
