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
/// Block type for log_tag_filter in .
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
    [TerraformArgument("action")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for metric_tag_filter in .
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
    [TerraformArgument("action")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_new_relic_tag_rule resource.
/// </summary>
public class AzurermNewRelicTagRule : TerraformResource
{
    public AzurermNewRelicTagRule(string name) : base("azurerm_new_relic_tag_rule", name)
    {
    }

    /// <summary>
    /// The activity_log_enabled attribute.
    /// </summary>
    [TerraformArgument("activity_log_enabled")]
    public TerraformValue<bool>? ActivityLogEnabled
    {
        get => new TerraformReference<bool>(this, "activity_log_enabled");
        set => SetArgument("activity_log_enabled", value);
    }

    /// <summary>
    /// The azure_active_directory_log_enabled attribute.
    /// </summary>
    [TerraformArgument("azure_active_directory_log_enabled")]
    public TerraformValue<bool>? AzureActiveDirectoryLogEnabled
    {
        get => new TerraformReference<bool>(this, "azure_active_directory_log_enabled");
        set => SetArgument("azure_active_directory_log_enabled", value);
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
    /// The metric_enabled attribute.
    /// </summary>
    [TerraformArgument("metric_enabled")]
    public TerraformValue<bool>? MetricEnabled
    {
        get => new TerraformReference<bool>(this, "metric_enabled");
        set => SetArgument("metric_enabled", value);
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
    /// The subscription_log_enabled attribute.
    /// </summary>
    [TerraformArgument("subscription_log_enabled")]
    public TerraformValue<bool>? SubscriptionLogEnabled
    {
        get => new TerraformReference<bool>(this, "subscription_log_enabled");
        set => SetArgument("subscription_log_enabled", value);
    }

    /// <summary>
    /// Block for log_tag_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("log_tag_filter")]
    public TerraformList<AzurermNewRelicTagRuleLogTagFilterBlock> LogTagFilter { get; set; } = new();

    /// <summary>
    /// Block for metric_tag_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("metric_tag_filter")]
    public TerraformList<AzurermNewRelicTagRuleMetricTagFilterBlock> MetricTagFilter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNewRelicTagRuleTimeoutsBlock Timeouts { get; set; } = new();

}
