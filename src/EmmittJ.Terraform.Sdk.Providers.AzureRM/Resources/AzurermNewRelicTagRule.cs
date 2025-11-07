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
    public TerraformLiteralProperty<bool>? ActivityLogEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("activity_log_enabled");
        set => this.WithProperty("activity_log_enabled", value);
    }

    /// <summary>
    /// The azure_active_directory_log_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AzureActiveDirectoryLogEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("azure_active_directory_log_enabled");
        set => this.WithProperty("azure_active_directory_log_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The metric_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MetricEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("metric_enabled");
        set => this.WithProperty("metric_enabled", value);
    }

    /// <summary>
    /// The monitor_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MonitorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitor_id");
        set => this.WithProperty("monitor_id", value);
    }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SubscriptionLogEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("subscription_log_enabled");
        set => this.WithProperty("subscription_log_enabled", value);
    }

}
