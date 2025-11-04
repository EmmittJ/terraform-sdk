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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
