using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_invocation resource.
/// </summary>
public partial class AwsLambdaInvocation : TerraformResource
{
    public AwsLambdaInvocation(string name) : base("aws_lambda_invocation", name)
    {
    }

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
    /// The input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Input is required")]
    [TerraformProperty("input")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Input { get; set; }

    /// <summary>
    /// The lifecycle_scope attribute.
    /// </summary>
    [TerraformProperty("lifecycle_scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LifecycleScope { get; set; }

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
    /// The terraform_key attribute.
    /// </summary>
    [TerraformProperty("terraform_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TerraformKey { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformProperty("triggers")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Triggers { get; set; }

    /// <summary>
    /// The result attribute.
    /// </summary>
    [TerraformProperty("result")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Result { get; }

}
