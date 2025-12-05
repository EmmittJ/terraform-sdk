using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsBedrockagentAgent.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentTimeoutsBlock : TerraformBlock
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
/// Represents a aws_bedrockagent_agent Terraform resource.
/// Manages a aws_bedrockagent_agent resource.
/// </summary>
public partial class AwsBedrockagentAgent(string name) : TerraformResource("aws_bedrockagent_agent", name)
{
    /// <summary>
    /// The agent_collaboration attribute.
    /// </summary>
    public TerraformValue<string> AgentCollaboration
    {
        get => GetArgument<TerraformValue<string>>("agent_collaboration") ?? CreateReference("agent_collaboration");
        set => SetArgument("agent_collaboration", value);
    }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentName is required")]
    public required TerraformValue<string> AgentName
    {
        get => GetRequiredArgument<TerraformValue<string>>("agent_name");
        set => SetArgument("agent_name", value);
    }

    /// <summary>
    /// The agent_resource_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentResourceRoleArn is required")]
    public required TerraformValue<string> AgentResourceRoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("agent_resource_role_arn");
        set => SetArgument("agent_resource_role_arn", value);
    }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? CustomerEncryptionKeyArn
    {
        get => GetArgument<TerraformValue<string>>("customer_encryption_key_arn");
        set => SetArgument("customer_encryption_key_arn", value);
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
    /// The foundation_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FoundationModel is required")]
    public required TerraformValue<string> FoundationModel
    {
        get => GetRequiredArgument<TerraformValue<string>>("foundation_model");
        set => SetArgument("foundation_model", value);
    }

    /// <summary>
    /// The guardrail_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? GuardrailConfiguration
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("guardrail_configuration");
        set => SetArgument("guardrail_configuration", value);
    }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> IdleSessionTtlInSeconds
    {
        get => GetArgument<TerraformValue<double>>("idle_session_ttl_in_seconds") ?? CreateReference("idle_session_ttl_in_seconds");
        set => SetArgument("idle_session_ttl_in_seconds", value);
    }

    /// <summary>
    /// The instruction attribute.
    /// </summary>
    public TerraformValue<string> Instruction
    {
        get => GetArgument<TerraformValue<string>>("instruction") ?? CreateReference("instruction");
        set => SetArgument("instruction", value);
    }

    /// <summary>
    /// The memory_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MemoryConfiguration
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("memory_configuration") ?? CreateReference("memory_configuration");
        set => SetArgument("memory_configuration", value);
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
    /// The prompt_override_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PromptOverrideConfiguration
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("prompt_override_configuration") ?? CreateReference("prompt_override_configuration");
        set => SetArgument("prompt_override_configuration", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The agent_arn attribute.
    /// </summary>
    public TerraformValue<string> AgentArn
        => CreateReference("agent_arn");

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    public TerraformValue<string> AgentId
        => CreateReference("agent_id");

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string> AgentVersion
        => CreateReference("agent_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The prepared_at attribute.
    /// </summary>
    public TerraformValue<string> PreparedAt
        => CreateReference("prepared_at");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentAgentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentAgentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
