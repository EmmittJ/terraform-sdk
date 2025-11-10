using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_memorydb_cluster.
/// </summary>
public class AwsMemorydbClusterDataSource : TerraformDataSource
{
    public AwsMemorydbClusterDataSource(string name) : base("aws_memorydb_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("acl_name");
        this.WithOutput("arn");
        this.WithOutput("auto_minor_version_upgrade");
        this.WithOutput("cluster_endpoint");
        this.WithOutput("data_tiering");
        this.WithOutput("description");
        this.WithOutput("engine");
        this.WithOutput("engine_patch_version");
        this.WithOutput("engine_version");
        this.WithOutput("final_snapshot_name");
        this.WithOutput("kms_key_arn");
        this.WithOutput("maintenance_window");
        this.WithOutput("node_type");
        this.WithOutput("num_replicas_per_shard");
        this.WithOutput("num_shards");
        this.WithOutput("parameter_group_name");
        this.WithOutput("port");
        this.WithOutput("security_group_ids");
        this.WithOutput("shards");
        this.WithOutput("snapshot_retention_limit");
        this.WithOutput("snapshot_window");
        this.WithOutput("sns_topic_arn");
        this.WithOutput("subnet_group_name");
        this.WithOutput("tls_enabled");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The acl_name attribute.
    /// </summary>
    public TerraformExpression AclName => this["acl_name"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformExpression AutoMinorVersionUpgrade => this["auto_minor_version_upgrade"];

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformExpression ClusterEndpoint => this["cluster_endpoint"];

    /// <summary>
    /// The data_tiering attribute.
    /// </summary>
    public TerraformExpression DataTiering => this["data_tiering"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The engine_patch_version attribute.
    /// </summary>
    public TerraformExpression EnginePatchVersion => this["engine_patch_version"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    public TerraformExpression FinalSnapshotName => this["final_snapshot_name"];

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformExpression KmsKeyArn => this["kms_key_arn"];

    /// <summary>
    /// The maintenance_window attribute.
    /// </summary>
    public TerraformExpression MaintenanceWindow => this["maintenance_window"];

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformExpression NodeType => this["node_type"];

    /// <summary>
    /// The num_replicas_per_shard attribute.
    /// </summary>
    public TerraformExpression NumReplicasPerShard => this["num_replicas_per_shard"];

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    public TerraformExpression NumShards => this["num_shards"];

    /// <summary>
    /// The parameter_group_name attribute.
    /// </summary>
    public TerraformExpression ParameterGroupName => this["parameter_group_name"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIds => this["security_group_ids"];

    /// <summary>
    /// The shards attribute.
    /// </summary>
    public TerraformExpression Shards => this["shards"];

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformExpression SnapshotRetentionLimit => this["snapshot_retention_limit"];

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformExpression SnapshotWindow => this["snapshot_window"];

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformExpression SnsTopicArn => this["sns_topic_arn"];

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    public TerraformExpression SubnetGroupName => this["subnet_group_name"];

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformExpression TlsEnabled => this["tls_enabled"];

}
