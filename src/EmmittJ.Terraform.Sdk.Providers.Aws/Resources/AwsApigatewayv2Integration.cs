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
    public string? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id")?.Value;
        set => this.WithProperty("api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public string? ConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_id")?.Value;
        set => this.WithProperty("connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public string? ConnectionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_type")?.Value;
        set => this.WithProperty("connection_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The credentials_arn attribute.
    /// </summary>
    public string? CredentialsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credentials_arn")?.Value;
        set => this.WithProperty("credentials_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The integration_method attribute.
    /// </summary>
    public string? IntegrationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_method")?.Value;
        set => this.WithProperty("integration_method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The integration_subtype attribute.
    /// </summary>
    public string? IntegrationSubtype
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_subtype")?.Value;
        set => this.WithProperty("integration_subtype", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The integration_type attribute.
    /// </summary>
    public string? IntegrationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_type")?.Value;
        set => this.WithProperty("integration_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The integration_uri attribute.
    /// </summary>
    public string? IntegrationUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_uri")?.Value;
        set => this.WithProperty("integration_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    public string? PassthroughBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("passthrough_behavior")?.Value;
        set => this.WithProperty("passthrough_behavior", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The payload_format_version attribute.
    /// </summary>
    public string? PayloadFormatVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("payload_format_version")?.Value;
        set => this.WithProperty("payload_format_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The request_parameters attribute.
    /// </summary>
    public Dictionary<string, string>? RequestParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("request_parameters")?.Value;
        set => this.WithProperty("request_parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    public Dictionary<string, string>? RequestTemplates
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("request_templates")?.Value;
        set => this.WithProperty("request_templates", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public string? TemplateSelectionExpression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_selection_expression")?.Value;
        set => this.WithProperty("template_selection_expression", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    public double? TimeoutMilliseconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("timeout_milliseconds")?.Value;
        set => this.WithProperty("timeout_milliseconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The integration_response_selection_expression attribute.
    /// </summary>
    public TerraformExpression IntegrationResponseSelectionExpression => this["integration_response_selection_expression"];

}
