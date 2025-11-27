using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_msk_cluster Terraform data source.
/// Retrieves information about a aws_msk_cluster.
/// </summary>
public partial class AwsMskClusterDataSource(string name) : TerraformDataSource("aws_msk_cluster", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokers
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers");
    }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslIam
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_public_sasl_iam");
    }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslScram
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_public_sasl_scram");
    }

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicTls
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_public_tls");
    }

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslIam
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_sasl_iam");
    }

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslScram
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_sasl_scram");
    }

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersTls
    {
        get => new TerraformReference<string>(this, "bootstrap_brokers_tls");
    }

    /// <summary>
    /// The broker_node_group_info attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BrokerNodeGroupInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "broker_node_group_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    public TerraformValue<string> ClusterUuid
    {
        get => new TerraformReference<string>(this, "cluster_uuid");
    }

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    public TerraformValue<string> KafkaVersion
    {
        get => new TerraformReference<string>(this, "kafka_version");
    }

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    public TerraformValue<double> NumberOfBrokerNodes
    {
        get => new TerraformReference<double>(this, "number_of_broker_nodes");
    }

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    public TerraformValue<string> ZookeeperConnectString
    {
        get => new TerraformReference<string>(this, "zookeeper_connect_string");
    }

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    public TerraformValue<string> ZookeeperConnectStringTls
    {
        get => new TerraformReference<string>(this, "zookeeper_connect_string_tls");
    }

}
