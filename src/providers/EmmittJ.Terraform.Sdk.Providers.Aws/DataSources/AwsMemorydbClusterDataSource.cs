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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    /// The acl_name attribute.
    /// </summary>
    public TerraformValue<string> AclName
        => AsReference("acl_name");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
        => AsReference("auto_minor_version_upgrade");

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterEndpoint
        => AsReference("cluster_endpoint");

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    public TerraformValue<bool> DataTiering
        => AsReference("data_tiering");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => AsReference("engine");

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    public TerraformValue<string> EnginePatchVersion
        => AsReference("engine_patch_version");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => AsReference("engine_version");

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformValue<string> FinalSnapshotName
        => AsReference("final_snapshot_name");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => AsReference("kms_key_arn");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
        => AsReference("maintenance_window");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
        => AsReference("node_type");

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    public TerraformValue<double> NumReplicasPerShard
        => AsReference("num_replicas_per_shard");

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformValue<double> NumShards
        => AsReference("num_shards");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
        => AsReference("parameter_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
        => AsReference("security_group_ids");

    /// <summary>
    /// The shards attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Shards
        => AsReference("shards");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
        => AsReference("snapshot_retention_limit");

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
        => AsReference("snapshot_window");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> SnsTopicArn
        => AsReference("sns_topic_arn");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
        => AsReference("subnet_group_name");

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TlsEnabled
        => AsReference("tls_enabled");

}
