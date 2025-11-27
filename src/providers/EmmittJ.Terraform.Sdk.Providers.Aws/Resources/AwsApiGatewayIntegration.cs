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
        get => new TerraformReference<bool>(this, "insecure_skip_verification");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cache_key_parameters").ResolveNodes(ctx));
        set => SetArgument("cache_key_parameters", value);
    }

    /// <summary>
    /// The cache_namespace attribute.
    /// </summary>
    public TerraformValue<string> CacheNamespace
    {
        get => new TerraformReference<string>(this, "cache_namespace");
        set => SetArgument("cache_namespace", value);
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
    /// The content_handling attribute.
    /// </summary>
    public TerraformValue<string>? ContentHandling
    {
        get => new TerraformReference<string>(this, "content_handling");
        set => SetArgument("content_handling", value);
    }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformValue<string>? Credentials
    {
        get => new TerraformReference<string>(this, "credentials");
        set => SetArgument("credentials", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformValue<string> HttpMethod
    {
        get => new TerraformReference<string>(this, "http_method");
        set => SetArgument("http_method", value);
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
    /// The integration_http_method attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationHttpMethod
    {
        get => new TerraformReference<string>(this, "integration_http_method");
        set => SetArgument("integration_http_method", value);
    }

    /// <summary>
    /// The passthrough_behavior attribute.
    /// </summary>
    public TerraformValue<string> PassthroughBehavior
    {
        get => new TerraformReference<string>(this, "passthrough_behavior");
        set => SetArgument("passthrough_behavior", value);
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformValue<string> RestApiId
    {
        get => new TerraformReference<string>(this, "rest_api_id");
        set => SetArgument("rest_api_id", value);
    }

    /// <summary>
    /// The timeout_milliseconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutMilliseconds
    {
        get => new TerraformReference<double>(this, "timeout_milliseconds");
        set => SetArgument("timeout_milliseconds", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
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
