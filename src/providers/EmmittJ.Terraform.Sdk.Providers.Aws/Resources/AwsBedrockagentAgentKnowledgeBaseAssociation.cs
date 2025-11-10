using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentKnowledgeBaseAssociationTimeoutsBlock : TerraformBlock
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
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The knowledge_base_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBaseId is required")]
    public required TerraformProperty<string> KnowledgeBaseId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("knowledge_base_id");
        set => this.WithProperty("knowledge_base_id", value);
    }

    /// <summary>
    /// The knowledge_base_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBaseState is required")]
    public required TerraformProperty<string> KnowledgeBaseState
    {
        get => GetRequiredProperty<TerraformProperty<string>>("knowledge_base_state");
        set => this.WithProperty("knowledge_base_state", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockagentAgentKnowledgeBaseAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBedrockagentAgentKnowledgeBaseAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
