using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for network_configuration in AwsBedrockagentcoreCodeInterpreter.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreCodeInterpreterNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkMode is required")]
    public required TerraformValue<string> NetworkMode
    {
        get => GetArgument<TerraformValue<string>>("network_mode");
        set => SetArgument("network_mode", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreCodeInterpreterNetworkConfigurationBlockVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreCodeInterpreterNetworkConfigurationBlockVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}

/// <summary>
/// Block type for vpc_config in AwsBedrockagentcoreCodeInterpreterNetworkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreCodeInterpreterNetworkConfigurationBlockVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroups is required")]
    public required TerraformSet<string> SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => GetArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockagentcoreCodeInterpreter.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentcoreCodeInterpreterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagentcore_code_interpreter Terraform resource.
/// Manages a aws_bedrockagentcore_code_interpreter resource.
/// </summary>
public partial class AwsBedrockagentcoreCodeInterpreter(string name) : TerraformResource("aws_bedrockagentcore_code_interpreter", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The code_interpreter_arn attribute.
    /// </summary>
    public TerraformValue<string> CodeInterpreterArn
        => AsReference("code_interpreter_arn");

    /// <summary>
    /// The code_interpreter_id attribute.
    /// </summary>
    public TerraformValue<string> CodeInterpreterId
        => AsReference("code_interpreter_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreCodeInterpreterNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreCodeInterpreterNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentcoreCodeInterpreterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentcoreCodeInterpreterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
