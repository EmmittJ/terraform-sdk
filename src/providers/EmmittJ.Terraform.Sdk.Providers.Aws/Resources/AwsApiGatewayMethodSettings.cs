using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayMethodSettingsSettingsBlock
{
    /// <summary>
    /// The cache_data_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("cache_data_encrypted")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> CacheDataEncrypted { get; set; } = default!;

    /// <summary>
    /// The cache_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("cache_ttl_in_seconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> CacheTtlInSeconds { get; set; } = default!;

    /// <summary>
    /// The caching_enabled attribute.
    /// </summary>
    [TerraformPropertyName("caching_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> CachingEnabled { get; set; } = default!;

    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_trace_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DataTraceEnabled { get; set; } = default!;

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    [TerraformPropertyName("logging_level")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoggingLevel { get; set; } = default!;

    /// <summary>
    /// The metrics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("metrics_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> MetricsEnabled { get; set; } = default!;

    /// <summary>
    /// The require_authorization_for_cache_control attribute.
    /// </summary>
    [TerraformPropertyName("require_authorization_for_cache_control")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireAuthorizationForCacheControl { get; set; } = default!;

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    [TerraformPropertyName("throttling_burst_limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ThrottlingBurstLimit { get; set; }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    [TerraformPropertyName("throttling_rate_limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ThrottlingRateLimit { get; set; }

    /// <summary>
    /// The unauthorized_cache_control_header_strategy attribute.
    /// </summary>
    [TerraformPropertyName("unauthorized_cache_control_header_strategy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UnauthorizedCacheControlHeaderStrategy { get; set; } = default!;

}

/// <summary>
/// Manages a aws_api_gateway_method_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayMethodSettings : TerraformResource
{
    public AwsApiGatewayMethodSettings(string name) : base("aws_api_gateway_method_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The method_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodPath is required")]
    [TerraformPropertyName("method_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MethodPath { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformPropertyName("rest_api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    [TerraformPropertyName("stage_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StageName { get; set; }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Settings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Settings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    [TerraformPropertyName("settings")]
    public TerraformList<TerraformBlock<AwsApiGatewayMethodSettingsSettingsBlock>>? Settings { get; set; }

}
