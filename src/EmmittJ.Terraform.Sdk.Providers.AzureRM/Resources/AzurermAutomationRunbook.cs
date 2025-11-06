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
    public string? AutomationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_name")?.Value;
        set => this.WithProperty("automation_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public string? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content")?.Value;
        set => this.WithProperty("content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The job_schedule attribute.
    /// </summary>
    public HashSet<object>? JobSchedule
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("job_schedule")?.Value;
        set => this.WithProperty("job_schedule", value == null ? null : new TerraformLiteralProperty<HashSet<object>>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_activity_trace_level attribute.
    /// </summary>
    public double? LogActivityTraceLevel
    {
        get => GetProperty<TerraformLiteralProperty<double>>("log_activity_trace_level")?.Value;
        set => this.WithProperty("log_activity_trace_level", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The log_progress attribute.
    /// </summary>
    public bool? LogProgress
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_progress")?.Value;
        set => this.WithProperty("log_progress", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The log_verbose attribute.
    /// </summary>
    public bool? LogVerbose
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_verbose")?.Value;
        set => this.WithProperty("log_verbose", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The runbook_type attribute.
    /// </summary>
    public string? RunbookType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runbook_type")?.Value;
        set => this.WithProperty("runbook_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
