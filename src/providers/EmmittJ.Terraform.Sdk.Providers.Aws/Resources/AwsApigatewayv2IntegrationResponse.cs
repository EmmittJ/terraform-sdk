using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_integration_response resource.
/// </summary>
public partial class AwsApigatewayv2IntegrationResponse : TerraformResource
{
    public AwsApigatewayv2IntegrationResponse(string name) : base("aws_apigatewayv2_integration_response", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The content_handling_strategy attribute.
    /// </summary>
    [TerraformProperty("content_handling_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentHandlingStrategy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationId is required")]
    [TerraformProperty("integration_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IntegrationId { get; set; }

    /// <summary>
    /// The integration_response_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationResponseKey is required")]
    [TerraformProperty("integration_response_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IntegrationResponseKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    [TerraformProperty("response_templates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResponseTemplates { get; set; }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    [TerraformProperty("template_selection_expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplateSelectionExpression { get; set; }

}
