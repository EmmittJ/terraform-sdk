using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_runtime_management_config Terraform resource.
/// Manages a aws_lambda_runtime_management_config resource.
/// </summary>
public partial class AwsLambdaRuntimeManagementConfig(string name) : TerraformResource("aws_lambda_runtime_management_config", name)
{
    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformValue<string>? Qualifier
    {
        get => GetArgument<TerraformValue<string>>("qualifier");
        set => SetArgument("qualifier", value);
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
    /// The runtime_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? RuntimeVersionArn
    {
        get => GetArgument<TerraformValue<string>>("runtime_version_arn");
        set => SetArgument("runtime_version_arn", value);
    }

    /// <summary>
    /// The update_runtime_on attribute.
    /// </summary>
    public TerraformValue<string>? UpdateRuntimeOn
    {
        get => GetArgument<TerraformValue<string>>("update_runtime_on");
        set => SetArgument("update_runtime_on", value);
    }

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    public TerraformValue<string> FunctionArn
        => AsReference("function_arn");

}
