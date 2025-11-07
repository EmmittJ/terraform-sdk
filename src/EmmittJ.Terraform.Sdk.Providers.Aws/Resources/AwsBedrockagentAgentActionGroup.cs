using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagent_agent_action_group resource.
/// </summary>
public class AwsBedrockagentAgentActionGroup : TerraformResource
{
    public AwsBedrockagentAgentActionGroup(string name) : base("aws_bedrockagent_agent_action_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("action_group_id");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The action_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ActionGroupName
    {
        get => GetProperty<TerraformProperty<string>>("action_group_name");
        set => this.WithProperty("action_group_name", value);
    }

    /// <summary>
    /// The action_group_state attribute.
    /// </summary>
    public TerraformProperty<string>? ActionGroupState
    {
        get => GetProperty<TerraformProperty<string>>("action_group_state");
        set => this.WithProperty("action_group_state", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The parent_action_group_signature attribute.
    /// </summary>
    public TerraformProperty<string>? ParentActionGroupSignature
    {
        get => GetProperty<TerraformProperty<string>>("parent_action_group_signature");
        set => this.WithProperty("parent_action_group_signature", value);
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
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipResourceInUseCheck
    {
        get => GetProperty<TerraformProperty<bool>>("skip_resource_in_use_check");
        set => this.WithProperty("skip_resource_in_use_check", value);
    }

    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    public TerraformExpression ActionGroupId => this["action_group_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
