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
    public TerraformProperty<string>? AgentAliasName
    {
        get => GetProperty<TerraformProperty<string>>("agent_alias_name");
        set => this.WithProperty("agent_alias_name", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The routing_configuration attribute.
    /// </summary>
    public TerraformProperty<List<object>>? RoutingConfiguration
    {
        get => GetProperty<TerraformProperty<List<object>>>("routing_configuration");
        set => this.WithProperty("routing_configuration", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
