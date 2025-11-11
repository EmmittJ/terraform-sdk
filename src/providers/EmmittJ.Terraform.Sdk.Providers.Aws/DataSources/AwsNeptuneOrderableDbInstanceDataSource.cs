using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_neptune_orderable_db_instance.
/// </summary>
public class AwsNeptuneOrderableDbInstanceDataSource : TerraformDataSource
{
    public AwsNeptuneOrderableDbInstanceDataSource(string name) : base("aws_neptune_orderable_db_instance", name)
    {
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EngineVersion { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [TerraformPropertyName("instance_class")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceClass { get; set; } = default!;

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LicenseModel { get; set; }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    [TerraformPropertyName("preferred_instance_classes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreferredInstanceClasses { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    [TerraformPropertyName("vpc")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Vpc { get; set; } = default!;

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AvailabilityZones => new TerraformReference(this, "availability_zones");

    /// <summary>
    /// The max_iops_per_db_instance attribute.
    /// </summary>
    [TerraformPropertyName("max_iops_per_db_instance")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxIopsPerDbInstance => new TerraformReference(this, "max_iops_per_db_instance");

    /// <summary>
    /// The max_iops_per_gib attribute.
    /// </summary>
    [TerraformPropertyName("max_iops_per_gib")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxIopsPerGib => new TerraformReference(this, "max_iops_per_gib");

    /// <summary>
    /// The max_storage_size attribute.
    /// </summary>
    [TerraformPropertyName("max_storage_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxStorageSize => new TerraformReference(this, "max_storage_size");

    /// <summary>
    /// The min_iops_per_db_instance attribute.
    /// </summary>
    [TerraformPropertyName("min_iops_per_db_instance")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinIopsPerDbInstance => new TerraformReference(this, "min_iops_per_db_instance");

    /// <summary>
    /// The min_iops_per_gib attribute.
    /// </summary>
    [TerraformPropertyName("min_iops_per_gib")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinIopsPerGib => new TerraformReference(this, "min_iops_per_gib");

    /// <summary>
    /// The min_storage_size attribute.
    /// </summary>
    [TerraformPropertyName("min_storage_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinStorageSize => new TerraformReference(this, "min_storage_size");

    /// <summary>
    /// The multi_az_capable attribute.
    /// </summary>
    [TerraformPropertyName("multi_az_capable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MultiAzCapable => new TerraformReference(this, "multi_az_capable");

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    [TerraformPropertyName("read_replica_capable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ReadReplicaCapable => new TerraformReference(this, "read_replica_capable");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageType => new TerraformReference(this, "storage_type");

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    [TerraformPropertyName("supports_enhanced_monitoring")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsEnhancedMonitoring => new TerraformReference(this, "supports_enhanced_monitoring");

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    [TerraformPropertyName("supports_iam_database_authentication")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsIamDatabaseAuthentication => new TerraformReference(this, "supports_iam_database_authentication");

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    [TerraformPropertyName("supports_iops")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsIops => new TerraformReference(this, "supports_iops");

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    [TerraformPropertyName("supports_performance_insights")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsPerformanceInsights => new TerraformReference(this, "supports_performance_insights");

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    [TerraformPropertyName("supports_storage_encryption")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SupportsStorageEncryption => new TerraformReference(this, "supports_storage_encryption");

}
