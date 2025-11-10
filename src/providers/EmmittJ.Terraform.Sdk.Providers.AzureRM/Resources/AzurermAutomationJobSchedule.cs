using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationJobScheduleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_automation_job_schedule resource.
/// </summary>
public class AzurermAutomationJobSchedule : TerraformResource
{
    public AzurermAutomationJobSchedule(string name) : base("azurerm_automation_job_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("resource_manager_id");
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformProperty<string> AutomationAccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("automation_account_name");
        set => this.WithProperty("automation_account_name", value);
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
    /// The job_schedule_id attribute.
    /// </summary>
    public TerraformProperty<string>? JobScheduleId
    {
        get => GetProperty<TerraformProperty<string>>("job_schedule_id");
        set => this.WithProperty("job_schedule_id", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The run_on attribute.
    /// </summary>
    public TerraformProperty<string>? RunOn
    {
        get => GetProperty<TerraformProperty<string>>("run_on");
        set => this.WithProperty("run_on", value);
    }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookName is required")]
    public required TerraformProperty<string> RunbookName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("runbook_name");
        set => this.WithProperty("runbook_name", value);
    }

    /// <summary>
    /// The schedule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleName is required")]
    public required TerraformProperty<string> ScheduleName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("schedule_name");
        set => this.WithProperty("schedule_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationJobScheduleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAutomationJobScheduleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

}
