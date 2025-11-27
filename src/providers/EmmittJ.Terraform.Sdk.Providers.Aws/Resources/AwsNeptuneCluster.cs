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
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MinCapacity
    {
        get => new TerraformReference<double>(this, "min_capacity");
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
        get => new TerraformReference<bool>(this, "allow_major_version_upgrade");
        set => SetArgument("allow_major_version_upgrade", value);
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool> ApplyImmediately
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
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToSnapshot
    {
        get => new TerraformReference<bool>(this, "copy_tags_to_snapshot");
        set => SetArgument("copy_tags_to_snapshot", value);
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
    /// The enable_cloudwatch_logs_exports attribute.
    /// </summary>
    public TerraformSet<string>? EnableCloudwatchLogsExports
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "enable_cloudwatch_logs_exports").ResolveNodes(ctx));
        set => SetArgument("enable_cloudwatch_logs_exports", value);
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
    /// The iam_database_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IamDatabaseAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "iam_database_authentication_enabled");
        set => SetArgument("iam_database_authentication_enabled", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string>? IamRoles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "iam_roles").ResolveNodes(ctx));
        set => SetArgument("iam_roles", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The neptune_cluster_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> NeptuneClusterParameterGroupName
    {
        get => new TerraformReference<string>(this, "neptune_cluster_parameter_group_name");
        set => SetArgument("neptune_cluster_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_instance_parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string>? NeptuneInstanceParameterGroupName
    {
        get => new TerraformReference<string>(this, "neptune_instance_parameter_group_name");
        set => SetArgument("neptune_instance_parameter_group_name", value);
    }

    /// <summary>
    /// The neptune_subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> NeptuneSubnetGroupName
    {
        get => new TerraformReference<string>(this, "neptune_subnet_group_name");
        set => SetArgument("neptune_subnet_group_name", value);
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
    /// The replication_source_identifier attribute.
    /// </summary>
    public TerraformValue<string>? ReplicationSourceIdentifier
    {
        get => new TerraformReference<string>(this, "replication_source_identifier");
        set => SetArgument("replication_source_identifier", value);
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
    public TerraformValue<string> StorageType
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
    /// The cluster_members attribute.
    /// </summary>
    public TerraformSet<string> ClusterMembers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cluster_members").ResolveNodes(ctx));
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
    /// The reader_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpoint
    {
        get => new TerraformReference<string>(this, "reader_endpoint");
    }

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
