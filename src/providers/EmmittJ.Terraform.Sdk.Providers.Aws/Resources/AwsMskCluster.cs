using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for broker_node_group_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlock : ITerraformBlock
{
    /// <summary>
    /// The az_distribution attribute.
    /// </summary>
    [TerraformPropertyName("az_distribution")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AzDistribution { get; set; }

    /// <summary>
    /// The client_subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSubnets is required")]
    [TerraformPropertyName("client_subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ClientSubnets { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroups is required")]
    [TerraformPropertyName("security_groups")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroups { get; set; }

}

/// <summary>
/// Block type for client_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterClientAuthenticationBlock : ITerraformBlock
{
    /// <summary>
    /// The unauthenticated attribute.
    /// </summary>
    [TerraformPropertyName("unauthenticated")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Unauthenticated { get; set; }

}

/// <summary>
/// Block type for configuration_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterConfigurationInfoBlock : ITerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformPropertyName("revision")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Revision { get; set; }

}

/// <summary>
/// Block type for encryption_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterEncryptionInfoBlock : ITerraformBlock
{
    /// <summary>
    /// The encryption_at_rest_kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_rest_kms_key_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EncryptionAtRestKmsKeyArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "encryption_at_rest_kms_key_arn");

}

/// <summary>
/// Block type for logging_info in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterLoggingInfoBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for open_monitoring in .
/// Nesting mode: list
/// </summary>
public class AwsMskClusterOpenMonitoringBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMskClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The enhanced_monitoring attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnhancedMonitoring { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaVersion is required")]
    [TerraformPropertyName("kafka_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KafkaVersion { get; set; }

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfBrokerNodes is required")]
    [TerraformPropertyName("number_of_broker_nodes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> NumberOfBrokerNodes { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The storage_mode attribute.
    /// </summary>
    [TerraformPropertyName("storage_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_mode");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for broker_node_group_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerNodeGroupInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BrokerNodeGroupInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrokerNodeGroupInfo block(s) allowed")]
    [TerraformPropertyName("broker_node_group_info")]
    public TerraformList<TerraformBlock<AwsMskClusterBrokerNodeGroupInfoBlock>>? BrokerNodeGroupInfo { get; set; } = new();

    /// <summary>
    /// Block for client_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthentication block(s) allowed")]
    [TerraformPropertyName("client_authentication")]
    public TerraformList<TerraformBlock<AwsMskClusterClientAuthenticationBlock>>? ClientAuthentication { get; set; } = new();

    /// <summary>
    /// Block for configuration_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationInfo block(s) allowed")]
    [TerraformPropertyName("configuration_info")]
    public TerraformList<TerraformBlock<AwsMskClusterConfigurationInfoBlock>>? ConfigurationInfo { get; set; } = new();

    /// <summary>
    /// Block for encryption_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionInfo block(s) allowed")]
    [TerraformPropertyName("encryption_info")]
    public TerraformList<TerraformBlock<AwsMskClusterEncryptionInfoBlock>>? EncryptionInfo { get; set; } = new();

    /// <summary>
    /// Block for logging_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingInfo block(s) allowed")]
    [TerraformPropertyName("logging_info")]
    public TerraformList<TerraformBlock<AwsMskClusterLoggingInfoBlock>>? LoggingInfo { get; set; } = new();

    /// <summary>
    /// Block for open_monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenMonitoring block(s) allowed")]
    [TerraformPropertyName("open_monitoring")]
    public TerraformList<TerraformBlock<AwsMskClusterOpenMonitoringBlock>>? OpenMonitoring { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMskClusterTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_vpc_connectivity_sasl_iam")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersVpcConnectivitySaslIam => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_vpc_connectivity_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_vpc_connectivity_sasl_scram")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersVpcConnectivitySaslScram => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_vpc_connectivity_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    [TerraformPropertyName("bootstrap_brokers_vpc_connectivity_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BootstrapBrokersVpcConnectivityTls => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bootstrap_brokers_vpc_connectivity_tls");

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    [TerraformPropertyName("cluster_uuid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterUuid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_uuid");

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    [TerraformPropertyName("current_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CurrentVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "current_version");

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
