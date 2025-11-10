using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEbsVolumeTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    public required TerraformProperty<string> AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? Encrypted
    {
        get => GetProperty<TerraformProperty<bool>>("encrypted");
        set => this.WithProperty("encrypted", value);
    }

    /// <summary>
    /// The final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool>? FinalSnapshot
    {
        get => GetProperty<TerraformProperty<bool>>("final_snapshot");
        set => this.WithProperty("final_snapshot", value);
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
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => this.WithProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The multi_attach_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAttachEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("multi_attach_enabled");
        set => this.WithProperty("multi_attach_enabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<double>? Size
    {
        get => GetProperty<TerraformProperty<double>>("size");
        set => this.WithProperty("size", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_id");
        set => this.WithProperty("snapshot_id", value);
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
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        get => GetProperty<TerraformProperty<double>>("throughput");
        set => this.WithProperty("throughput", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The volume_initialization_rate attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeInitializationRate
    {
        get => GetProperty<TerraformProperty<double>>("volume_initialization_rate");
        set => this.WithProperty("volume_initialization_rate", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEbsVolumeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEbsVolumeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
