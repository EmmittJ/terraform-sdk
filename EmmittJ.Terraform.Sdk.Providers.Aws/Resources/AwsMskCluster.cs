using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_msk_cluster resource.
/// </summary>
public class AwsMskCluster : TerraformResource
{
    public AwsMskCluster(string name) : base("aws_msk_cluster", name)
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
        this.DeclareOutput("bootstrap_brokers_vpc_connectivity_sasl_iam");
        this.DeclareOutput("bootstrap_brokers_vpc_connectivity_sasl_scram");
        this.DeclareOutput("bootstrap_brokers_vpc_connectivity_tls");
        this.DeclareOutput("cluster_uuid");
        this.DeclareOutput("current_version");
        this.DeclareOutput("zookeeper_connect_string");
        this.DeclareOutput("zookeeper_connect_string_tls");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enhanced_monitoring attribute.
    /// </summary>
    public string? EnhancedMonitoring
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enhanced_monitoring")?.Value;
        set => this.WithProperty("enhanced_monitoring", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kafka_version attribute.
    /// </summary>
    public string? KafkaVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kafka_version")?.Value;
        set => this.WithProperty("kafka_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    public double? NumberOfBrokerNodes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_broker_nodes")?.Value;
        set => this.WithProperty("number_of_broker_nodes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The storage_mode attribute.
    /// </summary>
    public string? StorageMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_mode")?.Value;
        set => this.WithProperty("storage_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersVpcConnectivitySaslIam => this["bootstrap_brokers_vpc_connectivity_sasl_iam"];

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersVpcConnectivitySaslScram => this["bootstrap_brokers_vpc_connectivity_sasl_scram"];

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    public TerraformExpression BootstrapBrokersVpcConnectivityTls => this["bootstrap_brokers_vpc_connectivity_tls"];

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    public TerraformExpression ClusterUuid => this["cluster_uuid"];

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformExpression CurrentVersion => this["current_version"];

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    public TerraformExpression ZookeeperConnectString => this["zookeeper_connect_string"];

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    public TerraformExpression ZookeeperConnectStringTls => this["zookeeper_connect_string_tls"];

}
