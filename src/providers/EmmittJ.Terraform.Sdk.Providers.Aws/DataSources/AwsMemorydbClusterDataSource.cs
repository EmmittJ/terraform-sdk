using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_memorydb_cluster Terraform data source.
/// Retrieves information about a aws_memorydb_cluster.
/// </summary>
public partial class AwsMemorydbClusterDataSource(string name) : TerraformDataSource("aws_memorydb_cluster", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    public TerraformValue<string> AclName
    {
        get => new TerraformReference<string>(this, "acl_name");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_minor_version_upgrade");
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterEndpoint
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cluster_endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    public TerraformValue<bool> DataTiering
    {
        get => new TerraformReference<bool>(this, "data_tiering");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
    }

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    public TerraformValue<string> EnginePatchVersion
    {
        get => new TerraformReference<string>(this, "engine_patch_version");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformValue<string> FinalSnapshotName
    {
        get => new TerraformReference<string>(this, "final_snapshot_name");
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
    {
        get => new TerraformReference<string>(this, "maintenance_window");
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
    }

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    public TerraformValue<double> NumReplicasPerShard
    {
        get => new TerraformReference<double>(this, "num_replicas_per_shard");
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformValue<double> NumShards
    {
        get => new TerraformReference<double>(this, "num_shards");
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
    {
        get => new TerraformReference<string>(this, "parameter_group_name");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The shards attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Shards
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "shards").ResolveNodes(ctx));
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
    {
        get => new TerraformReference<double>(this, "snapshot_retention_limit");
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
    {
        get => new TerraformReference<string>(this, "snapshot_window");
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> SnsTopicArn
    {
        get => new TerraformReference<string>(this, "sns_topic_arn");
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
    {
        get => new TerraformReference<string>(this, "subnet_group_name");
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TlsEnabled
    {
        get => new TerraformReference<bool>(this, "tls_enabled");
    }

}
