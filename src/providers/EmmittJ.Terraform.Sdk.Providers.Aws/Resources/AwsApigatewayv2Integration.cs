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
        set => SetProperty("mappings", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformProperty<string> StatusCode
    {
        set => SetProperty("status_code", value);
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
        set => SetProperty("server_name_to_verify", value);
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
        SetOutput("integration_response_selection_expression");
        SetOutput("api_id");
        SetOutput("connection_id");
        SetOutput("connection_type");
        SetOutput("content_handling_strategy");
        SetOutput("credentials_arn");
        SetOutput("description");
        SetOutput("id");
        SetOutput("integration_method");
        SetOutput("integration_subtype");
        SetOutput("integration_type");
        SetOutput("integration_uri");
        SetOutput("passthrough_behavior");
        SetOutput("payload_format_version");
        SetOutput("region");
        SetOutput("request_parameters");
        SetOutput("request_templates");
        SetOutput("template_selection_expression");
        SetOutput("timeout_milliseconds");
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
    /// The connection_id attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_id");
        set => SetProperty("connection_id", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_type");
        set => SetProperty("connection_type", value);
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
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformProperty<string> CredentialsArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("credentials_arn");
        set => SetProperty("credentials_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The integration_method attribute.
    /// </summary>
    public TerraformProperty<string> IntegrationMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_method");
        set => SetProperty("integration_method", value);
    }

    /// <summary>
    /// The integration_subtype attribute.
    /// </summary>
    public TerraformProperty<string> IntegrationSubtype
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_subtype");
        set => SetProperty("integration_subtype", value);
    }

    /// <summary>
    /// The integration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    public required TerraformProperty<string> IntegrationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_type");
        set => SetProperty("integration_type", value);
    }

    /// <summary>
    /// The integration_uri attribute.
    /// </summary>
    public TerraformProperty<string> IntegrationUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_uri");
        set => SetProperty("integration_uri", value);
    }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    public TerraformProperty<string> PassthroughBehavior
    {
        get => GetRequiredOutput<TerraformProperty<string>>("passthrough_behavior");
        set => SetProperty("passthrough_behavior", value);
    }

    /// <summary>
    /// The payload_format_version attribute.
    /// </summary>
    public TerraformProperty<string> PayloadFormatVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("payload_format_version");
        set => SetProperty("payload_format_version", value);
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
    /// The request_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> RequestParameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("request_parameters");
        set => SetProperty("request_parameters", value);
    }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> RequestTemplates
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("request_templates");
        set => SetProperty("request_templates", value);
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string> TemplateSelectionExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_selection_expression");
        set => SetProperty("template_selection_expression", value);
    }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    public TerraformProperty<double> TimeoutMilliseconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout_milliseconds");
        set => SetProperty("timeout_milliseconds", value);
    }

    /// <summary>
    /// Block for response_parameters.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsApigatewayv2IntegrationResponseParametersBlock>? ResponseParameters
    {
        set => SetProperty("response_parameters", value);
    }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public List<AwsApigatewayv2IntegrationTlsConfigBlock>? TlsConfig
    {
        set => SetProperty("tls_config", value);
    }

    /// <summary>
    /// The integration_response_selection_expression attribute.
    /// </summary>
    public TerraformExpression IntegrationResponseSelectionExpression => this["integration_response_selection_expression"];

}
