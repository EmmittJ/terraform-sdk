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
        set => SetProperty("consumer_group_id", value);
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
        set => SetProperty("collection_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The full_document attribute.
    /// </summary>
    public TerraformProperty<string>? FullDocument
    {
        set => SetProperty("full_document", value);
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
        set => SetProperty("metrics", value);
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
        set => SetProperty("maximum_pollers", value);
    }

    /// <summary>
    /// The minimum_pollers attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumPollers
    {
        set => SetProperty("minimum_pollers", value);
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
        set => SetProperty("maximum_concurrency", value);
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
        set => SetProperty("endpoints", value);
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
        set => SetProperty("consumer_group_id", value);
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
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        set => SetProperty("uri", value);
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
        SetOutput("arn");
        SetOutput("function_arn");
        SetOutput("last_modified");
        SetOutput("last_processing_result");
        SetOutput("state");
        SetOutput("state_transition_reason");
        SetOutput("uuid");
        SetOutput("batch_size");
        SetOutput("bisect_batch_on_function_error");
        SetOutput("enabled");
        SetOutput("event_source_arn");
        SetOutput("function_name");
        SetOutput("function_response_types");
        SetOutput("id");
        SetOutput("kms_key_arn");
        SetOutput("maximum_batching_window_in_seconds");
        SetOutput("maximum_record_age_in_seconds");
        SetOutput("maximum_retry_attempts");
        SetOutput("parallelization_factor");
        SetOutput("queues");
        SetOutput("region");
        SetOutput("starting_position");
        SetOutput("starting_position_timestamp");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("topics");
        SetOutput("tumbling_window_in_seconds");
    }

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformProperty<double> BatchSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("batch_size");
        set => SetProperty("batch_size", value);
    }

    /// <summary>
    /// The bisect_batch_on_function_error attribute.
    /// </summary>
    public TerraformProperty<bool> BisectBatchOnFunctionError
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bisect_batch_on_function_error");
        set => SetProperty("bisect_batch_on_function_error", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The event_source_arn attribute.
    /// </summary>
    public TerraformProperty<string> EventSourceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_source_arn");
        set => SetProperty("event_source_arn", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_name");
        set => SetProperty("function_name", value);
    }

    /// <summary>
    /// The function_response_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> FunctionResponseTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("function_response_types");
        set => SetProperty("function_response_types", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> MaximumBatchingWindowInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_batching_window_in_seconds");
        set => SetProperty("maximum_batching_window_in_seconds", value);
    }

    /// <summary>
    /// The maximum_record_age_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> MaximumRecordAgeInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_record_age_in_seconds");
        set => SetProperty("maximum_record_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformProperty<double> MaximumRetryAttempts
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_retry_attempts");
        set => SetProperty("maximum_retry_attempts", value);
    }

    /// <summary>
    /// The parallelization_factor attribute.
    /// </summary>
    public TerraformProperty<double> ParallelizationFactor
    {
        get => GetRequiredOutput<TerraformProperty<double>>("parallelization_factor");
        set => SetProperty("parallelization_factor", value);
    }

    /// <summary>
    /// The queues attribute.
    /// </summary>
    public List<TerraformProperty<string>> Queues
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("queues");
        set => SetProperty("queues", value);
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
    /// The starting_position attribute.
    /// </summary>
    public TerraformProperty<string> StartingPosition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("starting_position");
        set => SetProperty("starting_position", value);
    }

    /// <summary>
    /// The starting_position_timestamp attribute.
    /// </summary>
    public TerraformProperty<string> StartingPositionTimestamp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("starting_position_timestamp");
        set => SetProperty("starting_position_timestamp", value);
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
    /// The topics attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Topics
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("topics");
        set => SetProperty("topics", value);
    }

    /// <summary>
    /// The tumbling_window_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> TumblingWindowInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("tumbling_window_in_seconds");
        set => SetProperty("tumbling_window_in_seconds", value);
    }

    /// <summary>
    /// Block for amazon_managed_kafka_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonManagedKafkaEventSourceConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock>? AmazonManagedKafkaEventSourceConfig
    {
        set => SetProperty("amazon_managed_kafka_event_source_config", value);
    }

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingDestinationConfigBlock>? DestinationConfig
    {
        set => SetProperty("destination_config", value);
    }

    /// <summary>
    /// Block for document_db_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentDbEventSourceConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock>? DocumentDbEventSourceConfig
    {
        set => SetProperty("document_db_event_source_config", value);
    }

    /// <summary>
    /// Block for filter_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterCriteria block(s) allowed")]
    public List<AwsLambdaEventSourceMappingFilterCriteriaBlock>? FilterCriteria
    {
        set => SetProperty("filter_criteria", value);
    }

    /// <summary>
    /// Block for metrics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricsConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingMetricsConfigBlock>? MetricsConfig
    {
        set => SetProperty("metrics_config", value);
    }

    /// <summary>
    /// Block for provisioned_poller_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisionedPollerConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingProvisionedPollerConfigBlock>? ProvisionedPollerConfig
    {
        set => SetProperty("provisioned_poller_config", value);
    }

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingScalingConfigBlock>? ScalingConfig
    {
        set => SetProperty("scaling_config", value);
    }

    /// <summary>
    /// Block for self_managed_event_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedEventSource block(s) allowed")]
    public List<AwsLambdaEventSourceMappingSelfManagedEventSourceBlock>? SelfManagedEventSource
    {
        set => SetProperty("self_managed_event_source", value);
    }

    /// <summary>
    /// Block for self_managed_kafka_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedKafkaEventSourceConfig block(s) allowed")]
    public List<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock>? SelfManagedKafkaEventSourceConfig
    {
        set => SetProperty("self_managed_kafka_event_source_config", value);
    }

    /// <summary>
    /// Block for source_access_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(22, ErrorMessage = "Maximum 22 SourceAccessConfiguration block(s) allowed")]
    public HashSet<AwsLambdaEventSourceMappingSourceAccessConfigurationBlock>? SourceAccessConfiguration
    {
        set => SetProperty("source_access_configuration", value);
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
