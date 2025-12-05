using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kinesis_stream Terraform data source.
/// Retrieves information about a aws_kinesis_stream.
/// </summary>
public partial class AwsKinesisStreamDataSource(string name) : TerraformDataSource("aws_kinesis_stream", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The closed_shards attribute.
    /// </summary>
    public TerraformSet<string> ClosedShards
        => CreateReference("closed_shards");

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    public TerraformValue<double> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string> EncryptionType
        => CreateReference("encryption_type");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => CreateReference("kms_key_id");

    /// <summary>
    /// The open_shards attribute.
    /// </summary>
    public TerraformSet<string> OpenShards
        => CreateReference("open_shards");

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double> RetentionPeriod
        => CreateReference("retention_period");

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    public TerraformSet<string> ShardLevelMetrics
        => CreateReference("shard_level_metrics");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The stream_mode_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StreamModeDetails
        => CreateReference("stream_mode_details");

}
