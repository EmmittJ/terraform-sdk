using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_orderable_db_instance.
/// </summary>
public class AwsRdsOrderableDbInstanceDataSource : TerraformDataSource
{
    public AwsRdsOrderableDbInstanceDataSource(string name) : base("aws_rds_orderable_db_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("availability_zones");
        SetOutput("max_iops_per_db_instance");
        SetOutput("max_iops_per_gib");
        SetOutput("max_storage_size");
        SetOutput("min_iops_per_db_instance");
        SetOutput("min_iops_per_gib");
        SetOutput("min_storage_size");
        SetOutput("multi_az_capable");
        SetOutput("outpost_capable");
        SetOutput("availability_zone_group");
        SetOutput("engine");
        SetOutput("engine_latest_version");
        SetOutput("engine_version");
        SetOutput("id");
        SetOutput("instance_class");
        SetOutput("license_model");
        SetOutput("preferred_engine_versions");
        SetOutput("preferred_instance_classes");
        SetOutput("read_replica_capable");
        SetOutput("region");
        SetOutput("storage_type");
        SetOutput("supported_engine_modes");
        SetOutput("supported_network_types");
        SetOutput("supports_clusters");
        SetOutput("supports_enhanced_monitoring");
        SetOutput("supports_global_databases");
        SetOutput("supports_iam_database_authentication");
        SetOutput("supports_iops");
        SetOutput("supports_kerberos_authentication");
        SetOutput("supports_multi_az");
        SetOutput("supports_performance_insights");
        SetOutput("supports_storage_autoscaling");
        SetOutput("supports_storage_encryption");
        SetOutput("vpc");
    }

    /// <summary>
    /// The availability_zone_group attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZoneGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone_group");
        set => SetProperty("availability_zone_group", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    public required TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The engine_latest_version attribute.
    /// </summary>
    public TerraformProperty<bool> EngineLatestVersion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("engine_latest_version");
        set => SetProperty("engine_latest_version", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public TerraformProperty<string> InstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_class");
        set => SetProperty("instance_class", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformProperty<string> LicenseModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_model");
        set => SetProperty("license_model", value);
    }

    /// <summary>
    /// The preferred_engine_versions attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredEngineVersions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_engine_versions");
        set => SetProperty("preferred_engine_versions", value);
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredInstanceClasses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_instance_classes");
        set => SetProperty("preferred_instance_classes", value);
    }

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    public TerraformProperty<bool> ReadReplicaCapable
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("read_replica_capable");
        set => SetProperty("read_replica_capable", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_type");
        set => SetProperty("storage_type", value);
    }

    /// <summary>
    /// The supported_engine_modes attribute.
    /// </summary>
    public List<TerraformProperty<string>> SupportedEngineModes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("supported_engine_modes");
        set => SetProperty("supported_engine_modes", value);
    }

    /// <summary>
    /// The supported_network_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> SupportedNetworkTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("supported_network_types");
        set => SetProperty("supported_network_types", value);
    }

    /// <summary>
    /// The supports_clusters attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsClusters
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_clusters");
        set => SetProperty("supports_clusters", value);
    }

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsEnhancedMonitoring
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_enhanced_monitoring");
        set => SetProperty("supports_enhanced_monitoring", value);
    }

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsGlobalDatabases
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_global_databases");
        set => SetProperty("supports_global_databases", value);
    }

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsIamDatabaseAuthentication
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_iam_database_authentication");
        set => SetProperty("supports_iam_database_authentication", value);
    }

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsIops
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_iops");
        set => SetProperty("supports_iops", value);
    }

    /// <summary>
    /// The supports_kerberos_authentication attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsKerberosAuthentication
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_kerberos_authentication");
        set => SetProperty("supports_kerberos_authentication", value);
    }

    /// <summary>
    /// The supports_multi_az attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsMultiAz
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_multi_az");
        set => SetProperty("supports_multi_az", value);
    }

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsPerformanceInsights
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_performance_insights");
        set => SetProperty("supports_performance_insights", value);
    }

    /// <summary>
    /// The supports_storage_autoscaling attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsStorageAutoscaling
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_storage_autoscaling");
        set => SetProperty("supports_storage_autoscaling", value);
    }

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    public TerraformProperty<bool> SupportsStorageEncryption
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("supports_storage_encryption");
        set => SetProperty("supports_storage_encryption", value);
    }

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    public TerraformProperty<bool> Vpc
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("vpc");
        set => SetProperty("vpc", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

    /// <summary>
    /// The max_iops_per_db_instance attribute.
    /// </summary>
    public TerraformExpression MaxIopsPerDbInstance => this["max_iops_per_db_instance"];

    /// <summary>
    /// The max_iops_per_gib attribute.
    /// </summary>
    public TerraformExpression MaxIopsPerGib => this["max_iops_per_gib"];

    /// <summary>
    /// The max_storage_size attribute.
    /// </summary>
    public TerraformExpression MaxStorageSize => this["max_storage_size"];

    /// <summary>
    /// The min_iops_per_db_instance attribute.
    /// </summary>
    public TerraformExpression MinIopsPerDbInstance => this["min_iops_per_db_instance"];

    /// <summary>
    /// The min_iops_per_gib attribute.
    /// </summary>
    public TerraformExpression MinIopsPerGib => this["min_iops_per_gib"];

    /// <summary>
    /// The min_storage_size attribute.
    /// </summary>
    public TerraformExpression MinStorageSize => this["min_storage_size"];

    /// <summary>
    /// The multi_az_capable attribute.
    /// </summary>
    public TerraformExpression MultiAzCapable => this["multi_az_capable"];

    /// <summary>
    /// The outpost_capable attribute.
    /// </summary>
    public TerraformExpression OutpostCapable => this["outpost_capable"];

}
