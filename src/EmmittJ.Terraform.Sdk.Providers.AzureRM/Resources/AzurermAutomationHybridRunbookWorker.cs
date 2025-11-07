using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("ip");
        this.DeclareOutput("last_seen_date_time");
        this.DeclareOutput("registration_date_time");
        this.DeclareOutput("worker_name");
        this.DeclareOutput("worker_type");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The vm_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? VmResourceId
    {
        get => GetProperty<TerraformProperty<string>>("vm_resource_id");
        set => this.WithProperty("vm_resource_id", value);
    }

    /// <summary>
    /// The worker_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkerGroupName
    {
        get => GetProperty<TerraformProperty<string>>("worker_group_name");
        set => this.WithProperty("worker_group_name", value);
    }

    /// <summary>
    /// The worker_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkerId
    {
        get => GetProperty<TerraformProperty<string>>("worker_id");
        set => this.WithProperty("worker_id", value);
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
