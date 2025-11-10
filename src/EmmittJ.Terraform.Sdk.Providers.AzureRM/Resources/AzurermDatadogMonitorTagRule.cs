using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for log in .
/// Nesting mode: list
/// </summary>
public class AzurermDatadogMonitorTagRuleLogBlock : TerraformBlock
{
    /// <summary>
    /// The aad_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AadLogEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("aad_log_enabled");
        set => WithProperty("aad_log_enabled", value);
    }

    /// <summary>
    /// The resource_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ResourceLogEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("resource_log_enabled");
        set => WithProperty("resource_log_enabled", value);
    }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SubscriptionLogEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("subscription_log_enabled");
        set => WithProperty("subscription_log_enabled", value);
    }

}

/// <summary>
/// Block type for metric in .
/// Nesting mode: list
/// </summary>
public class AzurermDatadogMonitorTagRuleMetricBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatadogMonitorTagRuleTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_datadog_monitor_tag_rule resource.
/// </summary>
public class AzurermDatadogMonitorTagRule : TerraformResource
{
    public AzurermDatadogMonitorTagRule(string name) : base("azurerm_datadog_monitor_tag_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogMonitorId is required")]
    public required TerraformProperty<string> DatadogMonitorId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("datadog_monitor_id");
        set => this.WithProperty("datadog_monitor_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for log.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDatadogMonitorTagRuleLogBlock>? Log
    {
        get => GetProperty<List<AzurermDatadogMonitorTagRuleLogBlock>>("log");
        set => this.WithProperty("log", value);
    }

    /// <summary>
    /// Block for metric.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDatadogMonitorTagRuleMetricBlock>? Metric
    {
        get => GetProperty<List<AzurermDatadogMonitorTagRuleMetricBlock>>("metric");
        set => this.WithProperty("metric", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDatadogMonitorTagRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDatadogMonitorTagRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
