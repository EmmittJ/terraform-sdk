using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_cluster.
/// </summary>
public class AwsRdsClusterDataSource : TerraformDataSource
{
    public AwsRdsClusterDataSource(string name) : base("aws_rds_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("availability_zones");
        SetOutput("backtrack_window");
        SetOutput("backup_retention_period");
        SetOutput("cluster_members");
        SetOutput("cluster_resource_id");
        SetOutput("cluster_scalability_type");
        SetOutput("database_insights_mode");
        SetOutput("database_name");
        SetOutput("db_cluster_parameter_group_name");
        SetOutput("db_subnet_group_name");
        SetOutput("db_system_id");
        SetOutput("enabled_cloudwatch_logs_exports");
        SetOutput("endpoint");
        SetOutput("engine");
        SetOutput("engine_mode");
        SetOutput("engine_version");
        SetOutput("final_snapshot_identifier");
        SetOutput("hosted_zone_id");
        SetOutput("iam_database_authentication_enabled");
        SetOutput("iam_roles");
        SetOutput("kms_key_id");
        SetOutput("master_user_secret");
        SetOutput("master_username");
        SetOutput("monitoring_interval");
        SetOutput("monitoring_role_arn");
        SetOutput("network_type");
        SetOutput("port");
        SetOutput("preferred_backup_window");
        SetOutput("preferred_maintenance_window");
        SetOutput("reader_endpoint");
        SetOutput("replication_source_identifier");
        SetOutput("storage_encrypted");
        SetOutput("vpc_security_group_ids");
        SetOutput("cluster_identifier");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    public TerraformExpression BacktrackWindow => this["backtrack_window"];

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformExpression BackupRetentionPeriod => this["backup_retention_period"];

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public TerraformExpression ClusterMembers => this["cluster_members"];

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformExpression ClusterResourceId => this["cluster_resource_id"];

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    public TerraformExpression ClusterScalabilityType => this["cluster_scalability_type"];

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformExpression DatabaseInsightsMode => this["database_insights_mode"];

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformExpression DatabaseName => this["database_name"];

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformExpression DbClusterParameterGroupName => this["db_cluster_parameter_group_name"];

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformExpression DbSubnetGroupName => this["db_subnet_group_name"];

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    public TerraformExpression DbSystemId => this["db_system_id"];

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformExpression EnabledCloudwatchLogsExports => this["enabled_cloudwatch_logs_exports"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    public TerraformExpression EngineMode => this["engine_mode"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformExpression FinalSnapshotIdentifier => this["final_snapshot_identifier"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformExpression IamDatabaseAuthenticationEnabled => this["iam_database_authentication_enabled"];

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformExpression IamRoles => this["iam_roles"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformExpression MasterUserSecret => this["master_user_secret"];

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformExpression MasterUsername => this["master_username"];

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformExpression MonitoringInterval => this["monitoring_interval"];

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformExpression MonitoringRoleArn => this["monitoring_role_arn"];

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformExpression NetworkType => this["network_type"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformExpression PreferredBackupWindow => this["preferred_backup_window"];

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformExpression PreferredMaintenanceWindow => this["preferred_maintenance_window"];

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformExpression ReaderEndpoint => this["reader_endpoint"];

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformExpression ReplicationSourceIdentifier => this["replication_source_identifier"];

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformExpression StorageEncrypted => this["storage_encrypted"];

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformExpression VpcSecurityGroupIds => this["vpc_security_group_ids"];

}
