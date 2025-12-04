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
        get => GetRequiredArgument<TerraformMap<string>>("mappings");
        set => SetArgument("mappings", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<string> StatusCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("status_code");
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
        get => GetArgument<TerraformValue<string>>("server_name_to_verify");
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
        get => GetRequiredArgument<TerraformValue<string>>("api_id");
        set => SetArgument("api_id", value);
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionId
    {
        get => GetArgument<TerraformValue<string>>("connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionType
    {
        get => GetArgument<TerraformValue<string>>("connection_type");
        set => SetArgument("connection_type", value);
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
    /// The credentials_arn attribute.
    /// </summary>
    public TerraformValue<string>? CredentialsArn
    {
        get => GetArgument<TerraformValue<string>>("credentials_arn");
        set => SetArgument("credentials_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The integration_method attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationMethod
    {
        get => GetArgument<TerraformValue<string>>("integration_method");
        set => SetArgument("integration_method", value);
    }

    /// <summary>
    /// The integration_subtype attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationSubtype
    {
        get => GetArgument<TerraformValue<string>>("integration_subtype");
        set => SetArgument("integration_subtype", value);
    }

    /// <summary>
    /// The integration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationType is required")]
    public required TerraformValue<string> IntegrationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("integration_type");
        set => SetArgument("integration_type", value);
    }

    /// <summary>
    /// The integration_uri attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationUri
    {
        get => GetArgument<TerraformValue<string>>("integration_uri");
        set => SetArgument("integration_uri", value);
    }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    public TerraformValue<string>? PassthroughBehavior
    {
        get => GetArgument<TerraformValue<string>>("passthrough_behavior");
        set => SetArgument("passthrough_behavior", value);
    }

    /// <summary>
    /// The payload_format_version attribute.
    /// </summary>
    public TerraformValue<string>? PayloadFormatVersion
    {
        get => GetArgument<TerraformValue<string>>("payload_format_version");
        set => SetArgument("payload_format_version", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The request_parameters attribute.
    /// </summary>
    public TerraformMap<string>? RequestParameters
    {
        get => GetArgument<TerraformMap<string>>("request_parameters");
        set => SetArgument("request_parameters", value);
    }

    /// <summary>
    /// The request_templates attribute.
    /// </summary>
    public TerraformMap<string>? RequestTemplates
    {
        get => GetArgument<TerraformMap<string>>("request_templates");
        set => SetArgument("request_templates", value);
    }

    /// <summary>
    /// The template_selection_expression attribute.
    /// </summary>
    public TerraformValue<string>? TemplateSelectionExpression
    {
        get => GetArgument<TerraformValue<string>>("template_selection_expression");
        set => SetArgument("template_selection_expression", value);
    }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    public TerraformValue<double> TimeoutMilliseconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_milliseconds") ?? AsReference("timeout_milliseconds");
        set => SetArgument("timeout_milliseconds", value);
    }

    /// <summary>
    /// The integration_response_selection_expression attribute.
    /// </summary>
    public TerraformValue<string> IntegrationResponseSelectionExpression
        => AsReference("integration_response_selection_expression");

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
