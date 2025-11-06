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
    public string? ActionGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action_group_name")?.Value;
        set => this.WithProperty("action_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The action_group_state attribute.
    /// </summary>
    public string? ActionGroupState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action_group_state")?.Value;
        set => this.WithProperty("action_group_state", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parent_action_group_signature attribute.
    /// </summary>
    public string? ParentActionGroupSignature
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_action_group_signature")?.Value;
        set => this.WithProperty("parent_action_group_signature", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    public bool? SkipResourceInUseCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_resource_in_use_check")?.Value;
        set => this.WithProperty("skip_resource_in_use_check", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
