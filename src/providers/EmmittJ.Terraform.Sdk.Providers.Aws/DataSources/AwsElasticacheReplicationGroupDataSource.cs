using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_elasticache_replication_group Terraform data source.
/// Retrieves information about a aws_elasticache_replication_group.
/// </summary>
public partial class AwsElasticacheReplicationGroupDataSource(string name) : TerraformDataSource("aws_elasticache_replication_group", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    public required TerraformValue<string> ReplicationGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("replication_group_id");
        set => SetArgument("replication_group_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AuthTokenEnabled
        => CreateReference("auth_token_enabled");

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutomaticFailoverEnabled
        => CreateReference("automatic_failover_enabled");

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    public TerraformValue<string> ClusterMode
        => CreateReference("cluster_mode");

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpointAddress
        => CreateReference("configuration_endpoint_address");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogDeliveryConfiguration
        => CreateReference("log_delivery_configuration");

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    public TerraformSet<string> MemberClusters
        => CreateReference("member_clusters");

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MultiAzEnabled
        => CreateReference("multi_az_enabled");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
        => CreateReference("node_type");

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    public TerraformValue<double> NumCacheClusters
        => CreateReference("num_cache_clusters");

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformValue<double> NumNodeGroups
        => CreateReference("num_node_groups");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => CreateReference("port");

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> PrimaryEndpointAddress
        => CreateReference("primary_endpoint_address");

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpointAddress
        => CreateReference("reader_endpoint_address");

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    public TerraformValue<double> ReplicasPerNodeGroup
        => CreateReference("replicas_per_node_group");

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

}
