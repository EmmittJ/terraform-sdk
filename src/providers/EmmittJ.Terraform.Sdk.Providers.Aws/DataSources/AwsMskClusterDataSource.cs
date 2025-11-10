using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_cluster.
/// </summary>
public class AwsMskClusterDataSource : TerraformDataSource
{
    public AwsMskClusterDataSource(string name) : base("aws_msk_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokers => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_public_sasl_iam")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersPublicSaslIam => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_public_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_public_sasl_scram")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersPublicSaslScram => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_public_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_public_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersPublicTls => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_public_tls");

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_sasl_iam")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersSaslIam => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_sasl_scram")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersSaslScram => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersTls => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_tls");

    /// <summary>
    /// The broker_node_group_info attribute.
    /// </summary>
    [TerraformPropertyName("broker_node_group_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BrokerNodeGroupInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "broker_node_group_info");

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    [TerraformPropertyName("cluster_uuid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterUuid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_uuid");

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    [TerraformPropertyName("kafka_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KafkaVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kafka_version");

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_broker_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumberOfBrokerNodes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "number_of_broker_nodes");

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    [TerraformPropertyName("zookeeper_connect_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ZookeeperConnectString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zookeeper_connect_string");

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    [TerraformPropertyName("zookeeper_connect_string_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ZookeeperConnectStringTls => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zookeeper_connect_string_tls");

}
