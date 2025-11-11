using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualWanDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public TerraformBlock<AzurermVirtualWanDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allow_branch_to_branch_traffic attribute.
    /// </summary>
    [TerraformPropertyName("allow_branch_to_branch_traffic")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowBranchToBranchTraffic => new TerraformReference(this, "allow_branch_to_branch_traffic");

    /// <summary>
    /// The disable_vpn_encryption attribute.
    /// </summary>
    [TerraformPropertyName("disable_vpn_encryption")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableVpnEncryption => new TerraformReference(this, "disable_vpn_encryption");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The office365_local_breakout_category attribute.
    /// </summary>
    [TerraformPropertyName("office365_local_breakout_category")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Office365LocalBreakoutCategory => new TerraformReference(this, "office365_local_breakout_category");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The virtual_hub_ids attribute.
    /// </summary>
    [TerraformPropertyName("virtual_hub_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> VirtualHubIds => new TerraformReference(this, "virtual_hub_ids");

    /// <summary>
    /// The vpn_site_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpn_site_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> VpnSiteIds => new TerraformReference(this, "vpn_site_ids");

}
