using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_instance.
/// </summary>
public class AwsDbInstanceDataSource : TerraformDataSource
{
    public AwsDbInstanceDataSource(string name) : base("aws_db_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("address");
        this.WithOutput("allocated_storage");
        this.WithOutput("auto_minor_version_upgrade");
        this.WithOutput("availability_zone");
        this.WithOutput("backup_retention_period");
        this.WithOutput("ca_cert_identifier");
        this.WithOutput("database_insights_mode");
        this.WithOutput("db_cluster_identifier");
        this.WithOutput("db_instance_arn");
        this.WithOutput("db_instance_class");
        this.WithOutput("db_instance_port");
        this.WithOutput("db_name");
        this.WithOutput("db_parameter_groups");
        this.WithOutput("db_subnet_group");
        this.WithOutput("enabled_cloudwatch_logs_exports");
        this.WithOutput("endpoint");
        this.WithOutput("engine");
        this.WithOutput("engine_version");
        this.WithOutput("hosted_zone_id");
        this.WithOutput("iops");
        this.WithOutput("kms_key_id");
        this.WithOutput("license_model");
        this.WithOutput("master_user_secret");
        this.WithOutput("master_username");
        this.WithOutput("max_allocated_storage");
        this.WithOutput("monitoring_interval");
        this.WithOutput("monitoring_role_arn");
        this.WithOutput("multi_az");
        this.WithOutput("network_type");
        this.WithOutput("option_group_memberships");
        this.WithOutput("port");
        this.WithOutput("preferred_backup_window");
        this.WithOutput("preferred_maintenance_window");
        this.WithOutput("publicly_accessible");
        this.WithOutput("replicate_source_db");
        this.WithOutput("resource_id");
        this.WithOutput("storage_encrypted");
        this.WithOutput("storage_throughput");
        this.WithOutput("storage_type");
        this.WithOutput("timezone");
        this.WithOutput("vpc_security_groups");
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DbInstanceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_instance_identifier");
        set => this.WithProperty("db_instance_identifier", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformExpression Address => this["address"];

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformExpression AllocatedStorage => this["allocated_storage"];

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformExpression AutoMinorVersionUpgrade => this["auto_minor_version_upgrade"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformExpression BackupRetentionPeriod => this["backup_retention_period"];

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    public TerraformExpression CaCertIdentifier => this["ca_cert_identifier"];

    /// <summary>
    /// The database_insights_mode attribute.
    /// </summary>
    public TerraformExpression DatabaseInsightsMode => this["database_insights_mode"];

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    public TerraformExpression DbClusterIdentifier => this["db_cluster_identifier"];

    /// <summary>
    /// The db_instance_arn attribute.
    /// </summary>
    public TerraformExpression DbInstanceArn => this["db_instance_arn"];

    /// <summary>
    /// The db_instance_class attribute.
    /// </summary>
    public TerraformExpression DbInstanceClass => this["db_instance_class"];

    /// <summary>
    /// The db_instance_port attribute.
    /// </summary>
    public TerraformExpression DbInstancePort => this["db_instance_port"];

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformExpression DbName => this["db_name"];

    /// <summary>
    /// The db_parameter_groups attribute.
    /// </summary>
    public TerraformExpression DbParameterGroups => this["db_parameter_groups"];

    /// <summary>
    /// The db_subnet_group attribute.
    /// </summary>
    public TerraformExpression DbSubnetGroup => this["db_subnet_group"];

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformExpression EnabledCloudwatchLogsExports => this["enabled_cloudwatch_logs_exports"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformExpression Iops => this["iops"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformExpression MasterUserSecret => this["master_user_secret"];

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformExpression MasterUsername => this["master_username"];

    /// <summary>
    /// The max_allocated_storage attribute.
    /// </summary>
    public TerraformExpression MaxAllocatedStorage => this["max_allocated_storage"];

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    public TerraformExpression MonitoringInterval => this["monitoring_interval"];

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    public TerraformExpression MonitoringRoleArn => this["monitoring_role_arn"];

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    public TerraformExpression MultiAz => this["multi_az"];

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    public TerraformExpression NetworkType => this["network_type"];

    /// <summary>
    /// The option_group_memberships attribute.
    /// </summary>
    public TerraformExpression OptionGroupMemberships => this["option_group_memberships"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformExpression PreferredBackupWindow => this["preferred_backup_window"];

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformExpression PreferredMaintenanceWindow => this["preferred_maintenance_window"];

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformExpression PubliclyAccessible => this["publicly_accessible"];

    /// <summary>
    /// The replicate_source_db attribute.
    /// </summary>
    public TerraformExpression ReplicateSourceDb => this["replicate_source_db"];

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformExpression StorageEncrypted => this["storage_encrypted"];

    /// <summary>
    /// The storage_throughput attribute.
    /// </summary>
    public TerraformExpression StorageThroughput => this["storage_throughput"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformExpression Timezone => this["timezone"];

    /// <summary>
    /// The vpc_security_groups attribute.
    /// </summary>
    public TerraformExpression VpcSecurityGroups => this["vpc_security_groups"];

}
