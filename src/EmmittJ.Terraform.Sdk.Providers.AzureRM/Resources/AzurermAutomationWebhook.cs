using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_automation_webhook resource.
/// </summary>
public class AzurermAutomationWebhook : TerraformResource
{
    public AzurermAutomationWebhook(string name) : base("azurerm_automation_webhook", name)
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
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpiryTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiry_time");
        set => this.WithProperty("expiry_time", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The run_on_worker_group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RunOnWorkerGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("run_on_worker_group");
        set => this.WithProperty("run_on_worker_group", value);
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
    /// The uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Uri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("uri");
        set => this.WithProperty("uri", value);
    }

}
