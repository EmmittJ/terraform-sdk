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
    public double? BatchSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_size")?.Value;
        set => this.WithProperty("batch_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The bisect_batch_on_function_error attribute.
    /// </summary>
    public bool? BisectBatchOnFunctionError
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bisect_batch_on_function_error")?.Value;
        set => this.WithProperty("bisect_batch_on_function_error", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The event_source_arn attribute.
    /// </summary>
    public string? EventSourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_source_arn")?.Value;
        set => this.WithProperty("event_source_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public string? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name")?.Value;
        set => this.WithProperty("function_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_response_types attribute.
    /// </summary>
    public HashSet<string>? FunctionResponseTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("function_response_types")?.Value;
        set => this.WithProperty("function_response_types", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public double? MaximumBatchingWindowInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_batching_window_in_seconds")?.Value;
        set => this.WithProperty("maximum_batching_window_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The maximum_record_age_in_seconds attribute.
    /// </summary>
    public double? MaximumRecordAgeInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_record_age_in_seconds")?.Value;
        set => this.WithProperty("maximum_record_age_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public double? MaximumRetryAttempts
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_retry_attempts")?.Value;
        set => this.WithProperty("maximum_retry_attempts", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The parallelization_factor attribute.
    /// </summary>
    public double? ParallelizationFactor
    {
        get => GetProperty<TerraformLiteralProperty<double>>("parallelization_factor")?.Value;
        set => this.WithProperty("parallelization_factor", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The queues attribute.
    /// </summary>
    public List<string>? Queues
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("queues")?.Value;
        set => this.WithProperty("queues", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    public string? StartingPosition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("starting_position")?.Value;
        set => this.WithProperty("starting_position", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The starting_position_timestamp attribute.
    /// </summary>
    public string? StartingPositionTimestamp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("starting_position_timestamp")?.Value;
        set => this.WithProperty("starting_position_timestamp", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The topics attribute.
    /// </summary>
    public HashSet<string>? Topics
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("topics")?.Value;
        set => this.WithProperty("topics", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tumbling_window_in_seconds attribute.
    /// </summary>
    public double? TumblingWindowInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("tumbling_window_in_seconds")?.Value;
        set => this.WithProperty("tumbling_window_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
