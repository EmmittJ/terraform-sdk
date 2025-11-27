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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replication_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationGroupId is required")]
    public required TerraformValue<string> ReplicationGroupId
    {
        get => new TerraformReference<string>(this, "replication_group_id");
        set => SetArgument("replication_group_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auth_token_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AuthTokenEnabled
    {
        get => new TerraformReference<bool>(this, "auth_token_enabled");
    }

    /// <summary>
    /// The automatic_failover_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutomaticFailoverEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_failover_enabled");
    }

    /// <summary>
    /// The cluster_mode attribute.
    /// </summary>
    public TerraformValue<string> ClusterMode
    {
        get => new TerraformReference<string>(this, "cluster_mode");
    }

    /// <summary>
    /// The configuration_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ConfigurationEndpointAddress
    {
        get => new TerraformReference<string>(this, "configuration_endpoint_address");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The log_delivery_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogDeliveryConfiguration
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "log_delivery_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The member_clusters attribute.
    /// </summary>
    public TerraformSet<string> MemberClusters
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "member_clusters").ResolveNodes(ctx));
    }

    /// <summary>
    /// The multi_az_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MultiAzEnabled
    {
        get => new TerraformReference<bool>(this, "multi_az_enabled");
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
    }

    /// <summary>
    /// The num_cache_clusters attribute.
    /// </summary>
    public TerraformValue<double> NumCacheClusters
    {
        get => new TerraformReference<double>(this, "num_cache_clusters");
    }

    /// <summary>
    /// The num_node_groups attribute.
    /// </summary>
    public TerraformValue<double> NumNodeGroups
    {
        get => new TerraformReference<double>(this, "num_node_groups");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The primary_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> PrimaryEndpointAddress
    {
        get => new TerraformReference<string>(this, "primary_endpoint_address");
    }

    /// <summary>
    /// The reader_endpoint_address attribute.
    /// </summary>
    public TerraformValue<string> ReaderEndpointAddress
    {
        get => new TerraformReference<string>(this, "reader_endpoint_address");
    }

    /// <summary>
    /// The replicas_per_node_group attribute.
    /// </summary>
    public TerraformValue<double> ReplicasPerNodeGroup
    {
        get => new TerraformReference<double>(this, "replicas_per_node_group");
    }

    /// <summary>
    /// The snapshot_retention_limit attribute.
    /// </summary>
    public TerraformValue<double> SnapshotRetentionLimit
    {
        get => new TerraformReference<double>(this, "snapshot_retention_limit");
    }

    /// <summary>
    /// The snapshot_window attribute.
    /// </summary>
    public TerraformValue<string> SnapshotWindow
    {
        get => new TerraformReference<string>(this, "snapshot_window");
    }

}
