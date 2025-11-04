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
    public string? AutomationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("automation_account_name")?.Value;
        set => this.WithProperty("automation_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The expiry_time attribute.
    /// </summary>
    public string? ExpiryTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiry_time")?.Value;
        set => this.WithProperty("expiry_time", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The run_on_worker_group attribute.
    /// </summary>
    public string? RunOnWorkerGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("run_on_worker_group")?.Value;
        set => this.WithProperty("run_on_worker_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The runbook_name attribute.
    /// </summary>
    public string? RunbookName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runbook_name")?.Value;
        set => this.WithProperty("runbook_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public string? Uri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("uri")?.Value;
        set => this.WithProperty("uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
