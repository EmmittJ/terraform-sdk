using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayIntegrationTlsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The insecure_skip_verification attribute.
    /// </summary>
    [TerraformPropertyName("insecure_skip_verification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InsecureSkipVerification { get; set; }

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
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CacheKeyParameters { get; set; }

    /// <summary>
    /// The cache_namespace attribute.
    /// </summary>
    [TerraformPropertyName("cache_namespace")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CacheNamespace { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cache_namespace");

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [TerraformPropertyName("connection_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConnectionId { get; set; }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    [TerraformPropertyName("connection_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConnectionType { get; set; }

    /// <summary>
    /// The content_handling attribute.
    /// </summary>
    [TerraformPropertyName("content_handling")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentHandling { get; set; }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    [TerraformPropertyName("credentials")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Credentials { get; set; }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    [TerraformPropertyName("http_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HttpMethod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The integration_http_method attribute.
    /// </summary>
    [TerraformPropertyName("integration_http_method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IntegrationHttpMethod { get; set; }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    [TerraformPropertyName("passthrough_behavior")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PassthroughBehavior { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "passthrough_behavior");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    [TerraformPropertyName("request_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? RequestParameters { get; set; }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    [TerraformPropertyName("request_templates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? RequestTemplates { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformPropertyName("resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceId { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformPropertyName("rest_api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RestApiId { get; set; }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_milliseconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TimeoutMilliseconds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Uri { get; set; }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    [TerraformPropertyName("tls_config")]
    public TerraformList<TerraformBlock<AwsApiGatewayIntegrationTlsConfigBlock>>? TlsConfig { get; set; } = new();

}
