using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for subnet in AzurermDevTestVirtualNetwork.
/// Nesting mode: list
/// </summary>
public class AzurermDevTestVirtualNetworkSubnetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnet";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The use_in_virtual_machine_creation attribute.
    /// </summary>
    public TerraformValue<string>? UseInVirtualMachineCreation
    {
        get => GetArgument<TerraformValue<string>>("use_in_virtual_machine_creation");
        set => SetArgument("use_in_virtual_machine_creation", value);
    }

    /// <summary>
    /// The use_public_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? UsePublicIpAddress
    {
        get => GetArgument<TerraformValue<string>>("use_public_ip_address");
        set => SetArgument("use_public_ip_address", value);
    }

    /// <summary>
    /// SharedPublicIpAddress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SharedPublicIpAddress block(s) allowed")]
    public TerraformList<AzurermDevTestVirtualNetworkSubnetBlockSharedPublicIpAddressBlock>? SharedPublicIpAddress
    {
        get => GetArgument<TerraformList<AzurermDevTestVirtualNetworkSubnetBlockSharedPublicIpAddressBlock>>("shared_public_ip_address");
        set => SetArgument("shared_public_ip_address", value);
    }

}

/// <summary>
/// Block type for shared_public_ip_address in AzurermDevTestVirtualNetworkSubnetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDevTestVirtualNetworkSubnetBlockSharedPublicIpAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shared_public_ip_address";

    /// <summary>
    /// AllowedPorts block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDevTestVirtualNetworkSubnetBlockSharedPublicIpAddressBlockAllowedPortsBlock>? AllowedPorts
    {
        get => GetArgument<TerraformList<AzurermDevTestVirtualNetworkSubnetBlockSharedPublicIpAddressBlockAllowedPortsBlock>>("allowed_ports");
        set => SetArgument("allowed_ports", value);
    }

}

/// <summary>
/// Block type for allowed_ports in AzurermDevTestVirtualNetworkSubnetBlockSharedPublicIpAddressBlock.
/// Nesting mode: list
/// </summary>
public class AzurermDevTestVirtualNetworkSubnetBlockSharedPublicIpAddressBlockAllowedPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_ports";

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    public TerraformValue<double>? BackendPort
    {
        get => GetArgument<TerraformValue<double>>("backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The transport_protocol attribute.
    /// </summary>
    public TerraformValue<string>? TransportProtocol
    {
        get => GetArgument<TerraformValue<string>>("transport_protocol");
        set => SetArgument("transport_protocol", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDevTestVirtualNetwork.
/// Nesting mode: single
/// </summary>
public class AzurermDevTestVirtualNetworkTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_dev_test_virtual_network Terraform resource.
/// Manages a azurerm_dev_test_virtual_network resource.
/// </summary>
public partial class AzurermDevTestVirtualNetwork(string name) : TerraformResource("azurerm_dev_test_virtual_network", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    public required TerraformValue<string> LabName
    {
        get => GetRequiredArgument<TerraformValue<string>>("lab_name");
        set => SetArgument("lab_name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformValue<string> UniqueIdentifier
        => AsReference("unique_identifier");

    /// <summary>
    /// Subnet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subnet block(s) allowed")]
    public TerraformList<AzurermDevTestVirtualNetworkSubnetBlock>? Subnet
    {
        get => GetArgument<TerraformList<AzurermDevTestVirtualNetworkSubnetBlock>>("subnet");
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevTestVirtualNetworkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevTestVirtualNetworkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
