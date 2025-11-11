using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_vpn_gateway.
/// </summary>
public class AzurermVpnGatewayDataSource : TerraformDataSource
{
    public AzurermVpnGatewayDataSource(string name) : base("azurerm_vpn_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVpnGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    [TerraformPropertyName("bgp_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BgpSettings => new TerraformReference(this, "bgp_settings");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IpConfiguration => new TerraformReference(this, "ip_configuration");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The scale_unit attribute.
    /// </summary>
    [TerraformPropertyName("scale_unit")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ScaleUnit => new TerraformReference(this, "scale_unit");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_hub_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualHubId => new TerraformReference(this, "virtual_hub_id");

}
