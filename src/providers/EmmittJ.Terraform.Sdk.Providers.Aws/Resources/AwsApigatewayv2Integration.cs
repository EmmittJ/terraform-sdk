using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for response_parameters in AwsApigatewayv2Integration.
/// Nesting mode: set
/// </summary>
public class AwsApigatewayv2IntegrationResponseParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response_parameters";

    /// <summary>
    /// The mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mappings is required")]
    public required TerraformMap<string> Mappings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "mappings").ResolveNodes(ctx));
        set => SetArgument("mappings", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<string> StatusCode
    {
        get => new TerraformReference<string>(this, "status_code");
        set => SetArgument("status_code", value);
    }

}


/// <summary>
/// Block type for tls_config in AwsApigatewayv2Integration.
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2IntegrationTlsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls_config";

    /// <summary>
    /// The server_name_to_verify attribute.
    /// </summary>
    public TerraformValue<string>? ServerNameToVerify
    {
        get => new TerraformReference<string>(this, "server_name_to_verify");
        set => SetArgument("server_name_to_verify", value);
    }

}


/// <summary>
/// Represents a aws_apigatewayv2_integration Terraform resource.
/// Manages a aws_apigatewayv2_integration resource.
/// </summary>
public partial class AwsApigatewayv2Integration(string name) : TerraformResource("aws_apigatewayv2_integration", name)
{
    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformValue<string> ApiId
    {
        get => new TerraformReference<string>(this, "api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionId
    {
        get => new TerraformReference<string>(this, "connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionType
    {
        get => new TerraformReference<string>(this, "connection_type");
        set => SetArgument("connection_type", value);
    }

    /// <summary>
    /// The content_handling_strategy attribute.
    /// </summary>
    public TerraformValue<string>? ContentHandlingStrategy
    {
        get => new TerraformReference<string>(this, "content_handling_strategy");
        set => SetArgument("content_handling_strategy", value);
    }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformValue<string>? CredentialsArn
    {
        get => new TerraformReference<string>(this, "credentials_arn");
        set => SetArgument("credentials_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The integration_method attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationMethod
    {
        get => new TerraformReference<string>(this, "integration_method");
        set => SetArgument("integration_method", value);
    }

    /// <summary>
    /// The integration_subtype attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationSubtype
    {
        get => new TerraformReference<string>(this, "integration_subtype");
        set => SetArgument("integration_subtype", value);
    }

    /// <summary>
    /// The integration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    public required TerraformValue<string> IntegrationType
    {
        get => new TerraformReference<string>(this, "integration_type");
        set => SetArgument("integration_type", value);
    }

    /// <summary>
    /// The integration_uri attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationUri
    {
        get => new TerraformReference<string>(this, "integration_uri");
        set => SetArgument("integration_uri", value);
    }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    public TerraformValue<string>? PassthroughBehavior
    {
        get => new TerraformReference<string>(this, "passthrough_behavior");
        set => SetArgument("passthrough_behavior", value);
    }

    /// <summary>
    /// The payload_format_version attribute.
    /// </summary>
    public TerraformValue<string>? PayloadFormatVersion
    {
        get => new TerraformReference<string>(this, "payload_format_version");
        set => SetArgument("payload_format_version", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    public TerraformMap<string>? RequestParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "request_parameters").ResolveNodes(ctx));
        set => SetArgument("request_parameters", value);
    }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    public TerraformMap<string>? RequestTemplates
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "request_templates").ResolveNodes(ctx));
        set => SetArgument("request_templates", value);
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? TemplateSelectionExpression
    {
        get => new TerraformReference<string>(this, "template_selection_expression");
        set => SetArgument("template_selection_expression", value);
    }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    public TerraformValue<double> TimeoutMilliseconds
    {
        get => new TerraformReference<double>(this, "timeout_milliseconds");
        set => SetArgument("timeout_milliseconds", value);
    }

    /// <summary>
    /// The integration_response_selection_expression attribute.
    /// </summary>
    public TerraformValue<string> IntegrationResponseSelectionExpression
    {
        get => new TerraformReference<string>(this, "integration_response_selection_expression");
    }

    /// <summary>
    /// ResponseParameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsApigatewayv2IntegrationResponseParametersBlock>? ResponseParameters
    {
        get => GetArgument<TerraformSet<AwsApigatewayv2IntegrationResponseParametersBlock>>("response_parameters");
        set => SetArgument("response_parameters", value);
    }

    /// <summary>
    /// TlsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public TerraformList<AwsApigatewayv2IntegrationTlsConfigBlock>? TlsConfig
    {
        get => GetArgument<TerraformList<AwsApigatewayv2IntegrationTlsConfigBlock>>("tls_config");
        set => SetArgument("tls_config", value);
    }

}
