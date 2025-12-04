using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rds_cluster Terraform data source.
/// Retrieves information about a aws_rds_cluster.
/// </summary>
public partial class AwsRdsClusterDataSource(string name) : TerraformDataSource("aws_rds_cluster", name)
{
    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => AsReference("availability_zones");

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    public TerraformValue<double> BacktrackWindow
        => AsReference("backtrack_window");

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriod
        => AsReference("backup_retention_period");

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public TerraformSet<string> ClusterMembers
        => AsReference("cluster_members");

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterResourceId
        => AsReference("cluster_resource_id");

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    public TerraformValue<string> ClusterScalabilityType
        => AsReference("cluster_scalability_type");

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformValue<string> DatabaseInsightsMode
        => AsReference("database_insights_mode");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
        => AsReference("database_name");

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbClusterParameterGroupName
        => AsReference("db_cluster_parameter_group_name");

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroupName
        => AsReference("db_subnet_group_name");

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    public TerraformValue<string> DbSystemId
        => AsReference("db_system_id");

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformList<string> EnabledCloudwatchLogsExports
        => AsReference("enabled_cloudwatch_logs_exports");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => AsReference("engine");

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    public TerraformValue<string> EngineMode
        => AsReference("engine_mode");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => AsReference("engine_version");

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string> FinalSnapshotIdentifier
        => AsReference("final_snapshot_identifier");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
        => AsReference("hosted_zone_id");

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IamDatabaseAuthenticationEnabled
        => AsReference("iam_database_authentication_enabled");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string> IamRoles
        => AsReference("iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterUserSecret
        => AsReference("master_user_secret");

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string> MasterUsername
        => AsReference("master_username");

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformValue<double> MonitoringInterval
        => AsReference("monitoring_interval");

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformValue<string> MonitoringRoleArn
        => AsReference("monitoring_role_arn");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
        => AsReference("network_type");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredBackupWindow
        => AsReference("preferred_backup_window");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
        => AsReference("preferred_maintenance_window");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpoint
        => AsReference("reader_endpoint");

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSourceIdentifier
        => AsReference("replication_source_identifier");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
        => AsReference("storage_encrypted");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
        => AsReference("vpc_security_group_ids");

}
