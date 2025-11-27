using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for restore_to_point_in_time in AwsDocdbCluster.
/// Nesting mode: list
/// </summary>
public class AwsDocdbClusterRestoreToPointInTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_to_point_in_time";

    /// <summary>
    /// The restore_to_time attribute.
    /// </summary>
    public TerraformValue<string>? RestoreToTime
    {
        get => new TerraformReference<string>(this, "restore_to_time");
        set => SetArgument("restore_to_time", value);
    }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    public TerraformValue<string>? RestoreType
    {
        get => new TerraformReference<string>(this, "restore_type");
        set => SetArgument("restore_type", value);
    }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceClusterIdentifier is required")]
    public required TerraformValue<string> SourceClusterIdentifier
    {
        get => new TerraformReference<string>(this, "source_cluster_identifier");
        set => SetArgument("source_cluster_identifier", value);
    }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    public TerraformValue<bool>? UseLatestRestorableTime
    {
        get => new TerraformReference<bool>(this, "use_latest_restorable_time");
        set => SetArgument("use_latest_restorable_time", value);
    }

}


/// <summary>
/// Block type for serverless_v2_scaling_configuration in AwsDocdbCluster.
/// Nesting mode: list
/// </summary>
public class AwsDocdbClusterServerlessV2ScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serverless_v2_scaling_configuration";

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformValue<double> MaxCapacity
    {
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => new TerraformReference<double>(this, "min_capacity");
        set => SetArgument("min_capacity", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDocdbCluster.
/// Nesting mode: single
/// </summary>
public class AwsDocdbClusterTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_docdb_cluster Terraform resource.
/// Manages a aws_docdb_cluster resource.
/// </summary>
public partial class AwsDocdbCluster(string name) : TerraformResource("aws_docdb_cluster", name)
{
    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AllowMajorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "allow_major_version_upgrade");
        set => SetArgument("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyImmediately
    {
        get => new TerraformReference<bool>(this, "apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "availability_zones").ResolveNodes(ctx));
        set => SetArgument("availability_zones", value);
    }

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    public TerraformValue<double>? BackupRetentionPeriod
    {
        get => new TerraformReference<double>(this, "backup_retention_period");
        set => SetArgument("backup_retention_period", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string> ClusterIdentifier
    {
        get => new TerraformReference<string>(this, "cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    public TerraformValue<string> ClusterIdentifierPrefix
    {
        get => new TerraformReference<string>(this, "cluster_identifier_prefix");
        set => SetArgument("cluster_identifier_prefix", value);
    }

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    public TerraformSet<string> ClusterMembers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cluster_members").ResolveNodes(ctx));
        set => SetArgument("cluster_members", value);
    }

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbClusterParameterGroupName
    {
        get => new TerraformReference<string>(this, "db_cluster_parameter_group_name");
        set => SetArgument("db_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> DbSubnetGroupName
    {
        get => new TerraformReference<string>(this, "db_subnet_group_name");
        set => SetArgument("db_subnet_group_name", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformList<string>? EnabledCloudwatchLogsExports
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "enabled_cloudwatch_logs_exports").ResolveNodes(ctx));
        set => SetArgument("enabled_cloudwatch_logs_exports", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "final_snapshot_identifier");
        set => SetArgument("final_snapshot_identifier", value);
    }

    /// <summary>
    /// The global_cluster_identifier attribute.
    /// </summary>
    public TerraformValue<string>? GlobalClusterIdentifier
    {
        get => new TerraformReference<string>(this, "global_cluster_identifier");
        set => SetArgument("global_cluster_identifier", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    public TerraformValue<bool>? ManageMasterUserPassword
    {
        get => new TerraformReference<bool>(this, "manage_master_user_password");
        set => SetArgument("manage_master_user_password", value);
    }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    public TerraformValue<string>? MasterPassword
    {
        get => new TerraformReference<string>(this, "master_password");
        set => SetArgument("master_password", value);
    }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? MasterPasswordWo
    {
        get => new TerraformReference<string>(this, "master_password_wo");
        set => SetArgument("master_password_wo", value);
    }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? MasterPasswordWoVersion
    {
        get => new TerraformReference<double>(this, "master_password_wo_version");
        set => SetArgument("master_password_wo_version", value);
    }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    public TerraformValue<string> MasterUsername
    {
        get => new TerraformReference<string>(this, "master_username");
        set => SetArgument("master_username", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredBackupWindow
    {
        get => new TerraformReference<string>(this, "preferred_backup_window");
        set => SetArgument("preferred_backup_window", value);
    }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> PreferredMaintenanceWindow
    {
        get => new TerraformReference<string>(this, "preferred_maintenance_window");
        set => SetArgument("preferred_maintenance_window", value);
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
    /// The skip_final_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalSnapshot
    {
        get => new TerraformReference<bool>(this, "skip_final_snapshot");
        set => SetArgument("skip_final_snapshot", value);
    }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "snapshot_identifier");
        set => SetArgument("snapshot_identifier", value);
    }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? StorageEncrypted
    {
        get => new TerraformReference<bool>(this, "storage_encrypted");
        set => SetArgument("storage_encrypted", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    public TerraformValue<string> ClusterResourceId
    {
        get => new TerraformReference<string>(this, "cluster_resource_id");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
    }

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MasterUserSecret
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "master_user_secret").ResolveNodes(ctx));
    }

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpoint
    {
        get => new TerraformReference<string>(this, "reader_endpoint");
    }

    /// <summary>
    /// RestoreToPointInTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    public TerraformList<AwsDocdbClusterRestoreToPointInTimeBlock>? RestoreToPointInTime
    {
        get => GetArgument<TerraformList<AwsDocdbClusterRestoreToPointInTimeBlock>>("restore_to_point_in_time");
        set => SetArgument("restore_to_point_in_time", value);
    }

    /// <summary>
    /// ServerlessV2ScalingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessV2ScalingConfiguration block(s) allowed")]
    public TerraformList<AwsDocdbClusterServerlessV2ScalingConfigurationBlock>? ServerlessV2ScalingConfiguration
    {
        get => GetArgument<TerraformList<AwsDocdbClusterServerlessV2ScalingConfigurationBlock>>("serverless_v2_scaling_configuration");
        set => SetArgument("serverless_v2_scaling_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDocdbClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDocdbClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
