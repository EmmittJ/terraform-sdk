using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for amazon_managed_kafka_event_source_config in AwsLambdaEventSourceMapping.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amazon_managed_kafka_event_source_config";

    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    public TerraformValue<string> ConsumerGroupId
    {
        get => GetArgument<TerraformValue<string>>("consumer_group_id") ?? CreateReference("consumer_group_id");
        set => SetArgument("consumer_group_id", value);
    }

    /// <summary>
    /// SchemaRegistryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaRegistryConfig block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock>? SchemaRegistryConfig
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock>>("schema_registry_config");
        set => SetArgument("schema_registry_config", value);
    }

}

/// <summary>
/// Block type for schema_registry_config in AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_registry_config";

    /// <summary>
    /// The event_record_format attribute.
    /// </summary>
    public TerraformValue<string>? EventRecordFormat
    {
        get => GetArgument<TerraformValue<string>>("event_record_format");
        set => SetArgument("event_record_format", value);
    }

    /// <summary>
    /// The schema_registry_uri attribute.
    /// </summary>
    public TerraformValue<string>? SchemaRegistryUri
    {
        get => GetArgument<TerraformValue<string>>("schema_registry_uri");
        set => SetArgument("schema_registry_uri", value);
    }

    /// <summary>
    /// AccessConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockAccessConfigBlock>? AccessConfig
    {
        get => GetArgument<TerraformSet<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockAccessConfigBlock>>("access_config");
        set => SetArgument("access_config", value);
    }

    /// <summary>
    /// SchemaValidationConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockSchemaValidationConfigBlock>? SchemaValidationConfig
    {
        get => GetArgument<TerraformSet<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockSchemaValidationConfigBlock>>("schema_validation_config");
        set => SetArgument("schema_validation_config", value);
    }

}

/// <summary>
/// Block type for access_config in AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_config";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for schema_validation_config in AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockSchemaValidationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_validation_config";

    /// <summary>
    /// The attribute attribute.
    /// </summary>
    public TerraformValue<string>? Attribute
    {
        get => GetArgument<TerraformValue<string>>("attribute");
        set => SetArgument("attribute", value);
    }

}


/// <summary>
/// Block type for destination_config in AwsLambdaEventSourceMapping.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_config";

    /// <summary>
    /// OnFailure block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnFailure block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingDestinationConfigBlockOnFailureBlock>? OnFailure
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingDestinationConfigBlockOnFailureBlock>>("on_failure");
        set => SetArgument("on_failure", value);
    }

}

/// <summary>
/// Block type for on_failure in AwsLambdaEventSourceMappingDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingDestinationConfigBlockOnFailureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_failure";

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformValue<string> DestinationArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_arn");
        set => SetArgument("destination_arn", value);
    }

}


/// <summary>
/// Block type for document_db_event_source_config in AwsLambdaEventSourceMapping.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "document_db_event_source_config";

    /// <summary>
    /// The collection_name attribute.
    /// </summary>
    public TerraformValue<string>? CollectionName
    {
        get => GetArgument<TerraformValue<string>>("collection_name");
        set => SetArgument("collection_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The full_document attribute.
    /// </summary>
    public TerraformValue<string>? FullDocument
    {
        get => GetArgument<TerraformValue<string>>("full_document");
        set => SetArgument("full_document", value);
    }

}


/// <summary>
/// Block type for filter_criteria in AwsLambdaEventSourceMapping.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingFilterCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_criteria";

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Filter block(s) allowed")]
    public TerraformSet<AwsLambdaEventSourceMappingFilterCriteriaBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsLambdaEventSourceMappingFilterCriteriaBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for filter in AwsLambdaEventSourceMappingFilterCriteriaBlock.
/// Nesting mode: set
/// </summary>
public class AwsLambdaEventSourceMappingFilterCriteriaBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    public TerraformValue<string>? Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}


/// <summary>
/// Block type for metrics_config in AwsLambdaEventSourceMapping.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingMetricsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metrics_config";

    /// <summary>
    /// The metrics attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metrics is required")]
    public required TerraformSet<string> Metrics
    {
        get => GetRequiredArgument<TerraformSet<string>>("metrics");
        set => SetArgument("metrics", value);
    }

}


/// <summary>
/// Block type for provisioned_poller_config in AwsLambdaEventSourceMapping.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingProvisionedPollerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provisioned_poller_config";

    /// <summary>
    /// The maximum_pollers attribute.
    /// </summary>
    public TerraformValue<double> MaximumPollers
    {
        get => GetArgument<TerraformValue<double>>("maximum_pollers") ?? CreateReference("maximum_pollers");
        set => SetArgument("maximum_pollers", value);
    }

    /// <summary>
    /// The minimum_pollers attribute.
    /// </summary>
    public TerraformValue<double> MinimumPollers
    {
        get => GetArgument<TerraformValue<double>>("minimum_pollers") ?? CreateReference("minimum_pollers");
        set => SetArgument("minimum_pollers", value);
    }

}


