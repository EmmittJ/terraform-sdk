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
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public bool? EbsOptimized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ebs_optimized")?.Value;
        set => this.WithProperty("ebs_optimized", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The end_date attribute.
    /// </summary>
    public string? EndDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date")?.Value;
        set => this.WithProperty("end_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The end_date_type attribute.
    /// </summary>
    public string? EndDateType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_date_type")?.Value;
        set => this.WithProperty("end_date_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    public bool? EphemeralStorage
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ephemeral_storage")?.Value;
        set => this.WithProperty("ephemeral_storage", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public double? InstanceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_count")?.Value;
        set => this.WithProperty("instance_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The instance_match_criteria attribute.
    /// </summary>
    public string? InstanceMatchCriteria
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_match_criteria")?.Value;
        set => this.WithProperty("instance_match_criteria", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    public string? InstancePlatform
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_platform")?.Value;
        set => this.WithProperty("instance_platform", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public string? OutpostArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outpost_arn")?.Value;
        set => this.WithProperty("outpost_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The placement_group_arn attribute.
    /// </summary>
    public string? PlacementGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("placement_group_arn")?.Value;
        set => this.WithProperty("placement_group_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public string? Tenancy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenancy")?.Value;
        set => this.WithProperty("tenancy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
