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
    public string? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id")?.Value;
        set => this.WithProperty("api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_handling_strategy attribute.
    /// </summary>
    public string? ContentHandlingStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_handling_strategy")?.Value;
        set => this.WithProperty("content_handling_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The integration_id attribute.
    /// </summary>
    public string? IntegrationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_id")?.Value;
        set => this.WithProperty("integration_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The integration_response_key attribute.
    /// </summary>
    public string? IntegrationResponseKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_response_key")?.Value;
        set => this.WithProperty("integration_response_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public Dictionary<string, string>? ResponseTemplates
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("response_templates")?.Value;
        set => this.WithProperty("response_templates", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public string? TemplateSelectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_selection_expression")?.Value;
        set => this.WithProperty("template_selection_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
