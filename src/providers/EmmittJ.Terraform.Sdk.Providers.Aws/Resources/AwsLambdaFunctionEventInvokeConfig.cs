using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_config in AwsLambdaFunctionEventInvokeConfig.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEventInvokeConfigDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_config";

    /// <summary>
    /// OnFailure block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnFailure block(s) allowed")]
    public TerraformList<AwsLambdaFunctionEventInvokeConfigDestinationConfigBlockOnFailureBlock>? OnFailure
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionEventInvokeConfigDestinationConfigBlockOnFailureBlock>>("on_failure");
        set => SetArgument("on_failure", value);
    }

    /// <summary>
    /// OnSuccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OnSuccess block(s) allowed")]
    public TerraformList<AwsLambdaFunctionEventInvokeConfigDestinationConfigBlockOnSuccessBlock>? OnSuccess
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionEventInvokeConfigDestinationConfigBlockOnSuccessBlock>>("on_success");
        set => SetArgument("on_success", value);
    }

}

/// <summary>
/// Block type for on_failure in AwsLambdaFunctionEventInvokeConfigDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEventInvokeConfigDestinationConfigBlockOnFailureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_failure";

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for on_success in AwsLambdaFunctionEventInvokeConfigDestinationConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsLambdaFunctionEventInvokeConfigDestinationConfigBlockOnSuccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_success";

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination");
        set => SetArgument("destination", value);
    }

}


/// <summary>
/// Represents a aws_lambda_function_event_invoke_config Terraform resource.
/// Manages a aws_lambda_function_event_invoke_config resource.
/// </summary>
public partial class AwsLambdaFunctionEventInvokeConfig(string name) : TerraformResource("aws_lambda_function_event_invoke_config", name)
{
    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The maximum_event_age_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaximumEventAgeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_event_age_in_seconds");
        set => SetArgument("maximum_event_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformValue<double>? MaximumRetryAttempts
    {
        get => GetArgument<TerraformValue<double>>("maximum_retry_attempts");
        set => SetArgument("maximum_retry_attempts", value);
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
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// DestinationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfig block(s) allowed")]
    public TerraformList<AwsLambdaFunctionEventInvokeConfigDestinationConfigBlock>? DestinationConfig
    {
        get => GetArgument<TerraformList<AwsLambdaFunctionEventInvokeConfigDestinationConfigBlock>>("destination_config");
        set => SetArgument("destination_config", value);
    }

}
