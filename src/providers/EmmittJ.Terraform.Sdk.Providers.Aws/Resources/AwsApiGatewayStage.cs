using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_log_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsApiGatewayStageAccessLogSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformProperty("destination_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationArn { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    [TerraformProperty("format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Format { get; set; }

}

/// <summary>
/// Block type for canary_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsApiGatewayStageCanarySettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    [TerraformProperty("deployment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeploymentId { get; set; }

    /// <summary>
    /// The percent_traffic attribute.
    /// </summary>
    [TerraformProperty("percent_traffic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PercentTraffic { get; set; }

    /// <summary>
    /// The stage_variable_overrides attribute.
    /// </summary>
    [TerraformProperty("stage_variable_overrides")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? StageVariableOverrides { get; set; }

    /// <summary>
    /// The use_stage_cache attribute.
    /// </summary>
    [TerraformProperty("use_stage_cache")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseStageCache { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_stage resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApiGatewayStage : TerraformResource
{
    public AwsApiGatewayStage(string name) : base("aws_api_gateway_stage", name)
    {
    }

    /// <summary>
    /// The cache_cluster_enabled attribute.
    /// </summary>
    [TerraformProperty("cache_cluster_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CacheClusterEnabled { get; set; }

    /// <summary>
    /// The cache_cluster_size attribute.
    /// </summary>
    [TerraformProperty("cache_cluster_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CacheClusterSize { get; set; }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    [TerraformProperty("client_certificate_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientCertificateId { get; set; }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    [TerraformProperty("deployment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeploymentId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The documentation_version attribute.
    /// </summary>
    [TerraformProperty("documentation_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DocumentationVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    [TerraformProperty("variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Variables { get; set; }

    /// <summary>
    /// The xray_tracing_enabled attribute.
    /// </summary>
    [TerraformProperty("xray_tracing_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? XrayTracingEnabled { get; set; }

    /// <summary>
    /// Block for access_log_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    [TerraformProperty("access_log_settings")]
    public partial TerraformList<TerraformBlock<AwsApiGatewayStageAccessLogSettingsBlock>>? AccessLogSettings { get; set; }

    /// <summary>
    /// Block for canary_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanarySettings block(s) allowed")]
    [TerraformProperty("canary_settings")]
    public partial TerraformList<TerraformBlock<AwsApiGatewayStageCanarySettingsBlock>>? CanarySettings { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformProperty("execution_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExecutionArn { get; }

    /// <summary>
    /// The invoke_url attribute.
    /// </summary>
    [TerraformProperty("invoke_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InvokeUrl { get; }

    /// <summary>
    /// The web_acl_arn attribute.
    /// </summary>
    [TerraformProperty("web_acl_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WebAclArn { get; }

}
