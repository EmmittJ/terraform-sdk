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
        this.DeclareOutput("availability_zones");
        this.DeclareOutput("max_iops_per_db_instance");
        this.DeclareOutput("max_iops_per_gib");
        this.DeclareOutput("max_storage_size");
        this.DeclareOutput("min_iops_per_db_instance");
        this.DeclareOutput("min_iops_per_gib");
        this.DeclareOutput("min_storage_size");
        this.DeclareOutput("multi_az_capable");
        this.DeclareOutput("outpost_capable");
    }

    /// <summary>
    /// The availability_zone_group attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZoneGroup
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_group");
        set => this.WithProperty("availability_zone_group", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_latest_version attribute.
    /// </summary>
    public TerraformProperty<bool>? EngineLatestVersion
    {
        get => GetProperty<TerraformProperty<bool>>("engine_latest_version");
        set => this.WithProperty("engine_latest_version", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceClass
    {
        get => GetProperty<TerraformProperty<string>>("instance_class");
        set => this.WithProperty("instance_class", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseModel
    {
        get => GetProperty<TerraformProperty<string>>("license_model");
        set => this.WithProperty("license_model", value);
    }

    /// <summary>
    /// The preferred_engine_versions attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PreferredEngineVersions
    {
        get => GetProperty<TerraformProperty<List<string>>>("preferred_engine_versions");
        set => this.WithProperty("preferred_engine_versions", value);
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PreferredInstanceClasses
    {
        get => GetProperty<TerraformProperty<List<string>>>("preferred_instance_classes");
        set => this.WithProperty("preferred_instance_classes", value);
    }

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadReplicaCapable
    {
        get => GetProperty<TerraformProperty<bool>>("read_replica_capable");
        set => this.WithProperty("read_replica_capable", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The supported_engine_modes attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SupportedEngineModes
    {
        get => GetProperty<TerraformProperty<List<string>>>("supported_engine_modes");
        set => this.WithProperty("supported_engine_modes", value);
    }

    /// <summary>
    /// The supported_network_types attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SupportedNetworkTypes
    {
        get => GetProperty<TerraformProperty<List<string>>>("supported_network_types");
        set => this.WithProperty("supported_network_types", value);
    }

    /// <summary>
    /// The supports_clusters attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsClusters
    {
        get => GetProperty<TerraformProperty<bool>>("supports_clusters");
        set => this.WithProperty("supports_clusters", value);
    }

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsEnhancedMonitoring
    {
        get => GetProperty<TerraformProperty<bool>>("supports_enhanced_monitoring");
        set => this.WithProperty("supports_enhanced_monitoring", value);
    }

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsGlobalDatabases
    {
        get => GetProperty<TerraformProperty<bool>>("supports_global_databases");
        set => this.WithProperty("supports_global_databases", value);
    }

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsIamDatabaseAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("supports_iam_database_authentication");
        set => this.WithProperty("supports_iam_database_authentication", value);
    }

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsIops
    {
        get => GetProperty<TerraformProperty<bool>>("supports_iops");
        set => this.WithProperty("supports_iops", value);
    }

    /// <summary>
    /// The supports_kerberos_authentication attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsKerberosAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("supports_kerberos_authentication");
        set => this.WithProperty("supports_kerberos_authentication", value);
    }

    /// <summary>
    /// The supports_multi_az attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsMultiAz
    {
        get => GetProperty<TerraformProperty<bool>>("supports_multi_az");
        set => this.WithProperty("supports_multi_az", value);
    }

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsPerformanceInsights
    {
        get => GetProperty<TerraformProperty<bool>>("supports_performance_insights");
        set => this.WithProperty("supports_performance_insights", value);
    }

    /// <summary>
    /// The supports_storage_autoscaling attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsStorageAutoscaling
    {
        get => GetProperty<TerraformProperty<bool>>("supports_storage_autoscaling");
        set => this.WithProperty("supports_storage_autoscaling", value);
    }

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportsStorageEncryption
    {
        get => GetProperty<TerraformProperty<bool>>("supports_storage_encryption");
        set => this.WithProperty("supports_storage_encryption", value);
    }

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    public TerraformProperty<bool>? Vpc
    {
        get => GetProperty<TerraformProperty<bool>>("vpc");
        set => this.WithProperty("vpc", value);
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
