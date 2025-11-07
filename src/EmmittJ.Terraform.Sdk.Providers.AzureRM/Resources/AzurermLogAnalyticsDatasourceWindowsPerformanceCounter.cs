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
    public TerraformLiteralProperty<string>? CounterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("counter_name");
        set => this.WithProperty("counter_name", value);
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
    /// The instance_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_name");
        set => this.WithProperty("instance_name", value);
    }

    /// <summary>
    /// The interval_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IntervalSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("interval_seconds");
        set => this.WithProperty("interval_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The object_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_name");
        set => this.WithProperty("object_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_name");
        set => this.WithProperty("workspace_name", value);
    }

}
