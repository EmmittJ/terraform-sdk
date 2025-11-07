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
    public TerraformLiteralProperty<HashSet<string>>? CacheKeyParameters
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cache_key_parameters");
        set => this.WithProperty("cache_key_parameters", value);
    }

    /// <summary>
    /// The cache_namespace attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CacheNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_namespace");
        set => this.WithProperty("cache_namespace", value);
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
    /// The content_handling attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentHandling
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_handling");
        set => this.WithProperty("content_handling", value);
    }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Credentials
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credentials");
        set => this.WithProperty("credentials", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HttpMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_method");
        set => this.WithProperty("http_method", value);
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
    /// The integration_http_method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationHttpMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_http_method");
        set => this.WithProperty("integration_http_method", value);
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
    /// The resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Uri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("uri");
        set => this.WithProperty("uri", value);
    }

}
