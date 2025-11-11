using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_serverless_cache.
/// </summary>
public class AwsElasticacheServerlessCacheDataSource : TerraformDataSource
{
    public AwsElasticacheServerlessCacheDataSource(string name) : base("aws_elasticache_serverless_cache", name)
    {
    }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cache_usage_limits attribute.
    /// </summary>
    [TerraformPropertyName("cache_usage_limits")]
    // Output-only attribute - read-only reference
    public TerraformValue<object> CacheUsageLimits => new TerraformReference(this, "cache_usage_limits");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The daily_snapshot_time attribute.
    /// </summary>
    [TerraformPropertyName("daily_snapshot_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DailySnapshotTime => new TerraformReference(this, "daily_snapshot_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<object> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Engine => new TerraformReference(this, "engine");

    /// <summary>
    /// The full_engine_version attribute.
    /// </summary>
    [TerraformPropertyName("full_engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FullEngineVersion => new TerraformReference(this, "full_engine_version");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    [TerraformPropertyName("major_engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MajorEngineVersion => new TerraformReference(this, "major_engine_version");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("reader_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<object> ReaderEndpoint => new TerraformReference(this, "reader_endpoint");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SecurityGroupIds => new TerraformReference(this, "security_group_ids");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_retention_limit")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SnapshotRetentionLimit => new TerraformReference(this, "snapshot_retention_limit");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SubnetIds => new TerraformReference(this, "subnet_ids");

    /// <summary>
    /// The user_group_id attribute.
    /// </summary>
    [TerraformPropertyName("user_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserGroupId => new TerraformReference(this, "user_group_id");

}
