using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for connection_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermPointToSiteVpnGatewayConnectionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetSecurityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_security_enabled");
        set => WithProperty("internet_security_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPointToSiteVpnGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_point_to_site_vpn_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public List<TerraformProperty<string>>? DnsServers
    {
        get => GetProperty<List<TerraformProperty<string>>>("dns_servers");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleUnit is required")]
    public required TerraformProperty<double> ScaleUnit
    {
        get => GetProperty<TerraformProperty<double>>("scale_unit");
        set => this.WithProperty("scale_unit", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformProperty<string> VirtualHubId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_hub_id");
        set => this.WithProperty("virtual_hub_id", value);
    }

    /// <summary>
    /// The vpn_server_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnServerConfigurationId is required")]
    public required TerraformProperty<string> VpnServerConfigurationId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_server_configuration_id");
        set => this.WithProperty("vpn_server_configuration_id", value);
    }

    /// <summary>
    /// Block for connection_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionConfiguration block(s) required")]
    public List<AzurermPointToSiteVpnGatewayConnectionConfigurationBlock>? ConnectionConfiguration
    {
        get => GetProperty<List<AzurermPointToSiteVpnGatewayConnectionConfigurationBlock>>("connection_configuration");
        set => this.WithProperty("connection_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPointToSiteVpnGatewayTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPointToSiteVpnGatewayTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
