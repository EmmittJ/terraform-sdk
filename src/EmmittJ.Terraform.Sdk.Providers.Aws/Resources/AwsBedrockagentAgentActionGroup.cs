using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action_group_executor in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupActionGroupExecutorBlock : TerraformBlock
{
    /// <summary>
    /// The custom_control attribute.
    /// </summary>
    public TerraformProperty<string>? CustomControl
    {
        get => GetProperty<TerraformProperty<string>>("custom_control");
        set => WithProperty("custom_control", value);
    }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    public TerraformProperty<string>? Lambda
    {
        get => GetProperty<TerraformProperty<string>>("lambda");
        set => WithProperty("lambda", value);
    }

}

/// <summary>
/// Block type for api_schema in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupApiSchemaBlock : TerraformBlock
{
    /// <summary>
    /// The payload attribute.
    /// </summary>
    public TerraformProperty<string>? Payload
    {
        get => GetProperty<TerraformProperty<string>>("payload");
        set => WithProperty("payload", value);
    }

}

/// <summary>
/// Block type for function_schema in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupFunctionSchemaBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentActionGroupTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupName is required")]
    public required TerraformProperty<string> ActionGroupName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    public required TerraformProperty<string> AgentId
    {
        get => GetProperty<TerraformProperty<string>>("agent_id");
        set => this.WithProperty("agent_id", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentVersion is required")]
    public required TerraformProperty<string> AgentVersion
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
    /// Block for action_group_executor.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentActionGroupActionGroupExecutorBlock>? ActionGroupExecutor
    {
        get => GetProperty<List<AwsBedrockagentAgentActionGroupActionGroupExecutorBlock>>("action_group_executor");
        set => this.WithProperty("action_group_executor", value);
    }

    /// <summary>
    /// Block for api_schema.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentActionGroupApiSchemaBlock>? ApiSchema
    {
        get => GetProperty<List<AwsBedrockagentAgentActionGroupApiSchemaBlock>>("api_schema");
        set => this.WithProperty("api_schema", value);
    }

    /// <summary>
    /// Block for function_schema.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentActionGroupFunctionSchemaBlock>? FunctionSchema
    {
        get => GetProperty<List<AwsBedrockagentAgentActionGroupFunctionSchemaBlock>>("function_schema");
        set => this.WithProperty("function_schema", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockagentAgentActionGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBedrockagentAgentActionGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
