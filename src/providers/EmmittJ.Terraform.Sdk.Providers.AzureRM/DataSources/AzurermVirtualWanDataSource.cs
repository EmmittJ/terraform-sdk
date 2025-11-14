using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualWanDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualWanDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allow_branch_to_branch_traffic attribute.
    /// </summary>
    [TerraformArgument("allow_branch_to_branch_traffic")]
    public TerraformValue<bool> AllowBranchToBranchTraffic
    {
        get => new TerraformReference<bool>(this, "allow_branch_to_branch_traffic");
    }

    /// <summary>
    /// The disable_vpn_encryption attribute.
    /// </summary>
    [TerraformArgument("disable_vpn_encryption")]
    public TerraformValue<bool> DisableVpnEncryption
    {
        get => new TerraformReference<bool>(this, "disable_vpn_encryption");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The office365_local_breakout_category attribute.
    /// </summary>
    [TerraformArgument("office365_local_breakout_category")]
    public TerraformValue<string> Office365LocalBreakoutCategory
    {
        get => new TerraformReference<string>(this, "office365_local_breakout_category");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_hub_ids attribute.
    /// </summary>
    [TerraformArgument("virtual_hub_ids")]
    public TerraformList<string> VirtualHubIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "virtual_hub_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpn_site_ids attribute.
    /// </summary>
    [TerraformArgument("vpn_site_ids")]
    public TerraformList<string> VpnSiteIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vpn_site_ids").ResolveNodes(ctx));
    }

}
