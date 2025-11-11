using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayIntegrationTlsConfigBlock
{
    /// <summary>
    /// The insecure_skip_verification attribute.
    /// </summary>
    [TerraformPropertyName("insecure_skip_verification")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InsecureSkipVerification { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_integration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApiGatewayIntegration : TerraformResource
{
    public AwsApiGatewayIntegration(string name) : base("aws_api_gateway_integration", name)
    {
    }

    /// <summary>
    /// The cache_key_parameters attribute.
    /// </summary>
    [TerraformPropertyName("cache_key_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? CacheKeyParameters { get; set; }

    /// <summary>
    /// The cache_namespace attribute.
    /// </summary>
    [TerraformPropertyName("cache_namespace")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CacheNamespace { get; set; } = default!;

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [TerraformPropertyName("connection_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionId { get; set; }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    [TerraformPropertyName("connection_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionType { get; set; }

    /// <summary>
    /// The content_handling attribute.
    /// </summary>
    [TerraformPropertyName("content_handling")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentHandling { get; set; }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    [TerraformPropertyName("credentials")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Credentials { get; set; }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    [TerraformPropertyName("http_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HttpMethod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The integration_http_method attribute.
    /// </summary>
    [TerraformPropertyName("integration_http_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IntegrationHttpMethod { get; set; }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    [TerraformPropertyName("passthrough_behavior")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PassthroughBehavior { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    [TerraformPropertyName("request_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? RequestParameters { get; set; }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    [TerraformPropertyName("request_templates")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? RequestTemplates { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformPropertyName("rest_api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_milliseconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TimeoutMilliseconds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Uri { get; set; }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    [TerraformPropertyName("tls_config")]
    public TerraformList<TerraformBlock<AwsApiGatewayIntegrationTlsConfigBlock>>? TlsConfig { get; set; }

}
