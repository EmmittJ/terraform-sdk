using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ebs_volume.
/// </summary>
public class AwsEbsVolumeDataSource : TerraformDataSource
{
    public AwsEbsVolumeDataSource(string name) : base("aws_ebs_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("create_time");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("iops");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("multi_attach_enabled");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("size");
        this.DeclareOutput("snapshot_id");
        this.DeclareOutput("throughput");
        this.DeclareOutput("volume_id");
        this.DeclareOutput("volume_initialization_rate");
        this.DeclareOutput("volume_type");
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
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool>? MostRecent
    {
        get => GetProperty<TerraformProperty<bool>>("most_recent");
        set => this.WithProperty("most_recent", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformExpression Iops => this["iops"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The multi_attach_enabled attribute.
    /// </summary>
    public TerraformExpression MultiAttachEnabled => this["multi_attach_enabled"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformExpression Size => this["size"];

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformExpression SnapshotId => this["snapshot_id"];

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformExpression Throughput => this["throughput"];

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformExpression VolumeId => this["volume_id"];

    /// <summary>
    /// The volume_initialization_rate attribute.
    /// </summary>
    public TerraformExpression VolumeInitializationRate => this["volume_initialization_rate"];

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformExpression VolumeType => this["volume_type"];

}
