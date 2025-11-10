using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_log_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2StageAccessLogSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformPropertyName("destination_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationArn { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformPropertyName("format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Format { get; set; }

}

/// <summary>
/// Block type for default_route_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2StageDefaultRouteSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_trace_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DataTraceEnabled { get; set; }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("detailed_metrics_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DetailedMetricsEnabled { get; set; }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    [TerraformPropertyName("logging_level")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoggingLevel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "logging_level");

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    [TerraformPropertyName("throttling_burst_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ThrottlingBurstLimit { get; set; }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    [TerraformPropertyName("throttling_rate_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ThrottlingRateLimit { get; set; }

}

/// <summary>
/// Block type for route_settings in .
/// Nesting mode: set
/// </summary>
public class AwsApigatewayv2StageRouteSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_trace_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DataTraceEnabled { get; set; }

    /// <summary>
    /// The detailed_metrics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("detailed_metrics_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DetailedMetricsEnabled { get; set; }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    [TerraformPropertyName("logging_level")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoggingLevel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "logging_level");

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteKey is required")]
    [TerraformPropertyName("route_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RouteKey { get; set; }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    [TerraformPropertyName("throttling_burst_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ThrottlingBurstLimit { get; set; }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    [TerraformPropertyName("throttling_rate_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ThrottlingRateLimit { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_stage resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2Stage : TerraformResource
{
    public AwsApigatewayv2Stage(string name) : base("aws_apigatewayv2_stage", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiId { get; set; }

    /// <summary>
    /// The auto_deploy attribute.
    /// </summary>
    [TerraformPropertyName("auto_deploy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoDeploy { get; set; }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientCertificateId { get; set; }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DeploymentId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_id");

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
    /// The stage_variables attribute.
    /// </summary>
    [TerraformPropertyName("stage_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? StageVariables { get; set; }

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
    /// Block for access_log_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    [TerraformPropertyName("access_log_settings")]
    public TerraformList<TerraformBlock<AwsApigatewayv2StageAccessLogSettingsBlock>>? AccessLogSettings { get; set; } = new();

    /// <summary>
    /// Block for default_route_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultRouteSettings block(s) allowed")]
    [TerraformPropertyName("default_route_settings")]
    public TerraformList<TerraformBlock<AwsApigatewayv2StageDefaultRouteSettingsBlock>>? DefaultRouteSettings { get; set; } = new();

    /// <summary>
    /// Block for route_settings.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("route_settings")]
    public TerraformSet<TerraformBlock<AwsApigatewayv2StageRouteSettingsBlock>>? RouteSettings { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExecutionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "execution_arn");

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    [TerraformPropertyName("invoke_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvokeUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invoke_url");

}
