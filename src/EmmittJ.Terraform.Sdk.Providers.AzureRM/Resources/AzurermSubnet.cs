using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for delegation in .
/// Nesting mode: list
/// </summary>
public class AzurermSubnetDelegationBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for ip_address_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermSubnetIpAddressPoolBlock : TerraformBlock
{
    /// <summary>
    /// The allocated_ip_address_prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AllocatedIpAddressPrefixes
    {
        get => GetProperty<List<TerraformProperty<string>>>("allocated_ip_address_prefixes");
        set => WithProperty("allocated_ip_address_prefixes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    public required TerraformProperty<string> NumberOfIpAddresses
    {
        get => GetProperty<TerraformProperty<string>>("number_of_ip_addresses");
        set => WithProperty("number_of_ip_addresses", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubnetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_subnet resource.
/// </summary>
public class AzurermSubnet : TerraformResource
{
    public AzurermSubnet(string name) : base("azurerm_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AddressPrefixes
    {
        get => GetProperty<List<TerraformProperty<string>>>("address_prefixes");
        set => this.WithProperty("address_prefixes", value);
    }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DefaultOutboundAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("default_outbound_access_enabled");
        set => this.WithProperty("default_outbound_access_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateEndpointNetworkPolicies
    {
        get => GetProperty<TerraformProperty<string>>("private_endpoint_network_policies");
        set => this.WithProperty("private_endpoint_network_policies", value);
    }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateLinkServiceNetworkPoliciesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_link_service_network_policies_enabled");
        set => this.WithProperty("private_link_service_network_policies_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_endpoint_policy_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ServiceEndpointPolicyIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("service_endpoint_policy_ids");
        set => this.WithProperty("service_endpoint_policy_ids", value);
    }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ServiceEndpoints
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("service_endpoints");
        set => this.WithProperty("service_endpoints", value);
    }

    /// <summary>
    /// The sharing_scope attribute.
    /// </summary>
    public TerraformProperty<string>? SharingScope
    {
        get => GetProperty<TerraformProperty<string>>("sharing_scope");
        set => this.WithProperty("sharing_scope", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    public required TerraformProperty<string> VirtualNetworkName
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_name");
        set => this.WithProperty("virtual_network_name", value);
    }

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSubnetDelegationBlock>? Delegation
    {
        get => GetProperty<List<AzurermSubnetDelegationBlock>>("delegation");
        set => this.WithProperty("delegation", value);
    }

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAddressPool block(s) allowed")]
    public List<AzurermSubnetIpAddressPoolBlock>? IpAddressPool
    {
        get => GetProperty<List<AzurermSubnetIpAddressPoolBlock>>("ip_address_pool");
        set => this.WithProperty("ip_address_pool", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubnetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSubnetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
