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
    public string? AvailabilityZoneGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone_group")?.Value;
        set => this.WithProperty("availability_zone_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public string? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine")?.Value;
        set => this.WithProperty("engine", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_latest_version attribute.
    /// </summary>
    public bool? EngineLatestVersion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("engine_latest_version")?.Value;
        set => this.WithProperty("engine_latest_version", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    public string? InstanceClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_class")?.Value;
        set => this.WithProperty("instance_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public string? LicenseModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_model")?.Value;
        set => this.WithProperty("license_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_engine_versions attribute.
    /// </summary>
    public List<string>? PreferredEngineVersions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_engine_versions")?.Value;
        set => this.WithProperty("preferred_engine_versions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    public List<string>? PreferredInstanceClasses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_instance_classes")?.Value;
        set => this.WithProperty("preferred_instance_classes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The read_replica_capable attribute.
    /// </summary>
    public bool? ReadReplicaCapable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("read_replica_capable")?.Value;
        set => this.WithProperty("read_replica_capable", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public string? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type")?.Value;
        set => this.WithProperty("storage_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The supported_engine_modes attribute.
    /// </summary>
    public List<string>? SupportedEngineModes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("supported_engine_modes")?.Value;
        set => this.WithProperty("supported_engine_modes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The supported_network_types attribute.
    /// </summary>
    public List<string>? SupportedNetworkTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("supported_network_types")?.Value;
        set => this.WithProperty("supported_network_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The supports_clusters attribute.
    /// </summary>
    public bool? SupportsClusters
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_clusters")?.Value;
        set => this.WithProperty("supports_clusters", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supports_enhanced_monitoring attribute.
    /// </summary>
    public bool? SupportsEnhancedMonitoring
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_enhanced_monitoring")?.Value;
        set => this.WithProperty("supports_enhanced_monitoring", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supports_global_databases attribute.
    /// </summary>
    public bool? SupportsGlobalDatabases
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_global_databases")?.Value;
        set => this.WithProperty("supports_global_databases", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supports_iam_database_authentication attribute.
    /// </summary>
    public bool? SupportsIamDatabaseAuthentication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_iam_database_authentication")?.Value;
        set => this.WithProperty("supports_iam_database_authentication", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supports_iops attribute.
    /// </summary>
    public bool? SupportsIops
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_iops")?.Value;
        set => this.WithProperty("supports_iops", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supports_kerberos_authentication attribute.
    /// </summary>
    public bool? SupportsKerberosAuthentication
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_kerberos_authentication")?.Value;
        set => this.WithProperty("supports_kerberos_authentication", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supports_multi_az attribute.
    /// </summary>
    public bool? SupportsMultiAz
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_multi_az")?.Value;
        set => this.WithProperty("supports_multi_az", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supports_performance_insights attribute.
    /// </summary>
    public bool? SupportsPerformanceInsights
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_performance_insights")?.Value;
        set => this.WithProperty("supports_performance_insights", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supports_storage_autoscaling attribute.
    /// </summary>
    public bool? SupportsStorageAutoscaling
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_storage_autoscaling")?.Value;
        set => this.WithProperty("supports_storage_autoscaling", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supports_storage_encryption attribute.
    /// </summary>
    public bool? SupportsStorageEncryption
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("supports_storage_encryption")?.Value;
        set => this.WithProperty("supports_storage_encryption", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    public bool? Vpc
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("vpc")?.Value;
        set => this.WithProperty("vpc", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
