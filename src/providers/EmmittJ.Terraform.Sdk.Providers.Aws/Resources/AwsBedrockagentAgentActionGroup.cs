using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action_group_executor in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupActionGroupExecutorBlock : ITerraformBlock
{
    /// <summary>
    /// The custom_control attribute.
    /// </summary>
    [TerraformPropertyName("custom_control")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomControl { get; set; }

    /// <summary>
    /// The lambda attribute.
    /// </summary>
    [TerraformPropertyName("lambda")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Lambda { get; set; }

}

/// <summary>
/// Block type for api_schema in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupApiSchemaBlock : ITerraformBlock
{
    /// <summary>
    /// The payload attribute.
    /// </summary>
    [TerraformPropertyName("payload")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Payload { get; set; }

}

/// <summary>
/// Block type for function_schema in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentActionGroupFunctionSchemaBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentActionGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagent_agent_action_group resource.
/// </summary>
public class AwsBedrockagentAgentActionGroup : TerraformResource
{
    public AwsBedrockagentAgentActionGroup(string name) : base("aws_bedrockagent_agent_action_group", name)
    {
    }

    /// <summary>
    /// The action_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupName is required")]
    [TerraformPropertyName("action_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ActionGroupName { get; set; }

    /// <summary>
    /// The action_group_state attribute.
    /// </summary>
    [TerraformPropertyName("action_group_state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ActionGroupState { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "action_group_state");

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    [TerraformPropertyName("agent_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AgentId { get; set; }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentVersion is required")]
    [TerraformPropertyName("agent_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AgentVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The parent_action_group_signature attribute.
    /// </summary>
    [TerraformPropertyName("parent_action_group_signature")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ParentActionGroupSignature { get; set; }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    [TerraformPropertyName("prepare_agent")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PrepareAgent { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "prepare_agent");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    [TerraformPropertyName("skip_resource_in_use_check")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SkipResourceInUseCheck { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "skip_resource_in_use_check");

    /// <summary>
    /// Block for action_group_executor.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("action_group_executor")]
    public TerraformList<TerraformBlock<AwsBedrockagentAgentActionGroupActionGroupExecutorBlock>>? ActionGroupExecutor { get; set; } = new();

    /// <summary>
    /// Block for api_schema.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("api_schema")]
    public TerraformList<TerraformBlock<AwsBedrockagentAgentActionGroupApiSchemaBlock>>? ApiSchema { get; set; } = new();

    /// <summary>
    /// Block for function_schema.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("function_schema")]
    public TerraformList<TerraformBlock<AwsBedrockagentAgentActionGroupFunctionSchemaBlock>>? FunctionSchema { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockagentAgentActionGroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [TerraformPropertyName("action_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ActionGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "action_group_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
