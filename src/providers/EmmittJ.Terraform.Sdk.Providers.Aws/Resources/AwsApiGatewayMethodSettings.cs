using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsApiGatewayMethodSettingsSettingsBlock() : TerraformBlock("settings")
{
    /// <summary>
    /// The cache_data_encrypted attribute.
    /// </summary>
    [TerraformProperty("cache_data_encrypted")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> CacheDataEncrypted { get; set; }

    /// <summary>
    /// The cache_ttl_in_seconds attribute.
    /// </summary>
    [TerraformProperty("cache_ttl_in_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> CacheTtlInSeconds { get; set; }

    /// <summary>
    /// The caching_enabled attribute.
    /// </summary>
    [TerraformProperty("caching_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> CachingEnabled { get; set; }

    /// <summary>
    /// The data_trace_enabled attribute.
    /// </summary>
    [TerraformProperty("data_trace_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DataTraceEnabled { get; set; }

    /// <summary>
    /// The logging_level attribute.
    /// </summary>
    [TerraformProperty("logging_level")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LoggingLevel { get; set; }

    /// <summary>
    /// The metrics_enabled attribute.
    /// </summary>
    [TerraformProperty("metrics_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> MetricsEnabled { get; set; }

    /// <summary>
    /// The require_authorization_for_cache_control attribute.
    /// </summary>
    [TerraformProperty("require_authorization_for_cache_control")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> RequireAuthorizationForCacheControl { get; set; }

    /// <summary>
    /// The throttling_burst_limit attribute.
    /// </summary>
    [TerraformProperty("throttling_burst_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ThrottlingBurstLimit { get; set; }

    /// <summary>
    /// The throttling_rate_limit attribute.
    /// </summary>
    [TerraformProperty("throttling_rate_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ThrottlingRateLimit { get; set; }

    /// <summary>
    /// The unauthorized_cache_control_header_strategy attribute.
    /// </summary>
    [TerraformProperty("unauthorized_cache_control_header_strategy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UnauthorizedCacheControlHeaderStrategy { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_method_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApiGatewayMethodSettings : TerraformResource
{
    public AwsApiGatewayMethodSettings(string name) : base("aws_api_gateway_method_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The method_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MethodPath is required")]
    [TerraformProperty("method_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MethodPath { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformProperty("rest_api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    [TerraformProperty("stage_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StageName { get; set; }

    /// <summary>
    /// Block for settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Settings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Settings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Settings block(s) allowed")]
    [TerraformProperty("settings")]
    public required TerraformList<AwsApiGatewayMethodSettingsSettingsBlock> Settings { get; set; } = new();

}
