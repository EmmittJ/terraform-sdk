using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_version_summaries in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock() : TerraformBlock("agent_version_summaries")
{






}

/// <summary>
/// Retrieves information about a aws_bedrockagent_agent_versions.
/// </summary>
public partial class AwsBedrockagentAgentVersionsDataSource : TerraformDataSource
{
    public AwsBedrockagentAgentVersionsDataSource(string name) : base("aws_bedrockagent_agent_versions", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for agent_version_summaries.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("agent_version_summaries")]
    public TerraformList<AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock> AgentVersionSummaries { get; set; } = new();

}
