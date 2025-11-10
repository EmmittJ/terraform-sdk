using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_log_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayStageAccessLogSettingsBlock : ITerraformBlock
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
/// Block type for canary_settings in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayStageCanarySettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    [TerraformPropertyName("deployment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeploymentId { get; set; }

    /// <summary>
    /// The percent_traffic attribute.
    /// </summary>
    [TerraformPropertyName("percent_traffic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PercentTraffic { get; set; }

    /// <summary>
    /// The stage_variable_overrides attribute.
    /// </summary>
    [TerraformPropertyName("stage_variable_overrides")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? StageVariableOverrides { get; set; }

    /// <summary>
    /// The use_stage_cache attribute.
    /// </summary>
    [TerraformPropertyName("use_stage_cache")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseStageCache { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? CacheClusterEnabled { get; set; }

    /// <summary>
    /// The cache_cluster_size attribute.
    /// </summary>
    [TerraformPropertyName("cache_cluster_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CacheClusterSize { get; set; }

    /// <summary>
    /// The client_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientCertificateId { get; set; }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentId is required")]
    [TerraformPropertyName("deployment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeploymentId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The documentation_version attribute.
    /// </summary>
    [TerraformPropertyName("documentation_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DocumentationVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformPropertyName("rest_api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RestApiId { get; set; }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    [TerraformPropertyName("stage_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StageName { get; set; }

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
    /// The variables attribute.
    /// </summary>
    [TerraformPropertyName("variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Variables { get; set; }

    /// <summary>
    /// The xray_tracing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("xray_tracing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? XrayTracingEnabled { get; set; }

    /// <summary>
    /// Block for access_log_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogSettings block(s) allowed")]
    [TerraformPropertyName("access_log_settings")]
    public TerraformList<TerraformBlock<AwsApiGatewayStageAccessLogSettingsBlock>>? AccessLogSettings { get; set; } = new();

    /// <summary>
    /// Block for canary_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CanarySettings block(s) allowed")]
    [TerraformPropertyName("canary_settings")]
    public TerraformList<TerraformBlock<AwsApiGatewayStageCanarySettingsBlock>>? CanarySettings { get; set; } = new();

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

    /// <summary>
    /// The web_acl_arn attribute.
    /// </summary>
    [TerraformPropertyName("web_acl_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebAclArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "web_acl_arn");

}
