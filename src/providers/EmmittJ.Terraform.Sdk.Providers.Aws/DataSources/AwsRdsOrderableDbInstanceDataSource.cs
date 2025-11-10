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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneGroup { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_group");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformPropertyName("engine")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Engine { get; set; }

    /// <summary>
    /// The engine_latest_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_latest_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EngineLatestVersion { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [TerraformPropertyName("instance_class")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceClass { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_class");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LicenseModel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

    /// <summary>
    /// The preferred_engine_versions attribute.
    /// </summary>
    [TerraformPropertyName("preferred_engine_versions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PreferredEngineVersions { get; set; }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    [TerraformPropertyName("preferred_instance_classes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PreferredInstanceClasses { get; set; }

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    [TerraformPropertyName("read_replica_capable")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ReadReplicaCapable { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "read_replica_capable");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The supported_engine_modes attribute.
    /// </summary>
    [TerraformPropertyName("supported_engine_modes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> SupportedEngineModes { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_engine_modes");

    /// <summary>
    /// The supported_network_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_network_types")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> SupportedNetworkTypes { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_network_types");

    /// <summary>
    /// The supports_clusters attribute.
    /// </summary>
    [TerraformPropertyName("supports_clusters")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsClusters { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_clusters");

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    [TerraformPropertyName("supports_enhanced_monitoring")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsEnhancedMonitoring { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_enhanced_monitoring");

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    [TerraformPropertyName("supports_global_databases")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsGlobalDatabases { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_global_databases");

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    [TerraformPropertyName("supports_iam_database_authentication")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsIamDatabaseAuthentication { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_iam_database_authentication");

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    [TerraformPropertyName("supports_iops")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsIops { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_iops");

    /// <summary>
    /// The supports_kerberos_authentication attribute.
    /// </summary>
    [TerraformPropertyName("supports_kerberos_authentication")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsKerberosAuthentication { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_kerberos_authentication");

    /// <summary>
    /// The supports_multi_az attribute.
    /// </summary>
    [TerraformPropertyName("supports_multi_az")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsMultiAz { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_multi_az");

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    [TerraformPropertyName("supports_performance_insights")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsPerformanceInsights { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_performance_insights");

    /// <summary>
    /// The supports_storage_autoscaling attribute.
    /// </summary>
    [TerraformPropertyName("supports_storage_autoscaling")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsStorageAutoscaling { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_storage_autoscaling");

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    [TerraformPropertyName("supports_storage_encryption")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SupportsStorageEncryption { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "supports_storage_encryption");

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    [TerraformPropertyName("vpc")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Vpc { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "vpc");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "availability_zones");

    /// <summary>
    /// The max_iops_per_db_instance attribute.
    /// </summary>
    [TerraformPropertyName("max_iops_per_db_instance")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxIopsPerDbInstance => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_iops_per_db_instance");

    /// <summary>
    /// The max_iops_per_gib attribute.
    /// </summary>
    [TerraformPropertyName("max_iops_per_gib")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxIopsPerGib => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_iops_per_gib");

    /// <summary>
    /// The max_storage_size attribute.
    /// </summary>
    [TerraformPropertyName("max_storage_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxStorageSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_storage_size");

    /// <summary>
    /// The min_iops_per_db_instance attribute.
    /// </summary>
    [TerraformPropertyName("min_iops_per_db_instance")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinIopsPerDbInstance => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_iops_per_db_instance");

    /// <summary>
    /// The min_iops_per_gib attribute.
    /// </summary>
    [TerraformPropertyName("min_iops_per_gib")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinIopsPerGib => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_iops_per_gib");

    /// <summary>
    /// The min_storage_size attribute.
    /// </summary>
    [TerraformPropertyName("min_storage_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinStorageSize => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_storage_size");

    /// <summary>
    /// The multi_az_capable attribute.
    /// </summary>
    [TerraformPropertyName("multi_az_capable")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MultiAzCapable => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_az_capable");

    /// <summary>
    /// The outpost_capable attribute.
    /// </summary>
    [TerraformPropertyName("outpost_capable")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> OutpostCapable => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "outpost_capable");

}
