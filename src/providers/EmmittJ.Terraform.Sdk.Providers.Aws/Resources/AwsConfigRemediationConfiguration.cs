using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for execution_controls in AwsConfigRemediationConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsConfigRemediationConfigurationExecutionControlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_controls";

    /// <summary>
    /// SsmControls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SsmControls block(s) allowed")]
    public TerraformList<AwsConfigRemediationConfigurationExecutionControlsBlockSsmControlsBlock>? SsmControls
    {
        get => GetArgument<TerraformList<AwsConfigRemediationConfigurationExecutionControlsBlockSsmControlsBlock>>("ssm_controls");
        set => SetArgument("ssm_controls", value);
    }

}

/// <summary>
/// Block type for ssm_controls in AwsConfigRemediationConfigurationExecutionControlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsConfigRemediationConfigurationExecutionControlsBlockSsmControlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ssm_controls";

    /// <summary>
    /// The concurrent_execution_rate_percentage attribute.
    /// </summary>
    public TerraformValue<double>? ConcurrentExecutionRatePercentage
    {
        get => GetArgument<TerraformValue<double>>("concurrent_execution_rate_percentage");
        set => SetArgument("concurrent_execution_rate_percentage", value);
    }

    /// <summary>
    /// The error_percentage attribute.
    /// </summary>
    public TerraformValue<double>? ErrorPercentage
    {
        get => GetArgument<TerraformValue<double>>("error_percentage");
        set => SetArgument("error_percentage", value);
    }

}


/// <summary>
/// Block type for parameter in AwsConfigRemediationConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsConfigRemediationConfigurationParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_value attribute.
    /// </summary>
    public TerraformValue<string>? ResourceValue
    {
        get => GetArgument<TerraformValue<string>>("resource_value");
        set => SetArgument("resource_value", value);
    }

    /// <summary>
    /// The static_value attribute.
    /// </summary>
    public TerraformValue<string>? StaticValue
    {
        get => GetArgument<TerraformValue<string>>("static_value");
        set => SetArgument("static_value", value);
    }

    /// <summary>
    /// The static_values attribute.
    /// </summary>
    public TerraformList<string>? StaticValues
    {
        get => GetArgument<TerraformList<string>>("static_values");
        set => SetArgument("static_values", value);
    }

}


/// <summary>
/// Represents a aws_config_remediation_configuration Terraform resource.
/// Manages a aws_config_remediation_configuration resource.
/// </summary>
public partial class AwsConfigRemediationConfiguration(string name) : TerraformResource("aws_config_remediation_configuration", name)
{
    /// <summary>
    /// The automatic attribute.
    /// </summary>
    public TerraformValue<bool>? Automatic
    {
        get => GetArgument<TerraformValue<bool>>("automatic");
        set => SetArgument("automatic", value);
    }

    /// <summary>
    /// The config_rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigRuleName is required")]
    public required TerraformValue<string> ConfigRuleName
    {
        get => GetArgument<TerraformValue<string>>("config_rule_name");
        set => SetArgument("config_rule_name", value);
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
    /// The maximum_automatic_attempts attribute.
    /// </summary>
    public TerraformValue<double>? MaximumAutomaticAttempts
    {
        get => GetArgument<TerraformValue<double>>("maximum_automatic_attempts");
        set => SetArgument("maximum_automatic_attempts", value);
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
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The retry_attempt_seconds attribute.
    /// </summary>
    public TerraformValue<double>? RetryAttemptSeconds
    {
        get => GetArgument<TerraformValue<double>>("retry_attempt_seconds");
        set => SetArgument("retry_attempt_seconds", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    public required TerraformValue<string> TargetId
    {
        get => GetArgument<TerraformValue<string>>("target_id");
        set => SetArgument("target_id", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetType is required")]
    public required TerraformValue<string> TargetType
    {
        get => GetArgument<TerraformValue<string>>("target_type");
        set => SetArgument("target_type", value);
    }

    /// <summary>
    /// The target_version attribute.
    /// </summary>
    public TerraformValue<string>? TargetVersion
    {
        get => GetArgument<TerraformValue<string>>("target_version");
        set => SetArgument("target_version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// ExecutionControls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionControls block(s) allowed")]
    public TerraformList<AwsConfigRemediationConfigurationExecutionControlsBlock>? ExecutionControls
    {
        get => GetArgument<TerraformList<AwsConfigRemediationConfigurationExecutionControlsBlock>>("execution_controls");
        set => SetArgument("execution_controls", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 Parameter block(s) allowed")]
    public TerraformList<AwsConfigRemediationConfigurationParameterBlock>? Parameter
    {
        get => GetArgument<TerraformList<AwsConfigRemediationConfigurationParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}
