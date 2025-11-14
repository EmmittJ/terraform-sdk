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
public class AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_private_dns_zone_virtual_network_link.
/// </summary>
public class AzurermPrivateDnsZoneVirtualNetworkLinkDataSource : TerraformDataSource
{
    public AzurermPrivateDnsZoneVirtualNetworkLinkDataSource(string name) : base("azurerm_private_dns_zone_virtual_network_link", name)
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
    /// The private_dns_zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneName is required")]
    [TerraformArgument("private_dns_zone_name")]
    public required TerraformValue<string> PrivateDnsZoneName
    {
        get => new TerraformReference<string>(this, "private_dns_zone_name");
        set => SetArgument("private_dns_zone_name", value);
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
    public AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The registration_enabled attribute.
    /// </summary>
    [TerraformArgument("registration_enabled")]
    public TerraformValue<bool> RegistrationEnabled
    {
        get => new TerraformReference<bool>(this, "registration_enabled");
    }

    /// <summary>
    /// The resolution_policy attribute.
    /// </summary>
    [TerraformArgument("resolution_policy")]
    public TerraformValue<string> ResolutionPolicy
    {
        get => new TerraformReference<string>(this, "resolution_policy");
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
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformArgument("virtual_network_id")]
    public TerraformValue<string> VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
    }

}
