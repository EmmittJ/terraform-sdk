using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMemorydbClusterTimeoutsBlock : TerraformBlock
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
/// Manages a aws_memorydb_cluster resource.
/// </summary>
public class AwsMemorydbCluster : TerraformResource
{
    public AwsMemorydbCluster(string name) : base("aws_memorydb_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("cluster_endpoint");
        SetOutput("engine_patch_version");
        SetOutput("shards");
        SetOutput("acl_name");
        SetOutput("auto_minor_version_upgrade");
        SetOutput("data_tiering");
        SetOutput("description");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("final_snapshot_name");
        SetOutput("id");
        SetOutput("kms_key_arn");
        SetOutput("maintenance_window");
        SetOutput("multi_region_cluster_name");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("node_type");
        SetOutput("num_replicas_per_shard");
        SetOutput("num_shards");
        SetOutput("parameter_group_name");
        SetOutput("port");
        SetOutput("region");
        SetOutput("security_group_ids");
        SetOutput("snapshot_arns");
        SetOutput("snapshot_name");
        SetOutput("snapshot_retention_limit");
        SetOutput("snapshot_window");
        SetOutput("sns_topic_arn");
        SetOutput("subnet_group_name");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tls_enabled");
    }

    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AclName is required")]
    public required TerraformProperty<string> AclName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("acl_name");
        set => SetProperty("acl_name", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AutoMinorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => SetProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    public TerraformProperty<bool> DataTiering
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("data_tiering");
        set => SetProperty("data_tiering", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformProperty<string> FinalSnapshotName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("final_snapshot_name");
        set => SetProperty("final_snapshot_name", value);
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
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string> MaintenanceWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("maintenance_window");
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    public TerraformProperty<string> MultiRegionClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("multi_region_cluster_name");
        set => SetProperty("multi_region_cluster_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_type");
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    public TerraformProperty<double> NumReplicasPerShard
    {
        get => GetRequiredOutput<TerraformProperty<double>>("num_replicas_per_shard");
        set => SetProperty("num_replicas_per_shard", value);
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformProperty<double> NumShards
    {
        get => GetRequiredOutput<TerraformProperty<double>>("num_shards");
        set => SetProperty("num_shards", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ParameterGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_group_name");
        set => SetProperty("parameter_group_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public List<TerraformProperty<string>> SnapshotArns
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("snapshot_arns");
        set => SetProperty("snapshot_arns", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_name");
        set => SetProperty("snapshot_name", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformProperty<double> SnapshotRetentionLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("snapshot_retention_limit");
        set => SetProperty("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformProperty<string> SnapshotWindow
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_window");
        set => SetProperty("snapshot_window", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> SnsTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sns_topic_arn");
        set => SetProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string> SubnetGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_group_name");
        set => SetProperty("subnet_group_name", value);
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
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TlsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tls_enabled");
        set => SetProperty("tls_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMemorydbClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformExpression ClusterEndpoint => this["cluster_endpoint"];

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    public TerraformExpression EnginePatchVersion => this["engine_patch_version"];

    /// <summary>
    /// The shards attribute.
    /// </summary>
    public TerraformExpression Shards => this["shards"];

}
