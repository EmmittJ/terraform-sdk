using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_cluster.
/// </summary>
public partial class AwsMskClusterDataSource : TerraformDataSource
{
    public AwsMskClusterDataSource(string name) : base("aws_msk_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokers { get; }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_public_sasl_iam")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersPublicSaslIam { get; }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_public_sasl_scram")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersPublicSaslScram { get; }

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_public_tls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersPublicTls { get; }

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_sasl_iam")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersSaslIam { get; }

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_sasl_scram")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersSaslScram { get; }

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_tls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BootstrapBrokersTls { get; }

    /// <summary>
    /// The broker_node_group_info attribute.
    /// </summary>
    [TerraformProperty("broker_node_group_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BrokerNodeGroupInfo { get; }

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    [TerraformProperty("cluster_uuid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterUuid { get; }

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    [TerraformProperty("kafka_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KafkaVersion { get; }

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    [TerraformProperty("number_of_broker_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumberOfBrokerNodes { get; }

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    [TerraformProperty("zookeeper_connect_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ZookeeperConnectString { get; }

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    [TerraformProperty("zookeeper_connect_string_tls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ZookeeperConnectStringTls { get; }

}
