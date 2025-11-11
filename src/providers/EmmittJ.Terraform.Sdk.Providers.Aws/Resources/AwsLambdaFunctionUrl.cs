using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionUrlCorsBlock
{
    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    [TerraformPropertyName("allow_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowCredentials { get; set; }

    /// <summary>
    /// The allow_headers attribute.
    /// </summary>
    [TerraformPropertyName("allow_headers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowHeaders { get; set; }

    /// <summary>
    /// The allow_methods attribute.
    /// </summary>
    [TerraformPropertyName("allow_methods")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowMethods { get; set; }

    /// <summary>
    /// The allow_origins attribute.
    /// </summary>
    [TerraformPropertyName("allow_origins")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowOrigins { get; set; }

    /// <summary>
    /// The expose_headers attribute.
    /// </summary>
    [TerraformPropertyName("expose_headers")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// The max_age attribute.
    /// </summary>
    [TerraformPropertyName("max_age")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxAge { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLambdaFunctionUrlTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_lambda_function_url resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaFunctionUrl : TerraformResource
{
    public AwsLambdaFunctionUrl(string name) : base("aws_lambda_function_url", name)
    {
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationType is required")]
    [TerraformPropertyName("authorization_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthorizationType { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformPropertyName("function_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The invoke_mode attribute.
    /// </summary>
    [TerraformPropertyName("invoke_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InvokeMode { get; set; }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformPropertyName("qualifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    [TerraformPropertyName("cors")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionUrlCorsBlock>>? Cors { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLambdaFunctionUrlTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [TerraformPropertyName("function_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FunctionArn => new TerraformReference(this, "function_arn");

    /// <summary>
    /// The function_url attribute.
    /// </summary>
    [TerraformPropertyName("function_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FunctionUrl => new TerraformReference(this, "function_url");

    /// <summary>
    /// The url_id attribute.
    /// </summary>
    [TerraformPropertyName("url_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UrlId => new TerraformReference(this, "url_id");

}
