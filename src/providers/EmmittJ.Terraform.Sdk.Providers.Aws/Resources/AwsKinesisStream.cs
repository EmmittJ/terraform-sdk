using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for stream_mode_details in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisStreamStreamModeDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The stream_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamMode is required")]
    public required TerraformProperty<string> StreamMode
    {
        set => SetProperty("stream_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKinesisStreamTimeoutsBlock : TerraformBlock
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
/// Manages a aws_kinesis_stream resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKinesisStream : TerraformResource
{
    public AwsKinesisStream(string name) : base("aws_kinesis_stream", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("encryption_type");
        SetOutput("enforce_consumer_deletion");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("retention_period");
        SetOutput("shard_count");
        SetOutput("shard_level_metrics");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_type");
        set => SetProperty("encryption_type", value);
    }

    /// <summary>
    /// The enforce_consumer_deletion attribute.
    /// </summary>
    public TerraformProperty<bool> EnforceConsumerDeletion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enforce_consumer_deletion");
        set => SetProperty("enforce_consumer_deletion", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformProperty<double> RetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_period");
        set => SetProperty("retention_period", value);
    }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    public TerraformProperty<double> ShardCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("shard_count");
        set => SetProperty("shard_count", value);
    }

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ShardLevelMetrics
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("shard_level_metrics");
        set => SetProperty("shard_level_metrics", value);
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
    /// Block for stream_mode_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamModeDetails block(s) allowed")]
    public List<AwsKinesisStreamStreamModeDetailsBlock>? StreamModeDetails
    {
        set => SetProperty("stream_mode_details", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKinesisStreamTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
