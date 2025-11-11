using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_runtime_management_config resource.
/// </summary>
public partial class AwsLambdaRuntimeManagementConfig : TerraformResource
{
    public AwsLambdaRuntimeManagementConfig(string name) : base("aws_lambda_runtime_management_config", name)
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
    /// The runtime_version_arn attribute.
    /// </summary>
    [TerraformProperty("runtime_version_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuntimeVersionArn { get; set; }

    /// <summary>
    /// The update_runtime_on attribute.
    /// </summary>
    [TerraformProperty("update_runtime_on")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UpdateRuntimeOn { get; set; }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [TerraformProperty("function_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FunctionArn { get; }

}
