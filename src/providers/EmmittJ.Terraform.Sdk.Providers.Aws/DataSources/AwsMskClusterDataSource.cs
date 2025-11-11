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
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokers => new TerraformReference(this, "bootstrap_brokers");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_public_sasl_iam")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokersPublicSaslIam => new TerraformReference(this, "bootstrap_brokers_public_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_public_sasl_scram")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokersPublicSaslScram => new TerraformReference(this, "bootstrap_brokers_public_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_public_tls")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokersPublicTls => new TerraformReference(this, "bootstrap_brokers_public_tls");

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_sasl_iam")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokersSaslIam => new TerraformReference(this, "bootstrap_brokers_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_sasl_scram")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokersSaslScram => new TerraformReference(this, "bootstrap_brokers_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_tls")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokersTls => new TerraformReference(this, "bootstrap_brokers_tls");

    /// <summary>
    /// The broker_node_group_info attribute.
    /// </summary>
    [TerraformPropertyName("broker_node_group_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BrokerNodeGroupInfo => new TerraformReference(this, "broker_node_group_info");

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    [TerraformPropertyName("cluster_uuid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterUuid => new TerraformReference(this, "cluster_uuid");

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    [TerraformPropertyName("kafka_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KafkaVersion => new TerraformReference(this, "kafka_version");

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_broker_nodes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumberOfBrokerNodes => new TerraformReference(this, "number_of_broker_nodes");

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    [TerraformPropertyName("zookeeper_connect_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ZookeeperConnectString => new TerraformReference(this, "zookeeper_connect_string");

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    [TerraformPropertyName("zookeeper_connect_string_tls")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ZookeeperConnectStringTls => new TerraformReference(this, "zookeeper_connect_string_tls");

}
