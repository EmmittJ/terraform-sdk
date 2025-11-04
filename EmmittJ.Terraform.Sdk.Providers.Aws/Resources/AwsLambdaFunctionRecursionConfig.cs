using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_function_recursion_config resource.
/// </summary>
public class AwsLambdaFunctionRecursionConfig : TerraformResource
{
    public AwsLambdaFunctionRecursionConfig(string name) : base("aws_lambda_function_recursion_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The recursive_loop attribute.
    /// </summary>
    public string? RecursiveLoop
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recursive_loop")?.Value;
        set => this.WithProperty("recursive_loop", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
