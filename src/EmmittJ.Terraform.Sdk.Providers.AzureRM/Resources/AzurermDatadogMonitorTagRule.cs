using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_datadog_monitor_tag_rule resource.
/// </summary>
public class AzurermDatadogMonitorTagRule : TerraformResource
{
    public AzurermDatadogMonitorTagRule(string name) : base("azurerm_datadog_monitor_tag_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    public TerraformProperty<string>? DatadogMonitorId
    {
        get => GetProperty<TerraformProperty<string>>("datadog_monitor_id");
        set => this.WithProperty("datadog_monitor_id", value);
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

}
