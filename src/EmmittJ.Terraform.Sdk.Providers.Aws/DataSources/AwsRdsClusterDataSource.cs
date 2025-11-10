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
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zones");
        this.DeclareOutput("backtrack_window");
        this.DeclareOutput("backup_retention_period");
        this.DeclareOutput("cluster_members");
        this.DeclareOutput("cluster_resource_id");
        this.DeclareOutput("cluster_scalability_type");
        this.DeclareOutput("database_insights_mode");
        this.DeclareOutput("database_name");
        this.DeclareOutput("db_cluster_parameter_group_name");
        this.DeclareOutput("db_subnet_group_name");
        this.DeclareOutput("db_system_id");
        this.DeclareOutput("enabled_cloudwatch_logs_exports");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("engine");
        this.DeclareOutput("engine_mode");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("final_snapshot_identifier");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("iam_database_authentication_enabled");
        this.DeclareOutput("iam_roles");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("master_user_secret");
        this.DeclareOutput("master_username");
        this.DeclareOutput("monitoring_interval");
        this.DeclareOutput("monitoring_role_arn");
        this.DeclareOutput("network_type");
        this.DeclareOutput("port");
        this.DeclareOutput("preferred_backup_window");
        this.DeclareOutput("preferred_maintenance_window");
        this.DeclareOutput("reader_endpoint");
        this.DeclareOutput("replication_source_identifier");
        this.DeclareOutput("storage_encrypted");
        this.DeclareOutput("vpc_security_group_ids");
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
