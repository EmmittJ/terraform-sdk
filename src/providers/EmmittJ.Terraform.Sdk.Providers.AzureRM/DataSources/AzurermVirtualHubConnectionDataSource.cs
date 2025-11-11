using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubConnectionDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_hub_connection.
/// </summary>
public class AzurermVirtualHubConnectionDataSource : TerraformDataSource
{
    public AzurermVirtualHubConnectionDataSource(string name) : base("azurerm_virtual_hub_connection", name)
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
    /// The virtual_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubName is required")]
    [TerraformPropertyName("virtual_hub_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VirtualHubName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualHubConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_security_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> InternetSecurityEnabled => new TerraformReference(this, "internet_security_enabled");

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("remote_virtual_network_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RemoteVirtualNetworkId => new TerraformReference(this, "remote_virtual_network_id");

    /// <summary>
    /// The routing attribute.
    /// </summary>
    [TerraformPropertyName("routing")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Routing => new TerraformReference(this, "routing");

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_hub_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualHubId => new TerraformReference(this, "virtual_hub_id");

}
