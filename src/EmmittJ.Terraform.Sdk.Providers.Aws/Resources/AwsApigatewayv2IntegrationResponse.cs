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
    public TerraformProperty<string>? ApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The content_handling_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? ContentHandlingStrategy
    {
        get => GetProperty<TerraformProperty<string>>("content_handling_strategy");
        set => this.WithProperty("content_handling_strategy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The integration_id attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationId
    {
        get => GetProperty<TerraformProperty<string>>("integration_id");
        set => this.WithProperty("integration_id", value);
    }

    /// <summary>
    /// The integration_response_key attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationResponseKey
    {
        get => GetProperty<TerraformProperty<string>>("integration_response_key");
        set => this.WithProperty("integration_response_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The response_templates attribute.
    /// </summary>
    public TerraformMapProperty<string>? ResponseTemplates
    {
        get => GetProperty<TerraformMapProperty<string>>("response_templates");
        set => this.WithProperty("response_templates", value);
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateSelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("template_selection_expression");
        set => this.WithProperty("template_selection_expression", value);
    }

}
