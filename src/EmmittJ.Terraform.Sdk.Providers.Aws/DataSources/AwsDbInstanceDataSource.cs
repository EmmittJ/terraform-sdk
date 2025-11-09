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
        this.DeclareOutput("address");
        this.DeclareOutput("allocated_storage");
        this.DeclareOutput("auto_minor_version_upgrade");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("backup_retention_period");
        this.DeclareOutput("ca_cert_identifier");
        this.DeclareOutput("database_insights_mode");
        this.DeclareOutput("db_cluster_identifier");
        this.DeclareOutput("db_instance_arn");
        this.DeclareOutput("db_instance_class");
        this.DeclareOutput("db_instance_port");
        this.DeclareOutput("db_name");
        this.DeclareOutput("db_parameter_groups");
        this.DeclareOutput("db_subnet_group");
        this.DeclareOutput("enabled_cloudwatch_logs_exports");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("engine");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("iops");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("license_model");
        this.DeclareOutput("master_user_secret");
        this.DeclareOutput("master_username");
        this.DeclareOutput("max_allocated_storage");
        this.DeclareOutput("monitoring_interval");
        this.DeclareOutput("monitoring_role_arn");
        this.DeclareOutput("multi_az");
        this.DeclareOutput("network_type");
        this.DeclareOutput("option_group_memberships");
        this.DeclareOutput("port");
        this.DeclareOutput("preferred_backup_window");
        this.DeclareOutput("preferred_maintenance_window");
        this.DeclareOutput("publicly_accessible");
        this.DeclareOutput("replicate_source_db");
        this.DeclareOutput("resource_id");
        this.DeclareOutput("storage_encrypted");
        this.DeclareOutput("storage_throughput");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("timezone");
        this.DeclareOutput("vpc_security_groups");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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
