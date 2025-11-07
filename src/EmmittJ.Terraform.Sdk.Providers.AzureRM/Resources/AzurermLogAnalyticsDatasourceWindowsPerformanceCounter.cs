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
    public TerraformProperty<string>? CounterName
    {
        get => GetProperty<TerraformProperty<string>>("counter_name");
        set => this.WithProperty("counter_name", value);
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
    /// The instance_name attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceName
    {
        get => GetProperty<TerraformProperty<string>>("instance_name");
        set => this.WithProperty("instance_name", value);
    }

    /// <summary>
    /// The interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalSeconds
    {
        get => GetProperty<TerraformProperty<double>>("interval_seconds");
        set => this.WithProperty("interval_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The object_name attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectName
    {
        get => GetProperty<TerraformProperty<string>>("object_name");
        set => this.WithProperty("object_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The workspace_name attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceName
    {
        get => GetProperty<TerraformProperty<string>>("workspace_name");
        set => this.WithProperty("workspace_name", value);
    }

}
