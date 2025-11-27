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
        get => new TerraformReference<string>(this, "acl_name");
        set => SetArgument("acl_name", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMinorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    public TerraformValue<bool>? DataTiering
    {
        get => new TerraformReference<bool>(this, "data_tiering");
        set => SetArgument("data_tiering", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
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
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformValue<string>? FinalSnapshotName
    {
        get => new TerraformReference<string>(this, "final_snapshot_name");
        set => SetArgument("final_snapshot_name", value);
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
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
    {
        get => new TerraformReference<string>(this, "maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    public TerraformValue<string>? MultiRegionClusterName
    {
        get => new TerraformReference<string>(this, "multi_region_cluster_name");
        set => SetArgument("multi_region_cluster_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    public TerraformValue<double>? NumReplicasPerShard
    {
        get => new TerraformReference<double>(this, "num_replicas_per_shard");
        set => SetArgument("num_replicas_per_shard", value);
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformValue<double>? NumShards
    {
        get => new TerraformReference<double>(this, "num_shards");
        set => SetArgument("num_shards", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
    {
        get => new TerraformReference<string>(this, "parameter_group_name");
        set => SetArgument("parameter_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public TerraformList<string>? SnapshotArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "snapshot_arns").ResolveNodes(ctx));
        set => SetArgument("snapshot_arns", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotName
    {
        get => new TerraformReference<string>(this, "snapshot_name");
        set => SetArgument("snapshot_name", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
    {
        get => new TerraformReference<double>(this, "snapshot_retention_limit");
        set => SetArgument("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
    {
        get => new TerraformReference<string>(this, "snapshot_window");
        set => SetArgument("snapshot_window", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? SnsTopicArn
    {
        get => new TerraformReference<string>(this, "sns_topic_arn");
        set => SetArgument("sns_topic_arn", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
    {
        get => new TerraformReference<string>(this, "subnet_group_name");
        set => SetArgument("subnet_group_name", value);
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
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TlsEnabled
    {
        get => new TerraformReference<bool>(this, "tls_enabled");
        set => SetArgument("tls_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterEndpoint
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cluster_endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    public TerraformValue<string> EnginePatchVersion
    {
        get => new TerraformReference<string>(this, "engine_patch_version");
    }

    /// <summary>
    /// The shards attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Shards
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "shards").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMemorydbClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMemorydbClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
