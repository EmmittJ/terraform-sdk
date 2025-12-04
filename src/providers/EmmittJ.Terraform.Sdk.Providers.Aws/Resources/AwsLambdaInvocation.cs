using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lambda_invocation Terraform resource.
/// Manages a aws_lambda_invocation resource.
/// </summary>
public partial class AwsLambdaInvocation(string name) : TerraformResource("aws_lambda_invocation", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Input is required")]
    public required TerraformValue<string> Input
    {
        get => GetArgument<TerraformValue<string>>("input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// The lifecycle_scope attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleScope
    {
        get => GetArgument<TerraformValue<string>>("lifecycle_scope");
        set => SetArgument("lifecycle_scope", value);
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
    /// The terraform_key attribute.
    /// </summary>
    public TerraformValue<string>? TerraformKey
    {
        get => GetArgument<TerraformValue<string>>("terraform_key");
        set => SetArgument("terraform_key", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformMap<string>? Triggers
    {
        get => GetArgument<TerraformMap<string>>("triggers");
        set => SetArgument("triggers", value);
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformValue<string> Result
        => AsReference("result");

}
