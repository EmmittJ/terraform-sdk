using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? AclName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("acl_name")?.Value;
        set => this.WithProperty("acl_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public bool? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_minor_version_upgrade")?.Value;
        set => this.WithProperty("auto_minor_version_upgrade", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    public bool? DataTiering
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("data_tiering")?.Value;
        set => this.WithProperty("data_tiering", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public string? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine")?.Value;
        set => this.WithProperty("engine", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public string? EngineVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_version")?.Value;
        set => this.WithProperty("engine_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public string? FinalSnapshotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("final_snapshot_name")?.Value;
        set => this.WithProperty("final_snapshot_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public string? MaintenanceWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("maintenance_window")?.Value;
        set => this.WithProperty("maintenance_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    public string? MultiRegionClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("multi_region_cluster_name")?.Value;
        set => this.WithProperty("multi_region_cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public string? NodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_type")?.Value;
        set => this.WithProperty("node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    public double? NumReplicasPerShard
    {
        get => GetProperty<TerraformLiteralProperty<double>>("num_replicas_per_shard")?.Value;
        set => this.WithProperty("num_replicas_per_shard", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public double? NumShards
    {
        get => GetProperty<TerraformLiteralProperty<double>>("num_shards")?.Value;
        set => this.WithProperty("num_shards", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public string? ParameterGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_group_name")?.Value;
        set => this.WithProperty("parameter_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The snapshot_arns attribute.
    /// </summary>
    public List<string>? SnapshotArns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("snapshot_arns")?.Value;
        set => this.WithProperty("snapshot_arns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public string? SnapshotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_name")?.Value;
        set => this.WithProperty("snapshot_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public double? SnapshotRetentionLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("snapshot_retention_limit")?.Value;
        set => this.WithProperty("snapshot_retention_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public string? SnapshotWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_window")?.Value;
        set => this.WithProperty("snapshot_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public string? SnsTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sns_topic_arn")?.Value;
        set => this.WithProperty("sns_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public string? SubnetGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_group_name")?.Value;
        set => this.WithProperty("subnet_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public bool? TlsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tls_enabled")?.Value;
        set => this.WithProperty("tls_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
