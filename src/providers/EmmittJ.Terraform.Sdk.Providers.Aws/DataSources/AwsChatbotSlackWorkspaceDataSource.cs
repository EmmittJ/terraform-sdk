using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_chatbot_slack_workspace.
/// </summary>
public partial class AwsChatbotSlackWorkspaceDataSource : TerraformDataSource
{
    public AwsChatbotSlackWorkspaceDataSource(string name) : base("aws_chatbot_slack_workspace", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackTeamName is required")]
    [TerraformProperty("slack_team_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SlackTeamName { get; set; }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    [TerraformProperty("slack_team_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SlackTeamId { get; }

}
