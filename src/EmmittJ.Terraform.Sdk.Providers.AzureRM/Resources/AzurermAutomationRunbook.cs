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
    public TerraformProperty<string>? AutomationAccountName
    {
        get => GetProperty<TerraformProperty<string>>("automation_account_name");
        set => this.WithProperty("automation_account_name", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformProperty<string>? Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => this.WithProperty("content", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The job_schedule attribute.
    /// </summary>
    public TerraformProperty<HashSet<object>>? JobSchedule
    {
        get => GetProperty<TerraformProperty<HashSet<object>>>("job_schedule");
        set => this.WithProperty("job_schedule", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    public TerraformProperty<double>? LogActivityTraceLevel
    {
        get => GetProperty<TerraformProperty<double>>("log_activity_trace_level");
        set => this.WithProperty("log_activity_trace_level", value);
    }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    public TerraformProperty<bool>? LogProgress
    {
        get => GetProperty<TerraformProperty<bool>>("log_progress");
        set => this.WithProperty("log_progress", value);
    }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    public TerraformProperty<bool>? LogVerbose
    {
        get => GetProperty<TerraformProperty<bool>>("log_verbose");
        set => this.WithProperty("log_verbose", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The runbook_type attribute.
    /// </summary>
    public TerraformProperty<string>? RunbookType
    {
        get => GetProperty<TerraformProperty<string>>("runbook_type");
        set => this.WithProperty("runbook_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
