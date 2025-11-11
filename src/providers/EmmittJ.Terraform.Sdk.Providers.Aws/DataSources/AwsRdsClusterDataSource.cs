using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_cluster.
/// </summary>
public class AwsRdsClusterDataSource : TerraformDataSource
{
    public AwsRdsClusterDataSource(string name) : base("aws_rds_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformPropertyName("cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AvailabilityZones => new TerraformReference(this, "availability_zones");

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    [TerraformPropertyName("backtrack_window")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BacktrackWindow => new TerraformReference(this, "backtrack_window");

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BackupRetentionPeriod => new TerraformReference(this, "backup_retention_period");

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    [TerraformPropertyName("cluster_members")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ClusterMembers => new TerraformReference(this, "cluster_members");

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterResourceId => new TerraformReference(this, "cluster_resource_id");

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_scalability_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterScalabilityType => new TerraformReference(this, "cluster_scalability_type");

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_insights_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseInsightsMode => new TerraformReference(this, "database_insights_mode");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseName => new TerraformReference(this, "database_name");

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_parameter_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbClusterParameterGroupName => new TerraformReference(this, "db_cluster_parameter_group_name");

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbSubnetGroupName => new TerraformReference(this, "db_subnet_group_name");

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    [TerraformPropertyName("db_system_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbSystemId => new TerraformReference(this, "db_system_id");

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cloudwatch_logs_exports")]
    // Output-only attribute - read-only reference
    public TerraformList<string> EnabledCloudwatchLogsExports => new TerraformReference(this, "enabled_cloudwatch_logs_exports");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Engine => new TerraformReference(this, "engine");

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    [TerraformPropertyName("engine_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineMode => new TerraformReference(this, "engine_mode");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FinalSnapshotIdentifier => new TerraformReference(this, "final_snapshot_identifier");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostedZoneId => new TerraformReference(this, "hosted_zone_id");

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("iam_database_authentication_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IamDatabaseAuthenticationEnabled => new TerraformReference(this, "iam_database_authentication_enabled");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> IamRoles => new TerraformReference(this, "iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MasterUserSecret => new TerraformReference(this, "master_user_secret");

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformPropertyName("master_username")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterUsername => new TerraformReference(this, "master_username");

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_interval")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MonitoringInterval => new TerraformReference(this, "monitoring_interval");

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MonitoringRoleArn => new TerraformReference(this, "monitoring_role_arn");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkType => new TerraformReference(this, "network_type");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Port => new TerraformReference(this, "port");

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_backup_window")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredBackupWindow => new TerraformReference(this, "preferred_backup_window");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredMaintenanceWindow => new TerraformReference(this, "preferred_maintenance_window");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("reader_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReaderEndpoint => new TerraformReference(this, "reader_endpoint");

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    [TerraformPropertyName("replication_source_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationSourceIdentifier => new TerraformReference(this, "replication_source_identifier");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> StorageEncrypted => new TerraformReference(this, "storage_encrypted");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> VpcSecurityGroupIds => new TerraformReference(this, "vpc_security_group_ids");

}
