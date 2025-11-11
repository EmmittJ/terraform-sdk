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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The function_arns attribute.
    /// </summary>
    [TerraformPropertyName("function_arns")]
    // Output-only attribute - read-only reference
    public TerraformList<string> FunctionArns => new TerraformReference(this, "function_arns");

    /// <summary>
    /// The function_names attribute.
    /// </summary>
    [TerraformPropertyName("function_names")]
    // Output-only attribute - read-only reference
    public TerraformList<string> FunctionNames => new TerraformReference(this, "function_names");

}
