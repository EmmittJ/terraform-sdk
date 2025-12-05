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
        get => GetRequiredArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokers
        => CreateReference("bootstrap_brokers");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslIam
        => CreateReference("bootstrap_brokers_public_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslScram
        => CreateReference("bootstrap_brokers_public_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicTls
        => CreateReference("bootstrap_brokers_public_tls");

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslIam
        => CreateReference("bootstrap_brokers_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslScram
        => CreateReference("bootstrap_brokers_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersTls
        => CreateReference("bootstrap_brokers_tls");

    /// <summary>
    /// The broker_node_group_info attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BrokerNodeGroupInfo
        => CreateReference("broker_node_group_info");

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    public TerraformValue<string> ClusterUuid
        => CreateReference("cluster_uuid");

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    public TerraformValue<string> KafkaVersion
        => CreateReference("kafka_version");

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    public TerraformValue<double> NumberOfBrokerNodes
        => CreateReference("number_of_broker_nodes");

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    public TerraformValue<string> ZookeeperConnectString
        => CreateReference("zookeeper_connect_string");

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    public TerraformValue<string> ZookeeperConnectStringTls
        => CreateReference("zookeeper_connect_string_tls");

}
