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
    public required TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "availability_zones");

    /// <summary>
    /// The backtrack_window attribute.
    /// </summary>
    [TerraformPropertyName("backtrack_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> BacktrackWindow => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "backtrack_window");

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> BackupRetentionPeriod => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "backup_retention_period");

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    [TerraformPropertyName("cluster_members")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ClusterMembers => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "cluster_members");

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_resource_id");

    /// <summary>
    /// The cluster_scalability_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_scalability_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterScalabilityType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_scalability_type");

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_insights_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseInsightsMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_insights_mode");

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformPropertyName("database_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_name");

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_parameter_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbClusterParameterGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_cluster_parameter_group_name");

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbSubnetGroupName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_subnet_group_name");

    /// <summary>
    /// The db_system_id attribute.
    /// </summary>
    [TerraformPropertyName("db_system_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbSystemId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_system_id");

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cloudwatch_logs_exports")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> EnabledCloudwatchLogsExports => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "enabled_cloudwatch_logs_exports");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Engine => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine");

    /// <summary>
    /// The engine_mode attribute.
    /// </summary>
    [TerraformPropertyName("engine_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_mode");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FinalSnapshotIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "final_snapshot_identifier");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosted_zone_id");

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("iam_database_authentication_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IamDatabaseAuthenticationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "iam_database_authentication_enabled");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    [TerraformPropertyName("iam_roles")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> IamRoles => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MasterUserSecret => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "master_user_secret");

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformPropertyName("master_username")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterUsername => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_username");

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_interval")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MonitoringInterval => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "monitoring_interval");

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonitoringRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monitoring_role_arn");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_type");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_backup_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredBackupWindow => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_backup_window");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredMaintenanceWindow => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_maintenance_window");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("reader_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReaderEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reader_endpoint");

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    [TerraformPropertyName("replication_source_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReplicationSourceIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "replication_source_identifier");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> StorageEncrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "storage_encrypted");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

}
