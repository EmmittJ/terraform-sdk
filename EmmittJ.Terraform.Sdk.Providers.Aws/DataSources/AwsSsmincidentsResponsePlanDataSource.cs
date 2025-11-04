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
        this.DeclareOutput("action");
        this.DeclareOutput("chat_channel");
        this.DeclareOutput("display_name");
        this.DeclareOutput("engagements");
        this.DeclareOutput("incident_template");
        this.DeclareOutput("integration");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
