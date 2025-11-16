using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksVirtualNetworkPeeringTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_databricks_virtual_network_peering Terraform resource.
/// Manages a azurerm_databricks_virtual_network_peering resource.
/// </summary>
public partial class AzurermDatabricksVirtualNetworkPeering(string name) : TerraformResource("azurerm_databricks_virtual_network_peering", name)
{
    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    public TerraformValue<bool>? AllowForwardedTraffic
    {
        get => new TerraformReference<bool>(this, "allow_forwarded_traffic");
        set => SetArgument("allow_forwarded_traffic", value);
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public TerraformValue<bool>? AllowGatewayTransit
    {
        get => new TerraformReference<bool>(this, "allow_gateway_transit");
        set => SetArgument("allow_gateway_transit", value);
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public TerraformValue<bool>? AllowVirtualNetworkAccess
    {
        get => new TerraformReference<bool>(this, "allow_virtual_network_access");
        set => SetArgument("allow_virtual_network_access", value);
    }

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
    /// The remote_address_space_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressSpacePrefixes is required")]
    public TerraformList<string>? RemoteAddressSpacePrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "remote_address_space_prefixes").ResolveNodes(ctx));
        set => SetArgument("remote_address_space_prefixes", value);
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    public required TerraformValue<string> RemoteVirtualNetworkId
    {
        get => new TerraformReference<string>(this, "remote_virtual_network_id");
        set => SetArgument("remote_virtual_network_id", value);
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
    /// The use_remote_gateways attribute.
    /// </summary>
    public TerraformValue<bool>? UseRemoteGateways
    {
        get => new TerraformReference<bool>(this, "use_remote_gateways");
        set => SetArgument("use_remote_gateways", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The address_space_prefixes attribute.
    /// </summary>
    public TerraformList<string> AddressSpacePrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_space_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDatabricksVirtualNetworkPeeringTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDatabricksVirtualNetworkPeeringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
