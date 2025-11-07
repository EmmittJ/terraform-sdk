using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("resource_manager_id");
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
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The job_schedule_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? JobScheduleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_schedule_id");
        set => this.WithProperty("job_schedule_id", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
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
    /// The run_on attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RunOn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("run_on");
        set => this.WithProperty("run_on", value);
    }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RunbookName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runbook_name");
        set => this.WithProperty("runbook_name", value);
    }

    /// <summary>
    /// The schedule_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScheduleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule_name");
        set => this.WithProperty("schedule_name", value);
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformExpression ResourceManagerId => this["resource_manager_id"];

}
