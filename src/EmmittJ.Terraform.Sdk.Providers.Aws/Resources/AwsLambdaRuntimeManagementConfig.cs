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
        this.DeclareOutput("function_arn");
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformProperty<string>? Qualifier
    {
        get => GetProperty<TerraformProperty<string>>("qualifier");
        set => this.WithProperty("qualifier", value);
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
    /// The runtime_version_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersionArn
    {
        get => GetProperty<TerraformProperty<string>>("runtime_version_arn");
        set => this.WithProperty("runtime_version_arn", value);
    }

    /// <summary>
    /// The update_runtime_on attribute.
    /// </summary>
    public TerraformProperty<string>? UpdateRuntimeOn
    {
        get => GetProperty<TerraformProperty<string>>("update_runtime_on");
        set => this.WithProperty("update_runtime_on", value);
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public TerraformExpression FunctionArn => this["function_arn"];

}
