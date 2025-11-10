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
        set => SetProperty("allow_credentials", value);
    }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowHeaders
    {
        set => SetProperty("allow_headers", value);
    }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowMethods
    {
        set => SetProperty("allow_methods", value);
    }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowOrigins
    {
        set => SetProperty("allow_origins", value);
    }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExposeHeaders
    {
        set => SetProperty("expose_headers", value);
    }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAge
    {
        set => SetProperty("max_age", value);
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
        SetOutput("api_endpoint");
        SetOutput("arn");
        SetOutput("execution_arn");
        SetOutput("api_key_selection_expression");
        SetOutput("body");
        SetOutput("credentials_arn");
        SetOutput("description");
        SetOutput("disable_execute_api_endpoint");
        SetOutput("fail_on_warnings");
        SetOutput("id");
        SetOutput("ip_address_type");
        SetOutput("name");
        SetOutput("protocol_type");
        SetOutput("region");
        SetOutput("route_key");
        SetOutput("route_selection_expression");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target");
        SetOutput("version");
    }

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string> ApiKeySelectionExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_key_selection_expression");
        set => SetProperty("api_key_selection_expression", value);
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformProperty<string> Body
    {
        get => GetRequiredOutput<TerraformProperty<string>>("body");
        set => SetProperty("body", value);
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
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool> DisableExecuteApiEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_execute_api_endpoint");
        set => SetProperty("disable_execute_api_endpoint", value);
    }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    public TerraformProperty<bool> FailOnWarnings
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fail_on_warnings");
        set => SetProperty("fail_on_warnings", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> IpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address_type");
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    public required TerraformProperty<string> ProtocolType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol_type");
        set => SetProperty("protocol_type", value);
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
    /// The route_key attribute.
    /// </summary>
    public TerraformProperty<string> RouteKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_key");
        set => SetProperty("route_key", value);
    }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    public TerraformProperty<string> RouteSelectionExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_selection_expression");
        set => SetProperty("route_selection_expression", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string> Target
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target");
        set => SetProperty("target", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for cors_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfiguration block(s) allowed")]
    public List<AwsApigatewayv2ApiCorsConfigurationBlock>? CorsConfiguration
    {
        set => SetProperty("cors_configuration", value);
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
