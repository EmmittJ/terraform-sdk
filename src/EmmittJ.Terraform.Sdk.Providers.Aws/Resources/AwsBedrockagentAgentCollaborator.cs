using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("collaborator_id");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    public TerraformProperty<string>? AgentId
    {
        get => GetProperty<TerraformProperty<string>>("agent_id");
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
    public TerraformProperty<string>? CollaborationInstruction
    {
        get => GetProperty<TerraformProperty<string>>("collaboration_instruction");
        set => this.WithProperty("collaboration_instruction", value);
    }

    /// <summary>
    /// The collaborator_name attribute.
    /// </summary>
    public TerraformProperty<string>? CollaboratorName
    {
        get => GetProperty<TerraformProperty<string>>("collaborator_name");
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
    /// The collaborator_id attribute.
    /// </summary>
    public TerraformExpression CollaboratorId => this["collaborator_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
