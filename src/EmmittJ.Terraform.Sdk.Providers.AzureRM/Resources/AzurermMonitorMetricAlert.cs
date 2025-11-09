using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_monitor_metric_alert resource.
/// </summary>
public class AzurermMonitorMetricAlert : TerraformResource
{
    public AzurermMonitorMetricAlert(string name) : base("azurerm_monitor_metric_alert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_mitigate attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMitigate
    {
        get => GetProperty<TerraformProperty<bool>>("auto_mitigate");
        set => this.WithProperty("auto_mitigate", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformProperty<string>? Frequency
    {
        get => GetProperty<TerraformProperty<string>>("frequency");
        set => this.WithProperty("frequency", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The scopes attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Scopes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<double>? Severity
    {
        get => GetProperty<TerraformProperty<double>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformProperty<string>? TargetResourceLocation
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_location");
        set => this.WithProperty("target_resource_location", value);
    }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformProperty<string>? TargetResourceType
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_type");
        set => this.WithProperty("target_resource_type", value);
    }

    /// <summary>
    /// The window_size attribute.
    /// </summary>
    public TerraformProperty<string>? WindowSize
    {
        get => GetProperty<TerraformProperty<string>>("window_size");
        set => this.WithProperty("window_size", value);
    }

}
