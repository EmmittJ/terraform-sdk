using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for jwt_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2AuthorizerJwtConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Audience
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("audience");
        set => WithProperty("audience", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        get => GetProperty<TerraformProperty<string>>("issuer");
        set => WithProperty("issuer", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsApigatewayv2AuthorizerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_apigatewayv2_authorizer resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2Authorizer : TerraformResource
{
    public AwsApigatewayv2Authorizer(string name) : base("aws_apigatewayv2_authorizer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The authorizer_credentials_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizerCredentialsArn
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_credentials_arn");
        set => this.WithProperty("authorizer_credentials_arn", value);
    }

    /// <summary>
    /// The authorizer_payload_format_version attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizerPayloadFormatVersion
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_payload_format_version");
        set => this.WithProperty("authorizer_payload_format_version", value);
    }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? AuthorizerResultTtlInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("authorizer_result_ttl_in_seconds");
        set => this.WithProperty("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerType is required")]
    public required TerraformProperty<string> AuthorizerType
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_type");
        set => this.WithProperty("authorizer_type", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizerUri
    {
        get => GetProperty<TerraformProperty<string>>("authorizer_uri");
        set => this.WithProperty("authorizer_uri", value);
    }

    /// <summary>
    /// The enable_simple_responses attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableSimpleResponses
    {
        get => GetProperty<TerraformProperty<bool>>("enable_simple_responses");
        set => this.WithProperty("enable_simple_responses", value);
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
    /// The identity_sources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentitySources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_sources");
        set => this.WithProperty("identity_sources", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for jwt_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JwtConfiguration block(s) allowed")]
    public List<AwsApigatewayv2AuthorizerJwtConfigurationBlock>? JwtConfiguration
    {
        get => GetProperty<List<AwsApigatewayv2AuthorizerJwtConfigurationBlock>>("jwt_configuration");
        set => this.WithProperty("jwt_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsApigatewayv2AuthorizerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsApigatewayv2AuthorizerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
