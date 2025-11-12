using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_descriptor in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentAgentCollaboratorAgentDescriptorBlock() : TerraformBlock("agent_descriptor")
{
    /// <summary>
    /// The alias_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AliasArn is required")]
    [TerraformProperty("alias_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AliasArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockagentAgentCollaboratorTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_bedrockagent_agent_collaborator resource.
/// </summary>
public partial class AwsBedrockagentAgentCollaborator : TerraformResource
{
    public AwsBedrockagentAgentCollaborator(string name) : base("aws_bedrockagent_agent_collaborator", name)
    {
    }

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
    [TerraformProperty("agent_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AgentVersion { get; set; }

    /// <summary>
    /// The collaboration_instruction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationInstruction is required")]
    [TerraformProperty("collaboration_instruction")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CollaborationInstruction { get; set; }

    /// <summary>
    /// The collaborator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaboratorName is required")]
    [TerraformProperty("collaborator_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CollaboratorName { get; set; }

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
    /// The relay_conversation_history attribute.
    /// </summary>
    [TerraformProperty("relay_conversation_history")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RelayConversationHistory { get; set; }

    /// <summary>
    /// Block for agent_descriptor.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("agent_descriptor")]
    public TerraformList<AwsBedrockagentAgentCollaboratorAgentDescriptorBlock> AgentDescriptor { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsBedrockagentAgentCollaboratorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The collaborator_id attribute.
    /// </summary>
    [TerraformProperty("collaborator_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CollaboratorId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
