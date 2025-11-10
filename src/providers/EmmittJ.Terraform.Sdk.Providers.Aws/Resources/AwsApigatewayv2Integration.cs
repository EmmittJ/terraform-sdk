using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for response_parameters in .
/// Nesting mode: set
/// </summary>
public class AwsApigatewayv2IntegrationResponseParametersBlock : TerraformBlock
{
    /// <summary>
    /// The mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mappings is required")]
    public Dictionary<string, TerraformProperty<string>>? Mappings
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("mappings");
        set => WithProperty("mappings", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformProperty<string> StatusCode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("status_code");
        set => WithProperty("status_code", value);
    }

}

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2IntegrationTlsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The server_name_to_verify attribute.
    /// </summary>
    public TerraformProperty<string>? ServerNameToVerify
    {
        get => GetProperty<TerraformProperty<string>>("server_name_to_verify");
        set => WithProperty("server_name_to_verify", value);
    }

}

/// <summary>
/// Manages a aws_apigatewayv2_integration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2Integration : TerraformResource
{
    public AwsApigatewayv2Integration(string name) : base("aws_apigatewayv2_integration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("integration_response_selection_expression");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("connection_id");
        set => this.WithProperty("connection_id", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionType
    {
        get => GetProperty<TerraformProperty<string>>("connection_type");
        set => this.WithProperty("connection_type", value);
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
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CredentialsArn
    {
        get => GetProperty<TerraformProperty<string>>("credentials_arn");
        set => this.WithProperty("credentials_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The integration_method attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationMethod
    {
        get => GetProperty<TerraformProperty<string>>("integration_method");
        set => this.WithProperty("integration_method", value);
    }

    /// <summary>
    /// The integration_subtype attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationSubtype
    {
        get => GetProperty<TerraformProperty<string>>("integration_subtype");
        set => this.WithProperty("integration_subtype", value);
    }

    /// <summary>
    /// The integration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    public required TerraformProperty<string> IntegrationType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("integration_type");
        set => this.WithProperty("integration_type", value);
    }

    /// <summary>
    /// The integration_uri attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationUri
    {
        get => GetProperty<TerraformProperty<string>>("integration_uri");
        set => this.WithProperty("integration_uri", value);
    }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? PassthroughBehavior
    {
        get => GetProperty<TerraformProperty<string>>("passthrough_behavior");
        set => this.WithProperty("passthrough_behavior", value);
    }

    /// <summary>
    /// The payload_format_version attribute.
    /// </summary>
    public TerraformProperty<string>? PayloadFormatVersion
    {
        get => GetProperty<TerraformProperty<string>>("payload_format_version");
        set => this.WithProperty("payload_format_version", value);
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
    /// The request_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? RequestParameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("request_parameters");
        set => this.WithProperty("request_parameters", value);
    }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? RequestTemplates
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("request_templates");
        set => this.WithProperty("request_templates", value);
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateSelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("template_selection_expression");
        set => this.WithProperty("template_selection_expression", value);
    }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutMilliseconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_milliseconds");
        set => this.WithProperty("timeout_milliseconds", value);
    }

    /// <summary>
    /// Block for response_parameters.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsApigatewayv2IntegrationResponseParametersBlock>? ResponseParameters
    {
        get => GetProperty<HashSet<AwsApigatewayv2IntegrationResponseParametersBlock>>("response_parameters");
        set => this.WithProperty("response_parameters", value);
    }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public List<AwsApigatewayv2IntegrationTlsConfigBlock>? TlsConfig
    {
        get => GetProperty<List<AwsApigatewayv2IntegrationTlsConfigBlock>>("tls_config");
        set => this.WithProperty("tls_config", value);
    }

    /// <summary>
    /// The integration_response_selection_expression attribute.
    /// </summary>
    public TerraformExpression IntegrationResponseSelectionExpression => this["integration_response_selection_expression"];

}
