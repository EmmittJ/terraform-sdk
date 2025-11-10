using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_chatbot_slack_workspace.
/// </summary>
public class AwsChatbotSlackWorkspaceDataSource : TerraformDataSource
{
    public AwsChatbotSlackWorkspaceDataSource(string name) : base("aws_chatbot_slack_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("slack_team_id");
        SetOutput("region");
        SetOutput("slack_team_name");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackTeamName is required")]
    public required TerraformProperty<string> SlackTeamName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("slack_team_name");
        set => SetProperty("slack_team_name", value);
    }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    public TerraformExpression SlackTeamId => this["slack_team_id"];

}
