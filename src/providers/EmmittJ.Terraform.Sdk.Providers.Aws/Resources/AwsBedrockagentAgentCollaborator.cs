using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_descriptor in AwsBedrockagentAgentCollaborator.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentCollaboratorAgentDescriptorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "agent_descriptor";

    /// <summary>
    /// The alias_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AliasArn is required")]
    public required TerraformValue<string> AliasArn
    {
        get => new TerraformReference<string>(this, "alias_arn");
        set => SetArgument("alias_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockagentAgentCollaborator.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentCollaboratorTimeoutsBlock : TerraformBlock
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
/// Represents a aws_bedrockagent_agent_collaborator Terraform resource.
/// Manages a aws_bedrockagent_agent_collaborator resource.
/// </summary>
public partial class AwsBedrockagentAgentCollaborator(string name) : TerraformResource("aws_bedrockagent_agent_collaborator", name)
{
    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    public required TerraformValue<string> AgentId
    {
        get => new TerraformReference<string>(this, "agent_id");
        set => SetArgument("agent_id", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string> AgentVersion
    {
        get => new TerraformReference<string>(this, "agent_version");
        set => SetArgument("agent_version", value);
    }

    /// <summary>
    /// The collaboration_instruction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationInstruction is required")]
    public required TerraformValue<string> CollaborationInstruction
    {
        get => new TerraformReference<string>(this, "collaboration_instruction");
        set => SetArgument("collaboration_instruction", value);
    }

    /// <summary>
    /// The collaborator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaboratorName is required")]
    public required TerraformValue<string> CollaboratorName
    {
        get => new TerraformReference<string>(this, "collaborator_name");
        set => SetArgument("collaborator_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The relay_conversation_history attribute.
    /// </summary>
    public TerraformValue<string> RelayConversationHistory
    {
        get => new TerraformReference<string>(this, "relay_conversation_history");
        set => SetArgument("relay_conversation_history", value);
    }

    /// <summary>
    /// The collaborator_id attribute.
    /// </summary>
    public TerraformValue<string> CollaboratorId
    {
        get => new TerraformReference<string>(this, "collaborator_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// AgentDescriptor block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentAgentCollaboratorAgentDescriptorBlock>? AgentDescriptor
    {
        get => GetArgument<TerraformList<AwsBedrockagentAgentCollaboratorAgentDescriptorBlock>>("agent_descriptor");
        set => SetArgument("agent_descriptor", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentAgentCollaboratorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentAgentCollaboratorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
