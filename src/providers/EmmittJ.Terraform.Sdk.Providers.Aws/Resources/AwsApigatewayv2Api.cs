using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2ApiCorsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowCredentials
    {
        get => GetProperty<TerraformProperty<bool>>("allow_credentials");
        set => WithProperty("allow_credentials", value);
    }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowHeaders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allow_headers");
        set => WithProperty("allow_headers", value);
    }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowMethods
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allow_methods");
        set => WithProperty("allow_methods", value);
    }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowOrigins
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allow_origins");
        set => WithProperty("allow_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExposeHeaders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("expose_headers");
        set => WithProperty("expose_headers", value);
    }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAge
    {
        get => GetProperty<TerraformProperty<double>>("max_age");
        set => WithProperty("max_age", value);
    }

}

/// <summary>
/// Manages a aws_apigatewayv2_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2Api : TerraformResource
{
    public AwsApigatewayv2Api(string name) : base("aws_apigatewayv2_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("api_endpoint");
        this.WithOutput("arn");
        this.WithOutput("execution_arn");
    }

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? ApiKeySelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("api_key_selection_expression");
        set => this.WithProperty("api_key_selection_expression", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformProperty<string>? Body
    {
        get => GetProperty<TerraformProperty<string>>("body");
        set => this.WithProperty("body", value);
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
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableExecuteApiEndpoint
    {
        get => GetProperty<TerraformProperty<bool>>("disable_execute_api_endpoint");
        set => this.WithProperty("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformProperty<bool>? FailOnWarnings
    {
        get => GetProperty<TerraformProperty<bool>>("fail_on_warnings");
        set => this.WithProperty("fail_on_warnings", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    public required TerraformProperty<string> ProtocolType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("protocol_type");
        set => this.WithProperty("protocol_type", value);
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
    /// The route_key attribute.
    /// </summary>
    public TerraformProperty<string>? RouteKey
    {
        get => GetProperty<TerraformProperty<string>>("route_key");
        set => this.WithProperty("route_key", value);
    }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string>? RouteSelectionExpression
    {
        get => GetProperty<TerraformProperty<string>>("route_selection_expression");
        set => this.WithProperty("route_selection_expression", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for cors_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfiguration block(s) allowed")]
    public List<AwsApigatewayv2ApiCorsConfigurationBlock>? CorsConfiguration
    {
        get => GetProperty<List<AwsApigatewayv2ApiCorsConfigurationBlock>>("cors_configuration");
        set => this.WithProperty("cors_configuration", value);
    }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    public TerraformExpression ApiEndpoint => this["api_endpoint"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionArn => this["execution_arn"];

}
