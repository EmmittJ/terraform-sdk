using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagent_agent_knowledge_base_association resource.
/// </summary>
public class AwsBedrockagentAgentKnowledgeBaseAssociation : TerraformResource
{
    public AwsBedrockagentAgentKnowledgeBaseAssociation(string name) : base("aws_bedrockagent_agent_knowledge_base_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The knowledge_base_id attribute.
    /// </summary>
    public string? KnowledgeBaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("knowledge_base_id")?.Value;
        set => this.WithProperty("knowledge_base_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The knowledge_base_state attribute.
    /// </summary>
    public string? KnowledgeBaseState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("knowledge_base_state")?.Value;
        set => this.WithProperty("knowledge_base_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
