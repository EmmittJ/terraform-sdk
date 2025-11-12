using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for jwt_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApigatewayv2AuthorizerJwtConfigurationBlock() : TerraformBlock("jwt_configuration")
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    [TerraformProperty("audience")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Audience { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformProperty("issuer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Issuer { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsApigatewayv2AuthorizerTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_authorizer resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApigatewayv2Authorizer : TerraformResource
{
    public AwsApigatewayv2Authorizer(string name) : base("aws_apigatewayv2_authorizer", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The authorizer_credentials_arn attribute.
    /// </summary>
    [TerraformProperty("authorizer_credentials_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizerCredentialsArn { get; set; }

    /// <summary>
    /// The authorizer_payload_format_version attribute.
    /// </summary>
    [TerraformProperty("authorizer_payload_format_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizerPayloadFormatVersion { get; set; }

    /// <summary>
    /// The authorizer_result_ttl_in_seconds attribute.
    /// </summary>
    [TerraformProperty("authorizer_result_ttl_in_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AuthorizerResultTtlInSeconds { get; set; }

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerType is required")]
    [TerraformProperty("authorizer_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthorizerType { get; set; }

    /// <summary>
    /// The authorizer_uri attribute.
    /// </summary>
    [TerraformProperty("authorizer_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizerUri { get; set; }

    /// <summary>
    /// The enable_simple_responses attribute.
    /// </summary>
    [TerraformProperty("enable_simple_responses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableSimpleResponses { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_sources attribute.
    /// </summary>
    [TerraformProperty("identity_sources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentitySources { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for jwt_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JwtConfiguration block(s) allowed")]
    [TerraformProperty("jwt_configuration")]
    public TerraformList<AwsApigatewayv2AuthorizerJwtConfigurationBlock> JwtConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsApigatewayv2AuthorizerTimeoutsBlock Timeouts { get; set; } = new();

}
