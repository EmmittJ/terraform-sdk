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
    public TerraformProperty<string>? ConditionJson
    {
        get => GetProperty<TerraformProperty<string>>("condition_json");
        set => this.WithProperty("condition_json", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformProperty<string>? Expiration
    {
        get => GetProperty<TerraformProperty<string>>("expiration");
        set => this.WithProperty("expiration", value);
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
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
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => this.WithProperty("order", value);
    }

    /// <summary>
    /// The triggers_on attribute.
    /// </summary>
    public TerraformProperty<string>? TriggersOn
    {
        get => GetProperty<TerraformProperty<string>>("triggers_on");
        set => this.WithProperty("triggers_on", value);
    }

    /// <summary>
    /// The triggers_when attribute.
    /// </summary>
    public TerraformProperty<string>? TriggersWhen
    {
        get => GetProperty<TerraformProperty<string>>("triggers_when");
        set => this.WithProperty("triggers_when", value);
    }

}
