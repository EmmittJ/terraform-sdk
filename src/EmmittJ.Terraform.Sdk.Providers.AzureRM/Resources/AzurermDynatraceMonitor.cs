using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dynatrace_monitor resource.
/// </summary>
public class AzurermDynatraceMonitor : TerraformResource
{
    public AzurermDynatraceMonitor(string name) : base("azurerm_dynatrace_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The marketplace_subscription attribute.
    /// </summary>
    public TerraformProperty<string>? MarketplaceSubscription
    {
        get => GetProperty<TerraformProperty<string>>("marketplace_subscription");
        set => this.WithProperty("marketplace_subscription", value);
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("monitoring_enabled");
        set => this.WithProperty("monitoring_enabled", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
