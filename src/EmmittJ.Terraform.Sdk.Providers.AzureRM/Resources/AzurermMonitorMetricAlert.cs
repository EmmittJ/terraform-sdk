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
    public TerraformLiteralProperty<bool>? AutoMitigate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_mitigate");
        set => this.WithProperty("auto_mitigate", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Frequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("frequency");
        set => this.WithProperty("frequency", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The scopes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Severity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetResourceLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_location");
        set => this.WithProperty("target_resource_location", value);
    }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_type");
        set => this.WithProperty("target_resource_type", value);
    }

    /// <summary>
    /// The window_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WindowSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("window_size");
        set => this.WithProperty("window_size", value);
    }

}
