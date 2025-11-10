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
        set => SetProperty("audience", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        set => SetProperty("issuer", value);
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
        set => SetProperty("delete", value);
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
        SetOutput("api_id");
        SetOutput("authorizer_credentials_arn");
        SetOutput("authorizer_payload_format_version");
        SetOutput("authorizer_result_ttl_in_seconds");
        SetOutput("authorizer_type");
        SetOutput("authorizer_uri");
        SetOutput("enable_simple_responses");
        SetOutput("id");
        SetOutput("identity_sources");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    public required TerraformProperty<string> ApiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_id");
        set => SetProperty("api_id", value);
    }

    /// <summary>
    /// The authorizer_credentials_arn attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizerCredentialsArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorizer_credentials_arn");
        set => SetProperty("authorizer_credentials_arn", value);
    }

    /// <summary>
    /// The authorizer_payload_format_version attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizerPayloadFormatVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorizer_payload_format_version");
        set => SetProperty("authorizer_payload_format_version", value);
    }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> AuthorizerResultTtlInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("authorizer_result_ttl_in_seconds");
        set => SetProperty("authorizer_result_ttl_in_seconds", value);
    }

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerType is required")]
    public required TerraformProperty<string> AuthorizerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorizer_type");
        set => SetProperty("authorizer_type", value);
    }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizerUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorizer_uri");
        set => SetProperty("authorizer_uri", value);
    }

    /// <summary>
    /// The enable_simple_responses attribute.
    /// </summary>
    public TerraformProperty<bool> EnableSimpleResponses
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_simple_responses");
        set => SetProperty("enable_simple_responses", value);
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
    /// The identity_sources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IdentitySources
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("identity_sources");
        set => SetProperty("identity_sources", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for jwt_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JwtConfiguration block(s) allowed")]
    public List<AwsApigatewayv2AuthorizerJwtConfigurationBlock>? JwtConfiguration
    {
        set => SetProperty("jwt_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsApigatewayv2AuthorizerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
