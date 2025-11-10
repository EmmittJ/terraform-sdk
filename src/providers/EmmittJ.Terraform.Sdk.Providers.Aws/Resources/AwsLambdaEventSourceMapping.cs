using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for amazon_managed_kafka_event_source_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ConsumerGroupId
    {
        get => GetProperty<TerraformProperty<string>>("consumer_group_id");
        set => WithProperty("consumer_group_id", value);
    }

}

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingDestinationConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for document_db_event_source_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// The collection_name attribute.
    /// </summary>
    public TerraformProperty<string>? CollectionName
    {
        get => GetProperty<TerraformProperty<string>>("collection_name");
        set => WithProperty("collection_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database_name");
        set => WithProperty("database_name", value);
    }

    /// <summary>
    /// The full_document attribute.
    /// </summary>
    public TerraformProperty<string>? FullDocument
    {
        get => GetProperty<TerraformProperty<string>>("full_document");
        set => WithProperty("full_document", value);
    }

}

/// <summary>
/// Block type for filter_criteria in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingFilterCriteriaBlock : TerraformBlock
{
}

/// <summary>
/// Block type for metrics_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingMetricsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The metrics attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metrics is required")]
    public HashSet<TerraformProperty<string>>? Metrics
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("metrics");
        set => WithProperty("metrics", value);
    }

}

/// <summary>
/// Block type for provisioned_poller_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingProvisionedPollerConfigBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_pollers attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumPollers
    {
        get => GetProperty<TerraformProperty<double>>("maximum_pollers");
        set => WithProperty("maximum_pollers", value);
    }

    /// <summary>
    /// The minimum_pollers attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumPollers
    {
        get => GetProperty<TerraformProperty<double>>("minimum_pollers");
        set => WithProperty("minimum_pollers", value);
    }

}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingScalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_concurrency attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumConcurrency
    {
        get => GetProperty<TerraformProperty<double>>("maximum_concurrency");
        set => WithProperty("maximum_concurrency", value);
    }

}

/// <summary>
/// Block type for self_managed_event_source in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingSelfManagedEventSourceBlock : TerraformBlock
{
    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoints is required")]
    public Dictionary<string, TerraformProperty<string>>? Endpoints
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("endpoints");
        set => WithProperty("endpoints", value);
    }

}

/// <summary>
/// Block type for self_managed_kafka_event_source_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ConsumerGroupId
    {
        get => GetProperty<TerraformProperty<string>>("consumer_group_id");
        set => WithProperty("consumer_group_id", value);
    }

}

/// <summary>
/// Block type for source_access_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsLambdaEventSourceMappingSourceAccessConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

}

