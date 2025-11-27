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
        get => new TerraformReference<string>(this, "db_instance_identifier");
        set => SetArgument("db_instance_identifier", value);
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
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
    {
        get => new TerraformReference<string>(this, "address");
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
    {
        get => new TerraformReference<double>(this, "allocated_storage");
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_minor_version_upgrade");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformValue<double> BackupRetentionPeriod
    {
        get => new TerraformReference<double>(this, "backup_retention_period");
    }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformValue<string> CaCertIdentifier
    {
        get => new TerraformReference<string>(this, "ca_cert_identifier");
    }

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformValue<string> DatabaseInsightsMode
    {
        get => new TerraformReference<string>(this, "database_insights_mode");
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string> DbClusterIdentifier
    {
        get => new TerraformReference<string>(this, "db_cluster_identifier");
    }

    /// <summary>
    /// The db_instance_arn attribute.
    /// </summary>
    public TerraformValue<string> DbInstanceArn
    {
        get => new TerraformReference<string>(this, "db_instance_arn");
    }

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    public TerraformValue<string> DbInstanceClass
    {
        get => new TerraformReference<string>(this, "db_instance_class");
    }

    /// <summary>
    /// The db_instance_port attribute.
    /// </summary>
    public TerraformValue<double> DbInstancePort
    {
        get => new TerraformReference<double>(this, "db_instance_port");
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string> DbName
    {
        get => new TerraformReference<string>(this, "db_name");
    }

    /// <summary>
    /// The db_parameter_groups attribute.
    /// </summary>
    public TerraformList<string> DbParameterGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "db_parameter_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The db_subnet_group attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroup
    {
        get => new TerraformReference<string>(this, "db_subnet_group");
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
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
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
    /// The max_allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> MaxAllocatedStorage
    {
        get => new TerraformReference<double>(this, "max_allocated_storage");
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
    /// The multi_az attribute.
    /// </summary>
    public TerraformValue<bool> MultiAz
    {
        get => new TerraformReference<bool>(this, "multi_az");
    }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformValue<string> NetworkType
    {
        get => new TerraformReference<string>(this, "network_type");
    }

    /// <summary>
    /// The option_group_memberships attribute.
    /// </summary>
    public TerraformList<string> OptionGroupMemberships
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "option_group_memberships").ResolveNodes(ctx));
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
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool> PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
    }

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    public TerraformValue<string> ReplicateSourceDb
    {
        get => new TerraformReference<string>(this, "replicate_source_db");
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
    {
        get => new TerraformReference<bool>(this, "storage_encrypted");
    }

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    public TerraformValue<double> StorageThroughput
    {
        get => new TerraformReference<double>(this, "storage_throughput");
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string> Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
    }

    /// <summary>
    /// The vpc_security_groups attribute.
    /// </summary>
    public TerraformList<string> VpcSecurityGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vpc_security_groups").ResolveNodes(ctx));
    }

}
