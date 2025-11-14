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
    [TerraformArgument("aad_log_enabled")]
    public TerraformValue<bool>? AadLogEnabled
    {
        get => new TerraformReference<bool>(this, "aad_log_enabled");
        set => SetArgument("aad_log_enabled", value);
    }

    /// <summary>
    /// The resource_log_enabled attribute.
    /// </summary>
    [TerraformArgument("resource_log_enabled")]
    public TerraformValue<bool>? ResourceLogEnabled
    {
        get => new TerraformReference<bool>(this, "resource_log_enabled");
        set => SetArgument("resource_log_enabled", value);
    }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    [TerraformArgument("subscription_log_enabled")]
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
/// Manages a azurerm_datadog_monitor_tag_rule resource.
/// </summary>
public class AzurermDatadogMonitorTagRule : TerraformResource
{
    public AzurermDatadogMonitorTagRule(string name) : base("azurerm_datadog_monitor_tag_rule", name)
    {
    }

    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogMonitorId is required")]
    [TerraformArgument("datadog_monitor_id")]
    public required TerraformValue<string> DatadogMonitorId
    {
        get => new TerraformReference<string>(this, "datadog_monitor_id");
        set => SetArgument("datadog_monitor_id", value);
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
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for log.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("log")]
    public TerraformList<AzurermDatadogMonitorTagRuleLogBlock> Log { get; set; } = new();

    /// <summary>
    /// Block for metric.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("metric")]
    public TerraformList<AzurermDatadogMonitorTagRuleMetricBlock> Metric { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDatadogMonitorTagRuleTimeoutsBlock Timeouts { get; set; } = new();

}