/// <summary>
/// Block type for scaling_config in AwsLambdaEventSourceMapping.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingScalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling_config";

    /// <summary>
    /// The maximum_concurrency attribute.
    /// </summary>
    public TerraformValue<double>? MaximumConcurrency
    {
        get => GetArgument<TerraformValue<double>>("maximum_concurrency");
        set => SetArgument("maximum_concurrency", value);
    }

}


/// <summary>
/// Block type for self_managed_event_source in AwsLambdaEventSourceMapping.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingSelfManagedEventSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "self_managed_event_source";

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoints is required")]
    public required TerraformMap<string> Endpoints
    {
        get => GetRequiredArgument<TerraformMap<string>>("endpoints");
        set => SetArgument("endpoints", value);
    }

}


/// <summary>
/// Block type for self_managed_kafka_event_source_config in AwsLambdaEventSourceMapping.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "self_managed_kafka_event_source_config";

    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    public TerraformValue<string> ConsumerGroupId
    {
        get => GetArgument<TerraformValue<string>>("consumer_group_id") ?? CreateReference("consumer_group_id");
        set => SetArgument("consumer_group_id", value);
    }

    /// <summary>
    /// SchemaRegistryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaRegistryConfig block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock>? SchemaRegistryConfig
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock>>("schema_registry_config");
        set => SetArgument("schema_registry_config", value);
    }

}

/// <summary>
/// Block type for schema_registry_config in AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_registry_config";

    /// <summary>
    /// The event_record_format attribute.
    /// </summary>
    public TerraformValue<string>? EventRecordFormat
    {
        get => GetArgument<TerraformValue<string>>("event_record_format");
        set => SetArgument("event_record_format", value);
    }

    /// <summary>
    /// The schema_registry_uri attribute.
    /// </summary>
    public TerraformValue<string>? SchemaRegistryUri
    {
        get => GetArgument<TerraformValue<string>>("schema_registry_uri");
        set => SetArgument("schema_registry_uri", value);
    }

    /// <summary>
    /// AccessConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockAccessConfigBlock>? AccessConfig
    {
        get => GetArgument<TerraformSet<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockAccessConfigBlock>>("access_config");
        set => SetArgument("access_config", value);
    }

    /// <summary>
    /// SchemaValidationConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockSchemaValidationConfigBlock>? SchemaValidationConfig
    {
        get => GetArgument<TerraformSet<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockSchemaValidationConfigBlock>>("schema_validation_config");
        set => SetArgument("schema_validation_config", value);
    }

}

/// <summary>
/// Block type for access_config in AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_config";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for schema_validation_config in AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlockSchemaRegistryConfigBlockSchemaValidationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_validation_config";

    /// <summary>
    /// The attribute attribute.
    /// </summary>
    public TerraformValue<string>? Attribute
    {
        get => GetArgument<TerraformValue<string>>("attribute");
        set => SetArgument("attribute", value);
    }

}


