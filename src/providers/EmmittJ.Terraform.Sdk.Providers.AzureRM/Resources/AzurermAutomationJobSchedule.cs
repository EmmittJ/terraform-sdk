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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("resource_manager_id");
        SetOutput("automation_account_name");
        SetOutput("id");
        SetOutput("job_schedule_id");
        SetOutput("parameters");
        SetOutput("resource_group_name");
        SetOutput("run_on");
        SetOutput("runbook_name");
        SetOutput("schedule_name");
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
    /// The job_schedule_id attribute.
    /// </summary>
    public TerraformProperty<string> JobScheduleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_schedule_id");
        set => SetProperty("job_schedule_id", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
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
    /// The run_on attribute.
    /// </summary>
    public TerraformProperty<string> RunOn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("run_on");
        set => SetProperty("run_on", value);
    }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RunbookName is required")]
    public required TerraformProperty<string> RunbookName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runbook_name");
        set => SetProperty("runbook_name", value);
    }

    /// <summary>
    /// The schedule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleName is required")]
    public required TerraformProperty<string> ScheduleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule_name");
        set => SetProperty("schedule_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationJobScheduleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

}
