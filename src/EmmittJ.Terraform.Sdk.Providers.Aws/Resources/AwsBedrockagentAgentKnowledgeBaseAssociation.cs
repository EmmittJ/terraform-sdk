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
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The knowledge_base_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KnowledgeBaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("knowledge_base_id");
        set => this.WithProperty("knowledge_base_id", value);
    }

    /// <summary>
    /// The knowledge_base_state attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KnowledgeBaseState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("knowledge_base_state");
        set => this.WithProperty("knowledge_base_state", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
