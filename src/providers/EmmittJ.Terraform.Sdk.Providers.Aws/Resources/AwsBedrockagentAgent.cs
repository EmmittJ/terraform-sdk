using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockagentAgentTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagent_agent resource.
/// </summary>
public partial class AwsBedrockagentAgent : TerraformResource
{
    public AwsBedrockagentAgent(string name) : base("aws_bedrockagent_agent", name)
    {
    }

    /// <summary>
    /// The agent_collaboration attribute.
    /// </summary>
    [TerraformProperty("agent_collaboration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AgentCollaboration { get; set; }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentName is required")]
    [TerraformProperty("agent_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AgentName { get; set; }

    /// <summary>
    /// The agent_resource_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentResourceRoleArn is required")]
    [TerraformProperty("agent_resource_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AgentResourceRoleArn { get; set; }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    [TerraformProperty("customer_encryption_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomerEncryptionKeyArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The foundation_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FoundationModel is required")]
    [TerraformProperty("foundation_model")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FoundationModel { get; set; }

    /// <summary>
    /// The guardrail_configuration attribute.
    /// </summary>
    [TerraformProperty("guardrail_configuration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<object>? GuardrailConfiguration { get; set; }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    [TerraformProperty("idle_session_ttl_in_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> IdleSessionTtlInSeconds { get; set; }

    /// <summary>
    /// The instruction attribute.
    /// </summary>
    [TerraformProperty("instruction")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Instruction { get; set; }

    /// <summary>
    /// The memory_configuration attribute.
    /// </summary>
    [TerraformProperty("memory_configuration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> MemoryConfiguration { get; set; }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    [TerraformProperty("prepare_agent")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> PrepareAgent { get; set; }

    /// <summary>
    /// The prompt_override_configuration attribute.
    /// </summary>
    [TerraformProperty("prompt_override_configuration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> PromptOverrideConfiguration { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsBedrockagentAgentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The agent_arn attribute.
    /// </summary>
    [TerraformProperty("agent_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgentArn { get; }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [TerraformProperty("agent_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgentId { get; }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformProperty("agent_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgentVersion { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The prepared_at attribute.
    /// </summary>
    [TerraformProperty("prepared_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreparedAt { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
