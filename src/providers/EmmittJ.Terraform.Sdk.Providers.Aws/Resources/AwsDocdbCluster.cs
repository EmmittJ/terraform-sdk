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
        set => SetProperty("restore_to_time", value);
    }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    public TerraformProperty<string>? RestoreType
    {
        set => SetProperty("restore_type", value);
    }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceClusterIdentifier is required")]
    public required TerraformProperty<string> SourceClusterIdentifier
    {
        set => SetProperty("source_cluster_identifier", value);
    }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    public TerraformProperty<bool>? UseLatestRestorableTime
    {
        set => SetProperty("use_latest_restorable_time", value);
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
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformProperty<double> MinCapacity
    {
        set => SetProperty("min_capacity", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("cluster_resource_id");
        SetOutput("endpoint");
        SetOutput("hosted_zone_id");
        SetOutput("master_user_secret");
        SetOutput("reader_endpoint");
        SetOutput("allow_major_version_upgrade");
        SetOutput("apply_immediately");
        SetOutput("availability_zones");
        SetOutput("backup_retention_period");
        SetOutput("cluster_identifier");
        SetOutput("cluster_identifier_prefix");
        SetOutput("cluster_members");
        SetOutput("db_cluster_parameter_group_name");
        SetOutput("db_subnet_group_name");
        SetOutput("deletion_protection");
        SetOutput("enabled_cloudwatch_logs_exports");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("final_snapshot_identifier");
        SetOutput("global_cluster_identifier");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("manage_master_user_password");
        SetOutput("master_password");
        SetOutput("master_password_wo");
        SetOutput("master_password_wo_version");
        SetOutput("master_username");
        SetOutput("port");
        SetOutput("preferred_backup_window");
        SetOutput("preferred_maintenance_window");
        SetOutput("region");
        SetOutput("skip_final_snapshot");
        SetOutput("snapshot_identifier");
        SetOutput("storage_encrypted");
        SetOutput("storage_type");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_security_group_ids");
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AllowMajorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_major_version_upgrade");
        set => SetProperty("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_immediately");
        set => SetProperty("apply_immediately", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AvailabilityZones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("availability_zones");
        set => SetProperty("availability_zones", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformProperty<double> BackupRetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("backup_retention_period");
        set => SetProperty("backup_retention_period", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public TerraformProperty<string> ClusterIdentifierPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier_prefix");
        set => SetProperty("cluster_identifier_prefix", value);
    }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ClusterMembers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("cluster_members");
        set => SetProperty("cluster_members", value);
    }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> DbClusterParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_cluster_parameter_group_name");
        set => SetProperty("db_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string> DbSubnetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_subnet_group_name");
        set => SetProperty("db_subnet_group_name", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public List<TerraformProperty<string>> EnabledCloudwatchLogsExports
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("enabled_cloudwatch_logs_exports");
        set => SetProperty("enabled_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string> FinalSnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("final_snapshot_identifier");
        set => SetProperty("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The global_cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string> GlobalClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_cluster_identifier");
        set => SetProperty("global_cluster_identifier", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformProperty<bool> ManageMasterUserPassword
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("manage_master_user_password");
        set => SetProperty("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformProperty<string> MasterPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_password");
        set => SetProperty("master_password", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformProperty<string> MasterPasswordWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_password_wo");
        set => SetProperty("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> MasterPasswordWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("master_password_wo_version");
        set => SetProperty("master_password_wo_version", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformProperty<string> MasterUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("master_username");
        set => SetProperty("master_username", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredBackupWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_backup_window");
        set => SetProperty("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> PreferredMaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_maintenance_window");
        set => SetProperty("preferred_maintenance_window", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool> SkipFinalSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_final_snapshot");
        set => SetProperty("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_identifier");
        set => SetProperty("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformProperty<bool> StorageEncrypted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("storage_encrypted");
        set => SetProperty("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_type");
        set => SetProperty("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    public List<AwsDocdbClusterRestoreToPointInTimeBlock>? RestoreToPointInTime
    {
        set => SetProperty("restore_to_point_in_time", value);
    }

    /// <summary>
    /// Block for serverless_v2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessV2ScalingConfiguration block(s) allowed")]
    public List<AwsDocdbClusterServerlessV2ScalingConfigurationBlock>? ServerlessV2ScalingConfiguration
    {
        set => SetProperty("serverless_v2_scaling_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDocdbClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
