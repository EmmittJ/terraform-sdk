using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkInterfaceDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_network_interface Terraform data source.
/// Retrieves information about a azurerm_network_interface.
/// </summary>
public partial class AzurermNetworkInterfaceDataSource(string name) : TerraformDataSource("azurerm_network_interface", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AcceleratedNetworkingEnabled
        => AsReference("accelerated_networking_enabled");

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    public TerraformSet<string> AppliedDnsServers
        => AsReference("applied_dns_servers");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformSet<string> DnsServers
        => AsReference("dns_servers");

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    public TerraformValue<string> InternalDnsNameLabel
        => AsReference("internal_dns_name_label");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
        => AsReference("ip_configuration");

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    public TerraformValue<bool> IpForwardingEnabled
        => AsReference("ip_forwarding_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    public TerraformValue<string> MacAddress
        => AsReference("mac_address");

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> NetworkSecurityGroupId
        => AsReference("network_security_group_id");

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
        => AsReference("private_ip_address");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> PrivateIpAddresses
        => AsReference("private_ip_addresses");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualMachineId
        => AsReference("virtual_machine_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkInterfaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkInterfaceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
