using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_runtime_management_config resource.
/// </summary>
public class AwsLambdaRuntimeManagementConfig : TerraformResource
{
    public AwsLambdaRuntimeManagementConfig(string name) : base("aws_lambda_runtime_management_config", name)
    {
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    [TerraformPropertyName("function_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionName { get; set; }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [TerraformPropertyName("qualifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Qualifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The runtime_version_arn attribute.
    /// </summary>
    [TerraformPropertyName("runtime_version_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RuntimeVersionArn { get; set; }

    /// <summary>
    /// The update_runtime_on attribute.
    /// </summary>
    [TerraformPropertyName("update_runtime_on")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UpdateRuntimeOn { get; set; }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [TerraformPropertyName("function_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FunctionArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "function_arn");

}
