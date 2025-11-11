using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_orderable_db_instance.
/// </summary>
public partial class AwsRdsOrderableDbInstanceDataSource : TerraformDataSource
{
    public AwsRdsOrderableDbInstanceDataSource(string name) : base("aws_rds_orderable_db_instance", name)
    {
    }

    /// <summary>
    /// The availability_zone_group attribute.
    /// </summary>
    [TerraformProperty("availability_zone_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZoneGroup { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformProperty("engine")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_latest_version attribute.
    /// </summary>
    [TerraformProperty("engine_latest_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EngineLatestVersion { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [TerraformProperty("instance_class")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> InstanceClass { get; set; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformProperty("license_model")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LicenseModel { get; set; }

    /// <summary>
    /// The preferred_engine_versions attribute.
    /// </summary>
    [TerraformProperty("preferred_engine_versions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PreferredEngineVersions { get; set; }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    [TerraformProperty("preferred_instance_classes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PreferredInstanceClasses { get; set; }

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    [TerraformProperty("read_replica_capable")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ReadReplicaCapable { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageType { get; set; }

    /// <summary>
    /// The supported_engine_modes attribute.
    /// </summary>
    [TerraformProperty("supported_engine_modes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> SupportedEngineModes { get; set; }

    /// <summary>
    /// The supported_network_types attribute.
    /// </summary>
    [TerraformProperty("supported_network_types")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> SupportedNetworkTypes { get; set; }

    /// <summary>
    /// The supports_clusters attribute.
    /// </summary>
    [TerraformProperty("supports_clusters")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsClusters { get; set; }

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    [TerraformProperty("supports_enhanced_monitoring")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsEnhancedMonitoring { get; set; }

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    [TerraformProperty("supports_global_databases")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsGlobalDatabases { get; set; }

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    [TerraformProperty("supports_iam_database_authentication")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsIamDatabaseAuthentication { get; set; }

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    [TerraformProperty("supports_iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsIops { get; set; }

    /// <summary>
    /// The supports_kerberos_authentication attribute.
    /// </summary>
    [TerraformProperty("supports_kerberos_authentication")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsKerberosAuthentication { get; set; }

    /// <summary>
    /// The supports_multi_az attribute.
    /// </summary>
    [TerraformProperty("supports_multi_az")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsMultiAz { get; set; }

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    [TerraformProperty("supports_performance_insights")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsPerformanceInsights { get; set; }

    /// <summary>
    /// The supports_storage_autoscaling attribute.
    /// </summary>
    [TerraformProperty("supports_storage_autoscaling")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsStorageAutoscaling { get; set; }

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    [TerraformProperty("supports_storage_encryption")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SupportsStorageEncryption { get; set; }

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    [TerraformProperty("vpc")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Vpc { get; set; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AvailabilityZones { get; }

    /// <summary>
    /// The max_iops_per_db_instance attribute.
    /// </summary>
    [TerraformProperty("max_iops_per_db_instance")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxIopsPerDbInstance { get; }

    /// <summary>
    /// The max_iops_per_gib attribute.
    /// </summary>
    [TerraformProperty("max_iops_per_gib")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxIopsPerGib { get; }

    /// <summary>
    /// The max_storage_size attribute.
    /// </summary>
    [TerraformProperty("max_storage_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxStorageSize { get; }

    /// <summary>
    /// The min_iops_per_db_instance attribute.
    /// </summary>
    [TerraformProperty("min_iops_per_db_instance")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MinIopsPerDbInstance { get; }

    /// <summary>
    /// The min_iops_per_gib attribute.
    /// </summary>
    [TerraformProperty("min_iops_per_gib")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MinIopsPerGib { get; }

    /// <summary>
    /// The min_storage_size attribute.
    /// </summary>
    [TerraformProperty("min_storage_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MinStorageSize { get; }

    /// <summary>
    /// The multi_az_capable attribute.
    /// </summary>
    [TerraformProperty("multi_az_capable")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MultiAzCapable { get; }

    /// <summary>
    /// The outpost_capable attribute.
    /// </summary>
    [TerraformProperty("outpost_capable")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> OutpostCapable { get; }

}
