using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kinesis_stream resource.
/// </summary>
public class AwsKinesisStream : TerraformResource
{
    public AwsKinesisStream(string name) : base("aws_kinesis_stream", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionType
    {
        get => GetProperty<TerraformProperty<string>>("encryption_type");
        set => this.WithProperty("encryption_type", value);
    }

    /// <summary>
    /// The enforce_consumer_deletion attribute.
    /// </summary>
    public TerraformProperty<bool>? EnforceConsumerDeletion
    {
        get => GetProperty<TerraformProperty<bool>>("enforce_consumer_deletion");
        set => this.WithProperty("enforce_consumer_deletion", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("retention_period");
        set => this.WithProperty("retention_period", value);
    }

    /// <summary>
    /// The shard_count attribute.
    /// </summary>
    public TerraformProperty<double>? ShardCount
    {
        get => GetProperty<TerraformProperty<double>>("shard_count");
        set => this.WithProperty("shard_count", value);
    }

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ShardLevelMetrics
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("shard_level_metrics");
        set => this.WithProperty("shard_level_metrics", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

}
