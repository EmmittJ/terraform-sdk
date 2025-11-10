using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for tls_config in .
/// Nesting mode: list
/// </summary>
public class AwsApiGatewayIntegrationTlsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The insecure_skip_verification attribute.
    /// </summary>
    public TerraformProperty<bool>? InsecureSkipVerification
    {
        get => GetProperty<TerraformProperty<bool>>("insecure_skip_verification");
        set => WithProperty("insecure_skip_verification", value);
    }

}

/// <summary>
/// Manages a aws_api_gateway_integration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public HashSet<TerraformProperty<string>>? CacheKeyParameters
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cache_key_parameters");
        set => this.WithProperty("cache_key_parameters", value);
    }

    /// <summary>
    /// The cache_namespace attribute.
    /// </summary>
    public TerraformProperty<string>? CacheNamespace
    {
        get => GetProperty<TerraformProperty<string>>("cache_namespace");
        set => this.WithProperty("cache_namespace", value);
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
    /// The content_handling attribute.
    /// </summary>
    public TerraformProperty<string>? ContentHandling
    {
        get => GetProperty<TerraformProperty<string>>("content_handling");
        set => this.WithProperty("content_handling", value);
    }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformProperty<string>? Credentials
    {
        get => GetProperty<TerraformProperty<string>>("credentials");
        set => this.WithProperty("credentials", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformProperty<string> HttpMethod
    {
        get => GetRequiredProperty<TerraformProperty<string>>("http_method");
        set => this.WithProperty("http_method", value);
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
    /// The integration_http_method attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationHttpMethod
    {
        get => GetProperty<TerraformProperty<string>>("integration_http_method");
        set => this.WithProperty("integration_http_method", value);
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_id");
        set => this.WithProperty("resource_id", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rest_api_id");
        set => this.WithProperty("rest_api_id", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => this.WithProperty("uri", value);
    }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public List<AwsApiGatewayIntegrationTlsConfigBlock>? TlsConfig
    {
        get => GetProperty<List<AwsApiGatewayIntegrationTlsConfigBlock>>("tls_config");
        set => this.WithProperty("tls_config", value);
    }

}
