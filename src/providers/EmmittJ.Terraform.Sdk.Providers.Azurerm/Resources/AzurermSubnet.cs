using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for delegation in AzurermSubnet.
/// Nesting mode: list
/// </summary>
public class AzurermSubnetDelegationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delegation";

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
    /// ServiceDelegation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceDelegation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceDelegation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDelegation block(s) allowed")]
    public required TerraformList<AzurermSubnetDelegationBlockServiceDelegationBlock> ServiceDelegation
    {
        get => GetRequiredArgument<TerraformList<AzurermSubnetDelegationBlockServiceDelegationBlock>>("service_delegation");
        set => SetArgument("service_delegation", value);
    }

}

/// <summary>
/// Block type for service_delegation in AzurermSubnetDelegationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSubnetDelegationBlockServiceDelegationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_delegation";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    public TerraformSet<string>? Actions
    {
        get => GetArgument<TerraformSet<string>>("actions");
        set => SetArgument("actions", value);
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

}


/// <summary>
/// Block type for ip_address_pool in AzurermSubnet.
/// Nesting mode: list
/// </summary>
public class AzurermSubnetIpAddressPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_address_pool";

    /// <summary>
    /// The allocated_ip_address_prefixes attribute.
    /// </summary>
    public TerraformList<string> AllocatedIpAddressPrefixes
        => AsReference("allocated_ip_address_prefixes");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    public required TerraformValue<string> NumberOfIpAddresses
    {
        get => GetRequiredArgument<TerraformValue<string>>("number_of_ip_addresses");
        set => SetArgument("number_of_ip_addresses", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSubnet.
/// Nesting mode: single
/// </summary>
public class AzurermSubnetTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_subnet Terraform resource.
/// Manages a azurerm_subnet resource.
/// </summary>
public partial class AzurermSubnet(string name) : TerraformResource("azurerm_subnet", name)
{
    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformList<string>? AddressPrefixes
    {
        get => GetArgument<TerraformList<string>>("address_prefixes");
        set => SetArgument("address_prefixes", value);
    }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultOutboundAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("default_outbound_access_enabled");
        set => SetArgument("default_outbound_access_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    public TerraformValue<string>? PrivateEndpointNetworkPolicies
    {
        get => GetArgument<TerraformValue<string>>("private_endpoint_network_policies");
        set => SetArgument("private_endpoint_network_policies", value);
    }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateLinkServiceNetworkPoliciesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_link_service_network_policies_enabled");
        set => SetArgument("private_link_service_network_policies_enabled", value);
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
    /// The service_endpoint_policy_ids attribute.
    /// </summary>
    public TerraformSet<string>? ServiceEndpointPolicyIds
    {
        get => GetArgument<TerraformSet<string>>("service_endpoint_policy_ids");
        set => SetArgument("service_endpoint_policy_ids", value);
    }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    public TerraformSet<string>? ServiceEndpoints
    {
        get => GetArgument<TerraformSet<string>>("service_endpoints");
        set => SetArgument("service_endpoints", value);
    }

    /// <summary>
    /// The sharing_scope attribute.
    /// </summary>
    public TerraformValue<string>? SharingScope
    {
        get => GetArgument<TerraformValue<string>>("sharing_scope");
        set => SetArgument("sharing_scope", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    public required TerraformValue<string> VirtualNetworkName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_network_name");
        set => SetArgument("virtual_network_name", value);
    }

    /// <summary>
    /// Delegation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSubnetDelegationBlock>? Delegation
    {
        get => GetArgument<TerraformList<AzurermSubnetDelegationBlock>>("delegation");
        set => SetArgument("delegation", value);
    }

    /// <summary>
    /// IpAddressPool block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAddressPool block(s) allowed")]
    public TerraformList<AzurermSubnetIpAddressPoolBlock>? IpAddressPool
    {
        get => GetArgument<TerraformList<AzurermSubnetIpAddressPoolBlock>>("ip_address_pool");
        set => SetArgument("ip_address_pool", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubnetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubnetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
