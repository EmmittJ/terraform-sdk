using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for serverless_v2_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNeptuneClusterServerlessV2ScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacity
    {
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MinCapacity
    {
        set => SetProperty("min_capacity", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNeptuneClusterTimeoutsBlock : TerraformBlock
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
/// Manages a aws_neptune_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNeptuneCluster : TerraformResource
{
    public AwsNeptuneCluster(string name) : base("aws_neptune_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("cluster_members");
        SetOutput("cluster_resource_id");
        SetOutput("endpoint");
        SetOutput("hosted_zone_id");
        SetOutput("reader_endpoint");
        SetOutput("allow_major_version_upgrade");
        SetOutput("apply_immediately");
        SetOutput("availability_zones");
        SetOutput("backup_retention_period");
        SetOutput("cluster_identifier");
        SetOutput("cluster_identifier_prefix");
        SetOutput("copy_tags_to_snapshot");
        SetOutput("deletion_protection");
        SetOutput("enable_cloudwatch_logs_exports");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("final_snapshot_identifier");
        SetOutput("global_cluster_identifier");
        SetOutput("iam_database_authentication_enabled");
        SetOutput("iam_roles");
        SetOutput("id");
        SetOutput("kms_key_arn");
        SetOutput("neptune_cluster_parameter_group_name");
        SetOutput("neptune_instance_parameter_group_name");
        SetOutput("neptune_subnet_group_name");
        SetOutput("port");
        SetOutput("preferred_backup_window");
        SetOutput("preferred_maintenance_window");
        SetOutput("region");
        SetOutput("replication_source_identifier");
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
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTagsToSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags_to_snapshot");
        set => SetProperty("copy_tags_to_snapshot", value);
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
    /// The enable_cloudwatch_logs_exports attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EnableCloudwatchLogsExports
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("enable_cloudwatch_logs_exports");
        set => SetProperty("enable_cloudwatch_logs_exports", value);
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
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IamDatabaseAuthenticationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("iam_database_authentication_enabled");
        set => SetProperty("iam_database_authentication_enabled", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IamRoles
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("iam_roles");
        set => SetProperty("iam_roles", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The neptune_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> NeptuneClusterParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("neptune_cluster_parameter_group_name");
        set => SetProperty("neptune_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_instance_parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> NeptuneInstanceParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("neptune_instance_parameter_group_name");
        set => SetProperty("neptune_instance_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string> NeptuneSubnetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("neptune_subnet_group_name");
        set => SetProperty("neptune_subnet_group_name", value);
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
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformProperty<string> ReplicationSourceIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_source_identifier");
        set => SetProperty("replication_source_identifier", value);
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
    /// Block for serverless_v2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessV2ScalingConfiguration block(s) allowed")]
    public List<AwsNeptuneClusterServerlessV2ScalingConfigurationBlock>? ServerlessV2ScalingConfiguration
    {
        set => SetProperty("serverless_v2_scaling_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNeptuneClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public TerraformExpression ClusterMembers => this["cluster_members"];

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
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformExpression ReaderEndpoint => this["reader_endpoint"];

}
