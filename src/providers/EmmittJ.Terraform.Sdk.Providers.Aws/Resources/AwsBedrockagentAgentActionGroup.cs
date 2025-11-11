using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action_group_executor in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentAgentActionGroupActionGroupExecutorBlock : TerraformBlockBase
{
    /// <summary>
    /// The custom_control attribute.
    /// </summary>
    [TerraformProperty("custom_control")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomControl { get; set; }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    [TerraformProperty("lambda")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Lambda { get; set; }

}

/// <summary>
/// Block type for api_schema in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentAgentActionGroupApiSchemaBlock : TerraformBlockBase
{
    /// <summary>
    /// The payload attribute.
    /// </summary>
    [TerraformProperty("payload")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Payload { get; set; }

}

/// <summary>
/// Block type for function_schema in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentAgentActionGroupFunctionSchemaBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockagentAgentActionGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagent_agent_action_group resource.
/// </summary>
public partial class AwsBedrockagentAgentActionGroup : TerraformResource
{
    public AwsBedrockagentAgentActionGroup(string name) : base("aws_bedrockagent_agent_action_group", name)
    {
    }

    /// <summary>
    /// The action_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupName is required")]
    [TerraformProperty("action_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ActionGroupName { get; set; }

    /// <summary>
    /// The action_group_state attribute.
    /// </summary>
    [TerraformProperty("action_group_state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ActionGroupState { get; set; }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    [TerraformProperty("agent_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AgentId { get; set; }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentVersion is required")]
    [TerraformProperty("agent_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AgentVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The parent_action_group_signature attribute.
    /// </summary>
    [TerraformProperty("parent_action_group_signature")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ParentActionGroupSignature { get; set; }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    [TerraformProperty("prepare_agent")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> PrepareAgent { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    [TerraformProperty("skip_resource_in_use_check")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SkipResourceInUseCheck { get; set; }

    /// <summary>
    /// Block for action_group_executor.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("action_group_executor")]
    public partial TerraformList<TerraformBlock<AwsBedrockagentAgentActionGroupActionGroupExecutorBlock>>? ActionGroupExecutor { get; set; }

    /// <summary>
    /// Block for api_schema.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("api_schema")]
    public partial TerraformList<TerraformBlock<AwsBedrockagentAgentActionGroupApiSchemaBlock>>? ApiSchema { get; set; }

    /// <summary>
    /// Block for function_schema.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("function_schema")]
    public partial TerraformList<TerraformBlock<AwsBedrockagentAgentActionGroupFunctionSchemaBlock>>? FunctionSchema { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsBedrockagentAgentActionGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [TerraformProperty("action_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ActionGroupId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
