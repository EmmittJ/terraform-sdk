using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_cluster_instance resource.
/// </summary>
public class AwsRdsClusterInstance : TerraformResource
{
    public AwsRdsClusterInstance(string name) : base("aws_rds_cluster_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dbi_resource_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("engine_version_actual");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("network_type");
        this.DeclareOutput("port");
        this.DeclareOutput("storage_encrypted");
        this.DeclareOutput("writer");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public bool? ApplyImmediately
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("apply_immediately")?.Value;
        set => this.WithProperty("apply_immediately", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public bool? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_minor_version_upgrade")?.Value;
        set => this.WithProperty("auto_minor_version_upgrade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public string? CaCertIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ca_cert_identifier")?.Value;
        set => this.WithProperty("ca_cert_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public bool? CopyTagsToSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_snapshot")?.Value;
        set => this.WithProperty("copy_tags_to_snapshot", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    public string? CustomIamInstanceProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_iam_instance_profile")?.Value;
        set => this.WithProperty("custom_iam_instance_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_parameter_group_name attribute.
    /// </summary>
    public string? DbParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_parameter_group_name")?.Value;
        set => this.WithProperty("db_parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public string? DbSubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_subnet_group_name")?.Value;
        set => this.WithProperty("db_subnet_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public bool? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy")?.Value;
        set => this.WithProperty("force_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The identifier attribute.
    /// </summary>
    public string? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier")?.Value;
        set => this.WithProperty("identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public string? IdentifierPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier_prefix")?.Value;
        set => this.WithProperty("identifier_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The monitoring_interval attribute.
    /// </summary>
    public double? MonitoringInterval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("monitoring_interval")?.Value;
        set => this.WithProperty("monitoring_interval", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public string? MonitoringRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitoring_role_arn")?.Value;
        set => this.WithProperty("monitoring_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    public bool? PerformanceInsightsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("performance_insights_enabled")?.Value;
        set => this.WithProperty("performance_insights_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public string? PerformanceInsightsKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("performance_insights_kms_key_id")?.Value;
        set => this.WithProperty("performance_insights_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public double? PerformanceInsightsRetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("performance_insights_retention_period")?.Value;
        set => this.WithProperty("performance_insights_retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public string? PreferredBackupWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_backup_window")?.Value;
        set => this.WithProperty("preferred_backup_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public string? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_maintenance_window")?.Value;
        set => this.WithProperty("preferred_maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The promotion_tier attribute.
    /// </summary>
    public double? PromotionTier
    {
        get => GetProperty<TerraformLiteralProperty<double>>("promotion_tier")?.Value;
        set => this.WithProperty("promotion_tier", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public bool? PubliclyAccessible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("publicly_accessible")?.Value;
        set => this.WithProperty("publicly_accessible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dbi_resource_id attribute.
    /// </summary>
    public TerraformExpression DbiResourceId => this["dbi_resource_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    public TerraformExpression EngineVersionActual => this["engine_version_actual"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformExpression NetworkType => this["network_type"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformExpression StorageEncrypted => this["storage_encrypted"];

    /// <summary>
    /// The writer attribute.
    /// </summary>
    public TerraformExpression Writer => this["writer"];

}
