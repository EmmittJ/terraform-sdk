using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_instance.
/// </summary>
public class AwsDbInstanceDataSource : TerraformDataSource
{
    public AwsDbInstanceDataSource(string name) : base("aws_db_instance", name)
    {
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_identifier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DbInstanceIdentifier { get; set; } = default!;

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
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Address => new TerraformReference(this, "address");

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocatedStorage => new TerraformReference(this, "allocated_storage");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoMinorVersionUpgrade => new TerraformReference(this, "auto_minor_version_upgrade");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BackupRetentionPeriod => new TerraformReference(this, "backup_retention_period");

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    [TerraformPropertyName("ca_cert_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CaCertIdentifier => new TerraformReference(this, "ca_cert_identifier");

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_insights_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseInsightsMode => new TerraformReference(this, "database_insights_mode");

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbClusterIdentifier => new TerraformReference(this, "db_cluster_identifier");

    /// <summary>
    /// The db_instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbInstanceArn => new TerraformReference(this, "db_instance_arn");

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_class")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbInstanceClass => new TerraformReference(this, "db_instance_class");

    /// <summary>
    /// The db_instance_port attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DbInstancePort => new TerraformReference(this, "db_instance_port");

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformPropertyName("db_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbName => new TerraformReference(this, "db_name");

    /// <summary>
    /// The db_parameter_groups attribute.
    /// </summary>
    [TerraformPropertyName("db_parameter_groups")]
    // Output-only attribute - read-only reference
    public TerraformList<string> DbParameterGroups => new TerraformReference(this, "db_parameter_groups");

    /// <summary>
    /// The db_subnet_group attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbSubnetGroup => new TerraformReference(this, "db_subnet_group");

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
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostedZoneId => new TerraformReference(this, "hosted_zone_id");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Iops => new TerraformReference(this, "iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseModel => new TerraformReference(this, "license_model");

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
    /// The max_allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("max_allocated_storage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxAllocatedStorage => new TerraformReference(this, "max_allocated_storage");

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
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MultiAz => new TerraformReference(this, "multi_az");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkType => new TerraformReference(this, "network_type");

    /// <summary>
    /// The option_group_memberships attribute.
    /// </summary>
    [TerraformPropertyName("option_group_memberships")]
    // Output-only attribute - read-only reference
    public TerraformList<string> OptionGroupMemberships => new TerraformReference(this, "option_group_memberships");

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
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PubliclyAccessible => new TerraformReference(this, "publicly_accessible");

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    [TerraformPropertyName("replicate_source_db")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicateSourceDb => new TerraformReference(this, "replicate_source_db");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceId => new TerraformReference(this, "resource_id");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> StorageEncrypted => new TerraformReference(this, "storage_encrypted");

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    [TerraformPropertyName("storage_throughput")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StorageThroughput => new TerraformReference(this, "storage_throughput");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageType => new TerraformReference(this, "storage_type");

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Timezone => new TerraformReference(this, "timezone");

    /// <summary>
    /// The vpc_security_groups attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_groups")]
    // Output-only attribute - read-only reference
    public TerraformList<string> VpcSecurityGroups => new TerraformReference(this, "vpc_security_groups");

}
