using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for serverless_v2_scaling_configuration in AwsNeptuneCluster.
/// Nesting mode: list
/// </summary>
public class AwsNeptuneClusterServerlessV2ScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serverless_v2_scaling_configuration";

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacity
    {
        get => GetArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MinCapacity
    {
        get => GetArgument<TerraformValue<double>>("min_capacity");
        set => SetArgument("min_capacity", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsNeptuneCluster.
/// Nesting mode: single
/// </summary>
public class AwsNeptuneClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_neptune_cluster Terraform resource.
/// Manages a aws_neptune_cluster resource.
/// </summary>
public partial class AwsNeptuneCluster(string name) : TerraformResource("aws_neptune_cluster", name)
{
    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AllowMajorVersionUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("allow_major_version_upgrade") ?? AsReference("allow_major_version_upgrade");
        set => SetArgument("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool> ApplyImmediately
    {
        get => GetArgument<TerraformValue<bool>>("apply_immediately") ?? AsReference("apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
    {
        get => GetArgument<TerraformSet<string>>("availability_zones") ?? AsReference("availability_zones");
        set => SetArgument("availability_zones", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? BackupRetentionPeriod
    {
        get => GetArgument<TerraformValue<double>>("backup_retention_period");
        set => SetArgument("backup_retention_period", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string> ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier") ?? AsReference("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string> ClusterIdentifierPrefix
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier_prefix") ?? AsReference("cluster_identifier_prefix");
        set => SetArgument("cluster_identifier_prefix", value);
    }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToSnapshot
    {
        get => GetArgument<TerraformValue<bool>>("copy_tags_to_snapshot");
        set => SetArgument("copy_tags_to_snapshot", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The enable_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformSet<string>? EnableCloudwatchLogsExports
    {
        get => GetArgument<TerraformSet<string>>("enable_cloudwatch_logs_exports");
        set => SetArgument("enable_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => GetArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version") ?? AsReference("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("final_snapshot_identifier");
        set => SetArgument("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The global_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? GlobalClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("global_cluster_identifier");
        set => SetArgument("global_cluster_identifier", value);
    }

    /// <summary>
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IamDatabaseAuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("iam_database_authentication_enabled");
        set => SetArgument("iam_database_authentication_enabled", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string>? IamRoles
    {
        get => GetArgument<TerraformSet<string>>("iam_roles");
        set => SetArgument("iam_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn") ?? AsReference("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The neptune_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> NeptuneClusterParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("neptune_cluster_parameter_group_name") ?? AsReference("neptune_cluster_parameter_group_name");
        set => SetArgument("neptune_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_instance_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string>? NeptuneInstanceParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("neptune_instance_parameter_group_name");
        set => SetArgument("neptune_instance_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> NeptuneSubnetGroupName
    {
        get => GetArgument<TerraformValue<string>>("neptune_subnet_group_name") ?? AsReference("neptune_subnet_group_name");
        set => SetArgument("neptune_subnet_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredBackupWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_backup_window") ?? AsReference("preferred_backup_window");
        set => SetArgument("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("preferred_maintenance_window") ?? AsReference("preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ReplicationSourceIdentifier
    {
        get => GetArgument<TerraformValue<string>>("replication_source_identifier");
        set => SetArgument("replication_source_identifier", value);
    }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalSnapshot
    {
        get => GetArgument<TerraformValue<bool>>("skip_final_snapshot");
        set => SetArgument("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("snapshot_identifier");
        set => SetArgument("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? StorageEncrypted
    {
        get => GetArgument<TerraformValue<bool>>("storage_encrypted");
        set => SetArgument("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type") ?? AsReference("storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("vpc_security_group_ids") ?? AsReference("vpc_security_group_ids");
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public TerraformSet<string> ClusterMembers
        => AsReference("cluster_members");

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterResourceId
        => AsReference("cluster_resource_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
        => AsReference("hosted_zone_id");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpoint
        => AsReference("reader_endpoint");

    /// <summary>
    /// ServerlessV2ScalingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessV2ScalingConfiguration block(s) allowed")]
    public TerraformList<AwsNeptuneClusterServerlessV2ScalingConfigurationBlock>? ServerlessV2ScalingConfiguration
    {
        get => GetArgument<TerraformList<AwsNeptuneClusterServerlessV2ScalingConfigurationBlock>>("serverless_v2_scaling_configuration");
        set => SetArgument("serverless_v2_scaling_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNeptuneClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNeptuneClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
