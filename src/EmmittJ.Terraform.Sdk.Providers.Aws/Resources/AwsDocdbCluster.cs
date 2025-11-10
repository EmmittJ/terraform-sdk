using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public class AwsDocdbClusterRestoreToPointInTimeBlock : TerraformBlock
{
    /// <summary>
    /// The restore_to_time attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreToTime
    {
        get => GetProperty<TerraformProperty<string>>("restore_to_time");
        set => WithProperty("restore_to_time", value);
    }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreType
    {
        get => GetProperty<TerraformProperty<string>>("restore_type");
        set => WithProperty("restore_type", value);
    }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceClusterIdentifier is required")]
    public required TerraformProperty<string> SourceClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("source_cluster_identifier");
        set => WithProperty("source_cluster_identifier", value);
    }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    public TerraformProperty<bool>? UseLatestRestorableTime
    {
        get => GetProperty<TerraformProperty<bool>>("use_latest_restorable_time");
        set => WithProperty("use_latest_restorable_time", value);
    }

}

/// <summary>
/// Block type for serverless_v2_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsDocdbClusterServerlessV2ScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformProperty<double> MaxCapacity
    {
        get => GetProperty<TerraformProperty<double>>("max_capacity");
        set => WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        get => GetProperty<TerraformProperty<double>>("min_capacity");
        set => WithProperty("min_capacity", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDocdbClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_docdb_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDocdbCluster : TerraformResource
{
    public AwsDocdbCluster(string name) : base("aws_docdb_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cluster_resource_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("master_user_secret");
        this.DeclareOutput("reader_endpoint");
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowMajorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("allow_major_version_upgrade");
        set => this.WithProperty("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AvailabilityZones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformProperty<double>? BackupRetentionPeriod
    {
        get => GetProperty<TerraformProperty<double>>("backup_retention_period");
        set => this.WithProperty("backup_retention_period", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifierPrefix
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier_prefix");
        set => this.WithProperty("cluster_identifier_prefix", value);
    }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ClusterMembers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cluster_members");
        set => this.WithProperty("cluster_members", value);
    }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? DbClusterParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("db_cluster_parameter_group_name");
        set => this.WithProperty("db_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? DbSubnetGroupName
    {
        get => GetProperty<TerraformProperty<string>>("db_subnet_group_name");
        set => this.WithProperty("db_subnet_group_name", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EnabledCloudwatchLogsExports
    {
        get => GetProperty<List<TerraformProperty<string>>>("enabled_cloudwatch_logs_exports");
        set => this.WithProperty("enabled_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? FinalSnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("final_snapshot_identifier");
        set => this.WithProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The global_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("global_cluster_identifier");
        set => this.WithProperty("global_cluster_identifier", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformProperty<bool>? ManageMasterUserPassword
    {
        get => GetProperty<TerraformProperty<bool>>("manage_master_user_password");
        set => this.WithProperty("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformProperty<string>? MasterPassword
    {
        get => GetProperty<TerraformProperty<string>>("master_password");
        set => this.WithProperty("master_password", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformProperty<string>? MasterPasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("master_password_wo");
        set => this.WithProperty("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? MasterPasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("master_password_wo_version");
        set => this.WithProperty("master_password_wo_version", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformProperty<string>? MasterUsername
    {
        get => GetProperty<TerraformProperty<string>>("master_username");
        set => this.WithProperty("master_username", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredBackupWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_backup_window");
        set => this.WithProperty("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredMaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("preferred_maintenance_window");
        set => this.WithProperty("preferred_maintenance_window", value);
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
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipFinalSnapshot
    {
        get => GetProperty<TerraformProperty<bool>>("skip_final_snapshot");
        set => this.WithProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_identifier");
        set => this.WithProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool>? StorageEncrypted
    {
        get => GetProperty<TerraformProperty<bool>>("storage_encrypted");
        set => this.WithProperty("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    public List<AwsDocdbClusterRestoreToPointInTimeBlock>? RestoreToPointInTime
    {
        get => GetProperty<List<AwsDocdbClusterRestoreToPointInTimeBlock>>("restore_to_point_in_time");
        set => this.WithProperty("restore_to_point_in_time", value);
    }

    /// <summary>
    /// Block for serverless_v2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessV2ScalingConfiguration block(s) allowed")]
    public List<AwsDocdbClusterServerlessV2ScalingConfigurationBlock>? ServerlessV2ScalingConfiguration
    {
        get => GetProperty<List<AwsDocdbClusterServerlessV2ScalingConfigurationBlock>>("serverless_v2_scaling_configuration");
        set => this.WithProperty("serverless_v2_scaling_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDocdbClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDocdbClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformExpression ClusterResourceId => this["cluster_resource_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformExpression MasterUserSecret => this["master_user_secret"];

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformExpression ReaderEndpoint => this["reader_endpoint"];

}
