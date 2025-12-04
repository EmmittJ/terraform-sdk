using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_functions Terraform data source.
/// Retrieves information about a aws_lambda_functions.
/// </summary>
public partial class AwsLambdaFunctionsDataSource(string name) : TerraformDataSource("aws_lambda_functions", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The function_arns attribute.
    /// </summary>
    public TerraformList<string> FunctionArns
        => AsReference("function_arns");

    /// <summary>
    /// The function_names attribute.
    /// </summary>
    public TerraformList<string> FunctionNames
        => AsReference("function_names");

}
