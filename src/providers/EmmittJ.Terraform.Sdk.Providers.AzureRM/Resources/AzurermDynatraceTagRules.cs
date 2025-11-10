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
        set => SetProperty("send_activity_logs_enabled", value);
    }

    /// <summary>
    /// The send_azure_active_directory_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SendAzureActiveDirectoryLogsEnabled
    {
        set => SetProperty("send_azure_active_directory_logs_enabled", value);
    }

    /// <summary>
    /// The send_subscription_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SendSubscriptionLogsEnabled
    {
        set => SetProperty("send_subscription_logs_enabled", value);
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
        set => SetProperty("sending_metrics_enabled", value);
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
/// Manages a azurerm_dynatrace_tag_rules resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDynatraceTagRules : TerraformResource
{
    public AzurermDynatraceTagRules(string name) : base("azurerm_dynatrace_tag_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("monitor_id");
        SetOutput("name");
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
    /// The monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorId is required")]
    public required TerraformProperty<string> MonitorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitor_id");
        set => SetProperty("monitor_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for log_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogRule block(s) allowed")]
    public List<AzurermDynatraceTagRulesLogRuleBlock>? LogRule
    {
        set => SetProperty("log_rule", value);
    }

    /// <summary>
    /// Block for metric_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricRule block(s) allowed")]
    public List<AzurermDynatraceTagRulesMetricRuleBlock>? MetricRule
    {
        set => SetProperty("metric_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDynatraceTagRulesTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
