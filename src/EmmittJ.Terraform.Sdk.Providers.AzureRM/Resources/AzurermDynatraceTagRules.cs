using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for log_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceTagRulesLogRuleBlock : TerraformBlock
{
    /// <summary>
    /// The send_activity_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SendActivityLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("send_activity_logs_enabled");
        set => WithProperty("send_activity_logs_enabled", value);
    }

    /// <summary>
    /// The send_azure_active_directory_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SendAzureActiveDirectoryLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("send_azure_active_directory_logs_enabled");
        set => WithProperty("send_azure_active_directory_logs_enabled", value);
    }

    /// <summary>
    /// The send_subscription_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SendSubscriptionLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("send_subscription_logs_enabled");
        set => WithProperty("send_subscription_logs_enabled", value);
    }

}

/// <summary>
/// Block type for metric_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceTagRulesMetricRuleBlock : TerraformBlock
{
    /// <summary>
    /// The sending_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SendingMetricsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sending_metrics_enabled");
        set => WithProperty("sending_metrics_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDynatraceTagRulesTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_dynatrace_tag_rules resource.
/// </summary>
public class AzurermDynatraceTagRules : TerraformResource
{
    public AzurermDynatraceTagRules(string name) : base("azurerm_dynatrace_tag_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorId is required")]
    public required TerraformProperty<string> MonitorId
    {
        get => GetProperty<TerraformProperty<string>>("monitor_id");
        set => this.WithProperty("monitor_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for log_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogRule block(s) allowed")]
    public List<AzurermDynatraceTagRulesLogRuleBlock>? LogRule
    {
        get => GetProperty<List<AzurermDynatraceTagRulesLogRuleBlock>>("log_rule");
        set => this.WithProperty("log_rule", value);
    }

    /// <summary>
    /// Block for metric_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricRule block(s) allowed")]
    public List<AzurermDynatraceTagRulesMetricRuleBlock>? MetricRule
    {
        get => GetProperty<List<AzurermDynatraceTagRulesMetricRuleBlock>>("metric_rule");
        set => this.WithProperty("metric_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDynatraceTagRulesTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDynatraceTagRulesTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
