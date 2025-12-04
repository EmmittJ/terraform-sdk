using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for log_rule in AzurermDynatraceTagRules.
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
        get => GetArgument<TerraformValue<bool>>("send_activity_logs_enabled");
        set => SetArgument("send_activity_logs_enabled", value);
    }

    /// <summary>
    /// The send_azure_active_directory_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SendAzureActiveDirectoryLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("send_azure_active_directory_logs_enabled");
        set => SetArgument("send_azure_active_directory_logs_enabled", value);
    }

    /// <summary>
    /// The send_subscription_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SendSubscriptionLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("send_subscription_logs_enabled");
        set => SetArgument("send_subscription_logs_enabled", value);
    }

    /// <summary>
    /// FilteringTag block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilteringTag is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilteringTag block(s) required")]
    public required TerraformList<AzurermDynatraceTagRulesLogRuleBlockFilteringTagBlock> FilteringTag
    {
        get => GetRequiredArgument<TerraformList<AzurermDynatraceTagRulesLogRuleBlockFilteringTagBlock>>("filtering_tag");
        set => SetArgument("filtering_tag", value);
    }

}

/// <summary>
/// Block type for filtering_tag in AzurermDynatraceTagRulesLogRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceTagRulesLogRuleBlockFilteringTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filtering_tag";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for metric_rule in AzurermDynatraceTagRules.
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
        get => GetArgument<TerraformValue<bool>>("sending_metrics_enabled");
        set => SetArgument("sending_metrics_enabled", value);
    }

    /// <summary>
    /// FilteringTag block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilteringTag is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilteringTag block(s) required")]
    public required TerraformList<AzurermDynatraceTagRulesMetricRuleBlockFilteringTagBlock> FilteringTag
    {
        get => GetRequiredArgument<TerraformList<AzurermDynatraceTagRulesMetricRuleBlockFilteringTagBlock>>("filtering_tag");
        set => SetArgument("filtering_tag", value);
    }

}

/// <summary>
/// Block type for filtering_tag in AzurermDynatraceTagRulesMetricRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceTagRulesMetricRuleBlockFilteringTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filtering_tag";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDynatraceTagRules.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorId is required")]
    public required TerraformValue<string> MonitorId
    {
        get => GetArgument<TerraformValue<string>>("monitor_id");
        set => SetArgument("monitor_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// LogRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogRule block(s) allowed")]
    public TerraformList<AzurermDynatraceTagRulesLogRuleBlock>? LogRule
    {
        get => GetArgument<TerraformList<AzurermDynatraceTagRulesLogRuleBlock>>("log_rule");
        set => SetArgument("log_rule", value);
    }

    /// <summary>
    /// MetricRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricRule block(s) allowed")]
    public TerraformList<AzurermDynatraceTagRulesMetricRuleBlock>? MetricRule
    {
        get => GetArgument<TerraformList<AzurermDynatraceTagRulesMetricRuleBlock>>("metric_rule");
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
