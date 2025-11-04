using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_integration resource.
/// </summary>
public class AwsApiGatewayIntegration : TerraformResource
{
    public AwsApiGatewayIntegration(string name) : base("aws_api_gateway_integration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cache_key_parameters attribute.
    /// </summary>
    public HashSet<string>? CacheKeyParameters
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cache_key_parameters")?.Value;
        set => this.WithProperty("cache_key_parameters", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The cache_namespace attribute.
    /// </summary>
    public string? CacheNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_namespace")?.Value;
        set => this.WithProperty("cache_namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The content_handling attribute.
    /// </summary>
    public string? ContentHandling
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_handling")?.Value;
        set => this.WithProperty("content_handling", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public string? Credentials
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credentials")?.Value;
        set => this.WithProperty("credentials", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public string? HttpMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_method")?.Value;
        set => this.WithProperty("http_method", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The integration_http_method attribute.
    /// </summary>
    public string? IntegrationHttpMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_http_method")?.Value;
        set => this.WithProperty("integration_http_method", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_id attribute.
    /// </summary>
    public string? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id")?.Value;
        set => this.WithProperty("resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public string? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id")?.Value;
        set => this.WithProperty("rest_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public string? Uri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("uri")?.Value;
        set => this.WithProperty("uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
