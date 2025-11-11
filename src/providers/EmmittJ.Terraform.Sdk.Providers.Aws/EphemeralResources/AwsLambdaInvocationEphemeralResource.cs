using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_invocation ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AwsLambdaInvocationEphemeralResource : TerraformEphemeralResource
{
    public AwsLambdaInvocationEphemeralResource(string name) : base("aws_lambda_invocation", name)
    {
    }

    /// <summary>
    /// The client_context attribute.
    /// </summary>
    [TerraformPropertyName("client_context")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientContext { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformPropertyName("function_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [TerraformPropertyName("log_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogType { get; set; }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    [TerraformPropertyName("payload")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Payload { get; set; }

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
    /// The executed_version attribute.
    /// </summary>
    [TerraformPropertyName("executed_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExecutedVersion => new TerraformReference(this, "executed_version");

    /// <summary>
    /// The function_error attribute.
    /// </summary>
    [TerraformPropertyName("function_error")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FunctionError => new TerraformReference(this, "function_error");

    /// <summary>
    /// The log_result attribute.
    /// </summary>
    [TerraformPropertyName("log_result")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LogResult => new TerraformReference(this, "log_result");

    /// <summary>
    /// The result attribute.
    /// </summary>
    [TerraformPropertyName("result")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Result => new TerraformReference(this, "result");

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [TerraformPropertyName("status_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StatusCode => new TerraformReference(this, "status_code");

}
