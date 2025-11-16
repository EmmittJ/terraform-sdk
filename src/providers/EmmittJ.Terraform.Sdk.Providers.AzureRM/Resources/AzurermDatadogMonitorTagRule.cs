using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for log in .
/// Nesting mode: list
/// </summary>
public class AzurermDatadogMonitorTagRuleLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log";

    /// <summary>
    /// The aad_log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AadLogEnabled
    {
        get => new TerraformReference<bool>(this, "aad_log_enabled");
        set => SetArgument("aad_log_enabled", value);
    }

    /// <summary>
    /// The resource_log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ResourceLogEnabled
    {
        get => new TerraformReference<bool>(this, "resource_log_enabled");
        set => SetArgument("resource_log_enabled", value);
    }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SubscriptionLogEnabled
    {
        get => new TerraformReference<bool>(this, "subscription_log_enabled");
        set => SetArgument("subscription_log_enabled", value);
    }

}

/// <summary>
/// Block type for metric in .
/// Nesting mode: list
/// </summary>
public class AzurermDatadogMonitorTagRuleMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric";

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatadogMonitorTagRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_datadog_monitor_tag_rule Terraform resource.
/// Manages a azurerm_datadog_monitor_tag_rule resource.
/// </summary>
public partial class AzurermDatadogMonitorTagRule(string name) : TerraformResource("azurerm_datadog_monitor_tag_rule", name)
{
    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogMonitorId is required")]
    public required TerraformValue<string> DatadogMonitorId
    {
        get => new TerraformReference<string>(this, "datadog_monitor_id");
        set => SetArgument("datadog_monitor_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Log block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDatadogMonitorTagRuleLogBlock>? Log
    {
        get => GetArgument<TerraformList<AzurermDatadogMonitorTagRuleLogBlock>>("log");
        set => SetArgument("log", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDatadogMonitorTagRuleMetricBlock>? Metric
    {
        get => GetArgument<TerraformList<AzurermDatadogMonitorTagRuleMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDatadogMonitorTagRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDatadogMonitorTagRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
