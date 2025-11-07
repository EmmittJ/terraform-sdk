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
    public TerraformLiteralProperty<string>? AgentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_id");
        set => this.WithProperty("agent_id", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AgentVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_version");
        set => this.WithProperty("agent_version", value);
    }

    /// <summary>
    /// The collaboration_instruction attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CollaborationInstruction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collaboration_instruction");
        set => this.WithProperty("collaboration_instruction", value);
    }

    /// <summary>
    /// The collaborator_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CollaboratorName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collaborator_name");
        set => this.WithProperty("collaborator_name", value);
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PrepareAgent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("prepare_agent");
        set => this.WithProperty("prepare_agent", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The relay_conversation_history attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RelayConversationHistory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("relay_conversation_history");
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
