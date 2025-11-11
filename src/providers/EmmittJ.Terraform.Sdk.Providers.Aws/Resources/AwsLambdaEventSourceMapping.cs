using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for amazon_managed_kafka_event_source_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    [TerraformProperty("consumer_group_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ConsumerGroupId { get; set; }

}

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaEventSourceMappingDestinationConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for document_db_event_source_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The collection_name attribute.
    /// </summary>
    [TerraformProperty("collection_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CollectionName { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The full_document attribute.
    /// </summary>
    [TerraformProperty("full_document")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FullDocument { get; set; }

}

/// <summary>
/// Block type for filter_criteria in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaEventSourceMappingFilterCriteriaBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for metrics_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaEventSourceMappingMetricsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The metrics attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metrics is required")]
    [TerraformProperty("metrics")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Metrics { get; set; }

}

/// <summary>
/// Block type for provisioned_poller_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaEventSourceMappingProvisionedPollerConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum_pollers attribute.
    /// </summary>
    [TerraformProperty("maximum_pollers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaximumPollers { get; set; }

    /// <summary>
    /// The minimum_pollers attribute.
    /// </summary>
    [TerraformProperty("minimum_pollers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MinimumPollers { get; set; }

}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaEventSourceMappingScalingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum_concurrency attribute.
    /// </summary>
    [TerraformProperty("maximum_concurrency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaximumConcurrency { get; set; }

}

/// <summary>
/// Block type for self_managed_event_source in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaEventSourceMappingSelfManagedEventSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoints is required")]
    [TerraformProperty("endpoints")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> Endpoints { get; set; }

}

/// <summary>
/// Block type for self_managed_kafka_event_source_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    [TerraformProperty("consumer_group_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ConsumerGroupId { get; set; }

}

/// <summary>
/// Block type for source_access_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsLambdaEventSourceMappingSourceAccessConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Manages a aws_lambda_event_source_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLambdaEventSourceMapping : TerraformResource
{
    public AwsLambdaEventSourceMapping(string name) : base("aws_lambda_event_source_mapping", name)
    {
    }

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    [TerraformProperty("batch_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BatchSize { get; set; }

    /// <summary>
    /// The bisect_batch_on_function_error attribute.
    /// </summary>
    [TerraformProperty("bisect_batch_on_function_error")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BisectBatchOnFunctionError { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The event_source_arn attribute.
    /// </summary>
    [TerraformProperty("event_source_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventSourceArn { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The function_response_types attribute.
    /// </summary>
    [TerraformProperty("function_response_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? FunctionResponseTypes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    [TerraformProperty("maximum_batching_window_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>
    /// The maximum_record_age_in_seconds attribute.
    /// </summary>
    [TerraformProperty("maximum_record_age_in_seconds")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaximumRecordAgeInSeconds { get; set; }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    [TerraformProperty("maximum_retry_attempts")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaximumRetryAttempts { get; set; }

    /// <summary>
    /// The parallelization_factor attribute.
    /// </summary>
    [TerraformProperty("parallelization_factor")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ParallelizationFactor { get; set; }

    /// <summary>
    /// The queues attribute.
    /// </summary>
    [TerraformProperty("queues")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Queues { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    [TerraformProperty("starting_position")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StartingPosition { get; set; }

    /// <summary>
    /// The starting_position_timestamp attribute.
    /// </summary>
    [TerraformProperty("starting_position_timestamp")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StartingPositionTimestamp { get; set; }

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
    /// The topics attribute.
    /// </summary>
    [TerraformProperty("topics")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Topics { get; set; }

    /// <summary>
    /// The tumbling_window_in_seconds attribute.
    /// </summary>
    [TerraformProperty("tumbling_window_in_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TumblingWindowInSeconds { get; set; }

    /// <summary>
    /// Block for amazon_managed_kafka_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonManagedKafkaEventSourceConfig block(s) allowed")]
    [TerraformProperty("amazon_managed_kafka_event_source_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock>>? AmazonManagedKafkaEventSourceConfig { get; set; }

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    [TerraformProperty("destination_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingDestinationConfigBlock>>? DestinationConfig { get; set; }

    /// <summary>
    /// Block for document_db_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentDbEventSourceConfig block(s) allowed")]
    [TerraformProperty("document_db_event_source_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock>>? DocumentDbEventSourceConfig { get; set; }

    /// <summary>
    /// Block for filter_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterCriteria block(s) allowed")]
    [TerraformProperty("filter_criteria")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingFilterCriteriaBlock>>? FilterCriteria { get; set; }

    /// <summary>
    /// Block for metrics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricsConfig block(s) allowed")]
    [TerraformProperty("metrics_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingMetricsConfigBlock>>? MetricsConfig { get; set; }

    /// <summary>
    /// Block for provisioned_poller_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisionedPollerConfig block(s) allowed")]
    [TerraformProperty("provisioned_poller_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingProvisionedPollerConfigBlock>>? ProvisionedPollerConfig { get; set; }

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    [TerraformProperty("scaling_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingScalingConfigBlock>>? ScalingConfig { get; set; }

    /// <summary>
    /// Block for self_managed_event_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedEventSource block(s) allowed")]
    [TerraformProperty("self_managed_event_source")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingSelfManagedEventSourceBlock>>? SelfManagedEventSource { get; set; }

    /// <summary>
    /// Block for self_managed_kafka_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedKafkaEventSourceConfig block(s) allowed")]
    [TerraformProperty("self_managed_kafka_event_source_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock>>? SelfManagedKafkaEventSourceConfig { get; set; }

    /// <summary>
    /// Block for source_access_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(22, ErrorMessage = "Maximum 22 SourceAccessConfiguration block(s) allowed")]
    [TerraformProperty("source_access_configuration")]
    public TerraformSet<TerraformBlock<AwsLambdaEventSourceMappingSourceAccessConfigurationBlock>>? SourceAccessConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [TerraformProperty("function_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FunctionArn { get; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModified { get; }

    /// <summary>
    /// The last_processing_result attribute.
    /// </summary>
    [TerraformProperty("last_processing_result")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastProcessingResult { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The state_transition_reason attribute.
    /// </summary>
    [TerraformProperty("state_transition_reason")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StateTransitionReason { get; }

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    [TerraformProperty("uuid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uuid { get; }

}
