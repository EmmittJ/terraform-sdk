using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kinesis_stream.
/// </summary>
public class AwsKinesisStreamDataSource : TerraformDataSource
{
    public AwsKinesisStreamDataSource(string name) : base("aws_kinesis_stream", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The closed_shards attribute.
    /// </summary>
    [TerraformPropertyName("closed_shards")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ClosedShards => new TerraformReference(this, "closed_shards");

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("encryption_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EncryptionType => new TerraformReference(this, "encryption_type");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The open_shards attribute.
    /// </summary>
    [TerraformPropertyName("open_shards")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> OpenShards => new TerraformReference(this, "open_shards");

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    [TerraformPropertyName("retention_period")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RetentionPeriod => new TerraformReference(this, "retention_period");

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    [TerraformPropertyName("shard_level_metrics")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ShardLevelMetrics => new TerraformReference(this, "shard_level_metrics");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The stream_mode_details attribute.
    /// </summary>
    [TerraformPropertyName("stream_mode_details")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StreamModeDetails => new TerraformReference(this, "stream_mode_details");

}
