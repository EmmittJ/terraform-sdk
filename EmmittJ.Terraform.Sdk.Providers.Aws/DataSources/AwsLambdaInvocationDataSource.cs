using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_invocation.
/// </summary>
public class AwsLambdaInvocationDataSource : TerraformDataSource
{
    public AwsLambdaInvocationDataSource(string name) : base("aws_lambda_invocation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("result");
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public string? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name")?.Value;
        set => this.WithProperty("function_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The input attribute.
    /// </summary>
    public string? Input
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input")?.Value;
        set => this.WithProperty("input", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public string? Qualifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qualifier")?.Value;
        set => this.WithProperty("qualifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

}
