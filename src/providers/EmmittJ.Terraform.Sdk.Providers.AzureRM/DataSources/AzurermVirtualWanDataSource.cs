using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_virtual_wan Terraform data source.
/// Retrieves information about a azurerm_virtual_wan.
/// </summary>
public partial class AzurermVirtualWanDataSource(string name) : TerraformDataSource("azurerm_virtual_wan", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The allow_branch_to_branch_traffic attribute.
    /// </summary>
    public TerraformValue<bool> AllowBranchToBranchTraffic
    {
        get => new TerraformReference<bool>(this, "allow_branch_to_branch_traffic");
    }

    /// <summary>
    /// The disable_vpn_encryption attribute.
    /// </summary>
    public TerraformValue<bool> DisableVpnEncryption
    {
        get => new TerraformReference<bool>(this, "disable_vpn_encryption");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The office365_local_breakout_category attribute.
    /// </summary>
    public TerraformValue<string> Office365LocalBreakoutCategory
    {
        get => new TerraformReference<string>(this, "office365_local_breakout_category");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_hub_ids attribute.
    /// </summary>
    public TerraformList<string> VirtualHubIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "virtual_hub_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpn_site_ids attribute.
    /// </summary>
    public TerraformList<string> VpnSiteIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vpn_site_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualWanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualWanDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
