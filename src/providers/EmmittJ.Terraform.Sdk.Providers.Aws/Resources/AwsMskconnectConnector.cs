using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorCapacityBlock : TerraformBlock
{
}

/// <summary>
/// Block type for kafka_cluster in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterBlock : TerraformBlock
{
}

/// <summary>
/// Block type for kafka_cluster_client_authentication in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterClientAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationType
    {
        set => SetProperty("authentication_type", value);
    }

}

/// <summary>
/// Block type for kafka_cluster_encryption_in_transit in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterEncryptionInTransitBlock : TerraformBlock
{
    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionType
    {
        set => SetProperty("encryption_type", value);
    }

}

/// <summary>
/// Block type for log_delivery in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorLogDeliveryBlock : TerraformBlock
{
}

/// <summary>
/// Block type for plugin in .
/// Nesting mode: set
/// </summary>
public class AwsMskconnectConnectorPluginBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMskconnectConnectorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for worker_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorWorkerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformProperty<double> Revision
    {
        set => SetProperty("revision", value);
    }

}

/// <summary>
/// Manages a aws_mskconnect_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMskconnectConnector : TerraformResource
{
    public AwsMskconnectConnector(string name) : base("aws_mskconnect_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("version");
        SetOutput("connector_configuration");
        SetOutput("description");
        SetOutput("id");
        SetOutput("kafkaconnect_version");
        SetOutput("name");
        SetOutput("region");
        SetOutput("service_execution_role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The connector_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorConfiguration is required")]
    public Dictionary<string, TerraformProperty<string>> ConnectorConfiguration
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("connector_configuration");
        set => SetProperty("connector_configuration", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kafkaconnect_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaconnectVersion is required")]
    public required TerraformProperty<string> KafkaconnectVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kafkaconnect_version");
        set => SetProperty("kafkaconnect_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRoleArn is required")]
    public required TerraformProperty<string> ServiceExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_execution_role_arn");
        set => SetProperty("service_execution_role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Capacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    public List<AwsMskconnectConnectorCapacityBlock>? Capacity
    {
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// Block for kafka_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaCluster block(s) allowed")]
    public List<AwsMskconnectConnectorKafkaClusterBlock>? KafkaCluster
    {
        set => SetProperty("kafka_cluster", value);
    }

    /// <summary>
    /// Block for kafka_cluster_client_authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaClusterClientAuthentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaClusterClientAuthentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaClusterClientAuthentication block(s) allowed")]
    public List<AwsMskconnectConnectorKafkaClusterClientAuthenticationBlock>? KafkaClusterClientAuthentication
    {
        set => SetProperty("kafka_cluster_client_authentication", value);
    }

    /// <summary>
    /// Block for kafka_cluster_encryption_in_transit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaClusterEncryptionInTransit is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaClusterEncryptionInTransit block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaClusterEncryptionInTransit block(s) allowed")]
    public List<AwsMskconnectConnectorKafkaClusterEncryptionInTransitBlock>? KafkaClusterEncryptionInTransit
    {
        set => SetProperty("kafka_cluster_encryption_in_transit", value);
    }

    /// <summary>
    /// Block for log_delivery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogDelivery block(s) allowed")]
    public List<AwsMskconnectConnectorLogDeliveryBlock>? LogDelivery
    {
        set => SetProperty("log_delivery", value);
    }

    /// <summary>
    /// Block for plugin.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plugin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plugin block(s) required")]
    public HashSet<AwsMskconnectConnectorPluginBlock>? Plugin
    {
        set => SetProperty("plugin", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMskconnectConnectorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for worker_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfiguration block(s) allowed")]
    public List<AwsMskconnectConnectorWorkerConfigurationBlock>? WorkerConfiguration
    {
        set => SetProperty("worker_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
