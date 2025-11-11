using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_cluster.
/// </summary>
public partial class AwsRdsClusterDataSource : TerraformDataSource
{
    public AwsRdsClusterDataSource(string name) : base("aws_rds_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> AvailabilityZones { get; }

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    [TerraformProperty("backtrack_window")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> BacktrackWindow { get; }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformProperty("backup_retention_period")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> BackupRetentionPeriod { get; }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    [TerraformProperty("cluster_members")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ClusterMembers { get; }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [TerraformProperty("cluster_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterResourceId { get; }

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    [TerraformProperty("cluster_scalability_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterScalabilityType { get; }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformProperty("database_insights_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseInsightsMode { get; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformProperty("database_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseName { get; }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("db_cluster_parameter_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DbClusterParameterGroupName { get; }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("db_subnet_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DbSubnetGroupName { get; }

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    [TerraformProperty("db_system_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DbSystemId { get; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformProperty("enabled_cloudwatch_logs_exports")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> EnabledCloudwatchLogsExports { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Engine { get; }

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    [TerraformProperty("engine_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineMode { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformProperty("final_snapshot_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FinalSnapshotIdentifier { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("iam_database_authentication_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IamDatabaseAuthenticationEnabled { get; }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformProperty("iam_roles")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> IamRoles { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformProperty("master_user_secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MasterUserSecret { get; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformProperty("master_username")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MasterUsername { get; }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformProperty("monitoring_interval")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MonitoringInterval { get; }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformProperty("monitoring_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MonitoringRoleArn { get; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkType { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Port { get; }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformProperty("preferred_backup_window")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreferredBackupWindow { get; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreferredMaintenanceWindow { get; }

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformProperty("reader_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReaderEndpoint { get; }

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    [TerraformProperty("replication_source_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReplicationSourceIdentifier { get; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> StorageEncrypted { get; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> VpcSecurityGroupIds { get; }

}
