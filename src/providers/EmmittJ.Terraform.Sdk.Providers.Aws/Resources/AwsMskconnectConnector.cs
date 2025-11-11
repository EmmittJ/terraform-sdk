using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskconnectConnectorCapacityBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for kafka_cluster in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskconnectConnectorKafkaClusterBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for kafka_cluster_client_authentication in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskconnectConnectorKafkaClusterClientAuthenticationBlock : TerraformBlockBase
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformProperty("authentication_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthenticationType { get; set; }

}

/// <summary>
/// Block type for kafka_cluster_encryption_in_transit in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskconnectConnectorKafkaClusterEncryptionInTransitBlock : TerraformBlockBase
{
    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformProperty("encryption_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EncryptionType { get; set; }

}

/// <summary>
/// Block type for log_delivery in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskconnectConnectorLogDeliveryBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for plugin in .
/// Nesting mode: set
/// </summary>
public partial class AwsMskconnectConnectorPluginBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMskconnectConnectorTimeoutsBlock : TerraformBlockBase
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
/// Block type for worker_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsMskconnectConnectorWorkerConfigurationBlock : TerraformBlockBase
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
/// Manages a aws_mskconnect_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMskconnectConnector : TerraformResource
{
    public AwsMskconnectConnector(string name) : base("aws_mskconnect_connector", name)
    {
    }

    /// <summary>
    /// The connector_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorConfiguration is required")]
    [TerraformProperty("connector_configuration")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> ConnectorConfiguration { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kafkaconnect_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaconnectVersion is required")]
    [TerraformProperty("kafkaconnect_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KafkaconnectVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRoleArn is required")]
    [TerraformProperty("service_execution_role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceExecutionRoleArn { get; set; }

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
    /// Block for capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Capacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    [TerraformProperty("capacity")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorCapacityBlock>>? Capacity { get; set; }

    /// <summary>
    /// Block for kafka_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaCluster block(s) allowed")]
    [TerraformProperty("kafka_cluster")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorKafkaClusterBlock>>? KafkaCluster { get; set; }

    /// <summary>
    /// Block for kafka_cluster_client_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaClusterClientAuthentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaClusterClientAuthentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaClusterClientAuthentication block(s) allowed")]
    [TerraformProperty("kafka_cluster_client_authentication")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorKafkaClusterClientAuthenticationBlock>>? KafkaClusterClientAuthentication { get; set; }

    /// <summary>
    /// Block for kafka_cluster_encryption_in_transit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaClusterEncryptionInTransit is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaClusterEncryptionInTransit block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaClusterEncryptionInTransit block(s) allowed")]
    [TerraformProperty("kafka_cluster_encryption_in_transit")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorKafkaClusterEncryptionInTransitBlock>>? KafkaClusterEncryptionInTransit { get; set; }

    /// <summary>
    /// Block for log_delivery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogDelivery block(s) allowed")]
    [TerraformProperty("log_delivery")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorLogDeliveryBlock>>? LogDelivery { get; set; }

    /// <summary>
    /// Block for plugin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plugin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plugin block(s) required")]
    [TerraformProperty("plugin")]
    public TerraformSet<TerraformBlock<AwsMskconnectConnectorPluginBlock>>? Plugin { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsMskconnectConnectorTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for worker_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfiguration block(s) allowed")]
    [TerraformProperty("worker_configuration")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorWorkerConfigurationBlock>>? WorkerConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
