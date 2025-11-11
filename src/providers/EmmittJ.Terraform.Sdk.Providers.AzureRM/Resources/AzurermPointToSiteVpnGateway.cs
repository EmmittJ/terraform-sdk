using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for connection_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPointToSiteVpnGatewayConnectionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_security_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? InternetSecurityEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPointToSiteVpnGatewayTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_point_to_site_vpn_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermPointToSiteVpnGateway : TerraformResource
{
    public AzurermPointToSiteVpnGateway(string name) : base("azurerm_point_to_site_vpn_gateway", name)
    {
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The routing_preference_internet_enabled attribute.
    /// </summary>
    [TerraformProperty("routing_preference_internet_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RoutingPreferenceInternetEnabled { get; set; }

    /// <summary>
    /// The scale_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleUnit is required")]
    [TerraformProperty("scale_unit")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ScaleUnit { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    [TerraformProperty("virtual_hub_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualHubId { get; set; }

    /// <summary>
    /// The vpn_server_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnServerConfigurationId is required")]
    [TerraformProperty("vpn_server_configuration_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VpnServerConfigurationId { get; set; }

    /// <summary>
    /// Block for connection_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionConfiguration block(s) required")]
    [TerraformProperty("connection_configuration")]
    public TerraformList<TerraformBlock<AzurermPointToSiteVpnGatewayConnectionConfigurationBlock>>? ConnectionConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPointToSiteVpnGatewayTimeoutsBlock>? Timeouts { get; set; }

}
