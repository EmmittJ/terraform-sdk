using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("arn");
        SetOutput("dbi_resource_id");
        SetOutput("endpoint");
        SetOutput("engine_version_actual");
        SetOutput("kms_key_id");
        SetOutput("network_type");
        SetOutput("port");
        SetOutput("storage_encrypted");
        SetOutput("writer");
        SetOutput("apply_immediately");
        SetOutput("auto_minor_version_upgrade");
        SetOutput("availability_zone");
        SetOutput("ca_cert_identifier");
        SetOutput("cluster_identifier");
        SetOutput("copy_tags_to_snapshot");
        SetOutput("custom_iam_instance_profile");
        SetOutput("db_parameter_group_name");
        SetOutput("db_subnet_group_name");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("identifier");
        SetOutput("identifier_prefix");
        SetOutput("instance_class");
        SetOutput("monitoring_interval");
        SetOutput("monitoring_role_arn");
        SetOutput("performance_insights_enabled");
        SetOutput("performance_insights_kms_key_id");
        SetOutput("performance_insights_retention_period");
        SetOutput("preferred_backup_window");
        SetOutput("preferred_maintenance_window");
        SetOutput("promotion_tier");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_immediately");
        set => SetProperty("apply_immediately", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AutoMinorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => SetProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformProperty<string> CaCertIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ca_cert_identifier");
        set => SetProperty("ca_cert_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTagsToSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags_to_snapshot");
        set => SetProperty("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    public TerraformProperty<string> CustomIamInstanceProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_iam_instance_profile");
        set => SetProperty("custom_iam_instance_profile", value);
    }

    /// <summary>
    /// The db_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> DbParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_parameter_group_name");
        set => SetProperty("db_parameter_group_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string> DbSubnetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_subnet_group_name");
        set => SetProperty("db_subnet_group_name", value);
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
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string> Identifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identifier");
        set => SetProperty("identifier", value);
    }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string> IdentifierPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identifier_prefix");
        set => SetProperty("identifier_prefix", value);
    }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    public required TerraformProperty<string> InstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_class");
        set => SetProperty("instance_class", value);
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformProperty<double> MonitoringInterval
    {
        get => GetRequiredOutput<TerraformProperty<double>>("monitoring_interval");
        set => SetProperty("monitoring_interval", value);
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> MonitoringRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitoring_role_arn");
        set => SetProperty("monitoring_role_arn", value);
    }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PerformanceInsightsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("performance_insights_enabled");
        set => SetProperty("performance_insights_enabled", value);
    }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> PerformanceInsightsKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("performance_insights_kms_key_id");
        set => SetProperty("performance_insights_kms_key_id", value);
    }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    public TerraformProperty<double> PerformanceInsightsRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("performance_insights_retention_period");
        set => SetProperty("performance_insights_retention_period", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredBackupWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_backup_window");
        set => SetProperty("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredMaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_maintenance_window");
        set => SetProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// The promotion_tier attribute.
    /// </summary>
    public TerraformProperty<double> PromotionTier
    {
        get => GetRequiredOutput<TerraformProperty<double>>("promotion_tier");
        set => SetProperty("promotion_tier", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRdsClusterInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
