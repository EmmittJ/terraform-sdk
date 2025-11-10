using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for jwt_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2AuthorizerJwtConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    [TerraformPropertyName("audience")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Audience { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Issuer { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsApigatewayv2AuthorizerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_authorizer resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2Authorizer : TerraformResource
{
    public AwsApigatewayv2Authorizer(string name) : base("aws_apigatewayv2_authorizer", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApiId { get; set; }

    /// <summary>
    /// The authorizer_credentials_arn attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_credentials_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthorizerCredentialsArn { get; set; }

    /// <summary>
    /// The authorizer_payload_format_version attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_payload_format_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthorizerPayloadFormatVersion { get; set; }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_result_ttl_in_seconds")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AuthorizerResultTtlInSeconds { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "authorizer_result_ttl_in_seconds");

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerType is required")]
    [TerraformPropertyName("authorizer_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthorizerType { get; set; }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AuthorizerUri { get; set; }

    /// <summary>
    /// The enable_simple_responses attribute.
    /// </summary>
    [TerraformPropertyName("enable_simple_responses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableSimpleResponses { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identity_sources attribute.
    /// </summary>
    [TerraformPropertyName("identity_sources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentitySources { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for jwt_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JwtConfiguration block(s) allowed")]
    [TerraformPropertyName("jwt_configuration")]
    public TerraformList<TerraformBlock<AwsApigatewayv2AuthorizerJwtConfigurationBlock>>? JwtConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsApigatewayv2AuthorizerTimeoutsBlock>? Timeouts { get; set; } = new();

}
