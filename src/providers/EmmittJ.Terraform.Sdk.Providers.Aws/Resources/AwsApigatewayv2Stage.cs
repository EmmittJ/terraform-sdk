using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_log_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsApigatewayv2StageAccessLogSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformProperty("destination_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationArn { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformProperty("format")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Format { get; set; }

}

/// <summary>
/// Block type for default_route_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsApigatewayv2StageDefaultRouteSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    [TerraformProperty("data_trace_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DataTraceEnabled { get; set; }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    [TerraformProperty("detailed_metrics_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DetailedMetricsEnabled { get; set; }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    [TerraformProperty("logging_level")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LoggingLevel { get; set; }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    [TerraformProperty("throttling_burst_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ThrottlingBurstLimit { get; set; }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    [TerraformProperty("throttling_rate_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ThrottlingRateLimit { get; set; }

}

/// <summary>
/// Block type for route_settings in .
/// Nesting mode: set
/// </summary>
public partial class AwsApigatewayv2StageRouteSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    [TerraformProperty("data_trace_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DataTraceEnabled { get; set; }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    [TerraformProperty("detailed_metrics_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DetailedMetricsEnabled { get; set; }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    [TerraformProperty("logging_level")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LoggingLevel { get; set; }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    [TerraformProperty("route_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RouteKey { get; set; }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    [TerraformProperty("throttling_burst_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ThrottlingBurstLimit { get; set; }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    [TerraformProperty("throttling_rate_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ThrottlingRateLimit { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_stage resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApigatewayv2Stage : TerraformResource
{
    public AwsApigatewayv2Stage(string name) : base("aws_apigatewayv2_stage", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The auto_deploy attribute.
    /// </summary>
    [TerraformProperty("auto_deploy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoDeploy { get; set; }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    [TerraformProperty("client_certificate_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientCertificateId { get; set; }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformProperty("deployment_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DeploymentId { get; set; }

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
    /// The stage_variables attribute.
    /// </summary>
    [TerraformProperty("stage_variables")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? StageVariables { get; set; }

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
    /// Block for access_log_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    [TerraformProperty("access_log_settings")]
    public TerraformList<TerraformBlock<AwsApigatewayv2StageAccessLogSettingsBlock>>? AccessLogSettings { get; set; }

    /// <summary>
    /// Block for default_route_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteSettings block(s) allowed")]
    [TerraformProperty("default_route_settings")]
    public TerraformList<TerraformBlock<AwsApigatewayv2StageDefaultRouteSettingsBlock>>? DefaultRouteSettings { get; set; }

    /// <summary>
    /// Block for route_settings.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("route_settings")]
    public TerraformSet<TerraformBlock<AwsApigatewayv2StageRouteSettingsBlock>>? RouteSettings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformProperty("execution_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExecutionArn { get; }

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    [TerraformProperty("invoke_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InvokeUrl { get; }

}
