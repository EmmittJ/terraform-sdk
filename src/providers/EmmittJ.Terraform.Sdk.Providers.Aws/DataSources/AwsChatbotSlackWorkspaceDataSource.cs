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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The slack_team_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlackTeamName is required")]
    [TerraformPropertyName("slack_team_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SlackTeamName { get; set; }

    /// <summary>
    /// The slack_team_id attribute.
    /// </summary>
    [TerraformPropertyName("slack_team_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SlackTeamId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "slack_team_id");

}
