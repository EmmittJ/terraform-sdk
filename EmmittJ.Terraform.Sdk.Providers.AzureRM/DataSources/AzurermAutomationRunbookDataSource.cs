using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_automation_runbook.
/// </summary>
public class AzurermAutomationRunbookDataSource : TerraformDataSource
{
    public AzurermAutomationRunbookDataSource(string name) : base("azurerm_automation_runbook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("content");
        this.DeclareOutput("description");
        this.DeclareOutput("location");
        this.DeclareOutput("log_activity_trace_level");
        this.DeclareOutput("log_progress");
        this.DeclareOutput("log_verbose");
        this.DeclareOutput("runbook_type");
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    public string? AutomationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_name")?.Value;
        set => this.WithProperty("automation_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformExpression Content => this["content"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    public TerraformExpression LogActivityTraceLevel => this["log_activity_trace_level"];

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    public TerraformExpression LogProgress => this["log_progress"];

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    public TerraformExpression LogVerbose => this["log_verbose"];

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    public TerraformExpression RunbookType => this["runbook_type"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
