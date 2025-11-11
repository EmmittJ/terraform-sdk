using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagent_agent resource.
/// </summary>
public class AwsBedrockagentAgent : TerraformResource
{
    public AwsBedrockagentAgent(string name) : base("aws_bedrockagent_agent", name)
    {
    }

    /// <summary>
    /// The agent_collaboration attribute.
    /// </summary>
    [TerraformPropertyName("agent_collaboration")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AgentCollaboration { get; set; } = default!;

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentName is required")]
    [TerraformPropertyName("agent_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AgentName { get; set; }

    /// <summary>
    /// The agent_resource_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentResourceRoleArn is required")]
    [TerraformPropertyName("agent_resource_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AgentResourceRoleArn { get; set; }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("customer_encryption_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomerEncryptionKeyArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The foundation_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FoundationModel is required")]
    [TerraformPropertyName("foundation_model")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FoundationModel { get; set; }

    /// <summary>
    /// The guardrail_configuration attribute.
    /// </summary>
    [TerraformPropertyName("guardrail_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformList<object>? GuardrailConfiguration { get; set; }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("idle_session_ttl_in_seconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> IdleSessionTtlInSeconds { get; set; } = default!;

    /// <summary>
    /// The instruction attribute.
    /// </summary>
    [TerraformPropertyName("instruction")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Instruction { get; set; } = default!;

    /// <summary>
    /// The memory_configuration attribute.
    /// </summary>
    [TerraformPropertyName("memory_configuration")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> MemoryConfiguration { get; set; } = default!;

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    [TerraformPropertyName("prepare_agent")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> PrepareAgent { get; set; } = default!;

    /// <summary>
    /// The prompt_override_configuration attribute.
    /// </summary>
    [TerraformPropertyName("prompt_override_configuration")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> PromptOverrideConfiguration { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    [TerraformPropertyName("skip_resource_in_use_check")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SkipResourceInUseCheck { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockagentAgentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The agent_arn attribute.
    /// </summary>
    [TerraformPropertyName("agent_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AgentArn => new TerraformReference(this, "agent_arn");

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [TerraformPropertyName("agent_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AgentId => new TerraformReference(this, "agent_id");

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformPropertyName("agent_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AgentVersion => new TerraformReference(this, "agent_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The prepared_at attribute.
    /// </summary>
    [TerraformPropertyName("prepared_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreparedAt => new TerraformReference(this, "prepared_at");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
