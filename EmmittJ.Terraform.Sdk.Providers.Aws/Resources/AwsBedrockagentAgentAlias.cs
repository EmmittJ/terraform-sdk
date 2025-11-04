using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagent_agent_alias resource.
/// </summary>
public class AwsBedrockagentAgentAlias : TerraformResource
{
    public AwsBedrockagentAgentAlias(string name) : base("aws_bedrockagent_agent_alias", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("agent_alias_arn");
        this.DeclareOutput("agent_alias_id");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The agent_alias_name attribute.
    /// </summary>
    public string? AgentAliasName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_alias_name")?.Value;
        set => this.WithProperty("agent_alias_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_configuration attribute.
    /// </summary>
    public List<object>? RoutingConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("routing_configuration")?.Value;
        set => this.WithProperty("routing_configuration", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The agent_alias_arn attribute.
    /// </summary>
    public TerraformExpression AgentAliasArn => this["agent_alias_arn"];

    /// <summary>
    /// The agent_alias_id attribute.
    /// </summary>
    public TerraformExpression AgentAliasId => this["agent_alias_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
