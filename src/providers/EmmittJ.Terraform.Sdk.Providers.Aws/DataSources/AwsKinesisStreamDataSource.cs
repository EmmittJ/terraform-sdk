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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The closed_shards attribute.
    /// </summary>
    public TerraformSet<string> ClosedShards
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "closed_shards").ResolveNodes(ctx));
    }

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    public TerraformValue<double> CreationTimestamp
    {
        get => new TerraformReference<double>(this, "creation_timestamp");
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string> EncryptionType
    {
        get => new TerraformReference<string>(this, "encryption_type");
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The open_shards attribute.
    /// </summary>
    public TerraformSet<string> OpenShards
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "open_shards").ResolveNodes(ctx));
    }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    public TerraformValue<double> RetentionPeriod
    {
        get => new TerraformReference<double>(this, "retention_period");
    }

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    public TerraformSet<string> ShardLevelMetrics
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "shard_level_metrics").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The stream_mode_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StreamModeDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "stream_mode_details").ResolveNodes(ctx));
    }

}
