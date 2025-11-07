using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_runbook resource.
/// </summary>
public class AzurermAutomationRunbook : TerraformResource
{
    public AzurermAutomationRunbook(string name) : base("azurerm_automation_runbook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutomationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_name");
        set => this.WithProperty("automation_account_name", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content");
        set => this.WithProperty("content", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The job_schedule attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<object>>? JobSchedule
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("job_schedule");
        set => this.WithProperty("job_schedule", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? LogActivityTraceLevel
    {
        get => GetProperty<TerraformLiteralProperty<double>>("log_activity_trace_level");
        set => this.WithProperty("log_activity_trace_level", value);
    }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LogProgress
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_progress");
        set => this.WithProperty("log_progress", value);
    }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LogVerbose
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_verbose");
        set => this.WithProperty("log_verbose", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RunbookType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runbook_type");
        set => this.WithProperty("runbook_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
