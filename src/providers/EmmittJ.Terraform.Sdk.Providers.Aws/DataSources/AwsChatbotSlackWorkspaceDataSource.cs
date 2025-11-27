using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_chatbot_slack_workspace Terraform data source.
/// Retrieves information about a aws_chatbot_slack_workspace.
/// </summary>
public partial class AwsChatbotSlackWorkspaceDataSource(string name) : TerraformDataSource("aws_chatbot_slack_workspace", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackTeamName is required")]
    public required TerraformValue<string> SlackTeamName
    {
        get => new TerraformReference<string>(this, "slack_team_name");
        set => SetArgument("slack_team_name", value);
    }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    public TerraformValue<string> SlackTeamId
    {
        get => new TerraformReference<string>(this, "slack_team_id");
    }

}
