using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_functions.
/// </summary>
public class AwsLambdaFunctionsDataSource : TerraformDataSource
{
    public AwsLambdaFunctionsDataSource(string name) : base("aws_lambda_functions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("function_arns");
        this.DeclareOutput("function_names");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The function_arns attribute.
    /// </summary>
    public TerraformExpression FunctionArns => this["function_arns"];

    /// <summary>
    /// The function_names attribute.
    /// </summary>
    public TerraformExpression FunctionNames => this["function_names"];

}
