using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLocalNetworkGatewayDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_local_network_gateway.
/// </summary>
public class AzurermLocalNetworkGatewayDataSource : TerraformDataSource
{
    public AzurermLocalNetworkGatewayDataSource(string name) : base("azurerm_local_network_gateway", name)
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
    public TerraformBlock<AzurermLocalNetworkGatewayDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformPropertyName("address_space")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AddressSpace => new TerraformReference(this, "address_space");

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    [TerraformPropertyName("bgp_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BgpSettings => new TerraformReference(this, "bgp_settings");

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    [TerraformPropertyName("gateway_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayAddress => new TerraformReference(this, "gateway_address");

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("gateway_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayFqdn => new TerraformReference(this, "gateway_fqdn");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
