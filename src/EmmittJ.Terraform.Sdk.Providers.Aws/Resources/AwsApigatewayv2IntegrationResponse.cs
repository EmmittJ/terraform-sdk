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
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The content_handling_strategy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentHandlingStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_handling_strategy");
        set => this.WithProperty("content_handling_strategy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The integration_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_id");
        set => this.WithProperty("integration_id", value);
    }

    /// <summary>
    /// The integration_response_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationResponseKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_response_key");
        set => this.WithProperty("integration_response_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? ResponseTemplates
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_templates");
        set => this.WithProperty("response_templates", value);
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemplateSelectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_selection_expression");
        set => this.WithProperty("template_selection_expression", value);
    }

}
