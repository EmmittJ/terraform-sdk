using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionUrlCorsBlock : TerraformBlockBase
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLambdaFunctionUrlTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_lambda_function_url resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLambdaFunctionUrl : TerraformResource
{
    public AwsLambdaFunctionUrl(string name) : base("aws_lambda_function_url", name)
    {
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationType is required")]
    [TerraformProperty("authorization_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AuthorizationType { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The invoke_mode attribute.
    /// </summary>
    [TerraformProperty("invoke_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InvokeMode { get; set; }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformProperty("qualifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for cors.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    [TerraformProperty("cors")]
    public TerraformList<TerraformBlock<AwsLambdaFunctionUrlCorsBlock>>? Cors { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsLambdaFunctionUrlTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [TerraformProperty("function_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FunctionArn { get; }

    /// <summary>
    /// The function_url attribute.
    /// </summary>
    [TerraformProperty("function_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FunctionUrl { get; }

    /// <summary>
    /// The url_id attribute.
    /// </summary>
    [TerraformProperty("url_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UrlId { get; }

}
