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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "agent_collaboration");
        set => SetArgument("agent_collaboration", value);
    }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentName is required")]
    public required TerraformValue<string> AgentName
    {
        get => new TerraformReference<string>(this, "agent_name");
        set => SetArgument("agent_name", value);
    }

    /// <summary>
    /// The agent_resource_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentResourceRoleArn is required")]
    public required TerraformValue<string> AgentResourceRoleArn
    {
        get => new TerraformReference<string>(this, "agent_resource_role_arn");
        set => SetArgument("agent_resource_role_arn", value);
    }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? CustomerEncryptionKeyArn
    {
        get => new TerraformReference<string>(this, "customer_encryption_key_arn");
        set => SetArgument("customer_encryption_key_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The foundation_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FoundationModel is required")]
    public required TerraformValue<string> FoundationModel
    {
        get => new TerraformReference<string>(this, "foundation_model");
        set => SetArgument("foundation_model", value);
    }

    /// <summary>
    /// The guardrail_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? GuardrailConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "guardrail_configuration").ResolveNodes(ctx));
        set => SetArgument("guardrail_configuration", value);
    }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> IdleSessionTtlInSeconds
    {
        get => new TerraformReference<double>(this, "idle_session_ttl_in_seconds");
        set => SetArgument("idle_session_ttl_in_seconds", value);
    }

    /// <summary>
    /// The instruction attribute.
    /// </summary>
    public TerraformValue<string> Instruction
    {
        get => new TerraformReference<string>(this, "instruction");
        set => SetArgument("instruction", value);
    }

    /// <summary>
    /// The memory_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MemoryConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "memory_configuration").ResolveNodes(ctx));
        set => SetArgument("memory_configuration", value);
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public TerraformValue<bool> PrepareAgent
    {
        get => new TerraformReference<bool>(this, "prepare_agent");
        set => SetArgument("prepare_agent", value);
    }

    /// <summary>
    /// The prompt_override_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PromptOverrideConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "prompt_override_configuration").ResolveNodes(ctx));
        set => SetArgument("prompt_override_configuration", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    public TerraformValue<bool> SkipResourceInUseCheck
    {
        get => new TerraformReference<bool>(this, "skip_resource_in_use_check");
        set => SetArgument("skip_resource_in_use_check", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The agent_arn attribute.
    /// </summary>
    public TerraformValue<string> AgentArn
    {
        get => new TerraformReference<string>(this, "agent_arn");
    }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    public TerraformValue<string> AgentId
    {
        get => new TerraformReference<string>(this, "agent_id");
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string> AgentVersion
    {
        get => new TerraformReference<string>(this, "agent_version");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The prepared_at attribute.
    /// </summary>
    public TerraformValue<string> PreparedAt
    {
        get => new TerraformReference<string>(this, "prepared_at");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentAgentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentAgentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
