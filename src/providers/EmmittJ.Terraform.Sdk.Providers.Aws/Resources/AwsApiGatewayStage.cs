using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_log_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayStageAccessLogSettingsBlock
{
    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformPropertyName("destination_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DestinationArn { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformPropertyName("format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Format { get; set; }

}

/// <summary>
/// Block type for canary_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayStageCanarySettingsBlock
{
    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    [TerraformPropertyName("deployment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeploymentId { get; set; }

    /// <summary>
    /// The percent_traffic attribute.
    /// </summary>
    [TerraformPropertyName("percent_traffic")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PercentTraffic { get; set; }

    /// <summary>
    /// The stage_variable_overrides attribute.
    /// </summary>
    [TerraformPropertyName("stage_variable_overrides")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? StageVariableOverrides { get; set; }

    /// <summary>
    /// The use_stage_cache attribute.
    /// </summary>
    [TerraformPropertyName("use_stage_cache")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseStageCache { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_stage resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayStage : TerraformResource
{
    public AwsApiGatewayStage(string name) : base("aws_api_gateway_stage", name)
    {
    }

    /// <summary>
    /// The cache_cluster_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cache_cluster_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CacheClusterEnabled { get; set; }

    /// <summary>
    /// The cache_cluster_size attribute.
    /// </summary>
    [TerraformPropertyName("cache_cluster_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CacheClusterSize { get; set; }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientCertificateId { get; set; }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    [TerraformPropertyName("deployment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeploymentId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The documentation_version attribute.
    /// </summary>
    [TerraformPropertyName("documentation_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DocumentationVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The variables attribute.
    /// </summary>
    [TerraformPropertyName("variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Variables { get; set; }

    /// <summary>
    /// The xray_tracing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("xray_tracing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? XrayTracingEnabled { get; set; }

    /// <summary>
    /// Block for access_log_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    [TerraformPropertyName("access_log_settings")]
    public TerraformList<TerraformBlock<AwsApiGatewayStageAccessLogSettingsBlock>>? AccessLogSettings { get; set; }

    /// <summary>
    /// Block for canary_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanarySettings block(s) allowed")]
    [TerraformPropertyName("canary_settings")]
    public TerraformList<TerraformBlock<AwsApiGatewayStageCanarySettingsBlock>>? CanarySettings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExecutionArn => new TerraformReference(this, "execution_arn");

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    [TerraformPropertyName("invoke_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InvokeUrl => new TerraformReference(this, "invoke_url");

    /// <summary>
    /// The web_acl_arn attribute.
    /// </summary>
    [TerraformPropertyName("web_acl_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebAclArn => new TerraformReference(this, "web_acl_arn");

}
