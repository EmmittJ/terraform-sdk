using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_db_instance Terraform data source.
/// Retrieves information about a aws_db_instance.
/// </summary>
public partial class AwsDbInstanceDataSource(string name) : TerraformDataSource("aws_db_instance", name)
{
    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    public TerraformValue<string> DbInstanceIdentifier
    {
        get => GetArgument<TerraformValue<string>>("db_instance_identifier") ?? CreateReference("db_instance_identifier");
        set => SetArgument("db_instance_identifier", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
        => CreateReference("address");

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
        => CreateReference("allocated_storage");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
        => CreateReference("auto_minor_version_upgrade");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => CreateReference("availability_zone");

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriod
        => CreateReference("backup_retention_period");

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformValue<string> CaCertIdentifier
        => CreateReference("ca_cert_identifier");

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformValue<string> DatabaseInsightsMode
        => CreateReference("database_insights_mode");

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string> DbClusterIdentifier
        => CreateReference("db_cluster_identifier");

    /// <summary>
    /// The db_instance_arn attribute.
    /// </summary>
    public TerraformValue<string> DbInstanceArn
        => CreateReference("db_instance_arn");

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    public TerraformValue<string> DbInstanceClass
        => CreateReference("db_instance_class");

    /// <summary>
    /// The db_instance_port attribute.
    /// </summary>
    public TerraformValue<double> DbInstancePort
        => CreateReference("db_instance_port");

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string> DbName
        => CreateReference("db_name");

    /// <summary>
    /// The db_parameter_groups attribute.
    /// </summary>
    public TerraformList<string> DbParameterGroups
        => CreateReference("db_parameter_groups");

    /// <summary>
    /// The db_subnet_group attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroup
        => CreateReference("db_subnet_group");

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformList<string> EnabledCloudwatchLogsExports
        => CreateReference("enabled_cloudwatch_logs_exports");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => CreateReference("engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => CreateReference("engine_version");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
        => CreateReference("hosted_zone_id");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
        => CreateReference("iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => CreateReference("kms_key_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
        => CreateReference("license_model");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterUserSecret
        => CreateReference("master_user_secret");

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string> MasterUsername
        => CreateReference("master_username");

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> MaxAllocatedStorage
        => CreateReference("max_allocated_storage");

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformValue<double> MonitoringInterval
        => CreateReference("monitoring_interval");

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformValue<string> MonitoringRoleArn
        => CreateReference("monitoring_role_arn");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
        => CreateReference("multi_az");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
        => CreateReference("network_type");

    /// <summary>
    /// The option_group_memberships attribute.
    /// </summary>
    public TerraformList<string> OptionGroupMemberships
        => CreateReference("option_group_memberships");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => CreateReference("port");

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredBackupWindow
        => CreateReference("preferred_backup_window");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
        => CreateReference("preferred_maintenance_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
        => CreateReference("publicly_accessible");

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    public TerraformValue<string> ReplicateSourceDb
        => CreateReference("replicate_source_db");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
        => CreateReference("resource_id");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
        => CreateReference("storage_encrypted");

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    public TerraformValue<double> StorageThroughput
        => CreateReference("storage_throughput");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
        => CreateReference("storage_type");

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string> Timezone
        => CreateReference("timezone");

    /// <summary>
    /// The vpc_security_groups attribute.
    /// </summary>
    public TerraformList<string> VpcSecurityGroups
        => CreateReference("vpc_security_groups");

}
