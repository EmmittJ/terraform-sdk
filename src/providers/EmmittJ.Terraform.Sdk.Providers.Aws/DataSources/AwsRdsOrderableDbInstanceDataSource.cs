using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_orderable_db_instance.
/// </summary>
public class AwsRdsOrderableDbInstanceDataSource : TerraformDataSource
{
    public AwsRdsOrderableDbInstanceDataSource(string name) : base("aws_rds_orderable_db_instance", name)
    {
    }

    /// <summary>
    /// The availability_zone_group attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZoneGroup { get; set; } = default!;

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformPropertyName("engine")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_latest_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_latest_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EngineLatestVersion { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LicenseModel { get; set; } = default!;

    /// <summary>
    /// The preferred_engine_versions attribute.
    /// </summary>
    [TerraformPropertyName("preferred_engine_versions")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreferredEngineVersions { get; set; }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    [TerraformPropertyName("preferred_instance_classes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreferredInstanceClasses { get; set; }

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    [TerraformPropertyName("read_replica_capable")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ReadReplicaCapable { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageType { get; set; } = default!;

    /// <summary>
    /// The supported_engine_modes attribute.
    /// </summary>
    [TerraformPropertyName("supported_engine_modes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> SupportedEngineModes { get; set; } = default!;

    /// <summary>
    /// The supported_network_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_network_types")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> SupportedNetworkTypes { get; set; } = default!;

    /// <summary>
    /// The supports_clusters attribute.
    /// </summary>
    [TerraformPropertyName("supports_clusters")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsClusters { get; set; } = default!;

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    [TerraformPropertyName("supports_enhanced_monitoring")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsEnhancedMonitoring { get; set; } = default!;

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    [TerraformPropertyName("supports_global_databases")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsGlobalDatabases { get; set; } = default!;

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    [TerraformPropertyName("supports_iam_database_authentication")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsIamDatabaseAuthentication { get; set; } = default!;

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    [TerraformPropertyName("supports_iops")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsIops { get; set; } = default!;

    /// <summary>
    /// The supports_kerberos_authentication attribute.
    /// </summary>
    [TerraformPropertyName("supports_kerberos_authentication")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsKerberosAuthentication { get; set; } = default!;

    /// <summary>
    /// The supports_multi_az attribute.
    /// </summary>
    [TerraformPropertyName("supports_multi_az")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsMultiAz { get; set; } = default!;

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    [TerraformPropertyName("supports_performance_insights")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsPerformanceInsights { get; set; } = default!;

    /// <summary>
    /// The supports_storage_autoscaling attribute.
    /// </summary>
    [TerraformPropertyName("supports_storage_autoscaling")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsStorageAutoscaling { get; set; } = default!;

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    [TerraformPropertyName("supports_storage_encryption")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SupportsStorageEncryption { get; set; } = default!;

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
    /// The outpost_capable attribute.
    /// </summary>
    [TerraformPropertyName("outpost_capable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> OutpostCapable => new TerraformReference(this, "outpost_capable");

}
