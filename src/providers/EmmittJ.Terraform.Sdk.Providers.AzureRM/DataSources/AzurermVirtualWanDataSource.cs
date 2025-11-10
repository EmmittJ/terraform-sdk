using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualWanDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_wan.
/// </summary>
public class AzurermVirtualWanDataSource : TerraformDataSource
{
    public AzurermVirtualWanDataSource(string name) : base("azurerm_virtual_wan", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualWanDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The allow_branch_to_branch_traffic attribute.
    /// </summary>
    [TerraformPropertyName("allow_branch_to_branch_traffic")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowBranchToBranchTraffic => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_branch_to_branch_traffic");

    /// <summary>
    /// The disable_vpn_encryption attribute.
    /// </summary>
    [TerraformPropertyName("disable_vpn_encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableVpnEncryption => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_vpn_encryption");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The office365_local_breakout_category attribute.
    /// </summary>
    [TerraformPropertyName("office365_local_breakout_category")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Office365LocalBreakoutCategory => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "office365_local_breakout_category");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The virtual_hub_ids attribute.
    /// </summary>
    [TerraformPropertyName("virtual_hub_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VirtualHubIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "virtual_hub_ids");

    /// <summary>
    /// The vpn_site_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpn_site_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VpnSiteIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "vpn_site_ids");

}
