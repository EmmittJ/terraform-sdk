using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kinesis_stream.
/// </summary>
public class AwsKinesisStreamDataSource : TerraformDataSource
{
    public AwsKinesisStreamDataSource(string name) : base("aws_kinesis_stream", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("closed_shards");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("encryption_type");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("open_shards");
        this.DeclareOutput("retention_period");
        this.DeclareOutput("shard_level_metrics");
        this.DeclareOutput("status");
        this.DeclareOutput("stream_mode_details");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The closed_shards attribute.
    /// </summary>
    public TerraformExpression ClosedShards => this["closed_shards"];

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformExpression EncryptionType => this["encryption_type"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The open_shards attribute.
    /// </summary>
    public TerraformExpression OpenShards => this["open_shards"];

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    public TerraformExpression RetentionPeriod => this["retention_period"];

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    public TerraformExpression ShardLevelMetrics => this["shard_level_metrics"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The stream_mode_details attribute.
    /// </summary>
    public TerraformExpression StreamModeDetails => this["stream_mode_details"];

}
