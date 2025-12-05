using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsMemorydbCluster.
/// Nesting mode: single
/// </summary>
public class AwsMemorydbClusterTimeoutsBlock : TerraformBlock
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
/// Represents a aws_memorydb_cluster Terraform resource.
/// Manages a aws_memorydb_cluster resource.
/// </summary>
public partial class AwsMemorydbCluster(string name) : TerraformResource("aws_memorydb_cluster", name)
{
    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AclName is required")]
    public required TerraformValue<string> AclName
    {
        get => GetRequiredArgument<TerraformValue<string>>("acl_name");
        set => SetArgument("acl_name", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMinorVersionUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    public TerraformValue<bool>? DataTiering
    {
        get => GetArgument<TerraformValue<bool>>("data_tiering");
        set => SetArgument("data_tiering", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => GetArgument<TerraformValue<string>>("engine") ?? CreateReference("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => GetArgument<TerraformValue<string>>("engine_version") ?? CreateReference("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotName
    {
        get => GetArgument<TerraformValue<string>>("final_snapshot_name");
        set => SetArgument("final_snapshot_name", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
    {
        get => GetArgument<TerraformValue<string>>("maintenance_window") ?? CreateReference("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    public TerraformValue<string>? MultiRegionClusterName
    {
        get => GetArgument<TerraformValue<string>>("multi_region_cluster_name");
        set => SetArgument("multi_region_cluster_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? CreateReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    public TerraformValue<double>? NumReplicasPerShard
    {
        get => GetArgument<TerraformValue<double>>("num_replicas_per_shard");
        set => SetArgument("num_replicas_per_shard", value);
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformValue<double>? NumShards
    {
        get => GetArgument<TerraformValue<double>>("num_shards");
        set => SetArgument("num_shards", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
    {
        get => GetArgument<TerraformValue<string>>("parameter_group_name") ?? CreateReference("parameter_group_name");
        set => SetArgument("parameter_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? CreateReference("port");
        set => SetArgument("port", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public TerraformList<string>? SnapshotArns
    {
        get => GetArgument<TerraformList<string>>("snapshot_arns");
        set => SetArgument("snapshot_arns", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotName
    {
        get => GetArgument<TerraformValue<string>>("snapshot_name");
        set => SetArgument("snapshot_name", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
    {
        get => GetArgument<TerraformValue<double>>("snapshot_retention_limit") ?? CreateReference("snapshot_retention_limit");
        set => SetArgument("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
    {
        get => GetArgument<TerraformValue<string>>("snapshot_window") ?? CreateReference("snapshot_window");
        set => SetArgument("snapshot_window", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? SnsTopicArn
    {
        get => GetArgument<TerraformValue<string>>("sns_topic_arn");
        set => SetArgument("sns_topic_arn", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
    {
        get => GetArgument<TerraformValue<string>>("subnet_group_name") ?? CreateReference("subnet_group_name");
        set => SetArgument("subnet_group_name", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("tls_enabled");
        set => SetArgument("tls_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterEndpoint
        => CreateReference("cluster_endpoint");

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    public TerraformValue<string> EnginePatchVersion
        => CreateReference("engine_patch_version");

    /// <summary>
    /// The shards attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Shards
        => CreateReference("shards");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMemorydbClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMemorydbClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
