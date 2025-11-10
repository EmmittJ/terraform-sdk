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
        set => SetProperty("aad_log_enabled", value);
    }

    /// <summary>
    /// The resource_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ResourceLogEnabled
    {
        set => SetProperty("resource_log_enabled", value);
    }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SubscriptionLogEnabled
    {
        set => SetProperty("subscription_log_enabled", value);
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("datadog_monitor_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogMonitorId is required")]
    public required TerraformProperty<string> DatadogMonitorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("datadog_monitor_id");
        set => SetProperty("datadog_monitor_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for log.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDatadogMonitorTagRuleLogBlock>? Log
    {
        set => SetProperty("log", value);
    }

    /// <summary>
    /// Block for metric.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDatadogMonitorTagRuleMetricBlock>? Metric
    {
        set => SetProperty("metric", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDatadogMonitorTagRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
