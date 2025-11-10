using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationHybridRunbookWorkerTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_automation_hybrid_runbook_worker resource.
/// </summary>
public class AzurermAutomationHybridRunbookWorker : TerraformResource
{
    public AzurermAutomationHybridRunbookWorker(string name) : base("azurerm_automation_hybrid_runbook_worker", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("ip");
        SetOutput("last_seen_date_time");
        SetOutput("registration_date_time");
        SetOutput("worker_name");
        SetOutput("worker_type");
        SetOutput("automation_account_name");
        SetOutput("id");
        SetOutput("resource_group_name");
        SetOutput("vm_resource_id");
        SetOutput("worker_group_name");
        SetOutput("worker_id");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The vm_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmResourceId is required")]
    public required TerraformProperty<string> VmResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vm_resource_id");
        set => SetProperty("vm_resource_id", value);
    }

    /// <summary>
    /// The worker_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerGroupName is required")]
    public required TerraformProperty<string> WorkerGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("worker_group_name");
        set => SetProperty("worker_group_name", value);
    }

    /// <summary>
    /// The worker_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerId is required")]
    public required TerraformProperty<string> WorkerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("worker_id");
        set => SetProperty("worker_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationHybridRunbookWorkerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The ip attribute.
    /// </summary>
    public TerraformExpression Ip => this["ip"];

    /// <summary>
    /// The last_seen_date_time attribute.
    /// </summary>
    public TerraformExpression LastSeenDateTime => this["last_seen_date_time"];

    /// <summary>
    /// The registration_date_time attribute.
    /// </summary>
    public TerraformExpression RegistrationDateTime => this["registration_date_time"];

    /// <summary>
    /// The worker_name attribute.
    /// </summary>
    public TerraformExpression WorkerName => this["worker_name"];

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    public TerraformExpression WorkerType => this["worker_type"];

}
