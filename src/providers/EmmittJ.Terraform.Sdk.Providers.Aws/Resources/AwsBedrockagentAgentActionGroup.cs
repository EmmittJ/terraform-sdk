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
        set => SetProperty("custom_control", value);
    }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    public TerraformProperty<string>? Lambda
    {
        set => SetProperty("lambda", value);
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
        set => SetProperty("payload", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("action_group_id");
        SetOutput("id");
        SetOutput("action_group_name");
        SetOutput("action_group_state");
        SetOutput("agent_id");
        SetOutput("agent_version");
        SetOutput("description");
        SetOutput("parent_action_group_signature");
        SetOutput("prepare_agent");
        SetOutput("region");
        SetOutput("skip_resource_in_use_check");
    }

    /// <summary>
    /// The action_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupName is required")]
    public required TerraformProperty<string> ActionGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action_group_name");
        set => SetProperty("action_group_name", value);
    }

    /// <summary>
    /// The action_group_state attribute.
    /// </summary>
    public TerraformProperty<string> ActionGroupState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action_group_state");
        set => SetProperty("action_group_state", value);
    }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    public required TerraformProperty<string> AgentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_id");
        set => SetProperty("agent_id", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentVersion is required")]
    public required TerraformProperty<string> AgentVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_version");
        set => SetProperty("agent_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The parent_action_group_signature attribute.
    /// </summary>
    public TerraformProperty<string> ParentActionGroupSignature
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_action_group_signature");
        set => SetProperty("parent_action_group_signature", value);
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public TerraformProperty<bool> PrepareAgent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("prepare_agent");
        set => SetProperty("prepare_agent", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    public TerraformProperty<bool> SkipResourceInUseCheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_resource_in_use_check");
        set => SetProperty("skip_resource_in_use_check", value);
    }

    /// <summary>
    /// Block for action_group_executor.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentActionGroupActionGroupExecutorBlock>? ActionGroupExecutor
    {
        set => SetProperty("action_group_executor", value);
    }

    /// <summary>
    /// Block for api_schema.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentActionGroupApiSchemaBlock>? ApiSchema
    {
        set => SetProperty("api_schema", value);
    }

    /// <summary>
    /// Block for function_schema.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentActionGroupFunctionSchemaBlock>? FunctionSchema
    {
        set => SetProperty("function_schema", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockagentAgentActionGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
