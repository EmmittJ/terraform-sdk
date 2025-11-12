using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsApiGatewayIntegrationTlsConfigBlock() : TerraformBlock("tls_config")
{
    /// <summary>
    /// The insecure_skip_verification attribute.
    /// </summary>
    [TerraformProperty("insecure_skip_verification")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InsecureSkipVerification { get; set; }

}

/// <summary>
/// Manages a aws_api_gateway_integration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApiGatewayIntegration : TerraformResource
{
    public AwsApiGatewayIntegration(string name) : base("aws_api_gateway_integration", name)
    {
    }

    /// <summary>
    /// The cache_key_parameters attribute.
    /// </summary>
    [TerraformProperty("cache_key_parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? CacheKeyParameters { get; set; }

    /// <summary>
    /// The cache_namespace attribute.
    /// </summary>
    [TerraformProperty("cache_namespace")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CacheNamespace { get; set; }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [TerraformProperty("connection_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionId { get; set; }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    [TerraformProperty("connection_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionType { get; set; }

    /// <summary>
    /// The content_handling attribute.
    /// </summary>
    [TerraformProperty("content_handling")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentHandling { get; set; }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    [TerraformProperty("credentials")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Credentials { get; set; }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    [TerraformProperty("http_method")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HttpMethod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integration_http_method attribute.
    /// </summary>
    [TerraformProperty("integration_http_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IntegrationHttpMethod { get; set; }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    [TerraformProperty("passthrough_behavior")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PassthroughBehavior { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    [TerraformProperty("request_parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? RequestParameters { get; set; }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    [TerraformProperty("request_templates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? RequestTemplates { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceId { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformProperty("rest_api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    [TerraformProperty("timeout_milliseconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutMilliseconds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Uri { get; set; }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    [TerraformProperty("tls_config")]
    public TerraformList<AwsApiGatewayIntegrationTlsConfigBlock> TlsConfig { get; set; } = new();

}
