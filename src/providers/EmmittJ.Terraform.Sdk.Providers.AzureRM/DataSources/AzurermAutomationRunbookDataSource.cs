using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationRunbookDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("content");
        SetOutput("description");
        SetOutput("location");
        SetOutput("log_activity_trace_level");
        SetOutput("log_progress");
        SetOutput("log_verbose");
        SetOutput("runbook_type");
        SetOutput("tags");
        SetOutput("automation_account_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformProperty<string> AutomationAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automation_account_name");
        set => SetProperty("automation_account_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationRunbookDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
