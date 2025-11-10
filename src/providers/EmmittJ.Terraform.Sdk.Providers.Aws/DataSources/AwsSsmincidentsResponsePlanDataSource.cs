using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmincidents_response_plan.
/// </summary>
public class AwsSsmincidentsResponsePlanDataSource : TerraformDataSource
{
    public AwsSsmincidentsResponsePlanDataSource(string name) : base("aws_ssmincidents_response_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("action");
        SetOutput("chat_channel");
        SetOutput("display_name");
        SetOutput("engagements");
        SetOutput("incident_template");
        SetOutput("integration");
        SetOutput("name");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformExpression Action => this["action"];

    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    public TerraformExpression ChatChannel => this["chat_channel"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    public TerraformExpression Engagements => this["engagements"];

    /// <summary>
    /// The incident_template attribute.
    /// </summary>
    public TerraformExpression IncidentTemplate => this["incident_template"];

    /// <summary>
    /// The integration attribute.
    /// </summary>
    public TerraformExpression Integration => this["integration"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
