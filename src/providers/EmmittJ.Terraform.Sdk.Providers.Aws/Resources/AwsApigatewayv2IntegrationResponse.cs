using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_integration_response resource.
/// </summary>
public class AwsApigatewayv2IntegrationResponse : TerraformResource
{
    public AwsApigatewayv2IntegrationResponse(string name) : base("aws_apigatewayv2_integration_response", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_id");
        SetOutput("content_handling_strategy");
        SetOutput("id");
        SetOutput("integration_id");
        SetOutput("integration_response_key");
        SetOutput("region");
        SetOutput("response_templates");
        SetOutput("template_selection_expression");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The content_handling_strategy attribute.
    /// </summary>
    public TerraformProperty<string> ContentHandlingStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_handling_strategy");
        set => SetProperty("content_handling_strategy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The integration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationId is required")]
    public required TerraformProperty<string> IntegrationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_id");
        set => SetProperty("integration_id", value);
    }

    /// <summary>
    /// The integration_response_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationResponseKey is required")]
    public required TerraformProperty<string> IntegrationResponseKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_response_key");
        set => SetProperty("integration_response_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResponseTemplates
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("response_templates");
        set => SetProperty("response_templates", value);
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string> TemplateSelectionExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_selection_expression");
        set => SetProperty("template_selection_expression", value);
    }

}
