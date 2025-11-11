using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_invocation ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public partial class AwsLambdaInvocationEphemeralResource : TerraformEphemeralResource
{
    public AwsLambdaInvocationEphemeralResource(string name) : base("aws_lambda_invocation", name)
    {
    }

    /// <summary>
    /// The client_context attribute.
    /// </summary>
    [TerraformProperty("client_context")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientContext { get; set; }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [TerraformProperty("log_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LogType { get; set; }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    [TerraformProperty("payload")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Payload { get; set; }

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
    /// The executed_version attribute.
    /// </summary>
    [TerraformProperty("executed_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExecutedVersion { get; }

    /// <summary>
    /// The function_error attribute.
    /// </summary>
    [TerraformProperty("function_error")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FunctionError { get; }

    /// <summary>
    /// The log_result attribute.
    /// </summary>
    [TerraformProperty("log_result")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LogResult { get; }

    /// <summary>
    /// The result attribute.
    /// </summary>
    [TerraformProperty("result")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Result { get; }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [TerraformProperty("status_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> StatusCode { get; }

}
