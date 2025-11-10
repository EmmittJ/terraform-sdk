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
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
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
        SetOutput("activity_log_enabled");
        SetOutput("azure_active_directory_log_enabled");
        SetOutput("id");
        SetOutput("metric_enabled");
        SetOutput("monitor_id");
        SetOutput("subscription_log_enabled");
    }

    /// <summary>
    /// The activity_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ActivityLogEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("activity_log_enabled");
        set => SetProperty("activity_log_enabled", value);
    }

    /// <summary>
    /// The azure_active_directory_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AzureActiveDirectoryLogEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("azure_active_directory_log_enabled");
        set => SetProperty("azure_active_directory_log_enabled", value);
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
    /// The metric_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> MetricEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("metric_enabled");
        set => SetProperty("metric_enabled", value);
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
    /// The subscription_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SubscriptionLogEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("subscription_log_enabled");
        set => SetProperty("subscription_log_enabled", value);
    }

    /// <summary>
    /// Block for log_tag_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNewRelicTagRuleLogTagFilterBlock>? LogTagFilter
    {
        set => SetProperty("log_tag_filter", value);
    }

    /// <summary>
    /// Block for metric_tag_filter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermNewRelicTagRuleMetricTagFilterBlock>? MetricTagFilter
    {
        set => SetProperty("metric_tag_filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNewRelicTagRuleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
