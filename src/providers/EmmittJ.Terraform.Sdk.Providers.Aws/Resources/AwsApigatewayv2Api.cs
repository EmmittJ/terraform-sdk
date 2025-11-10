using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApigatewayv2ApiCorsConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    [TerraformPropertyName("allow_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowCredentials { get; set; }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    [TerraformPropertyName("allow_headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowHeaders { get; set; }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    [TerraformPropertyName("allow_methods")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowMethods { get; set; }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    [TerraformPropertyName("allow_origins")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowOrigins { get; set; }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    [TerraformPropertyName("expose_headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExposeHeaders { get; set; }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    [TerraformPropertyName("max_age")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxAge { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApigatewayv2Api : TerraformResource
{
    public AwsApigatewayv2Api(string name) : base("aws_apigatewayv2_api", name)
    {
    }

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("api_key_selection_expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiKeySelectionExpression { get; set; }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformPropertyName("body")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Body { get; set; }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    [TerraformPropertyName("credentials_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CredentialsArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("disable_execute_api_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableExecuteApiEndpoint { get; set; }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    [TerraformPropertyName("fail_on_warnings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FailOnWarnings { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address_type");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    [TerraformPropertyName("protocol_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProtocolType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [TerraformPropertyName("route_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RouteKey { get; set; }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    [TerraformPropertyName("route_selection_expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RouteSelectionExpression { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformPropertyName("target")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Target { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// Block for cors_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfiguration block(s) allowed")]
    [TerraformPropertyName("cors_configuration")]
    public TerraformList<TerraformBlock<AwsApigatewayv2ApiCorsConfigurationBlock>>? CorsConfiguration { get; set; } = new();

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("api_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_endpoint");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExecutionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "execution_arn");

}
