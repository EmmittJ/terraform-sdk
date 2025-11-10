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
        set => SetProperty("insecure_skip_verification", value);
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
        SetOutput("cache_key_parameters");
        SetOutput("cache_namespace");
        SetOutput("connection_id");
        SetOutput("connection_type");
        SetOutput("content_handling");
        SetOutput("credentials");
        SetOutput("http_method");
        SetOutput("id");
        SetOutput("integration_http_method");
        SetOutput("passthrough_behavior");
        SetOutput("region");
        SetOutput("request_parameters");
        SetOutput("request_templates");
        SetOutput("resource_id");
        SetOutput("rest_api_id");
        SetOutput("timeout_milliseconds");
        SetOutput("type");
        SetOutput("uri");
    }

    /// <summary>
    /// The cache_key_parameters attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> CacheKeyParameters
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("cache_key_parameters");
        set => SetProperty("cache_key_parameters", value);
    }

    /// <summary>
    /// The cache_namespace attribute.
    /// </summary>
    public TerraformProperty<string> CacheNamespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cache_namespace");
        set => SetProperty("cache_namespace", value);
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
    /// The content_handling attribute.
    /// </summary>
    public TerraformProperty<string> ContentHandling
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_handling");
        set => SetProperty("content_handling", value);
    }

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformProperty<string> Credentials
    {
        get => GetRequiredOutput<TerraformProperty<string>>("credentials");
        set => SetProperty("credentials", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpMethod is required")]
    public required TerraformProperty<string> HttpMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_method");
        set => SetProperty("http_method", value);
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
    /// The integration_http_method attribute.
    /// </summary>
    public TerraformProperty<string> IntegrationHttpMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_http_method");
        set => SetProperty("integration_http_method", value);
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_id");
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    public required TerraformProperty<string> RestApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rest_api_id");
        set => SetProperty("rest_api_id", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string> Uri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("uri");
        set => SetProperty("uri", value);
    }

    /// <summary>
    /// Block for tls_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TlsConfig block(s) allowed")]
    public List<AwsApiGatewayIntegrationTlsConfigBlock>? TlsConfig
    {
        set => SetProperty("tls_config", value);
    }

}
