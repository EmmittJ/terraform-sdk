using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualWanDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The allow_branch_to_branch_traffic attribute.
    /// </summary>
    public TerraformValue<bool> AllowBranchToBranchTraffic
        => CreateReference("allow_branch_to_branch_traffic");

    /// <summary>
    /// The disable_vpn_encryption attribute.
    /// </summary>
    public TerraformValue<bool> DisableVpnEncryption
        => CreateReference("disable_vpn_encryption");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The office365_local_breakout_category attribute.
    /// </summary>
    public TerraformValue<string> Office365LocalBreakoutCategory
        => CreateReference("office365_local_breakout_category");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => CreateReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The virtual_hub_ids attribute.
    /// </summary>
    public TerraformList<string> VirtualHubIds
        => CreateReference("virtual_hub_ids");

    /// <summary>
    /// The vpn_site_ids attribute.
    /// </summary>
    public TerraformList<string> VpnSiteIds
        => CreateReference("vpn_site_ids");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualWanDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualWanDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
