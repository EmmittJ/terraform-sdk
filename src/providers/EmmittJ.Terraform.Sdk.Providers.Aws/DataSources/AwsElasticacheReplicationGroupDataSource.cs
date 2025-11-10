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
        SetOutput("arn");
        SetOutput("auth_token_enabled");
        SetOutput("automatic_failover_enabled");
        SetOutput("cluster_mode");
        SetOutput("configuration_endpoint_address");
        SetOutput("description");
        SetOutput("log_delivery_configuration");
        SetOutput("member_clusters");
        SetOutput("multi_az_enabled");
        SetOutput("node_type");
        SetOutput("num_cache_clusters");
        SetOutput("num_node_groups");
        SetOutput("port");
        SetOutput("primary_endpoint_address");
        SetOutput("reader_endpoint_address");
        SetOutput("replicas_per_node_group");
        SetOutput("snapshot_retention_limit");
        SetOutput("snapshot_window");
        SetOutput("id");
        SetOutput("region");
        SetOutput("replication_group_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    public required TerraformProperty<string> ReplicationGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replication_group_id");
        set => SetProperty("replication_group_id", value);
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
