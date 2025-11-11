using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kinesis_stream.
/// </summary>
public partial class AwsKinesisStreamDataSource : TerraformDataSource
{
    public AwsKinesisStreamDataSource(string name) : base("aws_kinesis_stream", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The closed_shards attribute.
    /// </summary>
    [TerraformProperty("closed_shards")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ClosedShards { get; }

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CreationTimestamp { get; }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformProperty("encryption_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EncryptionType { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The open_shards attribute.
    /// </summary>
    [TerraformProperty("open_shards")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> OpenShards { get; }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    [TerraformProperty("retention_period")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RetentionPeriod { get; }

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    [TerraformProperty("shard_level_metrics")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ShardLevelMetrics { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The stream_mode_details attribute.
    /// </summary>
    [TerraformProperty("stream_mode_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StreamModeDetails { get; }

}
