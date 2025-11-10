using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for log_tag_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicTagRuleLogTagFilterBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for metric_tag_filter in .
/// Nesting mode: list
/// </summary>
public class AzurermNewRelicTagRuleMetricTagFilterBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNewRelicTagRuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_new_relic_tag_rule resource.
/// </summary>
public class AzurermNewRelicTagRule : TerraformResource
{
    public AzurermNewRelicTagRule(string name) : base("azurerm_new_relic_tag_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The activity_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ActivityLogEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("activity_log_enabled");
        set => this.WithProperty("activity_log_enabled", value);
    }

    /// <summary>
    /// The azure_active_directory_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AzureActiveDirectoryLogEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("azure_active_directory_log_enabled");
        set => this.WithProperty("azure_active_directory_log_enabled", value);
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
    /// The metric_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MetricEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("metric_enabled");
        set => this.WithProperty("metric_enabled", value);
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
    /// The subscription_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SubscriptionLogEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("subscription_log_enabled");
        set => this.WithProperty("subscription_log_enabled", value);
    }

    /// <summary>
    /// Block for log_tag_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNewRelicTagRuleLogTagFilterBlock>? LogTagFilter
    {
        get => GetProperty<List<AzurermNewRelicTagRuleLogTagFilterBlock>>("log_tag_filter");
        set => this.WithProperty("log_tag_filter", value);
    }

    /// <summary>
    /// Block for metric_tag_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNewRelicTagRuleMetricTagFilterBlock>? MetricTagFilter
    {
        get => GetProperty<List<AzurermNewRelicTagRuleMetricTagFilterBlock>>("metric_tag_filter");
        set => this.WithProperty("metric_tag_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNewRelicTagRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNewRelicTagRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
