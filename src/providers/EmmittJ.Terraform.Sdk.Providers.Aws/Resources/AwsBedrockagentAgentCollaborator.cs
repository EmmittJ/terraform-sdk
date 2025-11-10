using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_descriptor in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentCollaboratorAgentDescriptorBlock : TerraformBlock
{
    /// <summary>
    /// The alias_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AliasArn is required")]
    public required TerraformProperty<string> AliasArn
    {
        set => SetProperty("alias_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentCollaboratorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_bedrockagent_agent_collaborator resource.
/// </summary>
public class AwsBedrockagentAgentCollaborator : TerraformResource
{
    public AwsBedrockagentAgentCollaborator(string name) : base("aws_bedrockagent_agent_collaborator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("collaborator_id");
        SetOutput("id");
        SetOutput("agent_id");
        SetOutput("agent_version");
        SetOutput("collaboration_instruction");
        SetOutput("collaborator_name");
        SetOutput("prepare_agent");
        SetOutput("region");
        SetOutput("relay_conversation_history");
    }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    public required TerraformProperty<string> AgentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_id");
        set => SetProperty("agent_id", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformProperty<string> AgentVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_version");
        set => SetProperty("agent_version", value);
    }

    /// <summary>
    /// The collaboration_instruction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationInstruction is required")]
    public required TerraformProperty<string> CollaborationInstruction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collaboration_instruction");
        set => SetProperty("collaboration_instruction", value);
    }

    /// <summary>
    /// The collaborator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaboratorName is required")]
    public required TerraformProperty<string> CollaboratorName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collaborator_name");
        set => SetProperty("collaborator_name", value);
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public TerraformProperty<bool> PrepareAgent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("prepare_agent");
        set => SetProperty("prepare_agent", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The relay_conversation_history attribute.
    /// </summary>
    public TerraformProperty<string> RelayConversationHistory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("relay_conversation_history");
        set => SetProperty("relay_conversation_history", value);
    }

    /// <summary>
    /// Block for agent_descriptor.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentCollaboratorAgentDescriptorBlock>? AgentDescriptor
    {
        set => SetProperty("agent_descriptor", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockagentAgentCollaboratorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The collaborator_id attribute.
    /// </summary>
    public TerraformExpression CollaboratorId => this["collaborator_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
