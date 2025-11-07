using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_traffic_manager_profile.
/// </summary>
public class AzurermTrafficManagerProfileDataSource : TerraformDataSource
{
    public AzurermTrafficManagerProfileDataSource(string name) : base("azurerm_traffic_manager_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dns_config");
        this.DeclareOutput("fqdn");
        this.DeclareOutput("monitor_config");
        this.DeclareOutput("profile_status");
        this.DeclareOutput("traffic_routing_method");
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TrafficViewEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("traffic_view_enabled");
        set => this.WithProperty("traffic_view_enabled", value);
    }

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    public TerraformExpression DnsConfig => this["dns_config"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The monitor_config attribute.
    /// </summary>
    public TerraformExpression MonitorConfig => this["monitor_config"];

    /// <summary>
    /// The profile_status attribute.
    /// </summary>
    public TerraformExpression ProfileStatus => this["profile_status"];

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    public TerraformExpression TrafficRoutingMethod => this["traffic_routing_method"];

}
