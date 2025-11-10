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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("cluster_endpoint");
        this.DeclareOutput("engine_patch_version");
        this.DeclareOutput("shards");
    }

    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AclName is required")]
    public required TerraformProperty<string> AclName
    {
        get => GetProperty<TerraformProperty<string>>("acl_name");
        set => this.WithProperty("acl_name", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    public TerraformProperty<bool>? DataTiering
    {
        get => GetProperty<TerraformProperty<bool>>("data_tiering");
        set => this.WithProperty("data_tiering", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformProperty<string>? FinalSnapshotName
    {
        get => GetProperty<TerraformProperty<string>>("final_snapshot_name");
        set => this.WithProperty("final_snapshot_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformProperty<string>? MaintenanceWindow
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    public TerraformProperty<string>? MultiRegionClusterName
    {
        get => GetProperty<TerraformProperty<string>>("multi_region_cluster_name");
        set => this.WithProperty("multi_region_cluster_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        get => GetProperty<TerraformProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
    }

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    public TerraformProperty<double>? NumReplicasPerShard
    {
        get => GetProperty<TerraformProperty<double>>("num_replicas_per_shard");
        set => this.WithProperty("num_replicas_per_shard", value);
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformProperty<double>? NumShards
    {
        get => GetProperty<TerraformProperty<double>>("num_shards");
        set => this.WithProperty("num_shards", value);
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ParameterGroupName
    {
        get => GetProperty<TerraformProperty<string>>("parameter_group_name");
        set => this.WithProperty("parameter_group_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SnapshotArns
    {
        get => GetProperty<List<TerraformProperty<string>>>("snapshot_arns");
        set => this.WithProperty("snapshot_arns", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotName
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_name");
        set => this.WithProperty("snapshot_name", value);
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformProperty<double>? SnapshotRetentionLimit
    {
        get => GetProperty<TerraformProperty<double>>("snapshot_retention_limit");
        set => this.WithProperty("snapshot_retention_limit", value);
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotWindow
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_window");
        set => this.WithProperty("snapshot_window", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SnsTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("sns_topic_arn");
        set => this.WithProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetGroupName
    {
        get => GetProperty<TerraformProperty<string>>("subnet_group_name");
        set => this.WithProperty("subnet_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TlsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("tls_enabled");
        set => this.WithProperty("tls_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMemorydbClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsMemorydbClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
