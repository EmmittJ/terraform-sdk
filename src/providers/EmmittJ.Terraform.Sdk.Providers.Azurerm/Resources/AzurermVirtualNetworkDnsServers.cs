using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualNetworkDnsServers.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkDnsServersTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_network_dns_servers Terraform resource.
/// Manages a azurerm_virtual_network_dns_servers resource.
/// </summary>
public partial class AzurermVirtualNetworkDnsServers(string name) : TerraformResource("azurerm_virtual_network_dns_servers", name)
{
    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => GetArgument<TerraformList<string>>("dns_servers");
        set => SetArgument("dns_servers", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    public AzurermVirtualNetworkDnsServersTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkDnsServersTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
