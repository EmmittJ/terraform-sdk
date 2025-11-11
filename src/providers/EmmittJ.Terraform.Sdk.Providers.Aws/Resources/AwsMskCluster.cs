using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for broker_node_group_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlock
{
    /// <summary>
    /// The az_distribution attribute.
    /// </summary>
    [TerraformPropertyName("az_distribution")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AzDistribution { get; set; }

    /// <summary>
    /// The client_subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSubnets is required")]
    [TerraformPropertyName("client_subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> ClientSubnets { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroups is required")]
    [TerraformPropertyName("security_groups")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> SecurityGroups { get; set; }

}

/// <summary>
/// Block type for client_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterClientAuthenticationBlock
{
    /// <summary>
    /// The unauthenticated attribute.
    /// </summary>
    [TerraformPropertyName("unauthenticated")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Unauthenticated { get; set; }

}

/// <summary>
/// Block type for configuration_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterConfigurationInfoBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformPropertyName("revision")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Revision { get; set; }

}

/// <summary>
/// Block type for encryption_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterEncryptionInfoBlock
{
    /// <summary>
    /// The encryption_at_rest_kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_rest_kms_key_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EncryptionAtRestKmsKeyArn { get; set; } = default!;

}

/// <summary>
/// Block type for logging_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterLoggingInfoBlock
{
}

/// <summary>
/// Block type for open_monitoring in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterOpenMonitoringBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMskClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_msk_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMskCluster : TerraformResource
{
    public AwsMskCluster(string name) : base("aws_msk_cluster", name)
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
    /// The enhanced_monitoring attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EnhancedMonitoring { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaVersion is required")]
    [TerraformPropertyName("kafka_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KafkaVersion { get; set; }

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfBrokerNodes is required")]
    [TerraformPropertyName("number_of_broker_nodes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> NumberOfBrokerNodes { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The storage_mode attribute.
    /// </summary>
    [TerraformPropertyName("storage_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageMode { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for broker_node_group_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerNodeGroupInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BrokerNodeGroupInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrokerNodeGroupInfo block(s) allowed")]
    [TerraformPropertyName("broker_node_group_info")]
    public TerraformList<TerraformBlock<AwsMskClusterBrokerNodeGroupInfoBlock>>? BrokerNodeGroupInfo { get; set; }

    /// <summary>
    /// Block for client_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthentication block(s) allowed")]
    [TerraformPropertyName("client_authentication")]
    public TerraformList<TerraformBlock<AwsMskClusterClientAuthenticationBlock>>? ClientAuthentication { get; set; }

    /// <summary>
    /// Block for configuration_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationInfo block(s) allowed")]
    [TerraformPropertyName("configuration_info")]
    public TerraformList<TerraformBlock<AwsMskClusterConfigurationInfoBlock>>? ConfigurationInfo { get; set; }

    /// <summary>
    /// Block for encryption_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionInfo block(s) allowed")]
    [TerraformPropertyName("encryption_info")]
    public TerraformList<TerraformBlock<AwsMskClusterEncryptionInfoBlock>>? EncryptionInfo { get; set; }

    /// <summary>
    /// Block for logging_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingInfo block(s) allowed")]
    [TerraformPropertyName("logging_info")]
    public TerraformList<TerraformBlock<AwsMskClusterLoggingInfoBlock>>? LoggingInfo { get; set; }

    /// <summary>
    /// Block for open_monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenMonitoring block(s) allowed")]
    [TerraformPropertyName("open_monitoring")]
    public TerraformList<TerraformBlock<AwsMskClusterOpenMonitoringBlock>>? OpenMonitoring { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMskClusterTimeoutsBlock>? Timeouts { get; set; }

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
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_vpc_connectivity_sasl_iam")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslIam => new TerraformReference(this, "bootstrap_brokers_vpc_connectivity_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_vpc_connectivity_sasl_scram")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslScram => new TerraformReference(this, "bootstrap_brokers_vpc_connectivity_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_vpc_connectivity_tls")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BootstrapBrokersVpcConnectivityTls => new TerraformReference(this, "bootstrap_brokers_vpc_connectivity_tls");

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    [TerraformPropertyName("cluster_uuid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterUuid => new TerraformReference(this, "cluster_uuid");

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    [TerraformPropertyName("current_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CurrentVersion => new TerraformReference(this, "current_version");

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
