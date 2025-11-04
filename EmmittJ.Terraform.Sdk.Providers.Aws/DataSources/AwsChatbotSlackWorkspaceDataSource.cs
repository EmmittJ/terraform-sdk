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
        this.DeclareOutput("slack_team_id");
    }

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    public string? SlackTeamName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("slack_team_name")?.Value;
        set => this.WithProperty("slack_team_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    public TerraformExpression SlackTeamId => this["slack_team_id"];

}
