using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action_group_executor in AwsBedrockagentAgentActionGroup.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupActionGroupExecutorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_group_executor";

    /// <summary>
    /// The custom_control attribute.
    /// </summary>
    public TerraformValue<string>? CustomControl
    {
        get => GetArgument<TerraformValue<string>>("custom_control");
        set => SetArgument("custom_control", value);
    }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    public TerraformValue<string>? Lambda
    {
        get => GetArgument<TerraformValue<string>>("lambda");
        set => SetArgument("lambda", value);
    }

}


/// <summary>
/// Block type for api_schema in AwsBedrockagentAgentActionGroup.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupApiSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_schema";

    /// <summary>
    /// The payload attribute.
    /// </summary>
    public TerraformValue<string>? Payload
    {
        get => GetArgument<TerraformValue<string>>("payload");
        set => SetArgument("payload", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentAgentActionGroupApiSchemaBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsBedrockagentAgentActionGroupApiSchemaBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for s3 in AwsBedrockagentAgentActionGroupApiSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupApiSchemaBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? S3BucketName
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_object_key attribute.
    /// </summary>
    public TerraformValue<string>? S3ObjectKey
    {
        get => GetArgument<TerraformValue<string>>("s3_object_key");
        set => SetArgument("s3_object_key", value);
    }

}


/// <summary>
/// Block type for function_schema in AwsBedrockagentAgentActionGroup.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupFunctionSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "function_schema";

    /// <summary>
    /// MemberFunctions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlock>? MemberFunctions
    {
        get => GetArgument<TerraformList<AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlock>>("member_functions");
        set => SetArgument("member_functions", value);
    }

}

/// <summary>
/// Block type for member_functions in AwsBedrockagentAgentActionGroupFunctionSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "member_functions";

    /// <summary>
    /// Functions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlockFunctionsBlock>? Functions
    {
        get => GetArgument<TerraformList<AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlockFunctionsBlock>>("functions");
        set => SetArgument("functions", value);
    }

}

/// <summary>
/// Block type for functions in AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlockFunctionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "functions";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlockFunctionsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlockFunctionsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlockFunctionsBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockagentAgentActionGroupFunctionSchemaBlockMemberFunctionsBlockFunctionsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The map_block_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MapBlockKey is required")]
    public required TerraformValue<string> MapBlockKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("map_block_key");
        set => SetArgument("map_block_key", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool>? Required
    {
        get => GetArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockagentAgentActionGroup.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentActionGroupTimeoutsBlock : TerraformBlock
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
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagent_agent_action_group Terraform resource.
/// Manages a aws_bedrockagent_agent_action_group resource.
/// </summary>
public partial class AwsBedrockagentAgentActionGroup(string name) : TerraformResource("aws_bedrockagent_agent_action_group", name)
{
    /// <summary>
    /// The action_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupName is required")]
    public required TerraformValue<string> ActionGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("action_group_name");
        set => SetArgument("action_group_name", value);
    }

    /// <summary>
    /// The action_group_state attribute.
    /// </summary>
    public TerraformValue<string> ActionGroupState
    {
        get => GetArgument<TerraformValue<string>>("action_group_state") ?? CreateReference("action_group_state");
        set => SetArgument("action_group_state", value);
    }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    public required TerraformValue<string> AgentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("agent_id");
        set => SetArgument("agent_id", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentVersion is required")]
    public required TerraformValue<string> AgentVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("agent_version");
        set => SetArgument("agent_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The parent_action_group_signature attribute.
    /// </summary>
    public TerraformValue<string>? ParentActionGroupSignature
    {
        get => GetArgument<TerraformValue<string>>("parent_action_group_signature");
        set => SetArgument("parent_action_group_signature", value);
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public TerraformValue<bool> PrepareAgent
    {
        get => GetArgument<TerraformValue<bool>>("prepare_agent") ?? CreateReference("prepare_agent");
        set => SetArgument("prepare_agent", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    public TerraformValue<bool> SkipResourceInUseCheck
    {
        get => GetArgument<TerraformValue<bool>>("skip_resource_in_use_check") ?? CreateReference("skip_resource_in_use_check");
        set => SetArgument("skip_resource_in_use_check", value);
    }

    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    public TerraformValue<string> ActionGroupId
        => CreateReference("action_group_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// ActionGroupExecutor block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentAgentActionGroupActionGroupExecutorBlock>? ActionGroupExecutor
    {
        get => GetArgument<TerraformList<AwsBedrockagentAgentActionGroupActionGroupExecutorBlock>>("action_group_executor");
        set => SetArgument("action_group_executor", value);
    }

    /// <summary>
    /// ApiSchema block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentAgentActionGroupApiSchemaBlock>? ApiSchema
    {
        get => GetArgument<TerraformList<AwsBedrockagentAgentActionGroupApiSchemaBlock>>("api_schema");
        set => SetArgument("api_schema", value);
    }

    /// <summary>
    /// FunctionSchema block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentAgentActionGroupFunctionSchemaBlock>? FunctionSchema
    {
        get => GetArgument<TerraformList<AwsBedrockagentAgentActionGroupFunctionSchemaBlock>>("function_schema");
        set => SetArgument("function_schema", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentAgentActionGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentAgentActionGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
