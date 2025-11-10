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
        get => GetRequiredProperty<TerraformProperty<string>>("alias_arn");
        set => WithProperty("alias_arn", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("collaborator_id");
        this.WithOutput("id");
    }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    public required TerraformProperty<string> AgentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("agent_id");
        set => this.WithProperty("agent_id", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformProperty<string>? AgentVersion
    {
        get => GetProperty<TerraformProperty<string>>("agent_version");
        set => this.WithProperty("agent_version", value);
    }

    /// <summary>
    /// The collaboration_instruction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationInstruction is required")]
    public required TerraformProperty<string> CollaborationInstruction
    {
        get => GetRequiredProperty<TerraformProperty<string>>("collaboration_instruction");
        set => this.WithProperty("collaboration_instruction", value);
    }

    /// <summary>
    /// The collaborator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaboratorName is required")]
    public required TerraformProperty<string> CollaboratorName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("collaborator_name");
        set => this.WithProperty("collaborator_name", value);
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public TerraformProperty<bool>? PrepareAgent
    {
        get => GetProperty<TerraformProperty<bool>>("prepare_agent");
        set => this.WithProperty("prepare_agent", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The relay_conversation_history attribute.
    /// </summary>
    public TerraformProperty<string>? RelayConversationHistory
    {
        get => GetProperty<TerraformProperty<string>>("relay_conversation_history");
        set => this.WithProperty("relay_conversation_history", value);
    }

    /// <summary>
    /// Block for agent_descriptor.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentCollaboratorAgentDescriptorBlock>? AgentDescriptor
    {
        get => GetProperty<List<AwsBedrockagentAgentCollaboratorAgentDescriptorBlock>>("agent_descriptor");
        set => this.WithProperty("agent_descriptor", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockagentAgentCollaboratorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBedrockagentAgentCollaboratorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
