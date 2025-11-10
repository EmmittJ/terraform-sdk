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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The closed_shards attribute.
    /// </summary>
    [TerraformPropertyName("closed_shards")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ClosedShards => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "closed_shards");

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("encryption_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptionType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encryption_type");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The open_shards attribute.
    /// </summary>
    [TerraformPropertyName("open_shards")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> OpenShards => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "open_shards");

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    [TerraformPropertyName("retention_period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RetentionPeriod => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "retention_period");

    /// <summary>
    /// The shard_level_metrics attribute.
    /// </summary>
    [TerraformPropertyName("shard_level_metrics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ShardLevelMetrics => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "shard_level_metrics");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The stream_mode_details attribute.
    /// </summary>
    [TerraformPropertyName("stream_mode_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StreamModeDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "stream_mode_details");

}
