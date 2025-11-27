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
        get => new TerraformReference<string>(this, "cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "availability_zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    public TerraformValue<double> BacktrackWindow
    {
        get => new TerraformReference<double>(this, "backtrack_window");
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriod
    {
        get => new TerraformReference<double>(this, "backup_retention_period");
    }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public TerraformSet<string> ClusterMembers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cluster_members").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterResourceId
    {
        get => new TerraformReference<string>(this, "cluster_resource_id");
    }

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    public TerraformValue<string> ClusterScalabilityType
    {
        get => new TerraformReference<string>(this, "cluster_scalability_type");
    }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformValue<string> DatabaseInsightsMode
    {
        get => new TerraformReference<string>(this, "database_insights_mode");
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
    }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbClusterParameterGroupName
    {
        get => new TerraformReference<string>(this, "db_cluster_parameter_group_name");
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroupName
    {
        get => new TerraformReference<string>(this, "db_subnet_group_name");
    }

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    public TerraformValue<string> DbSystemId
    {
        get => new TerraformReference<string>(this, "db_system_id");
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformList<string> EnabledCloudwatchLogsExports
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "enabled_cloudwatch_logs_exports").ResolveNodes(ctx));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
    }

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    public TerraformValue<string> EngineMode
    {
        get => new TerraformReference<string>(this, "engine_mode");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string> FinalSnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "final_snapshot_identifier");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IamDatabaseAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "iam_database_authentication_enabled");
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string> IamRoles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "iam_roles").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterUserSecret
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "master_user_secret").ResolveNodes(ctx));
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string> MasterUsername
    {
        get => new TerraformReference<string>(this, "master_username");
    }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformValue<double> MonitoringInterval
    {
        get => new TerraformReference<double>(this, "monitoring_interval");
    }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformValue<string> MonitoringRoleArn
    {
        get => new TerraformReference<string>(this, "monitoring_role_arn");
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => new TerraformReference<string>(this, "network_type");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredBackupWindow
    {
        get => new TerraformReference<string>(this, "preferred_backup_window");
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => new TerraformReference<string>(this, "preferred_maintenance_window");
    }

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpoint
    {
        get => new TerraformReference<string>(this, "reader_endpoint");
    }

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformValue<string> ReplicationSourceIdentifier
    {
        get => new TerraformReference<string>(this, "replication_source_identifier");
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
    {
        get => new TerraformReference<bool>(this, "storage_encrypted");
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
    }

}
