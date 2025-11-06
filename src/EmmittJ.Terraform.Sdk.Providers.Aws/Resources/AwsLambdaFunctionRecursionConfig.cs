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

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
