using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_invocation resource.
/// </summary>
public class AwsLambdaInvocation : TerraformResource
{
    public AwsLambdaInvocation(string name) : base("aws_lambda_invocation", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Input is required")]
    [TerraformPropertyName("input")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Input { get; set; }

    /// <summary>
    /// The lifecycle_scope attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LifecycleScope { get; set; }

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
    /// The terraform_key attribute.
    /// </summary>
    [TerraformPropertyName("terraform_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TerraformKey { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Triggers { get; set; }

    /// <summary>
    /// The result attribute.
    /// </summary>
    [TerraformPropertyName("result")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Result => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "result");

}
