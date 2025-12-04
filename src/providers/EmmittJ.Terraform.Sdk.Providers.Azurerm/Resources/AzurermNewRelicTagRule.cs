using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for log_tag_filter in AzurermNewRelicTagRule.
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicTagRuleLogTagFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_tag_filter";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for metric_tag_filter in AzurermNewRelicTagRule.
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicTagRuleMetricTagFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_tag_filter";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNewRelicTagRule.
/// Nesting mode: single
/// </summary>
public class AzurermNewRelicTagRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_new_relic_tag_rule Terraform resource.
/// Manages a azurerm_new_relic_tag_rule resource.
/// </summary>
public partial class AzurermNewRelicTagRule(string name) : TerraformResource("azurerm_new_relic_tag_rule", name)
{
    /// <summary>
    /// The activity_log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ActivityLogEnabled
    {
        get => GetArgument<TerraformValue<bool>>("activity_log_enabled");
        set => SetArgument("activity_log_enabled", value);
    }

    /// <summary>
    /// The azure_active_directory_log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AzureActiveDirectoryLogEnabled
    {
        get => GetArgument<TerraformValue<bool>>("azure_active_directory_log_enabled");
        set => SetArgument("azure_active_directory_log_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The metric_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MetricEnabled
    {
        get => GetArgument<TerraformValue<bool>>("metric_enabled");
        set => SetArgument("metric_enabled", value);
    }

    /// <summary>
    /// The monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorId is required")]
    public required TerraformValue<string> MonitorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("monitor_id");
        set => SetArgument("monitor_id", value);
    }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SubscriptionLogEnabled
    {
        get => GetArgument<TerraformValue<bool>>("subscription_log_enabled");
        set => SetArgument("subscription_log_enabled", value);
    }

    /// <summary>
    /// LogTagFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermNewRelicTagRuleLogTagFilterBlock>? LogTagFilter
    {
        get => GetArgument<TerraformList<AzurermNewRelicTagRuleLogTagFilterBlock>>("log_tag_filter");
        set => SetArgument("log_tag_filter", value);
    }

    /// <summary>
    /// MetricTagFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermNewRelicTagRuleMetricTagFilterBlock>? MetricTagFilter
    {
        get => GetArgument<TerraformList<AzurermNewRelicTagRuleMetricTagFilterBlock>>("metric_tag_filter");
        set => SetArgument("metric_tag_filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNewRelicTagRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNewRelicTagRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
