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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbInstanceIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_instance_identifier");

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
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address");

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AllocatedStorage => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "allocated_storage");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoMinorVersionUpgrade => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_minor_version_upgrade");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> BackupRetentionPeriod => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "backup_retention_period");

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    [TerraformPropertyName("ca_cert_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CaCertIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ca_cert_identifier");

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    [TerraformPropertyName("database_insights_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseInsightsMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_insights_mode");

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbClusterIdentifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_cluster_identifier");

    /// <summary>
    /// The db_instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbInstanceArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_instance_arn");

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_class")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbInstanceClass => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_instance_class");

    /// <summary>
    /// The db_instance_port attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbInstancePort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_instance_port");

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformPropertyName("db_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_name");

    /// <summary>
    /// The db_parameter_groups attribute.
    /// </summary>
    [TerraformPropertyName("db_parameter_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DbParameterGroups => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "db_parameter_groups");

    /// <summary>
    /// The db_subnet_group attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbSubnetGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_subnet_group");

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
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosted_zone_id");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Iops => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

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
    /// The max_allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("max_allocated_storage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxAllocatedStorage => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_allocated_storage");

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
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MultiAz => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_az");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_type");

    /// <summary>
    /// The option_group_memberships attribute.
    /// </summary>
    [TerraformPropertyName("option_group_memberships")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OptionGroupMemberships => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "option_group_memberships");

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
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PubliclyAccessible => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "publicly_accessible");

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    [TerraformPropertyName("replicate_source_db")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReplicateSourceDb => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "replicate_source_db");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_id");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> StorageEncrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "storage_encrypted");

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    [TerraformPropertyName("storage_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageThroughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_throughput");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Timezone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "timezone");

    /// <summary>
    /// The vpc_security_groups attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VpcSecurityGroups => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "vpc_security_groups");

}
