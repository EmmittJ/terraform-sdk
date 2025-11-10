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
        SetOutput("function_name");
        SetOutput("recursive_loop");
        SetOutput("region");
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_name");
        set => SetProperty("function_name", value);
    }

    /// <summary>
    /// The recursive_loop attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecursiveLoop is required")]
    public required TerraformProperty<string> RecursiveLoop
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recursive_loop");
        set => SetProperty("recursive_loop", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
