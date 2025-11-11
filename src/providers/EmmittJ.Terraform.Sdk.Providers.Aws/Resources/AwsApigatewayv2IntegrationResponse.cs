using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_integration_response resource.
/// </summary>
public class AwsApigatewayv2IntegrationResponse : TerraformResource
{
    public AwsApigatewayv2IntegrationResponse(string name) : base("aws_apigatewayv2_integration_response", name)
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
    /// The content_handling_strategy attribute.
    /// </summary>
    [TerraformPropertyName("content_handling_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentHandlingStrategy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The integration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationId is required")]
    [TerraformPropertyName("integration_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IntegrationId { get; set; }

    /// <summary>
    /// The integration_response_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationResponseKey is required")]
    [TerraformPropertyName("integration_response_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IntegrationResponseKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    [TerraformPropertyName("response_templates")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResponseTemplates { get; set; }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("template_selection_expression")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemplateSelectionExpression { get; set; }

}
