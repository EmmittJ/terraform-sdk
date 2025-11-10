using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AgentCollaboration { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_collaboration");

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentName is required")]
    [TerraformPropertyName("agent_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AgentName { get; set; }

    /// <summary>
    /// The agent_resource_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentResourceRoleArn is required")]
    [TerraformPropertyName("agent_resource_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AgentResourceRoleArn { get; set; }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("customer_encryption_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomerEncryptionKeyArn { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The foundation_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FoundationModel is required")]
    [TerraformPropertyName("foundation_model")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FoundationModel { get; set; }

    /// <summary>
    /// The guardrail_configuration attribute.
    /// </summary>
    [TerraformPropertyName("guardrail_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<object>>>? GuardrailConfiguration { get; set; }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("idle_session_ttl_in_seconds")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> IdleSessionTtlInSeconds { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "idle_session_ttl_in_seconds");

    /// <summary>
    /// The instruction attribute.
    /// </summary>
    [TerraformPropertyName("instruction")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Instruction { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instruction");

    /// <summary>
    /// The memory_configuration attribute.
    /// </summary>
    [TerraformPropertyName("memory_configuration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> MemoryConfiguration { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "memory_configuration");

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    [TerraformPropertyName("prepare_agent")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PrepareAgent { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "prepare_agent");

    /// <summary>
    /// The prompt_override_configuration attribute.
    /// </summary>
    [TerraformPropertyName("prompt_override_configuration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> PromptOverrideConfiguration { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "prompt_override_configuration");

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockagentAgentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The agent_arn attribute.
    /// </summary>
    [TerraformPropertyName("agent_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_arn");

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [TerraformPropertyName("agent_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_id");

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformPropertyName("agent_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The prepared_at attribute.
    /// </summary>
    [TerraformPropertyName("prepared_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreparedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "prepared_at");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
