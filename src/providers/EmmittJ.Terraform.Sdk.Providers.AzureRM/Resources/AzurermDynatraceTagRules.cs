using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("send_activity_logs_enabled")]
    public TerraformValue<bool>? SendActivityLogsEnabled
    {
        get => new TerraformReference<bool>(this, "send_activity_logs_enabled");
        set => SetArgument("send_activity_logs_enabled", value);
    }

    /// <summary>
    /// The send_azure_active_directory_logs_enabled attribute.
    /// </summary>
    [TerraformArgument("send_azure_active_directory_logs_enabled")]
    public TerraformValue<bool>? SendAzureActiveDirectoryLogsEnabled
    {
        get => new TerraformReference<bool>(this, "send_azure_active_directory_logs_enabled");
        set => SetArgument("send_azure_active_directory_logs_enabled", value);
    }

    /// <summary>
    /// The send_subscription_logs_enabled attribute.
    /// </summary>
    [TerraformArgument("send_subscription_logs_enabled")]
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
    [TerraformArgument("sending_metrics_enabled")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorId is required")]
    [TerraformArgument("monitor_id")]
    public required TerraformValue<string> MonitorId
    {
        get => new TerraformReference<string>(this, "monitor_id");
        set => SetArgument("monitor_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for log_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogRule block(s) allowed")]
    [TerraformArgument("log_rule")]
    public TerraformList<AzurermDynatraceTagRulesLogRuleBlock> LogRule { get; set; } = new();

    /// <summary>
    /// Block for metric_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricRule block(s) allowed")]
    [TerraformArgument("metric_rule")]
    public TerraformList<AzurermDynatraceTagRulesMetricRuleBlock> MetricRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDynatraceTagRulesTimeoutsBlock Timeouts { get; set; } = new();

}
