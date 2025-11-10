using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_descriptor in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentCollaboratorAgentDescriptorBlock : ITerraformBlock
{
    /// <summary>
    /// The alias_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AliasArn is required")]
    [TerraformPropertyName("alias_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AliasArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentCollaboratorTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_bedrockagent_agent_collaborator resource.
/// </summary>
public class AwsBedrockagentAgentCollaborator : TerraformResource
{
    public AwsBedrockagentAgentCollaborator(string name) : base("aws_bedrockagent_agent_collaborator", name)
    {
    }

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
    [TerraformPropertyName("agent_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AgentVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_version");

    /// <summary>
    /// The collaboration_instruction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationInstruction is required")]
    [TerraformPropertyName("collaboration_instruction")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CollaborationInstruction { get; set; }

    /// <summary>
    /// The collaborator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaboratorName is required")]
    [TerraformPropertyName("collaborator_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CollaboratorName { get; set; }

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
    /// The relay_conversation_history attribute.
    /// </summary>
    [TerraformPropertyName("relay_conversation_history")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RelayConversationHistory { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "relay_conversation_history");

    /// <summary>
    /// Block for agent_descriptor.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("agent_descriptor")]
    public TerraformList<TerraformBlock<AwsBedrockagentAgentCollaboratorAgentDescriptorBlock>>? AgentDescriptor { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockagentAgentCollaboratorTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The collaborator_id attribute.
    /// </summary>
    [TerraformPropertyName("collaborator_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CollaboratorId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "collaborator_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
