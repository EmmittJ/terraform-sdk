using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_event_source_mapping resource.
/// </summary>
public class AwsLambdaEventSourceMapping : TerraformResource
{
    public AwsLambdaEventSourceMapping(string name) : base("aws_lambda_event_source_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("function_arn");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("last_processing_result");
        this.DeclareOutput("state");
        this.DeclareOutput("state_transition_reason");
        this.DeclareOutput("uuid");
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
    public TerraformProperty<string>? FunctionName
    {
        get => GetProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
    }

    /// <summary>
    /// The function_response_types attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? FunctionResponseTypes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("function_response_types");
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
    public TerraformProperty<List<string>>? Queues
    {
        get => GetProperty<TerraformProperty<List<string>>>("queues");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The topics attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Topics
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("topics");
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
