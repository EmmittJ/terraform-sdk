using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? MonitorId
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

}
