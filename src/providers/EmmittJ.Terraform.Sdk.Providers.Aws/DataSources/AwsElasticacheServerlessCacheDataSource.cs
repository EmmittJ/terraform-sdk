using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_serverless_cache.
/// </summary>
public partial class AwsElasticacheServerlessCacheDataSource : TerraformDataSource
{
    public AwsElasticacheServerlessCacheDataSource(string name) : base("aws_elasticache_serverless_cache", name)
    {
    }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cache_usage_limits attribute.
    /// </summary>
    [TerraformProperty("cache_usage_limits")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<object> CacheUsageLimits { get; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The daily_snapshot_time attribute.
    /// </summary>
    [TerraformProperty("daily_snapshot_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DailySnapshotTime { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<object> Endpoint { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Engine { get; }

    /// <summary>
    /// The full_engine_version attribute.
    /// </summary>
    [TerraformProperty("full_engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FullEngineVersion { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    [TerraformProperty("major_engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MajorEngineVersion { get; }

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformProperty("reader_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<object> ReaderEndpoint { get; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SecurityGroupIds { get; }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformProperty("snapshot_retention_limit")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SnapshotRetentionLimit { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SubnetIds { get; }

    /// <summary>
    /// The user_group_id attribute.
    /// </summary>
    [TerraformProperty("user_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserGroupId { get; }

}
