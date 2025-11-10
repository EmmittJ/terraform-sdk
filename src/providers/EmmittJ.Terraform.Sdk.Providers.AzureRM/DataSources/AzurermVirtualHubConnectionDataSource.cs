using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubConnectionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The virtual_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubName is required")]
    [TerraformPropertyName("virtual_hub_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualHubName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualHubConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_security_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> InternetSecurityEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "internet_security_enabled");

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("remote_virtual_network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RemoteVirtualNetworkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "remote_virtual_network_id");

    /// <summary>
    /// The routing attribute.
    /// </summary>
    [TerraformPropertyName("routing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Routing => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "routing");

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_hub_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualHubId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_hub_id");

}
