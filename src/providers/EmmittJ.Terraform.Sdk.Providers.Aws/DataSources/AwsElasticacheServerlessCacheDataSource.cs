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
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cache_usage_limits attribute.
    /// </summary>
    [TerraformPropertyName("cache_usage_limits")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<object>> CacheUsageLimits => new TerraformReferenceProperty<TerraformProperty<object>>(ResourceAddress, "cache_usage_limits");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The daily_snapshot_time attribute.
    /// </summary>
    [TerraformPropertyName("daily_snapshot_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DailySnapshotTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "daily_snapshot_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<object>> Endpoint => new TerraformReferenceProperty<TerraformProperty<object>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Engine => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine");

    /// <summary>
    /// The full_engine_version attribute.
    /// </summary>
    [TerraformPropertyName("full_engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FullEngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "full_engine_version");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    [TerraformPropertyName("major_engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MajorEngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "major_engine_version");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("reader_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<object>> ReaderEndpoint => new TerraformReferenceProperty<TerraformProperty<object>>(ResourceAddress, "reader_endpoint");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SecurityGroupIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_retention_limit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SnapshotRetentionLimit => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "snapshot_retention_limit");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The user_group_id attribute.
    /// </summary>
    [TerraformPropertyName("user_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_group_id");

}
