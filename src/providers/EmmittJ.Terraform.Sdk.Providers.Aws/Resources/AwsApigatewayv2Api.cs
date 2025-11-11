using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsApigatewayv2ApiCorsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    [TerraformProperty("allow_credentials")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowCredentials { get; set; }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    [TerraformProperty("allow_headers")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowHeaders { get; set; }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    [TerraformProperty("allow_methods")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowMethods { get; set; }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    [TerraformProperty("allow_origins")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowOrigins { get; set; }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    [TerraformProperty("expose_headers")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    [TerraformProperty("max_age")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxAge { get; set; }

}

/// <summary>
/// Manages a aws_apigatewayv2_api resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsApigatewayv2Api : TerraformResource
{
    public AwsApigatewayv2Api(string name) : base("aws_apigatewayv2_api", name)
    {
    }

    /// <summary>
    /// The api_key_selection_expression attribute.
    /// </summary>
    [TerraformProperty("api_key_selection_expression")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiKeySelectionExpression { get; set; }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformProperty("body")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Body { get; set; }

    /// <summary>
    /// The credentials_arn attribute.
    /// </summary>
    [TerraformProperty("credentials_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CredentialsArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The disable_execute_api_endpoint attribute.
    /// </summary>
    [TerraformProperty("disable_execute_api_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableExecuteApiEndpoint { get; set; }

    /// <summary>
    /// The fail_on_warnings attribute.
    /// </summary>
    [TerraformProperty("fail_on_warnings")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? FailOnWarnings { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    [TerraformProperty("protocol_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProtocolType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The route_key attribute.
    /// </summary>
    [TerraformProperty("route_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RouteKey { get; set; }

    /// <summary>
    /// The route_selection_expression attribute.
    /// </summary>
    [TerraformProperty("route_selection_expression")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RouteSelectionExpression { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformProperty("target")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Target { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for cors_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfiguration block(s) allowed")]
    [TerraformProperty("cors_configuration")]
    public TerraformList<TerraformBlock<AwsApigatewayv2ApiCorsConfigurationBlock>>? CorsConfiguration { get; set; }

    /// <summary>
    /// The api_endpoint attribute.
    /// </summary>
    [TerraformProperty("api_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApiEndpoint { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The execution_arn attribute.
    /// </summary>
    [TerraformProperty("execution_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExecutionArn { get; }

}
