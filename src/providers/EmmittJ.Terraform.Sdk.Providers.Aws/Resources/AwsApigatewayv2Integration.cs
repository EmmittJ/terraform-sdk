using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for response_parameters in .
/// Nesting mode: set
/// </summary>
public class AwsApigatewayv2IntegrationResponseParametersBlock
{
    /// <summary>
    /// The mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mappings is required")]
    [TerraformPropertyName("mappings")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformMap<string> Mappings { get; set; }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    [TerraformPropertyName("status_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StatusCode { get; set; }

}

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2IntegrationTlsConfigBlock
{
    /// <summary>
    /// The server_name_to_verify attribute.
    /// </summary>
    [TerraformPropertyName("server_name_to_verify")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServerNameToVerify { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_integration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2Integration : TerraformResource
{
    public AwsApigatewayv2Integration(string name) : base("aws_apigatewayv2_integration", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiId { get; set; }

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
    /// The content_handling_strategy attribute.
    /// </summary>
    [TerraformPropertyName("content_handling_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentHandlingStrategy { get; set; }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    [TerraformPropertyName("credentials_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CredentialsArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The integration_method attribute.
    /// </summary>
    [TerraformPropertyName("integration_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IntegrationMethod { get; set; }

    /// <summary>
    /// The integration_subtype attribute.
    /// </summary>
    [TerraformPropertyName("integration_subtype")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IntegrationSubtype { get; set; }

    /// <summary>
    /// The integration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    [TerraformPropertyName("integration_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IntegrationType { get; set; }

    /// <summary>
    /// The integration_uri attribute.
    /// </summary>
    [TerraformPropertyName("integration_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IntegrationUri { get; set; }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    [TerraformPropertyName("passthrough_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PassthroughBehavior { get; set; }

    /// <summary>
    /// The payload_format_version attribute.
    /// </summary>
    [TerraformPropertyName("payload_format_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PayloadFormatVersion { get; set; }

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
    /// The template_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("template_selection_expression")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemplateSelectionExpression { get; set; }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_milliseconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> TimeoutMilliseconds { get; set; } = default!;

    /// <summary>
    /// Block for response_parameters.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("response_parameters")]
    public TerraformSet<TerraformBlock<AwsApigatewayv2IntegrationResponseParametersBlock>>? ResponseParameters { get; set; }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    [TerraformPropertyName("tls_config")]
    public TerraformList<TerraformBlock<AwsApigatewayv2IntegrationTlsConfigBlock>>? TlsConfig { get; set; }

    /// <summary>
    /// The integration_response_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("integration_response_selection_expression")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IntegrationResponseSelectionExpression => new TerraformReference(this, "integration_response_selection_expression");

}
