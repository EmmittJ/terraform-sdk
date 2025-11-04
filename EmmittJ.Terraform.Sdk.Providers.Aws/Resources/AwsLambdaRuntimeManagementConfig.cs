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
    public string? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name")?.Value;
        set => this.WithProperty("function_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The runtime_version_arn attribute.
    /// </summary>
    public string? RuntimeVersionArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_version_arn")?.Value;
        set => this.WithProperty("runtime_version_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The update_runtime_on attribute.
    /// </summary>
    public string? UpdateRuntimeOn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("update_runtime_on")?.Value;
        set => this.WithProperty("update_runtime_on", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public TerraformExpression FunctionArn => this["function_arn"];

}
