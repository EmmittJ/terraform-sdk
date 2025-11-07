using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("created_date");
        this.DeclareOutput("ebs_optimized");
        this.DeclareOutput("end_date");
        this.DeclareOutput("end_date_type");
        this.DeclareOutput("id");
        this.DeclareOutput("instance_count");
        this.DeclareOutput("instance_type");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("placement_group_arn");
        this.DeclareOutput("reservation_type");
        this.DeclareOutput("start_date");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("tenancy");
    }

    /// <summary>
    /// The capacity_block_offering_id attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityBlockOfferingId
    {
        get => GetProperty<TerraformProperty<string>>("capacity_block_offering_id");
        set => this.WithProperty("capacity_block_offering_id", value);
    }

    /// <summary>
    /// The instance_platform attribute.
    /// </summary>
    public TerraformProperty<string>? InstancePlatform
    {
        get => GetProperty<TerraformProperty<string>>("instance_platform");
        set => this.WithProperty("instance_platform", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
