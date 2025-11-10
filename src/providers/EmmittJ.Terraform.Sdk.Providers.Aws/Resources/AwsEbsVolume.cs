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
        SetOutput("arn");
        SetOutput("create_time");
        SetOutput("availability_zone");
        SetOutput("encrypted");
        SetOutput("final_snapshot");
        SetOutput("id");
        SetOutput("iops");
        SetOutput("kms_key_id");
        SetOutput("multi_attach_enabled");
        SetOutput("outpost_arn");
        SetOutput("region");
        SetOutput("size");
        SetOutput("snapshot_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("throughput");
        SetOutput("type");
        SetOutput("volume_initialization_rate");
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
    /// The encrypted attribute.
    /// </summary>
    public TerraformProperty<bool> Encrypted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("encrypted");
        set => SetProperty("encrypted", value);
    }

    /// <summary>
    /// The final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool> FinalSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("final_snapshot");
        set => SetProperty("final_snapshot", value);
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
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double> Iops
    {
        get => GetRequiredOutput<TerraformProperty<double>>("iops");
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The multi_attach_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> MultiAttachEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_attach_enabled");
        set => SetProperty("multi_attach_enabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<double> Size
    {
        get => GetRequiredOutput<TerraformProperty<double>>("size");
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_id");
        set => SetProperty("snapshot_id", value);
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
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double> Throughput
    {
        get => GetRequiredOutput<TerraformProperty<double>>("throughput");
        set => SetProperty("throughput", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The volume_initialization_rate attribute.
    /// </summary>
    public TerraformProperty<double> VolumeInitializationRate
    {
        get => GetRequiredOutput<TerraformProperty<double>>("volume_initialization_rate");
        set => SetProperty("volume_initialization_rate", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEbsVolumeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
