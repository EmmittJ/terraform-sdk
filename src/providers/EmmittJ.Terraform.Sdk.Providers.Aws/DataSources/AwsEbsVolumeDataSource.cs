using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEbsVolumeDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEbsVolumeDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("arn");
        this.WithOutput("availability_zone");
        this.WithOutput("create_time");
        this.WithOutput("encrypted");
        this.WithOutput("iops");
        this.WithOutput("kms_key_id");
        this.WithOutput("multi_attach_enabled");
        this.WithOutput("outpost_arn");
        this.WithOutput("size");
        this.WithOutput("snapshot_id");
        this.WithOutput("throughput");
        this.WithOutput("volume_id");
        this.WithOutput("volume_initialization_rate");
        this.WithOutput("volume_type");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEbsVolumeDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEbsVolumeDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEbsVolumeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEbsVolumeDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
