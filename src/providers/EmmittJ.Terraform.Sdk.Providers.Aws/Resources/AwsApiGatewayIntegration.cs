using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tls_config in AwsApiGatewayIntegration.
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayIntegrationTlsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls_config";

    /// <summary>
    /// The insecure_skip_verification attribute.
    /// </summary>
    public TerraformValue<bool>? InsecureSkipVerification
    {
        get => GetArgument<TerraformValue<bool>>("insecure_skip_verification");
        set => SetArgument("insecure_skip_verification", value);
    }

}


/// <summary>
/// Represents a aws_api_gateway_integration Terraform resource.
/// Manages a aws_api_gateway_integration resource.
/// </summary>
public partial class AwsApiGatewayIntegration(string name) : TerraformResource("aws_api_gateway_integration", name)
{
    /// <summary>
    /// The cache_key_parameters attribute.
    /// </summary>
    public TerraformSet<string>? CacheKeyParameters
    {
        get => GetArgument<TerraformSet<string>>("cache_key_parameters");
        set => SetArgument("cache_key_parameters", value);
    }

    /// <summary>
    /// The cache_namespace attribute.
    /// </summary>
    public TerraformValue<string>? CacheNamespace
    {
        get => GetArgument<TerraformValue<string>>("cache_namespace");
        set => SetArgument("cache_namespace", value);
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
    /// The content_handling attribute.
    /// </summary>
    public TerraformValue<string>? ContentHandling
    {
        get => GetArgument<TerraformValue<string>>("content_handling");
        set => SetArgument("content_handling", value);
    }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformValue<string>? Credentials
    {
        get => GetArgument<TerraformValue<string>>("credentials");
        set => SetArgument("credentials", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformValue<string> HttpMethod
    {
        get => GetArgument<TerraformValue<string>>("http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The integration_http_method attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationHttpMethod
    {
        get => GetArgument<TerraformValue<string>>("integration_http_method");
        set => SetArgument("integration_http_method", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => GetArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => GetArgument<TerraformValue<string>>("rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutMilliseconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_milliseconds");
        set => SetArgument("timeout_milliseconds", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// TlsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public TerraformList<AwsApiGatewayIntegrationTlsConfigBlock>? TlsConfig
    {
        get => GetArgument<TerraformList<AwsApiGatewayIntegrationTlsConfigBlock>>("tls_config");
        set => SetArgument("tls_config", value);
    }

}
