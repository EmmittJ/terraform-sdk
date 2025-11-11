using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsLambdaFunctionEventInvokeConfigDestinationConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_lambda_function_event_invoke_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLambdaFunctionEventInvokeConfig : TerraformResource
{
    public AwsLambdaFunctionEventInvokeConfig(string name) : base("aws_lambda_function_event_invoke_config", name)
    {
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformProperty("function_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The maximum_event_age_in_seconds attribute.
    /// </summary>
    [TerraformProperty("maximum_event_age_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumEventAgeInSeconds { get; set; }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    [TerraformProperty("maximum_retry_attempts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumRetryAttempts { get; set; }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformProperty("qualifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for destination_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    [TerraformProperty("destination_config")]
    public partial TerraformList<TerraformBlock<AwsLambdaFunctionEventInvokeConfigDestinationConfigBlock>>? DestinationConfig { get; set; }

}
