using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_cluster.
/// </summary>
public class AwsMskClusterDataSource : TerraformDataSource
{
    public AwsMskClusterDataSource(string name) : base("aws_msk_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("bootstrap_brokers");
        this.DeclareOutput("bootstrap_brokers_public_sasl_iam");
        this.DeclareOutput("bootstrap_brokers_public_sasl_scram");
        this.DeclareOutput("bootstrap_brokers_public_tls");
        this.DeclareOutput("bootstrap_brokers_sasl_iam");
        this.DeclareOutput("bootstrap_brokers_sasl_scram");
        this.DeclareOutput("bootstrap_brokers_tls");
        this.DeclareOutput("broker_node_group_info");
        this.DeclareOutput("cluster_uuid");
        this.DeclareOutput("kafka_version");
        this.DeclareOutput("number_of_broker_nodes");
        this.DeclareOutput("zookeeper_connect_string");
        this.DeclareOutput("zookeeper_connect_string_tls");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokers => this["bootstrap_brokers"];

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersPublicSaslIam => this["bootstrap_brokers_public_sasl_iam"];

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersPublicSaslScram => this["bootstrap_brokers_public_sasl_scram"];

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersPublicTls => this["bootstrap_brokers_public_tls"];

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersSaslIam => this["bootstrap_brokers_sasl_iam"];

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersSaslScram => this["bootstrap_brokers_sasl_scram"];

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersTls => this["bootstrap_brokers_tls"];

    /// <summary>
    /// The broker_node_group_info attribute.
    /// </summary>
    public TerraformExpression BrokerNodeGroupInfo => this["broker_node_group_info"];

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    public TerraformExpression ClusterUuid => this["cluster_uuid"];

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    public TerraformExpression KafkaVersion => this["kafka_version"];

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    public TerraformExpression NumberOfBrokerNodes => this["number_of_broker_nodes"];

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    public TerraformExpression ZookeeperConnectString => this["zookeeper_connect_string"];

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    public TerraformExpression ZookeeperConnectStringTls => this["zookeeper_connect_string_tls"];

}
