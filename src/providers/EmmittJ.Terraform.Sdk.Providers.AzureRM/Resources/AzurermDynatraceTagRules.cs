using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for log_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceTagRulesLogRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_rule";

    /// <summary>
    /// The send_activity_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SendActivityLogsEnabled
    {
        get => new TerraformReference<bool>(this, "send_activity_logs_enabled");
        set => SetArgument("send_activity_logs_enabled", value);
    }

    /// <summary>
    /// The send_azure_active_directory_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SendAzureActiveDirectoryLogsEnabled
    {
        get => new TerraformReference<bool>(this, "send_azure_active_directory_logs_enabled");
        set => SetArgument("send_azure_active_directory_logs_enabled", value);
    }

    /// <summary>
    /// The send_subscription_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SendSubscriptionLogsEnabled
    {
        get => new TerraformReference<bool>(this, "send_subscription_logs_enabled");
        set => SetArgument("send_subscription_logs_enabled", value);
    }

}

/// <summary>
/// Block type for metric_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceTagRulesMetricRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_rule";

    /// <summary>
    /// The sending_metrics_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SendingMetricsEnabled
    {
        get => new TerraformReference<bool>(this, "sending_metrics_enabled");
        set => SetArgument("sending_metrics_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDynatraceTagRulesTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_dynatrace_tag_rules Terraform resource.
/// Manages a azurerm_dynatrace_tag_rules resource.
/// </summary>
public partial class AzurermDynatraceTagRules(string name) : TerraformResource("azurerm_dynatrace_tag_rules", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorId is required")]
    public required TerraformValue<string> MonitorId
    {
        get => new TerraformReference<string>(this, "monitor_id");
        set => SetArgument("monitor_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// LogRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogRule block(s) allowed")]
    public AzurermDynatraceTagRulesLogRuleBlock? LogRule
    {
        get => GetArgument<AzurermDynatraceTagRulesLogRuleBlock>("log_rule");
        set => SetArgument("log_rule", value);
    }

    /// <summary>
    /// MetricRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricRule block(s) allowed")]
    public AzurermDynatraceTagRulesMetricRuleBlock? MetricRule
    {
        get => GetArgument<AzurermDynatraceTagRulesMetricRuleBlock>("metric_rule");
        set => SetArgument("metric_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDynatraceTagRulesTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDynatraceTagRulesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
