using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apigatewayv2_integration resource.
/// </summary>
public class AwsApigatewayv2Integration : TerraformResource
{
    public AwsApigatewayv2Integration(string name) : base("aws_apigatewayv2_integration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("integration_response_selection_expression");
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
    /// The connection_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_id");
        set => this.WithProperty("connection_id", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_type");
        set => this.WithProperty("connection_type", value);
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
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CredentialsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credentials_arn");
        set => this.WithProperty("credentials_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The integration_method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_method");
        set => this.WithProperty("integration_method", value);
    }

    /// <summary>
    /// The integration_subtype attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationSubtype
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_subtype");
        set => this.WithProperty("integration_subtype", value);
    }

    /// <summary>
    /// The integration_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_type");
        set => this.WithProperty("integration_type", value);
    }

    /// <summary>
    /// The integration_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_uri");
        set => this.WithProperty("integration_uri", value);
    }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PassthroughBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("passthrough_behavior");
        set => this.WithProperty("passthrough_behavior", value);
    }

    /// <summary>
    /// The payload_format_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PayloadFormatVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("payload_format_version");
        set => this.WithProperty("payload_format_version", value);
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
    /// The request_parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? RequestParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("request_parameters");
        set => this.WithProperty("request_parameters", value);
    }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? RequestTemplates
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("request_templates");
        set => this.WithProperty("request_templates", value);
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemplateSelectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_selection_expression");
        set => this.WithProperty("template_selection_expression", value);
    }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? TimeoutMilliseconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout_milliseconds");
        set => this.WithProperty("timeout_milliseconds", value);
    }

    /// <summary>
    /// The integration_response_selection_expression attribute.
    /// </summary>
    public TerraformExpression IntegrationResponseSelectionExpression => this["integration_response_selection_expression"];

}
