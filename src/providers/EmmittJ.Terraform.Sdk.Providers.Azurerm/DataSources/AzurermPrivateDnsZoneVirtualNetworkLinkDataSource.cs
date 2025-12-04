using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateDnsZoneVirtualNetworkLinkDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_private_dns_zone_virtual_network_link Terraform data source.
/// Retrieves information about a azurerm_private_dns_zone_virtual_network_link.
/// </summary>
public partial class AzurermPrivateDnsZoneVirtualNetworkLinkDataSource(string name) : TerraformDataSource("azurerm_private_dns_zone_virtual_network_link", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_dns_zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneName is required")]
    public required TerraformValue<string> PrivateDnsZoneName
    {
        get => GetArgument<TerraformValue<string>>("private_dns_zone_name");
        set => SetArgument("private_dns_zone_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The registration_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RegistrationEnabled
        => AsReference("registration_enabled");

    /// <summary>
    /// The resolution_policy attribute.
    /// </summary>
    public TerraformValue<string> ResolutionPolicy
        => AsReference("resolution_policy");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkId
        => AsReference("virtual_network_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
