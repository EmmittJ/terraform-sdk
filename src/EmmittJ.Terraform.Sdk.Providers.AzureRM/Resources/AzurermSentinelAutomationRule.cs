using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_sentinel_automation_rule resource.
/// </summary>
public class AzurermSentinelAutomationRule : TerraformResource
{
    public AzurermSentinelAutomationRule(string name) : base("azurerm_sentinel_automation_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The condition_json attribute.
    /// </summary>
    public string? ConditionJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("condition_json")?.Value;
        set => this.WithProperty("condition_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The expiration attribute.
    /// </summary>
    public string? Expiration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration")?.Value;
        set => this.WithProperty("expiration", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public string? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id")?.Value;
        set => this.WithProperty("log_analytics_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The order attribute.
    /// </summary>
    public double? Order
    {
        get => GetProperty<TerraformLiteralProperty<double>>("order")?.Value;
        set => this.WithProperty("order", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The triggers_on attribute.
    /// </summary>
    public string? TriggersOn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("triggers_on")?.Value;
        set => this.WithProperty("triggers_on", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The triggers_when attribute.
    /// </summary>
    public string? TriggersWhen
    {
        get => GetProperty<TerraformLiteralProperty<string>>("triggers_when")?.Value;
        set => this.WithProperty("triggers_when", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
