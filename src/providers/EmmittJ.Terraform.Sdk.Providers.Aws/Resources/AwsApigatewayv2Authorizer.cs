using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for jwt_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2AuthorizerJwtConfigurationBlock
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    [TerraformPropertyName("audience")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Audience { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Issuer { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsApigatewayv2AuthorizerTimeoutsBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

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
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The authorizer_credentials_arn attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_credentials_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizerCredentialsArn { get; set; }

    /// <summary>
    /// The authorizer_payload_format_version attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_payload_format_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizerPayloadFormatVersion { get; set; }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_result_ttl_in_seconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> AuthorizerResultTtlInSeconds { get; set; } = default!;

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerType is required")]
    [TerraformPropertyName("authorizer_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthorizerType { get; set; }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [TerraformPropertyName("authorizer_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizerUri { get; set; }

    /// <summary>
    /// The enable_simple_responses attribute.
    /// </summary>
    [TerraformPropertyName("enable_simple_responses")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableSimpleResponses { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The identity_sources attribute.
    /// </summary>
    [TerraformPropertyName("identity_sources")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentitySources { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for jwt_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JwtConfiguration block(s) allowed")]
    [TerraformPropertyName("jwt_configuration")]
    public TerraformList<TerraformBlock<AwsApigatewayv2AuthorizerJwtConfigurationBlock>>? JwtConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsApigatewayv2AuthorizerTimeoutsBlock>? Timeouts { get; set; }

}
