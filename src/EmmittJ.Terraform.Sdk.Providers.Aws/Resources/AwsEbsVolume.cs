using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ebs_volume resource.
/// </summary>
public class AwsEbsVolume : TerraformResource
{
    public AwsEbsVolume(string name) : base("aws_ebs_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("create_time");
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
    /// The encrypted attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("encrypted");
        set => this.WithProperty("encrypted", value);
    }

    /// <summary>
    /// The final_snapshot attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FinalSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("final_snapshot");
        set => this.WithProperty("final_snapshot", value);
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
    /// The iops attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Iops
    {
        get => GetProperty<TerraformLiteralProperty<double>>("iops");
        set => this.WithProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The multi_attach_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MultiAttachEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_attach_enabled");
        set => this.WithProperty("multi_attach_enabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Size
    {
        get => GetProperty<TerraformLiteralProperty<double>>("size");
        set => this.WithProperty("size", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_id");
        set => this.WithProperty("snapshot_id", value);
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
    /// The throughput attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Throughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput");
        set => this.WithProperty("throughput", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The volume_initialization_rate attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? VolumeInitializationRate
    {
        get => GetProperty<TerraformLiteralProperty<double>>("volume_initialization_rate");
        set => this.WithProperty("volume_initialization_rate", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

}
