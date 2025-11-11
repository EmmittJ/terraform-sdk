using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for broker_node_group_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskClusterBrokerNodeGroupInfoBlock : TerraformBlockBase
{
    /// <summary>
    /// The az_distribution attribute.
    /// </summary>
    [TerraformProperty("az_distribution")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AzDistribution { get; set; }

    /// <summary>
    /// The client_subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSubnets is required")]
    [TerraformProperty("client_subnets")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> ClientSubnets { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroups is required")]
    [TerraformProperty("security_groups")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> SecurityGroups { get; set; }

}

/// <summary>
/// Block type for client_authentication in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskClusterClientAuthenticationBlock : TerraformBlockBase
{
    /// <summary>
    /// The unauthenticated attribute.
    /// </summary>
    [TerraformProperty("unauthenticated")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Unauthenticated { get; set; }

}

/// <summary>
/// Block type for configuration_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskClusterConfigurationInfoBlock : TerraformBlockBase
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformProperty("revision")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Revision { get; set; }

}

/// <summary>
/// Block type for encryption_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskClusterEncryptionInfoBlock : TerraformBlockBase
{
    /// <summary>
    /// The encryption_at_rest_kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("encryption_at_rest_kms_key_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EncryptionAtRestKmsKeyArn { get; set; }

}

/// <summary>
/// Block type for logging_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskClusterLoggingInfoBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for open_monitoring in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskClusterOpenMonitoringBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMskClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_msk_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMskCluster : TerraformResource
{
    public AwsMskCluster(string name) : base("aws_msk_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The enhanced_monitoring attribute.
    /// </summary>
    [TerraformProperty("enhanced_monitoring")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EnhancedMonitoring { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaVersion is required")]
    [TerraformProperty("kafka_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KafkaVersion { get; set; }

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfBrokerNodes is required")]
    [TerraformProperty("number_of_broker_nodes")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> NumberOfBrokerNodes { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The storage_mode attribute.
    /// </summary>
    [TerraformProperty("storage_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StorageMode { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for broker_node_group_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerNodeGroupInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BrokerNodeGroupInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrokerNodeGroupInfo block(s) allowed")]
    [TerraformProperty("broker_node_group_info")]
    public TerraformList<TerraformBlock<AwsMskClusterBrokerNodeGroupInfoBlock>>? BrokerNodeGroupInfo { get; set; }

    /// <summary>
    /// Block for client_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthentication block(s) allowed")]
    [TerraformProperty("client_authentication")]
    public TerraformList<TerraformBlock<AwsMskClusterClientAuthenticationBlock>>? ClientAuthentication { get; set; }

    /// <summary>
    /// Block for configuration_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationInfo block(s) allowed")]
    [TerraformProperty("configuration_info")]
    public TerraformList<TerraformBlock<AwsMskClusterConfigurationInfoBlock>>? ConfigurationInfo { get; set; }

    /// <summary>
    /// Block for encryption_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionInfo block(s) allowed")]
    [TerraformProperty("encryption_info")]
    public TerraformList<TerraformBlock<AwsMskClusterEncryptionInfoBlock>>? EncryptionInfo { get; set; }

    /// <summary>
    /// Block for logging_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingInfo block(s) allowed")]
    [TerraformProperty("logging_info")]
    public TerraformList<TerraformBlock<AwsMskClusterLoggingInfoBlock>>? LoggingInfo { get; set; }

    /// <summary>
    /// Block for open_monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenMonitoring block(s) allowed")]
    [TerraformProperty("open_monitoring")]
    public TerraformList<TerraformBlock<AwsMskClusterOpenMonitoringBlock>>? OpenMonitoring { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsMskClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokers { get; }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_public_sasl_iam")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokersPublicSaslIam { get; }

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_public_sasl_scram")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokersPublicSaslScram { get; }

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_public_tls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokersPublicTls { get; }

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_sasl_iam")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokersSaslIam { get; }

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_sasl_scram")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokersSaslScram { get; }

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_tls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokersTls { get; }

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_vpc_connectivity_sasl_iam")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslIam { get; }

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_vpc_connectivity_sasl_scram")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslScram { get; }

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    [TerraformProperty("bootstrap_brokers_vpc_connectivity_tls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BootstrapBrokersVpcConnectivityTls { get; }

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    [TerraformProperty("cluster_uuid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterUuid { get; }

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    [TerraformProperty("current_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CurrentVersion { get; }

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    [TerraformProperty("zookeeper_connect_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ZookeeperConnectString { get; }

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    [TerraformProperty("zookeeper_connect_string_tls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ZookeeperConnectStringTls { get; }

}
