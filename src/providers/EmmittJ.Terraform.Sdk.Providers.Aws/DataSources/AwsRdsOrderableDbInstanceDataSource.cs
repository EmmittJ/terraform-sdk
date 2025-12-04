using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rds_orderable_db_instance Terraform data source.
/// Retrieves information about a aws_rds_orderable_db_instance.
/// </summary>
public partial class AwsRdsOrderableDbInstanceDataSource(string name) : TerraformDataSource("aws_rds_orderable_db_instance", name)
{
    /// <summary>
    /// The availability_zone_group attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZoneGroup
    {
        get => GetArgument<TerraformValue<string>>("availability_zone_group");
        set => SetArgument("availability_zone_group", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformValue<string> Engine
    {
        get => GetArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_latest_version attribute.
    /// </summary>
    public TerraformValue<bool>? EngineLatestVersion
    {
        get => GetArgument<TerraformValue<bool>>("engine_latest_version");
        set => SetArgument("engine_latest_version", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string>? EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public TerraformValue<string>? InstanceClass
    {
        get => GetArgument<TerraformValue<string>>("instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string>? LicenseModel
    {
        get => GetArgument<TerraformValue<string>>("license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The preferred_engine_versions attribute.
    /// </summary>
    public TerraformList<string>? PreferredEngineVersions
    {
        get => GetArgument<TerraformList<string>>("preferred_engine_versions");
        set => SetArgument("preferred_engine_versions", value);
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public TerraformList<string>? PreferredInstanceClasses
    {
        get => GetArgument<TerraformList<string>>("preferred_instance_classes");
        set => SetArgument("preferred_instance_classes", value);
    }

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    public TerraformValue<bool>? ReadReplicaCapable
    {
        get => GetArgument<TerraformValue<bool>>("read_replica_capable");
        set => SetArgument("read_replica_capable", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The supported_engine_modes attribute.
    /// </summary>
    public TerraformList<string>? SupportedEngineModes
    {
        get => GetArgument<TerraformList<string>>("supported_engine_modes");
        set => SetArgument("supported_engine_modes", value);
    }

    /// <summary>
    /// The supported_network_types attribute.
    /// </summary>
    public TerraformList<string>? SupportedNetworkTypes
    {
        get => GetArgument<TerraformList<string>>("supported_network_types");
        set => SetArgument("supported_network_types", value);
    }

    /// <summary>
    /// The supports_clusters attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsClusters
    {
        get => GetArgument<TerraformValue<bool>>("supports_clusters");
        set => SetArgument("supports_clusters", value);
    }

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsEnhancedMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("supports_enhanced_monitoring");
        set => SetArgument("supports_enhanced_monitoring", value);
    }

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsGlobalDatabases
    {
        get => GetArgument<TerraformValue<bool>>("supports_global_databases");
        set => SetArgument("supports_global_databases", value);
    }

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsIamDatabaseAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("supports_iam_database_authentication");
        set => SetArgument("supports_iam_database_authentication", value);
    }

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsIops
    {
        get => GetArgument<TerraformValue<bool>>("supports_iops");
        set => SetArgument("supports_iops", value);
    }

    /// <summary>
    /// The supports_kerberos_authentication attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsKerberosAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("supports_kerberos_authentication");
        set => SetArgument("supports_kerberos_authentication", value);
    }

    /// <summary>
    /// The supports_multi_az attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsMultiAz
    {
        get => GetArgument<TerraformValue<bool>>("supports_multi_az");
        set => SetArgument("supports_multi_az", value);
    }

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsPerformanceInsights
    {
        get => GetArgument<TerraformValue<bool>>("supports_performance_insights");
        set => SetArgument("supports_performance_insights", value);
    }

    /// <summary>
    /// The supports_storage_autoscaling attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsStorageAutoscaling
    {
        get => GetArgument<TerraformValue<bool>>("supports_storage_autoscaling");
        set => SetArgument("supports_storage_autoscaling", value);
    }

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    public TerraformValue<bool>? SupportsStorageEncryption
    {
        get => GetArgument<TerraformValue<bool>>("supports_storage_encryption");
        set => SetArgument("supports_storage_encryption", value);
    }

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    public TerraformValue<bool>? Vpc
    {
        get => GetArgument<TerraformValue<bool>>("vpc");
        set => SetArgument("vpc", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformList<string> AvailabilityZones
        => AsReference("availability_zones");

    /// <summary>
    /// The max_iops_per_db_instance attribute.
    /// </summary>
    public TerraformValue<double> MaxIopsPerDbInstance
        => AsReference("max_iops_per_db_instance");

    /// <summary>
    /// The max_iops_per_gib attribute.
    /// </summary>
    public TerraformValue<double> MaxIopsPerGib
        => AsReference("max_iops_per_gib");

    /// <summary>
    /// The max_storage_size attribute.
    /// </summary>
    public TerraformValue<double> MaxStorageSize
        => AsReference("max_storage_size");

    /// <summary>
    /// The min_iops_per_db_instance attribute.
    /// </summary>
    public TerraformValue<double> MinIopsPerDbInstance
        => AsReference("min_iops_per_db_instance");

    /// <summary>
    /// The min_iops_per_gib attribute.
    /// </summary>
    public TerraformValue<double> MinIopsPerGib
        => AsReference("min_iops_per_gib");

    /// <summary>
    /// The min_storage_size attribute.
    /// </summary>
    public TerraformValue<double> MinStorageSize
        => AsReference("min_storage_size");

    /// <summary>
    /// The multi_az_capable attribute.
    /// </summary>
    public TerraformValue<bool> MultiAzCapable
        => AsReference("multi_az_capable");

    /// <summary>
    /// The outpost_capable attribute.
    /// </summary>
    public TerraformValue<bool> OutpostCapable
        => AsReference("outpost_capable");

}
