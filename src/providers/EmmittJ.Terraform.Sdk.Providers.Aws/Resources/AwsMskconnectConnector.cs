using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorCapacityBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for kafka_cluster in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for kafka_cluster_client_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterClientAuthenticationBlock : ITerraformBlock
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformPropertyName("authentication_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthenticationType { get; set; }

}

/// <summary>
/// Block type for kafka_cluster_encryption_in_transit in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterEncryptionInTransitBlock : ITerraformBlock
{
    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("encryption_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncryptionType { get; set; }

}

/// <summary>
/// Block type for log_delivery in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorLogDeliveryBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for plugin in .
/// Nesting mode: set
/// </summary>
public class AwsMskconnectConnectorPluginBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMskconnectConnectorTimeoutsBlock : ITerraformBlock
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
/// Block type for worker_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorWorkerConfigurationBlock : ITerraformBlock
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
/// Manages a aws_mskconnect_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMskconnectConnector : TerraformResource
{
    public AwsMskconnectConnector(string name) : base("aws_mskconnect_connector", name)
    {
    }

    /// <summary>
    /// The connector_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorConfiguration is required")]
    [TerraformPropertyName("connector_configuration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ConnectorConfiguration { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kafkaconnect_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaconnectVersion is required")]
    [TerraformPropertyName("kafkaconnect_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KafkaconnectVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRoleArn is required")]
    [TerraformPropertyName("service_execution_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceExecutionRoleArn { get; set; }

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
    /// Block for capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Capacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    [TerraformPropertyName("capacity")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorCapacityBlock>>? Capacity { get; set; } = new();

    /// <summary>
    /// Block for kafka_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaCluster block(s) allowed")]
    [TerraformPropertyName("kafka_cluster")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorKafkaClusterBlock>>? KafkaCluster { get; set; } = new();

    /// <summary>
    /// Block for kafka_cluster_client_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaClusterClientAuthentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaClusterClientAuthentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaClusterClientAuthentication block(s) allowed")]
    [TerraformPropertyName("kafka_cluster_client_authentication")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorKafkaClusterClientAuthenticationBlock>>? KafkaClusterClientAuthentication { get; set; } = new();

    /// <summary>
    /// Block for kafka_cluster_encryption_in_transit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaClusterEncryptionInTransit is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaClusterEncryptionInTransit block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaClusterEncryptionInTransit block(s) allowed")]
    [TerraformPropertyName("kafka_cluster_encryption_in_transit")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorKafkaClusterEncryptionInTransitBlock>>? KafkaClusterEncryptionInTransit { get; set; } = new();

    /// <summary>
    /// Block for log_delivery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogDelivery block(s) allowed")]
    [TerraformPropertyName("log_delivery")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorLogDeliveryBlock>>? LogDelivery { get; set; } = new();

    /// <summary>
    /// Block for plugin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plugin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plugin block(s) required")]
    [TerraformPropertyName("plugin")]
    public TerraformSet<TerraformBlock<AwsMskconnectConnectorPluginBlock>>? Plugin { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMskconnectConnectorTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for worker_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfiguration block(s) allowed")]
    [TerraformPropertyName("worker_configuration")]
    public TerraformList<TerraformBlock<AwsMskconnectConnectorWorkerConfigurationBlock>>? WorkerConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