/// <summary>
/// Block type for source_access_configuration in AwsLambdaEventSourceMapping.
/// Nesting mode: set
/// </summary>
public class AwsLambdaEventSourceMappingSourceAccessConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_access_configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Represents a aws_lambda_event_source_mapping Terraform resource.
/// Manages a aws_lambda_event_source_mapping resource.
/// </summary>
public partial class AwsLambdaEventSourceMapping(string name) : TerraformResource("aws_lambda_event_source_mapping", name)
{
    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformValue<double>? BatchSize
    {
        get => GetArgument<TerraformValue<double>>("batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The bisect_batch_on_function_error attribute.
    /// </summary>
    public TerraformValue<bool>? BisectBatchOnFunctionError
    {
        get => GetArgument<TerraformValue<bool>>("bisect_batch_on_function_error");
        set => SetArgument("bisect_batch_on_function_error", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The event_source_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventSourceArn
    {
        get => GetArgument<TerraformValue<string>>("event_source_arn");
        set => SetArgument("event_source_arn", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The function_response_types attribute.
    /// </summary>
    public TerraformSet<string>? FunctionResponseTypes
    {
        get => GetArgument<TerraformSet<string>>("function_response_types");
        set => SetArgument("function_response_types", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaximumBatchingWindowInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_batching_window_in_seconds");
        set => SetArgument("maximum_batching_window_in_seconds", value);
    }

    /// <summary>
    /// The maximum_record_age_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumRecordAgeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_record_age_in_seconds") ?? CreateReference("maximum_record_age_in_seconds");
        set => SetArgument("maximum_record_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformValue<double> MaximumRetryAttempts
    {
        get => GetArgument<TerraformValue<double>>("maximum_retry_attempts") ?? CreateReference("maximum_retry_attempts");
        set => SetArgument("maximum_retry_attempts", value);
    }

    /// <summary>
    /// The parallelization_factor attribute.
    /// </summary>
    public TerraformValue<double> ParallelizationFactor
    {
        get => GetArgument<TerraformValue<double>>("parallelization_factor") ?? CreateReference("parallelization_factor");
        set => SetArgument("parallelization_factor", value);
    }

    /// <summary>
    /// The queues attribute.
    /// </summary>
    public TerraformList<string>? Queues
    {
        get => GetArgument<TerraformList<string>>("queues");
        set => SetArgument("queues", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    public TerraformValue<string>? StartingPosition
    {
        get => GetArgument<TerraformValue<string>>("starting_position");
        set => SetArgument("starting_position", value);
    }

    /// <summary>
    /// The starting_position_timestamp attribute.
    /// </summary>
    public TerraformValue<string>? StartingPositionTimestamp
    {
        get => GetArgument<TerraformValue<string>>("starting_position_timestamp");
        set => SetArgument("starting_position_timestamp", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The topics attribute.
    /// </summary>
    public TerraformSet<string>? Topics
    {
        get => GetArgument<TerraformSet<string>>("topics");
        set => SetArgument("topics", value);
    }

    /// <summary>
    /// The tumbling_window_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TumblingWindowInSeconds
    {
        get => GetArgument<TerraformValue<double>>("tumbling_window_in_seconds");
        set => SetArgument("tumbling_window_in_seconds", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public TerraformValue<string> FunctionArn
        => CreateReference("function_arn");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
        => CreateReference("last_modified");

    /// <summary>
    /// The last_processing_result attribute.
    /// </summary>
    public TerraformValue<string> LastProcessingResult
        => CreateReference("last_processing_result");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The state_transition_reason attribute.
    /// </summary>
    public TerraformValue<string> StateTransitionReason
        => CreateReference("state_transition_reason");

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformValue<string> Uuid
        => CreateReference("uuid");

    /// <summary>
    /// AmazonManagedKafkaEventSourceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonManagedKafkaEventSourceConfig block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock>? AmazonManagedKafkaEventSourceConfig
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingAmazonManagedKafkaEventSourceConfigBlock>>("amazon_managed_kafka_event_source_config");
        set => SetArgument("amazon_managed_kafka_event_source_config", value);
    }

    /// <summary>
    /// DestinationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingDestinationConfigBlock>? DestinationConfig
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingDestinationConfigBlock>>("destination_config");
        set => SetArgument("destination_config", value);
    }

    /// <summary>
    /// DocumentDbEventSourceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentDbEventSourceConfig block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock>? DocumentDbEventSourceConfig
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingDocumentDbEventSourceConfigBlock>>("document_db_event_source_config");
        set => SetArgument("document_db_event_source_config", value);
    }

    /// <summary>
    /// FilterCriteria block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterCriteria block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingFilterCriteriaBlock>? FilterCriteria
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingFilterCriteriaBlock>>("filter_criteria");
        set => SetArgument("filter_criteria", value);
    }

    /// <summary>
    /// MetricsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricsConfig block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingMetricsConfigBlock>? MetricsConfig
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingMetricsConfigBlock>>("metrics_config");
        set => SetArgument("metrics_config", value);
    }

    /// <summary>
    /// ProvisionedPollerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisionedPollerConfig block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingProvisionedPollerConfigBlock>? ProvisionedPollerConfig
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingProvisionedPollerConfigBlock>>("provisioned_poller_config");
        set => SetArgument("provisioned_poller_config", value);
    }

    /// <summary>
    /// ScalingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingScalingConfigBlock>? ScalingConfig
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingScalingConfigBlock>>("scaling_config");
        set => SetArgument("scaling_config", value);
    }

    /// <summary>
    /// SelfManagedEventSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedEventSource block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingSelfManagedEventSourceBlock>? SelfManagedEventSource
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingSelfManagedEventSourceBlock>>("self_managed_event_source");
        set => SetArgument("self_managed_event_source", value);
    }

    /// <summary>
    /// SelfManagedKafkaEventSourceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedKafkaEventSourceConfig block(s) allowed")]
    public TerraformList<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock>? SelfManagedKafkaEventSourceConfig
    {
        get => GetArgument<TerraformList<AwsLambdaEventSourceMappingSelfManagedKafkaEventSourceConfigBlock>>("self_managed_kafka_event_source_config");
        set => SetArgument("self_managed_kafka_event_source_config", value);
    }

    /// <summary>
    /// SourceAccessConfiguration block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(22, ErrorMessage = "Maximum 22 SourceAccessConfiguration block(s) allowed")]
    public TerraformSet<AwsLambdaEventSourceMappingSourceAccessConfigurationBlock>? SourceAccessConfiguration
    {
        get => GetArgument<TerraformSet<AwsLambdaEventSourceMappingSourceAccessConfigurationBlock>>("source_access_configuration");
        set => SetArgument("source_access_configuration", value);
    }

}
