using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_log_analytics_datasource_windows_performance_counter resource.
/// </summary>
public class AzurermLogAnalyticsDatasourceWindowsPerformanceCounter : TerraformResource
{
    public AzurermLogAnalyticsDatasourceWindowsPerformanceCounter(string name) : base("azurerm_log_analytics_datasource_windows_performance_counter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The counter_name attribute.
    /// </summary>
    public string? CounterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("counter_name")?.Value;
        set => this.WithProperty("counter_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance_name attribute.
    /// </summary>
    public string? InstanceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_name")?.Value;
        set => this.WithProperty("instance_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The interval_seconds attribute.
    /// </summary>
    public double? IntervalSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("interval_seconds")?.Value;
        set => this.WithProperty("interval_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_name attribute.
    /// </summary>
    public string? ObjectName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_name")?.Value;
        set => this.WithProperty("object_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    public string? WorkspaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_name")?.Value;
        set => this.WithProperty("workspace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
