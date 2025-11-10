using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for amazon_managed_kafka_event_source_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    [TerraformPropertyName("consumer_group_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ConsumerGroupId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "consumer_group_id");

}

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingDestinationConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for document_db_event_source_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The collection_name attribute.
    /// </summary>
    [TerraformPropertyName("collection_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CollectionName { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; }

    /// <summary>
    /// The full_document attribute.
    /// </summary>
    [TerraformPropertyName("full_document")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FullDocument { get; set; }

}

/// <summary>
/// Block type for filter_criteria in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingFilterCriteriaBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for metrics_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingMetricsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The metrics attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metrics is required")]
    [TerraformPropertyName("metrics")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Metrics { get; set; }

}

/// <summary>
/// Block type for provisioned_poller_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingProvisionedPollerConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum_pollers attribute.
    /// </summary>
    [TerraformPropertyName("maximum_pollers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaximumPollers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "maximum_pollers");

    /// <summary>
    /// The minimum_pollers attribute.
    /// </summary>
    [TerraformPropertyName("minimum_pollers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MinimumPollers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "minimum_pollers");

}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingScalingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum_concurrency attribute.
    /// </summary>
    [TerraformPropertyName("maximum_concurrency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumConcurrency { get; set; }

}

/// <summary>
/// Block type for self_managed_event_source in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingSelfManagedEventSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoints is required")]
    [TerraformPropertyName("endpoints")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Endpoints { get; set; }

}

/// <summary>
/// Block type for self_managed_kafka_event_source_config in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    [TerraformPropertyName("consumer_group_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ConsumerGroupId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "consumer_group_id");

}

/// <summary>
/// Block type for source_access_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsLambdaEventSourceMappingSourceAccessConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Uri { get; set; }

}

/// <summary>
/// Manages a aws_lambda_event_source_mapping resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaEventSourceMapping : TerraformResource
{
    public AwsLambdaEventSourceMapping(string name) : base("aws_lambda_event_source_mapping", name)
    {
    }

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    [TerraformPropertyName("batch_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BatchSize { get; set; }

    /// <summary>
    /// The bisect_batch_on_function_error attribute.
    /// </summary>
    [TerraformPropertyName("bisect_batch_on_function_error")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BisectBatchOnFunctionError { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The event_source_arn attribute.
    /// </summary>
    [TerraformPropertyName("event_source_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EventSourceArn { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformPropertyName("function_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionName { get; set; }

    /// <summary>
    /// The function_response_types attribute.
    /// </summary>
    [TerraformPropertyName("function_response_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? FunctionResponseTypes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("maximum_batching_window_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumBatchingWindowInSeconds { get; set; }

    /// <summary>
    /// The maximum_record_age_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("maximum_record_age_in_seconds")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaximumRecordAgeInSeconds { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_record_age_in_seconds");

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    [TerraformPropertyName("maximum_retry_attempts")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaximumRetryAttempts { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_retry_attempts");

    /// <summary>
    /// The parallelization_factor attribute.
    /// </summary>
    [TerraformPropertyName("parallelization_factor")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ParallelizationFactor { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "parallelization_factor");

    /// <summary>
    /// The queues attribute.
    /// </summary>
    [TerraformPropertyName("queues")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Queues { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    [TerraformPropertyName("starting_position")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartingPosition { get; set; }

    /// <summary>
    /// The starting_position_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("starting_position_timestamp")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartingPositionTimestamp { get; set; }

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
    /// The topics attribute.
    /// </summary>
    [TerraformPropertyName("topics")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Topics { get; set; }

    /// <summary>
    /// The tumbling_window_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tumbling_window_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TumblingWindowInSeconds { get; set; }

    /// <summary>
    /// Block for amazon_managed_kafka_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonManagedKafkaEventSourceConfig block(s) allowed")]
    [TerraformPropertyName("amazon_managed_kafka_event_source_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock>>? AmazonManagedKafkaEventSourceConfig { get; set; } = new();

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    [TerraformPropertyName("destination_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingDestinationConfigBlock>>? DestinationConfig { get; set; } = new();

    /// <summary>
    /// Block for document_db_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentDbEventSourceConfig block(s) allowed")]
    [TerraformPropertyName("document_db_event_source_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock>>? DocumentDbEventSourceConfig { get; set; } = new();

    /// <summary>
    /// Block for filter_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterCriteria block(s) allowed")]
    [TerraformPropertyName("filter_criteria")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingFilterCriteriaBlock>>? FilterCriteria { get; set; } = new();

    /// <summary>
    /// Block for metrics_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricsConfig block(s) allowed")]
    [TerraformPropertyName("metrics_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingMetricsConfigBlock>>? MetricsConfig { get; set; } = new();

    /// <summary>
    /// Block for provisioned_poller_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisionedPollerConfig block(s) allowed")]
    [TerraformPropertyName("provisioned_poller_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingProvisionedPollerConfigBlock>>? ProvisionedPollerConfig { get; set; } = new();

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    [TerraformPropertyName("scaling_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingScalingConfigBlock>>? ScalingConfig { get; set; } = new();

    /// <summary>
    /// Block for self_managed_event_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedEventSource block(s) allowed")]
    [TerraformPropertyName("self_managed_event_source")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingSelfManagedEventSourceBlock>>? SelfManagedEventSource { get; set; } = new();

    /// <summary>
    /// Block for self_managed_kafka_event_source_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedKafkaEventSourceConfig block(s) allowed")]
    [TerraformPropertyName("self_managed_kafka_event_source_config")]
    public TerraformList<TerraformBlock<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock>>? SelfManagedKafkaEventSourceConfig { get; set; } = new();

    /// <summary>
    /// Block for source_access_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(22, ErrorMessage = "Maximum 22 SourceAccessConfiguration block(s) allowed")]
    [TerraformPropertyName("source_access_configuration")]
    public TerraformSet<TerraformBlock<AwsLambdaEventSourceMappingSourceAccessConfigurationBlock>>? SourceAccessConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [TerraformPropertyName("function_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FunctionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "function_arn");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModified => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified");

    /// <summary>
    /// The last_processing_result attribute.
    /// </summary>
    [TerraformPropertyName("last_processing_result")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastProcessingResult => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_processing_result");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The state_transition_reason attribute.
    /// </summary>
    [TerraformPropertyName("state_transition_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateTransitionReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_transition_reason");

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    [TerraformPropertyName("uuid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uuid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uuid");

}
