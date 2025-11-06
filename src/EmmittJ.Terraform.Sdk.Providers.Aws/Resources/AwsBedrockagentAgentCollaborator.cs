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
    public string? AgentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_id")?.Value;
        set => this.WithProperty("agent_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public string? AgentVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_version")?.Value;
        set => this.WithProperty("agent_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The collaboration_instruction attribute.
    /// </summary>
    public string? CollaborationInstruction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collaboration_instruction")?.Value;
        set => this.WithProperty("collaboration_instruction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The collaborator_name attribute.
    /// </summary>
    public string? CollaboratorName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("collaborator_name")?.Value;
        set => this.WithProperty("collaborator_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public bool? PrepareAgent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("prepare_agent")?.Value;
        set => this.WithProperty("prepare_agent", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The relay_conversation_history attribute.
    /// </summary>
    public string? RelayConversationHistory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("relay_conversation_history")?.Value;
        set => this.WithProperty("relay_conversation_history", value == null ? null : new TerraformLiteralProperty<string>(value));
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
