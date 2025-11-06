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
    public bool? ActivityLogEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("activity_log_enabled")?.Value;
        set => this.WithProperty("activity_log_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The azure_active_directory_log_enabled attribute.
    /// </summary>
    public bool? AzureActiveDirectoryLogEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("azure_active_directory_log_enabled")?.Value;
        set => this.WithProperty("azure_active_directory_log_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metric_enabled attribute.
    /// </summary>
    public bool? MetricEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("metric_enabled")?.Value;
        set => this.WithProperty("metric_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The monitor_id attribute.
    /// </summary>
    public string? MonitorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitor_id")?.Value;
        set => this.WithProperty("monitor_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    public bool? SubscriptionLogEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("subscription_log_enabled")?.Value;
        set => this.WithProperty("subscription_log_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
