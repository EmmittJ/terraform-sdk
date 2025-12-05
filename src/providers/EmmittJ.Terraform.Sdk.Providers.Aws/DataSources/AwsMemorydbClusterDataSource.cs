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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    public TerraformValue<string> AclName
        => CreateReference("acl_name");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool> AutoMinorVersionUpgrade
        => CreateReference("auto_minor_version_upgrade");

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterEndpoint
        => CreateReference("cluster_endpoint");

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    public TerraformValue<bool> DataTiering
        => CreateReference("data_tiering");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => CreateReference("engine");

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    public TerraformValue<string> EnginePatchVersion
        => CreateReference("engine_patch_version");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => CreateReference("engine_version");

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformValue<string> FinalSnapshotName
        => CreateReference("final_snapshot_name");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => CreateReference("kms_key_arn");

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformValue<string> MaintenanceWindow
        => CreateReference("maintenance_window");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
        => CreateReference("node_type");

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    public TerraformValue<double> NumReplicasPerShard
        => CreateReference("num_replicas_per_shard");

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformValue<double> NumShards
        => CreateReference("num_shards");

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupName
        => CreateReference("parameter_group_name");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => CreateReference("port");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
        => CreateReference("security_group_ids");

    /// <summary>
    /// The shards attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Shards
        => CreateReference("shards");

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
        => CreateReference("snapshot_retention_limit");

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
        => CreateReference("snapshot_window");

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string> SnsTopicArn
        => CreateReference("sns_topic_arn");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformValue<string> SubnetGroupName
        => CreateReference("subnet_group_name");

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TlsEnabled
        => CreateReference("tls_enabled");

}
