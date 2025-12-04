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
        get => GetArgument<TerraformValue<string>>("alias_arn");
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
        get => GetArgument<TerraformValue<string>>("agent_id");
        set => SetArgument("agent_id", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string>? AgentVersion
    {
        get => GetArgument<TerraformValue<string>>("agent_version");
        set => SetArgument("agent_version", value);
    }

    /// <summary>
    /// The collaboration_instruction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationInstruction is required")]
    public required TerraformValue<string> CollaborationInstruction
    {
        get => GetArgument<TerraformValue<string>>("collaboration_instruction");
        set => SetArgument("collaboration_instruction", value);
    }

    /// <summary>
    /// The collaborator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaboratorName is required")]
    public required TerraformValue<string> CollaboratorName
    {
        get => GetArgument<TerraformValue<string>>("collaborator_name");
        set => SetArgument("collaborator_name", value);
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public TerraformValue<bool>? PrepareAgent
    {
        get => GetArgument<TerraformValue<bool>>("prepare_agent");
        set => SetArgument("prepare_agent", value);
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
    /// The relay_conversation_history attribute.
    /// </summary>
    public TerraformValue<string>? RelayConversationHistory
    {
        get => GetArgument<TerraformValue<string>>("relay_conversation_history");
        set => SetArgument("relay_conversation_history", value);
    }

    /// <summary>
    /// The collaborator_id attribute.
    /// </summary>
    public TerraformValue<string> CollaboratorId
        => AsReference("collaborator_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

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
