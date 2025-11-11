using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_instance.
/// </summary>
public partial class AwsDbInstanceDataSource : TerraformDataSource
{
    public AwsDbInstanceDataSource(string name) : base("aws_db_instance", name)
    {
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    [TerraformProperty("db_instance_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DbInstanceIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformProperty("address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Address { get; }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformProperty("allocated_storage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AllocatedStorage { get; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutoMinorVersionUpgrade { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformProperty("backup_retention_period")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> BackupRetentionPeriod { get; }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    [TerraformProperty("ca_cert_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CaCertIdentifier { get; }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformProperty("database_insights_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DatabaseInsightsMode { get; }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("db_cluster_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbClusterIdentifier { get; }

    /// <summary>
    /// The db_instance_arn attribute.
    /// </summary>
    [TerraformProperty("db_instance_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbInstanceArn { get; }

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    [TerraformProperty("db_instance_class")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbInstanceClass { get; }

    /// <summary>
    /// The db_instance_port attribute.
    /// </summary>
    [TerraformProperty("db_instance_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DbInstancePort { get; }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformProperty("db_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbName { get; }

    /// <summary>
    /// The db_parameter_groups attribute.
    /// </summary>
    [TerraformProperty("db_parameter_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> DbParameterGroups { get; }

    /// <summary>
    /// The db_subnet_group attribute.
    /// </summary>
    [TerraformProperty("db_subnet_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbSubnetGroup { get; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformProperty("enabled_cloudwatch_logs_exports")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> EnabledCloudwatchLogsExports { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Engine { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Iops { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformProperty("license_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LicenseModel { get; }

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformProperty("master_user_secret")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MasterUserSecret { get; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformProperty("master_username")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MasterUsername { get; }

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    [TerraformProperty("max_allocated_storage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxAllocatedStorage { get; }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformProperty("monitoring_interval")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MonitoringInterval { get; }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformProperty("monitoring_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MonitoringRoleArn { get; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformProperty("multi_az")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MultiAz { get; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkType { get; }

    /// <summary>
    /// The option_group_memberships attribute.
    /// </summary>
    [TerraformProperty("option_group_memberships")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OptionGroupMemberships { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformProperty("preferred_backup_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreferredBackupWindow { get; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreferredMaintenanceWindow { get; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PubliclyAccessible { get; }

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    [TerraformProperty("replicate_source_db")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReplicateSourceDb { get; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> StorageEncrypted { get; }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    [TerraformProperty("storage_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> StorageThroughput { get; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageType { get; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformProperty("timezone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Timezone { get; }

    /// <summary>
    /// The vpc_security_groups attribute.
    /// </summary>
    [TerraformProperty("vpc_security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> VpcSecurityGroups { get; }

}
