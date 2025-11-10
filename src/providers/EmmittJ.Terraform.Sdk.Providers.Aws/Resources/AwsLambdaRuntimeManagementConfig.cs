using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_runtime_management_config resource.
/// </summary>
public class AwsLambdaRuntimeManagementConfig : TerraformResource
{
    public AwsLambdaRuntimeManagementConfig(string name) : base("aws_lambda_runtime_management_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("function_arn");
        SetOutput("function_name");
        SetOutput("qualifier");
        SetOutput("region");
        SetOutput("runtime_version_arn");
        SetOutput("update_runtime_on");
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
    /// The qualifier attribute.
    /// </summary>
    public TerraformProperty<string> Qualifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("qualifier");
        set => SetProperty("qualifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The runtime_version_arn attribute.
    /// </summary>
    public TerraformProperty<string> RuntimeVersionArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime_version_arn");
        set => SetProperty("runtime_version_arn", value);
    }

    /// <summary>
    /// The update_runtime_on attribute.
    /// </summary>
    public TerraformProperty<string> UpdateRuntimeOn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("update_runtime_on");
        set => SetProperty("update_runtime_on", value);
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public TerraformExpression FunctionArn => this["function_arn"];

}
