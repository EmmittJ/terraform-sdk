using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_replication_group.
/// </summary>
public class AwsElasticacheReplicationGroupDataSource : TerraformDataSource
{
    public AwsElasticacheReplicationGroupDataSource(string name) : base("aws_elasticache_replication_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("auth_token_enabled");
        this.DeclareOutput("automatic_failover_enabled");
        this.DeclareOutput("cluster_mode");
        this.DeclareOutput("configuration_endpoint_address");
        this.DeclareOutput("description");
        this.DeclareOutput("log_delivery_configuration");
        this.DeclareOutput("member_clusters");
        this.DeclareOutput("multi_az_enabled");
        this.DeclareOutput("node_type");
        this.DeclareOutput("num_cache_clusters");
        this.DeclareOutput("num_node_groups");
        this.DeclareOutput("port");
        this.DeclareOutput("primary_endpoint_address");
        this.DeclareOutput("reader_endpoint_address");
        this.DeclareOutput("replicas_per_node_group");
        this.DeclareOutput("snapshot_retention_limit");
        this.DeclareOutput("snapshot_window");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    public required TerraformProperty<string> ReplicationGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("replication_group_id");
        set => this.WithProperty("replication_group_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    public TerraformExpression AuthTokenEnabled => this["auth_token_enabled"];

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformExpression AutomaticFailoverEnabled => this["automatic_failover_enabled"];

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    public TerraformExpression ClusterMode => this["cluster_mode"];

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    public TerraformExpression ConfigurationEndpointAddress => this["configuration_endpoint_address"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    public TerraformExpression LogDeliveryConfiguration => this["log_delivery_configuration"];

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    public TerraformExpression MemberClusters => this["member_clusters"];

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    public TerraformExpression MultiAzEnabled => this["multi_az_enabled"];

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformExpression NodeType => this["node_type"];

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    public TerraformExpression NumCacheClusters => this["num_cache_clusters"];

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformExpression NumNodeGroups => this["num_node_groups"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    public TerraformExpression PrimaryEndpointAddress => this["primary_endpoint_address"];

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    public TerraformExpression ReaderEndpointAddress => this["reader_endpoint_address"];

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    public TerraformExpression ReplicasPerNodeGroup => this["replicas_per_node_group"];

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformExpression SnapshotRetentionLimit => this["snapshot_retention_limit"];

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformExpression SnapshotWindow => this["snapshot_window"];

}
