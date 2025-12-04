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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    public required TerraformValue<string> ReplicationGroupId
    {
        get => GetArgument<TerraformValue<string>>("replication_group_id");
        set => SetArgument("replication_group_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AuthTokenEnabled
        => AsReference("auth_token_enabled");

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutomaticFailoverEnabled
        => AsReference("automatic_failover_enabled");

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    public TerraformValue<string> ClusterMode
        => AsReference("cluster_mode");

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpointAddress
        => AsReference("configuration_endpoint_address");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogDeliveryConfiguration
        => AsReference("log_delivery_configuration");

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    public TerraformSet<string> MemberClusters
        => AsReference("member_clusters");

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MultiAzEnabled
        => AsReference("multi_az_enabled");

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
        => AsReference("node_type");

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    public TerraformValue<double> NumCacheClusters
        => AsReference("num_cache_clusters");

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformValue<double> NumNodeGroups
        => AsReference("num_node_groups");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> PrimaryEndpointAddress
        => AsReference("primary_endpoint_address");

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpointAddress
        => AsReference("reader_endpoint_address");

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    public TerraformValue<double> ReplicasPerNodeGroup
        => AsReference("replicas_per_node_group");

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

}