/// <summary>
/// Manages a aws_lambda_event_source_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaEventSourceMapping : TerraformResource
{
    public AwsLambdaEventSourceMapping(string name) : base("aws_lambda_event_source_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("function_arn");
        this.WithOutput("last_modified");
        this.WithOutput("last_processing_result");
        this.WithOutput("state");
        this.WithOutput("state_transition_reason");
        this.WithOutput("uuid");
    }

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformProperty<double>? BatchSize
    {
        get => GetProperty<TerraformProperty<double>>("batch_size");
        set => this.WithProperty("batch_size", value);
    }

    /// <summary>
    /// The bisect_batch_on_function_error attribute.
    /// </summary>
    public TerraformProperty<bool>? BisectBatchOnFunctionError
    {
        get => GetProperty<TerraformProperty<bool>>("bisect_batch_on_function_error");
        set => this.WithProperty("bisect_batch_on_function_error", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The event_source_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EventSourceArn
    {
        get => GetProperty<TerraformProperty<string>>("event_source_arn");
        set => this.WithProperty("event_source_arn", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
    }

    /// <summary>
    /// The function_response_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? FunctionResponseTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("function_response_types");
        set => this.WithProperty("function_response_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumBatchingWindowInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("maximum_batching_window_in_seconds");
        set => this.WithProperty("maximum_batching_window_in_seconds", value);
    }

    /// <summary>
    /// The maximum_record_age_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumRecordAgeInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("maximum_record_age_in_seconds");
        set => this.WithProperty("maximum_record_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumRetryAttempts
    {
        get => GetProperty<TerraformProperty<double>>("maximum_retry_attempts");
        set => this.WithProperty("maximum_retry_attempts", value);
    }

    /// <summary>
    /// The parallelization_factor attribute.
    /// </summary>
    public TerraformProperty<double>? ParallelizationFactor
    {
        get => GetProperty<TerraformProperty<double>>("parallelization_factor");
        set => this.WithProperty("parallelization_factor", value);
    }

    /// <summary>
    /// The queues attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Queues
    {
        get => GetProperty<List<TerraformProperty<string>>>("queues");
        set => this.WithProperty("queues", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    public TerraformProperty<string>? StartingPosition
    {
        get => GetProperty<TerraformProperty<string>>("starting_position");
        set => this.WithProperty("starting_position", value);
    }

    /// <summary>
    /// The starting_position_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? StartingPositionTimestamp
    {
        get => GetProperty<TerraformProperty<string>>("starting_position_timestamp");
        set => this.WithProperty("starting_position_timestamp", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The topics attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Topics
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("topics");
        set => this.WithProperty("topics", value);
    }

    /// <summary>
    /// The tumbling_window_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TumblingWindowInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tumbling_window_in_seconds");
        set => this.WithProperty("tumbling_window_in_seconds", value);
    }

    /// <summary>
    /// Block for amazon_managed_kafka_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonManagedKafkaEventSourceConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock>? AmazonManagedKafkaEventSourceConfig
    {
        get => GetProperty<List<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock>>("amazon_managed_kafka_event_source_config");
        set => this.WithProperty("amazon_managed_kafka_event_source_config", value);
    }

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingDestinationConfigBlock>? DestinationConfig
    {
        get => GetProperty<List<AwsLambdaEventSourceMappingDestinationConfigBlock>>("destination_config");
        set => this.WithProperty("destination_config", value);
    }

    /// <summary>
    /// Block for document_db_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentDbEventSourceConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock>? DocumentDbEventSourceConfig
    {
        get => GetProperty<List<AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock>>("document_db_event_source_config");
        set => this.WithProperty("document_db_event_source_config", value);
    }

    /// <summary>
    /// Block for filter_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterCriteria block(s) allowed")]
    public List<AwsLambdaEventSourceMappingFilterCriteriaBlock>? FilterCriteria
    {
        get => GetProperty<List<AwsLambdaEventSourceMappingFilterCriteriaBlock>>("filter_criteria");
        set => this.WithProperty("filter_criteria", value);
    }

    /// <summary>
    /// Block for metrics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricsConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingMetricsConfigBlock>? MetricsConfig
    {
        get => GetProperty<List<AwsLambdaEventSourceMappingMetricsConfigBlock>>("metrics_config");
        set => this.WithProperty("metrics_config", value);
    }

    /// <summary>
    /// Block for provisioned_poller_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisionedPollerConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingProvisionedPollerConfigBlock>? ProvisionedPollerConfig
    {
        get => GetProperty<List<AwsLambdaEventSourceMappingProvisionedPollerConfigBlock>>("provisioned_poller_config");
        set => this.WithProperty("provisioned_poller_config", value);
    }

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingScalingConfigBlock>? ScalingConfig
    {
        get => GetProperty<List<AwsLambdaEventSourceMappingScalingConfigBlock>>("scaling_config");
        set => this.WithProperty("scaling_config", value);
    }

    /// <summary>
    /// Block for self_managed_event_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedEventSource block(s) allowed")]
    public List<AwsLambdaEventSourceMappingSelfManagedEventSourceBlock>? SelfManagedEventSource
    {
        get => GetProperty<List<AwsLambdaEventSourceMappingSelfManagedEventSourceBlock>>("self_managed_event_source");
        set => this.WithProperty("self_managed_event_source", value);
    }

    /// <summary>
    /// Block for self_managed_kafka_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedKafkaEventSourceConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock>? SelfManagedKafkaEventSourceConfig
    {
        get => GetProperty<List<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock>>("self_managed_kafka_event_source_config");
        set => this.WithProperty("self_managed_kafka_event_source_config", value);
    }

    /// <summary>
    /// Block for source_access_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(22, ErrorMessage = "Maximum 22 SourceAccessConfiguration block(s) allowed")]
    public HashSet<AwsLambdaEventSourceMappingSourceAccessConfigurationBlock>? SourceAccessConfiguration
    {
        get => GetProperty<HashSet<AwsLambdaEventSourceMappingSourceAccessConfigurationBlock>>("source_access_configuration");
        set => this.WithProperty("source_access_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public TerraformExpression FunctionArn => this["function_arn"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The last_processing_result attribute.
    /// </summary>
    public TerraformExpression LastProcessingResult => this["last_processing_result"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The state_transition_reason attribute.
    /// </summary>
    public TerraformExpression StateTransitionReason => this["state_transition_reason"];

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformExpression Uuid => this["uuid"];

}
