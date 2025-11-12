using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockagentAgentKnowledgeBaseAssociationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_bedrockagent_agent_knowledge_base_association resource.
/// </summary>
public partial class AwsBedrockagentAgentKnowledgeBaseAssociation : TerraformResource
{
    public AwsBedrockagentAgentKnowledgeBaseAssociation(string name) : base("aws_bedrockagent_agent_knowledge_base_association", name)
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
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The knowledge_base_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBaseId is required")]
    [TerraformProperty("knowledge_base_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KnowledgeBaseId { get; set; }

    /// <summary>
    /// The knowledge_base_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBaseState is required")]
    [TerraformProperty("knowledge_base_state")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KnowledgeBaseState { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsBedrockagentAgentKnowledgeBaseAssociationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
