using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_functions.
/// </summary>
public class AwsLambdaFunctionsDataSource : TerraformDataSource
{
    public AwsLambdaFunctionsDataSource(string name) : base("aws_lambda_functions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The function_arns attribute.
    /// </summary>
    [TerraformPropertyName("function_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> FunctionArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "function_arns");

    /// <summary>
    /// The function_names attribute.
    /// </summary>
    [TerraformPropertyName("function_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> FunctionNames => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "function_names");

}
