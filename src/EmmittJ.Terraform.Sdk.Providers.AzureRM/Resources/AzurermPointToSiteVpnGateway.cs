using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_point_to_site_vpn_gateway resource.
/// </summary>
public class AzurermPointToSiteVpnGateway : TerraformResource
{
    public AzurermPointToSiteVpnGateway(string name) : base("azurerm_point_to_site_vpn_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? DnsServers
    {
        get => GetProperty<TerraformProperty<List<string>>>("dns_servers");
        set => this.WithProperty("dns_servers", value);
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
    /// The routing_preference_internet_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RoutingPreferenceInternetEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("routing_preference_internet_enabled");
        set => this.WithProperty("routing_preference_internet_enabled", value);
    }

    /// <summary>
    /// The scale_unit attribute.
    /// </summary>
    public TerraformProperty<double>? ScaleUnit
    {
        get => GetProperty<TerraformProperty<double>>("scale_unit");
        set => this.WithProperty("scale_unit", value);
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
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualHubId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_hub_id");
        set => this.WithProperty("virtual_hub_id", value);
    }

    /// <summary>
    /// The vpn_server_configuration_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpnServerConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_server_configuration_id");
        set => this.WithProperty("vpn_server_configuration_id", value);
    }

}
