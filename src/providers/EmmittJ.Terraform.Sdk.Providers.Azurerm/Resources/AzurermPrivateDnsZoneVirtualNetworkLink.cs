using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateDnsZoneVirtualNetworkLink.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneVirtualNetworkLinkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_private_dns_zone_virtual_network_link Terraform resource.
/// Manages a azurerm_private_dns_zone_virtual_network_link resource.
/// </summary>
public partial class AzurermPrivateDnsZoneVirtualNetworkLink(string name) : TerraformResource("azurerm_private_dns_zone_virtual_network_link", name)
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
    /// The registration_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RegistrationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("registration_enabled");
        set => SetArgument("registration_enabled", value);
    }

    /// <summary>
    /// The resolution_policy attribute.
    /// </summary>
    public TerraformValue<string>? ResolutionPolicy
    {
        get => GetArgument<TerraformValue<string>>("resolution_policy");
        set => SetArgument("resolution_policy", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformValue<string> VirtualNetworkId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsZoneVirtualNetworkLinkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsZoneVirtualNetworkLinkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
