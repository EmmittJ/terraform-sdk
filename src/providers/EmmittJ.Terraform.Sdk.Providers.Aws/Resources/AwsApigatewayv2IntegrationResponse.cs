using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_apigatewayv2_integration_response Terraform resource.
/// Manages a aws_apigatewayv2_integration_response resource.
/// </summary>
public partial class AwsApigatewayv2IntegrationResponse(string name) : TerraformResource("aws_apigatewayv2_integration_response", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => GetArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The content_handling_strategy attribute.
    /// </summary>
    public TerraformValue<string>? ContentHandlingStrategy
    {
        get => GetArgument<TerraformValue<string>>("content_handling_strategy");
        set => SetArgument("content_handling_strategy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The integration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationId is required")]
    public required TerraformValue<string> IntegrationId
    {
        get => GetArgument<TerraformValue<string>>("integration_id");
        set => SetArgument("integration_id", value);
    }

    /// <summary>
    /// The integration_response_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationResponseKey is required")]
    public required TerraformValue<string> IntegrationResponseKey
    {
        get => GetArgument<TerraformValue<string>>("integration_response_key");
        set => SetArgument("integration_response_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public TerraformMap<string>? ResponseTemplates
    {
        get => GetArgument<TerraformMap<string>>("response_templates");
        set => SetArgument("response_templates", value);
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? TemplateSelectionExpression
    {
        get => GetArgument<TerraformValue<string>>("template_selection_expression");
        set => SetArgument("template_selection_expression", value);
    }

}
