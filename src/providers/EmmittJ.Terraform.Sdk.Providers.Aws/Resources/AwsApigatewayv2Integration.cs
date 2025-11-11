using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for response_parameters in .
/// Nesting mode: set
/// </summary>
public partial class AwsApigatewayv2IntegrationResponseParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// The mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mappings is required")]
    [TerraformProperty("mappings")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> Mappings { get; set; }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    [TerraformProperty("status_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StatusCode { get; set; }

}

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsApigatewayv2IntegrationTlsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The server_name_to_verify attribute.
    /// </summary>
    [TerraformProperty("server_name_to_verify")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServerNameToVerify { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_integration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApigatewayv2Integration : TerraformResource
{
    public AwsApigatewayv2Integration(string name) : base("aws_apigatewayv2_integration", name)
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
    /// The connection_id attribute.
    /// </summary>
    [TerraformProperty("connection_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionId { get; set; }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    [TerraformProperty("connection_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionType { get; set; }

    /// <summary>
    /// The content_handling_strategy attribute.
    /// </summary>
    [TerraformProperty("content_handling_strategy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContentHandlingStrategy { get; set; }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    [TerraformProperty("credentials_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CredentialsArn { get; set; }

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
    /// The integration_method attribute.
    /// </summary>
    [TerraformProperty("integration_method")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IntegrationMethod { get; set; }

    /// <summary>
    /// The integration_subtype attribute.
    /// </summary>
    [TerraformProperty("integration_subtype")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IntegrationSubtype { get; set; }

    /// <summary>
    /// The integration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    [TerraformProperty("integration_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IntegrationType { get; set; }

    /// <summary>
    /// The integration_uri attribute.
    /// </summary>
    [TerraformProperty("integration_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IntegrationUri { get; set; }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    [TerraformProperty("passthrough_behavior")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PassthroughBehavior { get; set; }

    /// <summary>
    /// The payload_format_version attribute.
    /// </summary>
    [TerraformProperty("payload_format_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PayloadFormatVersion { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    [TerraformProperty("request_parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? RequestParameters { get; set; }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    [TerraformProperty("request_templates")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? RequestTemplates { get; set; }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    [TerraformProperty("template_selection_expression")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TemplateSelectionExpression { get; set; }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    [TerraformProperty("timeout_milliseconds")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> TimeoutMilliseconds { get; set; }

    /// <summary>
    /// Block for response_parameters.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("response_parameters")]
    public TerraformSet<TerraformBlock<AwsApigatewayv2IntegrationResponseParametersBlock>>? ResponseParameters { get; set; }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    [TerraformProperty("tls_config")]
    public TerraformList<TerraformBlock<AwsApigatewayv2IntegrationTlsConfigBlock>>? TlsConfig { get; set; }

    /// <summary>
    /// The integration_response_selection_expression attribute.
    /// </summary>
    [TerraformProperty("integration_response_selection_expression")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IntegrationResponseSelectionExpression { get; }

}
