using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_chatbot_slack_workspace.
/// </summary>
public class AwsChatbotSlackWorkspaceDataSource : TerraformDataSource
{
    public AwsChatbotSlackWorkspaceDataSource(string name) : base("aws_chatbot_slack_workspace", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackTeamName is required")]
    [TerraformPropertyName("slack_team_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SlackTeamName { get; set; }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    [TerraformPropertyName("slack_team_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SlackTeamId => new TerraformReference(this, "slack_team_id");

}
