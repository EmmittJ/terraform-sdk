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
        set => SetProperty("name", value);
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
        set => SetProperty("allocated_ip_address_prefixes", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The number_of_ip_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfIpAddresses is required")]
    public required TerraformProperty<string> NumberOfIpAddresses
    {
        set => SetProperty("number_of_ip_addresses", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_subnet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSubnet : TerraformResource
{
    public AzurermSubnet(string name) : base("azurerm_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("address_prefixes");
        SetOutput("default_outbound_access_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("private_endpoint_network_policies");
        SetOutput("private_link_service_network_policies_enabled");
        SetOutput("resource_group_name");
        SetOutput("service_endpoint_policy_ids");
        SetOutput("service_endpoints");
        SetOutput("sharing_scope");
        SetOutput("virtual_network_name");
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>> AddressPrefixes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("address_prefixes");
        set => SetProperty("address_prefixes", value);
    }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DefaultOutboundAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("default_outbound_access_enabled");
        set => SetProperty("default_outbound_access_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    public TerraformProperty<string> PrivateEndpointNetworkPolicies
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_endpoint_network_policies");
        set => SetProperty("private_endpoint_network_policies", value);
    }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PrivateLinkServiceNetworkPoliciesEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_link_service_network_policies_enabled");
        set => SetProperty("private_link_service_network_policies_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_endpoint_policy_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ServiceEndpointPolicyIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("service_endpoint_policy_ids");
        set => SetProperty("service_endpoint_policy_ids", value);
    }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ServiceEndpoints
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("service_endpoints");
        set => SetProperty("service_endpoints", value);
    }

    /// <summary>
    /// The sharing_scope attribute.
    /// </summary>
    public TerraformProperty<string> SharingScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sharing_scope");
        set => SetProperty("sharing_scope", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    public required TerraformProperty<string> VirtualNetworkName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_name");
        set => SetProperty("virtual_network_name", value);
    }

    /// <summary>
    /// Block for delegation.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSubnetDelegationBlock>? Delegation
    {
        set => SetProperty("delegation", value);
    }

    /// <summary>
    /// Block for ip_address_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpAddressPool block(s) allowed")]
    public List<AzurermSubnetIpAddressPoolBlock>? IpAddressPool
    {
        set => SetProperty("ip_address_pool", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubnetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
